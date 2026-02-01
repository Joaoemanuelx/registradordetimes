using System.Text.Json;

namespace registradordetimes
{
    public partial class frm_prc : Form
    {
        public frm_prc()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void showDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Jogador> jogadores;
            if (File.Exists("Jogadores.json"))
            {
                string existingJson = File.ReadAllText("Jogadores.json");
                jogadores = JsonSerializer.Deserialize<List<Jogador>>(existingJson);
                dataGridView1.DataSource = jogadores;
            }
            else
            {
                MessageBox.Show("Nenhum jogador cadastrado ainda.");
            }
        }

        private void registerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frm_register formRegisterData = new frm_register();
            formRegisterData.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_time formTime = new frm_time();
            formTime.Show();
        }
    }
}
