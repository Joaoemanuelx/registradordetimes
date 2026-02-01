using System.Text.Json;


namespace registradordetimes
{
    public partial class frm_register : Form
    {
        public frm_register()
        {
            InitializeComponent();
            //asasasa
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                List<Jogador> jogadores;
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
                jogador.nome = txt_nome.Text;
                jogador.posicao = txt_posicao.Text;
                jogador.idade = int.Parse(txt_idade.Text);
                jogador.time = comboBox1.Text;
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
            txt_nome.Clear();
            txt_posicao.Clear();
            txt_idade.Clear();
            
        }

        private void mostrarlista()
        {
            List<Jogador> jogadores;
            string existingJson = File.ReadAllText("Jogadores.json");
            jogadores = JsonSerializer.Deserialize<List<Jogador>>(existingJson);
            listBox1.DataSource = jogadores;
            listBox1.DisplayMember = "nome";

            List<Time> times;
            string existingJson2 = File.ReadAllText("Times.json");
            times = JsonSerializer.Deserialize<List<Time>>(existingJson2);
            comboBox1.DataSource = times;
            comboBox1.DisplayMember = "nome";
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                mostrarlista();
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
                MessageBox.Show("Erro ao carregar lista de jogadores: " + ex.Message);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um jogador para apagar.");
                    return;
                }
                DialogResult result = MessageBox.Show("Tem certeza que deseja apagar o jogador selecionado?", "Confirmação", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    return;
                }
                List<Jogador> jogadores;
                string existingJson = File.ReadAllText("Jogadores.json");
                jogadores = JsonSerializer.Deserialize<List<Jogador>>(existingJson);
                Jogador jogadorToRemove = (Jogador)listBox1.SelectedItem;
                jogadores.RemoveAll(j => j.nome == jogadorToRemove.nome);
                string jsonString = JsonSerializer.Serialize(jogadores, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("Jogadores.json", jsonString);
                MessageBox.Show("Jogador " + jogadorToRemove.nome + " apagado com sucesso!");
                mostrarlista();
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
            if (string.IsNullOrWhiteSpace(txt_nome.Text) ||
                !txt_nome.Text.Replace(" ", "").All(char.IsLetter))
            {
                errorProvider1.SetError(txt_nome, "Nome invalido");

                temerro = true;
            }

            errorProvider2.Clear();
            if (string.IsNullOrWhiteSpace(txt_posicao.Text) ||
                !txt_posicao.Text.Replace(" ", "").All(char.IsLetter))
            {
                errorProvider2.SetError(txt_posicao, "Posição invalida");

                temerro = true;
            }

            errorProvider3.Clear();
            if (!int.TryParse(txt_idade.Text, out int idade) || idade <= 0)
            {
                errorProvider3.SetError(txt_idade, "Idade invalida");

                temerro = true;
            }

            return !temerro;
        }

        private void txt_posicao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_idade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_time_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_register_Load(object sender, EventArgs e)
        {

        }

        
    }
}
