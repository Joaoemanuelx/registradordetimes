using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace registradordetimes
{
    public partial class frmTimes : Form
    {
        public frmTimes()
        {
            InitializeComponent();
        }

        private void btnCadastrarTime_Click(object sender, EventArgs e)
        {
            Time time = new Time();
            List<Time> times;
            if (File.Exists("Times.json"))
            {
                string existingJson = File.ReadAllText("Times.json");
                times = JsonSerializer.Deserialize<List<Time>>(existingJson);

            }
            else
            {
                times = new List<Time>();
            }
            if(times.Any(t =>
            t.nome.Equals(txtNomeTime.Text, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Já existe um time cadastrado com esse nome.");
                return;
            }
            time.nome = txtNomeTime.Text;
            times.Add(time);
            string fileName = "Times.json";
            string jsonString = JsonSerializer.Serialize(times, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(fileName, jsonString);
            MessageBox.Show("Time " + time.nome + " cadastrado com sucesso!");
            limparTimes();
        }

        private void btnCarregarTimes_Click(object sender, EventArgs e)
        {
            mostrarlista();
        }

        private void btnApagarTime_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null)
            {
                MessageBox.Show("Selecione um jogador para apagar.");
                return;
            }
            DialogResult result = MessageBox.Show("Tem certeza que deseja apagar o jogador selecionado?", "Confirmação", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }
            List<Time> times;
            string existingJson = File.ReadAllText("Times.json");
            times = JsonSerializer.Deserialize<List<Time>>(existingJson);
            Time timeToRemove = (Time)listBox2.SelectedItem;
            times.RemoveAll(j => j.nome == timeToRemove.nome);
            string jsonString = JsonSerializer.Serialize(times, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("Times.json", jsonString);
            MessageBox.Show("Time " + timeToRemove.nome + " apagado com sucesso!");
            mostrarlista();
        }

        private void mostrarlista()
        {
            List<Time> times;
            string existingJson = File.ReadAllText("Times.json");
            times = JsonSerializer.Deserialize<List<Time>>(existingJson);
            listBox2.DataSource = times;
            listBox2.DisplayMember = "nome";
        }

        private void limparTimes()
        {
            txtNomeTime.Clear();
        }
    }
}
