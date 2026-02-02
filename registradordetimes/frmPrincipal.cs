using System.Text.Json;

namespace registradordetimes
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
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
                dgvJogadores.DataSource = jogadores;
            }
            else
            {
                MessageBox.Show("Nenhum jogador cadastrado ainda.");
            }
        }

        private void registerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmRegister formRegisterData = new frmRegister();
            formRegisterData.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimes formTime = new frmTimes();
            formTime.Show();
        }
    }
}
