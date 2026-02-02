using System.ComponentModel;
using System.Text.Json;


namespace registradordetimes
{
    public partial class frmRegister : Form
    {
        private List<Time> times = new List<Time>();
        private List<Jogador> jogadores = new List<Jogador>();

        public frmRegister()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            // Verifica se um time foi selecionado antes de cadastrar
            if (cboTimes.SelectedItem == null || string.IsNullOrWhiteSpace(cboTimes.Text))
            {
                MessageBox.Show("Selecione um time antes de cadastrar o jogador.", "Time não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Jogador jogador = new Jogador();

                if (File.Exists("Jogadores.json"))
                {
                    string existingJson = File.ReadAllText("Jogadores.json");
                    jogadores = JsonSerializer.Deserialize<List<Jogador>>(existingJson);

                }

                else
                {
                    jogadores = new List<Jogador>();
                }

                jogador.nome = txtNome.Text;
                jogador.posicao = txtPosicao.Text;
                jogador.idade = int.Parse(txtIdade.Text);
                jogador.time = cboTimes.Text;

                if (jogadores.Count >= 11)
                {
                    MessageBox.Show("Limite de jogadores atingido. Não é possível cadastrar mais jogadores.");
                    return;
                }

                jogadores.Add(jogador);

                string fileName = "Jogadores.json";
                string jsonString = JsonSerializer.Serialize(jogadores, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(fileName, jsonString);
                MessageBox.Show("Jogador " + jogador.nome + " cadastrado com sucesso!");

                CarregarJogadoresCombo();
                limparcampos();
            }

            //catch (FormatException formatEx)
            //{
            //    MessageBox.Show("Erro de formato nos dados inseridos: " + formatEx.Message);

            //}
            catch (IOException ioEx)
            {
                MessageBox.Show("Erro ao acessar o arquivo: " + ioEx.Message);
            }
            catch (JsonException jsonEx)
            {
                MessageBox.Show("Erro ao processar os dados JSON: " + jsonEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar jogador: " + ex.Message);
            }
        }

        private void limparcampos()
        {
            txtNome.Clear();
            txtPosicao.Clear();
            txtIdade.Clear();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboJogadores.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um jogador para apagar.");
                    return;
                }

                DialogResult result = MessageBox.Show("Tem certeza que deseja apagar o jogador selecionado?", "Confirmação", MessageBoxButtons.YesNo);

                if (result != DialogResult.Yes)
                {
                    return;
                }

                Jogador jogadorApagar = (Jogador)cboJogadores.SelectedItem;
                if (jogadorApagar == null || jogadorApagar.nome == "➕ Cadastrar novo jogador...")
                {
                    MessageBox.Show("Selecione um jogador válido para apagar.");
                    return;
                }

                if (File.Exists("Jogadores.json"))
                {
                    string existingJson = File.ReadAllText("Jogadores.json");
                    jogadores = JsonSerializer.Deserialize<List<Jogador>>(existingJson) ?? new List<Jogador>();
                }

                jogadores.RemoveAll(j => j.nome == jogadorApagar.nome);

                string jsonString = JsonSerializer.Serialize(jogadores, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("Jogadores.json", jsonString);

                MessageBox.Show("Jogador " + jogadorApagar.nome + " apagado com sucesso!");
                CarregarJogadoresCombo();
            }
            catch (FileNotFoundException fnfEx)
            {
                MessageBox.Show("Arquivo não encontrado: " + fnfEx.Message);
            }
            catch (JsonException jsonEx)
            {
                MessageBox.Show("Erro ao processar os dados JSON: " + jsonEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar jogador: " + ex.Message);
            }
        }

        private bool ValidarCampos()
        {
            bool temerro = false;

            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                !txtNome.Text.Replace(" ", "").All(char.IsLetter))
            {
                errorProvider1.SetError(txtNome, "Nome invalido");

                temerro = true;
            }

            errorProvider2.Clear();
            if (string.IsNullOrWhiteSpace(txtPosicao.Text) ||
                !txtPosicao.Text.Replace(" ", "").All(char.IsLetter))
            {
                errorProvider2.SetError(txtPosicao, "Posição invalida");

                temerro = true;
            }

            errorProvider3.Clear();
            if (!int.TryParse(txtIdade.Text, out int idade) || idade <= 0)
            {
                errorProvider3.SetError(txtIdade, "Idade invalida");

                temerro = true;
            }

            return !temerro;
        }


        private void frm_register_Load(object sender, EventArgs e)
        {
            CarregarTimesCombo();
            CarregarJogadoresCombo();
        }

        private void cboJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboJogadores.SelectedIndex == -1) return;

            Jogador jogadorSelecionado = (Jogador)cboJogadores.SelectedItem;

            if (jogadorSelecionado.nome == "➕ Cadastrar novo jogador...")
            {
                btnApagar.Enabled = false;
                btnEnviar.Enabled = true;
                limparcampos();
                cboTimes.SelectedIndex = -1;
                return;
            }

            btnApagar.Enabled = true;
            btnEnviar.Enabled = false;

            txtNome.Text = jogadorSelecionado.nome;
            txtPosicao.Text = jogadorSelecionado.posicao;
            txtIdade.Text = jogadorSelecionado.idade.ToString();
            cboTimes.Text = jogadorSelecionado.time;
        }

        //carregar times no combobox
        private void CarregarTimesCombo()
        {
            if (!File.Exists("Times.json"))
            {
                cboTimes.DataSource = null;
                return;
            }

            string json = File.ReadAllText("Times.json");
            times = JsonSerializer.Deserialize<List<Time>>(json) ?? new List<Time>();

            cboTimes.DataSource = null;
            cboTimes.DataSource = times;
            cboTimes.DisplayMember = "nome";
        }

        //carregar jogadores no combobox
        private void CarregarJogadoresCombo()
        {
            var listaParaCombo = new List<Jogador>();
            listaParaCombo.Add(new Jogador { nome = "➕ Cadastrar novo jogador..." });

            if (File.Exists("Jogadores.json"))
            {
                string json = File.ReadAllText("Jogadores.json");
                jogadores = JsonSerializer.Deserialize<List<Jogador>>(json) ?? new List<Jogador>();
            }
            else
            {
                jogadores = new List<Jogador>();
            }

            listaParaCombo.AddRange(jogadores);

            cboJogadores.DataSource = null;
            cboJogadores.DataSource = listaParaCombo;
            cboJogadores.DisplayMember = "nome";
        }

        private void lblOpcao_Click(object sender, EventArgs e)
        {

        }
    }
}
