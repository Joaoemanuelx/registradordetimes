namespace registradordetimes
{
    partial class frm_register
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
            txt_idade = new TextBox();
            txt_posicao = new TextBox();
            txt_nome = new TextBox();
            lbl_time = new Label();
            btn_enviar = new Button();
            listBox1 = new ListBox();
            btnApagar = new Button();
            btnCarregar = new Button();
            errorProvider1 = new ErrorProvider(components);
            toolTip1 = new ToolTip(components);
            errorProvider2 = new ErrorProvider(components);
            toolTip2 = new ToolTip(components);
            errorProvider3 = new ErrorProvider(components);
            toolTip3 = new ToolTip(components);
            errorProvider4 = new ErrorProvider(components);
            toolTip4 = new ToolTip(components);
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            SuspendLayout();
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(46, 44);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(53, 20);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "Nome:";
            // 
            // lbl_posicao
            // 
            lbl_posicao.AutoSize = true;
            lbl_posicao.Location = new Point(46, 97);
            lbl_posicao.Name = "lbl_posicao";
            lbl_posicao.Size = new Size(62, 20);
            lbl_posicao.TabIndex = 1;
            lbl_posicao.Text = "Posição:";
            // 
            // lbl_idade
            // 
            lbl_idade.AutoSize = true;
            lbl_idade.Location = new Point(46, 153);
            lbl_idade.Name = "lbl_idade";
            lbl_idade.Size = new Size(50, 20);
            lbl_idade.TabIndex = 2;
            lbl_idade.Text = "Idade:";
            // 
            // txt_idade
            // 
            txt_idade.Location = new Point(113, 150);
            txt_idade.Name = "txt_idade";
            txt_idade.Size = new Size(231, 27);
            txt_idade.TabIndex = 4;
            toolTip3.SetToolTip(txt_idade, "Digite uma idade valida!");
            txt_idade.TextChanged += txt_idade_TextChanged;
            // 
            // txt_posicao
            // 
            txt_posicao.Location = new Point(113, 94);
            txt_posicao.Name = "txt_posicao";
            txt_posicao.Size = new Size(231, 27);
            txt_posicao.TabIndex = 5;
            toolTip2.SetToolTip(txt_posicao, "Digite uma posição valida!");
            txt_posicao.TextChanged += txt_posicao_TextChanged;
            // 
            // txt_nome
            // 
            txt_nome.BackColor = SystemColors.Window;
            txt_nome.Location = new Point(113, 41);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(231, 27);
            txt_nome.TabIndex = 6;
            toolTip1.SetToolTip(txt_nome, "Digite um nome valido!");
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.Location = new Point(46, 206);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new Size(45, 20);
            lbl_time.TabIndex = 7;
            lbl_time.Text = "Time:";
            // 
            // btn_enviar
            // 
            btn_enviar.Location = new Point(113, 253);
            btn_enviar.Name = "btn_enviar";
            btn_enviar.Size = new Size(94, 29);
            btn_enviar.TabIndex = 9;
            btn_enviar.Text = "&Enviar";
            btn_enviar.UseVisualStyleBackColor = true;
            btn_enviar.Click += btn_enviar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(373, 26);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(147, 204);
            listBox1.TabIndex = 10;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(526, 79);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(94, 29);
            btnApagar.TabIndex = 11;
            btnApagar.Text = "&Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(526, 28);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(94, 29);
            btnCarregar.TabIndex = 12;
            btnCarregar.Text = "&Carregar";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(113, 203);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 13;
            
            // 
            // frm_register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(726, 369);
            Controls.Add(comboBox1);
            Controls.Add(btnCarregar);
            Controls.Add(btnApagar);
            Controls.Add(listBox1);
            Controls.Add(btn_enviar);
            Controls.Add(lbl_time);
            Controls.Add(txt_nome);
            Controls.Add(txt_posicao);
            Controls.Add(txt_idade);
            Controls.Add(lbl_idade);
            Controls.Add(lbl_posicao);
            Controls.Add(lbl_nome);
            Name = "frm_register";
            Text = "Registrar";
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
        private TextBox txt_idade;
        private TextBox txt_posicao;
        private TextBox txt_nome;
        private Label lbl_time;
        private Button btn_enviar;
        private ListBox listBox1;
        private Button btnApagar;
        private Button btnCarregar;
        private ErrorProvider errorProvider1;
        private ToolTip toolTip1;
        private ErrorProvider errorProvider2;
        private ToolTip toolTip2;
        private ErrorProvider errorProvider3;
        private ToolTip toolTip3;
        private ErrorProvider errorProvider4;
        private ToolTip toolTip4;
        private ComboBox comboBox1;
    }
}