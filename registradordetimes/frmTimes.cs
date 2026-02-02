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
        private List<Time> times = new List<Time>();
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

            if (times.Any(t =>
            t.nome.Equals(txtNomeTime.Text, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Já existe um time cadastrado com esse nome.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNomeTime.Text))
            {
                MessageBox.Show("O nome do time não pode estar vazio.");
                return;
            }

            time.nome = txtNomeTime.Text;
            times.Add(time);
            string fileName = "Times.json";
            string jsonString = JsonSerializer.Serialize(times, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(fileName, jsonString);
            MessageBox.Show("Time " + time.nome + " cadastrado com sucesso!");
            limparTimes();
            CarregarTimesCombo();
        }

        private void btnApagarTime_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione um time para apagar.");
                return;
            }
            DialogResult result = MessageBox.Show("Tem certeza que deseja apagar o time selecionado?", "Confirmação", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }
            List<Time> times;
            string existingJson = File.ReadAllText("Times.json");
            times = JsonSerializer.Deserialize<List<Time>>(existingJson);
            Time timeToRemove = (Time)comboBox1.SelectedItem;
            times.RemoveAll(j => j.nome == timeToRemove.nome);
            string jsonString = JsonSerializer.Serialize(times, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("Times.json", jsonString);
            MessageBox.Show("Time " + timeToRemove.nome + " apagado com sucesso!");
            CarregarTimesCombo();

        }

        private void CarregarTimesCombo()
        {
            var listaParaCombo = new List<Time>();
            listaParaCombo.Add(new Time { nome = "+ Cadastrar novo Time..." });

            if (File.Exists("Times.json"))
            {
                string json = File.ReadAllText("Times.json");
                times = JsonSerializer.Deserialize<List<Time>>(json) ?? new List<Time>();
            }
            else 
            { 
                times = new List<Time>();
            }
            listaParaCombo.AddRange(times);

            comboBox1.DataSource = null;
            comboBox1.DataSource = listaParaCombo;
            comboBox1.DisplayMember = "nome";
        }

        private void frmTimes_Load(object sender, EventArgs e)
        {
            CarregarTimesCombo();
        }

        private void limparTimes()
        {
            txtNomeTime.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) return;

            Time timeSelecionado = (Time)comboBox1.SelectedItem;
            if (timeSelecionado.nome == "+ Cadastrar novo Time...")
            {
                btnApagarTime.Enabled = false;
                btnCadastrartime.Enabled = true;
                txtNomeTime.Enabled = true;
                limparTimes();
                return;
            }

            txtNomeTime.Text = timeSelecionado.nome;

            btnApagarTime.Enabled = true;
            btnCadastrartime.Enabled = false;
            txtNomeTime.Enabled = false;
        }
    }
}
