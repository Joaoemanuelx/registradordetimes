namespace registradordetimes
{
    partial class frmTimes
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
            txtNomeTime = new TextBox();
            txtCadastratTime = new Label();
            btnCadastrartime = new Button();
            btnApagarTime = new Button();
            comboBox1 = new ComboBox();
            lblTimesNome = new Label();
            SuspendLayout();
            // 
            // txtNomeTime
            // 
            txtNomeTime.Location = new Point(98, 52);
            txtNomeTime.Margin = new Padding(4);
            txtNomeTime.Name = "txtNomeTime";
            txtNomeTime.Size = new Size(256, 34);
            txtNomeTime.TabIndex = 0;
            // 
            // txtCadastratTime
            // 
            txtCadastratTime.AutoSize = true;
            txtCadastratTime.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            txtCadastratTime.Location = new Point(18, 56);
            txtCadastratTime.Margin = new Padding(4, 0, 4, 0);
            txtCadastratTime.Name = "txtCadastratTime";
            txtCadastratTime.Size = new Size(72, 24);
            txtCadastratTime.TabIndex = 1;
            txtCadastratTime.Text = "Nome:";
            // 
            // btnCadastrartime
            // 
            btnCadastrartime.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btnCadastrartime.Location = new Point(98, 94);
            btnCadastrartime.Margin = new Padding(4);
            btnCadastrartime.Name = "btnCadastrartime";
            btnCadastrartime.Size = new Size(141, 35);
            btnCadastrartime.TabIndex = 2;
            btnCadastrartime.Text = "&Cadastrar";
            btnCadastrartime.UseVisualStyleBackColor = true;
            btnCadastrartime.Click += btnCadastrarTime_Click;
            // 
            // btnApagarTime
            // 
            btnApagarTime.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btnApagarTime.Location = new Point(98, 226);
            btnApagarTime.Margin = new Padding(4);
            btnApagarTime.Name = "btnApagarTime";
            btnApagarTime.Size = new Size(141, 35);
            btnApagarTime.TabIndex = 3;
            btnApagarTime.Text = "&Apagar";
            btnApagarTime.UseVisualStyleBackColor = true;
            btnApagarTime.Click += btnApagarTime_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(98, 186);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(256, 32);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblTimesNome
            // 
            lblTimesNome.AutoSize = true;
            lblTimesNome.Location = new Point(18, 189);
            lblTimesNome.Name = "lblTimesNome";
            lblTimesNome.Size = new Size(71, 24);
            lblTimesNome.TabIndex = 7;
            lblTimesNome.Text = "Times:";
            // 
            // frmTimes
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 322);
            Controls.Add(lblTimesNome);
            Controls.Add(comboBox1);
            Controls.Add(btnApagarTime);
            Controls.Add(btnCadastrartime);
            Controls.Add(txtCadastratTime);
            Controls.Add(txtNomeTime);
            Font = new Font("Gadugi", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "frmTimes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadrastar Times";
            Load += frmTimes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeTime;
        private Label txtCadastratTime;
        private Button btnCadastrartime;
        private Button btnApagarTime;
        private ComboBox comboBox1;
        private Label lblTimesNome;
    }
}