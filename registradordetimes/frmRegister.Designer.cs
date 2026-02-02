namespace registradordetimes
{
    partial class frmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbl_nome = new Label();
            lbl_posicao = new Label();
            lbl_idade = new Label();
            txtIdade = new TextBox();
            txtPosicao = new TextBox();
            txtNome = new TextBox();
            btnEnviar = new Button();
            btnApagar = new Button();
            errorProvider1 = new ErrorProvider(components);
            toolTip1 = new ToolTip(components);
            errorProvider2 = new ErrorProvider(components);
            toolTip2 = new ToolTip(components);
            errorProvider3 = new ErrorProvider(components);
            toolTip3 = new ToolTip(components);
            errorProvider4 = new ErrorProvider(components);
            toolTip4 = new ToolTip(components);
            cboTimes = new ComboBox();
            cboJogadores = new ComboBox();
            lbl_time = new Label();
            lblOpcao = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            SuspendLayout();
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(36, 172);
            lbl_nome.Margin = new Padding(4, 0, 4, 0);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(60, 19);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "Nome:";
            // 
            // lbl_posicao
            // 
            lbl_posicao.AutoSize = true;
            lbl_posicao.Location = new Point(36, 218);
            lbl_posicao.Margin = new Padding(4, 0, 4, 0);
            lbl_posicao.Name = "lbl_posicao";
            lbl_posicao.Size = new Size(72, 19);
            lbl_posicao.TabIndex = 1;
            lbl_posicao.Text = "Posição:";
            // 
            // lbl_idade
            // 
            lbl_idade.AutoSize = true;
            lbl_idade.Location = new Point(36, 272);
            lbl_idade.Margin = new Padding(4, 0, 4, 0);
            lbl_idade.Name = "lbl_idade";
            lbl_idade.Size = new Size(56, 19);
            lbl_idade.TabIndex = 2;
            lbl_idade.Text = "Idade:";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(120, 267);
            txtIdade.Margin = new Padding(4);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(288, 29);
            txtIdade.TabIndex = 4;
            toolTip3.SetToolTip(txtIdade, "Digite uma idade valida!");
            // 
            // txtPosicao
            // 
            txtPosicao.Location = new Point(120, 215);
            txtPosicao.Margin = new Padding(4);
            txtPosicao.Name = "txtPosicao";
            txtPosicao.Size = new Size(288, 29);
            txtPosicao.TabIndex = 5;
            toolTip2.SetToolTip(txtPosicao, "Digite uma posição valida!");
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.Window;
            txtNome.Location = new Point(120, 170);
            txtNome.Margin = new Padding(4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(288, 29);
            txtNome.TabIndex = 6;
            toolTip1.SetToolTip(txtNome, "Digite um nome valido!");
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(109, 319);
            btnEnviar.Margin = new Padding(4);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(116, 28);
            btnEnviar.TabIndex = 9;
            btnEnviar.Text = "&Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btn_enviar_Click;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(294, 319);
            btnApagar.Margin = new Padding(4);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(116, 28);
            btnApagar.TabIndex = 11;
            btnApagar.Text = "&Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Devs";
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // toolTip2
            // 
            toolTip2.ToolTipIcon = ToolTipIcon.Info;
            toolTip2.ToolTipTitle = "Devs";
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // toolTip3
            // 
            toolTip3.ToolTipIcon = ToolTipIcon.Info;
            toolTip3.ToolTipTitle = "Devs";
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // toolTip4
            // 
            toolTip4.ToolTipIcon = ToolTipIcon.Info;
            toolTip4.ToolTipTitle = "Devs";
            // 
            // cboTimes
            // 
            cboTimes.AccessibleDescription = "";
            cboTimes.FormattingEnabled = true;
            cboTimes.Location = new Point(120, 123);
            cboTimes.Margin = new Padding(4);
            cboTimes.Name = "cboTimes";
            cboTimes.Size = new Size(288, 27);
            cboTimes.TabIndex = 13;
            cboTimes.Text = "Escolha o time do jogador";
            // 
            // cboJogadores
            // 
            cboJogadores.FormattingEnabled = true;
            cboJogadores.Location = new Point(119, 49);
            cboJogadores.Margin = new Padding(4);
            cboJogadores.Name = "cboJogadores";
            cboJogadores.Size = new Size(288, 27);
            cboJogadores.TabIndex = 14;
            cboJogadores.Text = "Jogadores cadrastrados";
            cboJogadores.SelectedIndexChanged += cboJogadores_SelectedIndexChanged;
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.Location = new Point(36, 125);
            lbl_time.Margin = new Padding(4, 0, 4, 0);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new Size(51, 19);
            lbl_time.TabIndex = 7;
            lbl_time.Text = "Time:";
            // 
            // lblOpcao
            // 
            lblOpcao.AutoSize = true;
            lblOpcao.Location = new Point(98, 26);
            lblOpcao.Margin = new Padding(4, 0, 4, 0);
            lblOpcao.Name = "lblOpcao";
            lblOpcao.Size = new Size(330, 19);
            lblOpcao.TabIndex = 15;
            lblOpcao.Text = "Selecionar Jogador ou Cadrastar um Novo";
            lblOpcao.Click += lblOpcao_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(500, 381);
            Controls.Add(lblOpcao);
            Controls.Add(cboJogadores);
            Controls.Add(cboTimes);
            Controls.Add(btnApagar);
            Controls.Add(btnEnviar);
            Controls.Add(lbl_time);
            Controls.Add(txtNome);
            Controls.Add(txtPosicao);
            Controls.Add(txtIdade);
            Controls.Add(lbl_idade);
            Controls.Add(lbl_posicao);
            Controls.Add(lbl_nome);
            Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Jogador";
            Load += frm_register_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nome;
        private Label lbl_posicao;
        private Label lbl_idade;
        private TextBox txtIdade;
        private TextBox txtPosicao;
        private TextBox txtNome;
        private Button btnEnviar;
        private Button btnApagar;
        private ErrorProvider errorProvider1;
        private ToolTip toolTip1;
        private ErrorProvider errorProvider2;
        private ToolTip toolTip2;
        private ErrorProvider errorProvider3;
        private ToolTip toolTip3;
        private ErrorProvider errorProvider4;
        private ToolTip toolTip4;
        private ComboBox cboTimes;
        private ComboBox cboJogadores;
        private Label lbl_time;
        private Label lblOpcao;
    }
}