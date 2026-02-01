namespace registradordetimes
{
    partial class frm_time
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
            listBox2 = new ListBox();
            btnCarregarTimes = new Button();
            SuspendLayout();
            // 
            // txtNomeTime
            // 
            txtNomeTime.Location = new Point(88, 64);
            txtNomeTime.Name = "txtNomeTime";
            txtNomeTime.Size = new Size(172, 27);
            txtNomeTime.TabIndex = 0;
            // 
            // txtCadastratTime
            // 
            txtCadastratTime.AutoSize = true;
            txtCadastratTime.Location = new Point(29, 68);
            txtCadastratTime.Name = "txtCadastratTime";
            txtCadastratTime.Size = new Size(53, 20);
            txtCadastratTime.TabIndex = 1;
            txtCadastratTime.Text = "Nome:";
            // 
            // btnCadastrartime
            // 
            btnCadastrartime.Location = new Point(88, 118);
            btnCadastrartime.Name = "btnCadastrartime";
            btnCadastrartime.Size = new Size(94, 29);
            btnCadastrartime.TabIndex = 2;
            btnCadastrartime.Text = "&Cadastrar";
            btnCadastrartime.UseVisualStyleBackColor = true;
            btnCadastrartime.Click += btnCadastrarTime_Click;
            // 
            // btnApagarTime
            // 
            btnApagarTime.Location = new Point(446, 94);
            btnApagarTime.Name = "btnApagarTime";
            btnApagarTime.Size = new Size(94, 29);
            btnApagarTime.TabIndex = 3;
            btnApagarTime.Text = "&Apagar";
            btnApagarTime.UseVisualStyleBackColor = true;
            btnApagarTime.Click += btnApagarTime_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(290, 59);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 104);
            listBox2.TabIndex = 4;
            // 
            // btnCarregarTimes
            // 
            btnCarregarTimes.Location = new Point(446, 59);
            btnCarregarTimes.Name = "btnCarregarTimes";
            btnCarregarTimes.Size = new Size(94, 29);
            btnCarregarTimes.TabIndex = 5;
            btnCarregarTimes.Text = "&Carregar";
            btnCarregarTimes.UseVisualStyleBackColor = true;
            btnCarregarTimes.Click += btnCarregarTimes_Click;
            // 
            // frm_time
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 221);
            Controls.Add(btnCarregarTimes);
            Controls.Add(listBox2);
            Controls.Add(btnApagarTime);
            Controls.Add(btnCadastrartime);
            Controls.Add(txtCadastratTime);
            Controls.Add(txtNomeTime);
            Name = "frm_time";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeTime;
        private Label txtCadastratTime;
        private Button btnCadastrartime;
        private Button btnApagarTime;
        private ListBox listBox2;
        private Button btnCarregarTimes;
    }
}