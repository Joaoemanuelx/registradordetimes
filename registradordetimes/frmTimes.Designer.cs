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
            listBox2 = new ListBox();
            btnCarregarTimes = new Button();
            SuspendLayout();
            // 
            // txtNomeTime
            // 
            txtNomeTime.Location = new Point(77, 48);
            txtNomeTime.Margin = new Padding(3, 2, 3, 2);
            txtNomeTime.Name = "txtNomeTime";
            txtNomeTime.Size = new Size(151, 23);
            txtNomeTime.TabIndex = 0;
            // 
            // txtCadastratTime
            // 
            txtCadastratTime.AutoSize = true;
            txtCadastratTime.Location = new Point(25, 51);
            txtCadastratTime.Name = "txtCadastratTime";
            txtCadastratTime.Size = new Size(43, 15);
            txtCadastratTime.TabIndex = 1;
            txtCadastratTime.Text = "Nome:";
            // 
            // btnCadastrartime
            // 
            btnCadastrartime.Location = new Point(77, 88);
            btnCadastrartime.Margin = new Padding(3, 2, 3, 2);
            btnCadastrartime.Name = "btnCadastrartime";
            btnCadastrartime.Size = new Size(82, 22);
            btnCadastrartime.TabIndex = 2;
            btnCadastrartime.Text = "&Cadastrar";
            btnCadastrartime.UseVisualStyleBackColor = true;
            btnCadastrartime.Click += btnCadastrarTime_Click;
            // 
            // btnApagarTime
            // 
            btnApagarTime.Location = new Point(390, 70);
            btnApagarTime.Margin = new Padding(3, 2, 3, 2);
            btnApagarTime.Name = "btnApagarTime";
            btnApagarTime.Size = new Size(82, 22);
            btnApagarTime.TabIndex = 3;
            btnApagarTime.Text = "&Apagar";
            btnApagarTime.UseVisualStyleBackColor = true;
            btnApagarTime.Click += btnApagarTime_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(254, 44);
            listBox2.Margin = new Padding(3, 2, 3, 2);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(132, 79);
            listBox2.TabIndex = 4;
            // 
            // btnCarregarTimes
            // 
            btnCarregarTimes.Location = new Point(390, 44);
            btnCarregarTimes.Margin = new Padding(3, 2, 3, 2);
            btnCarregarTimes.Name = "btnCarregarTimes";
            btnCarregarTimes.Size = new Size(82, 22);
            btnCarregarTimes.TabIndex = 5;
            btnCarregarTimes.Text = "&Carregar";
            btnCarregarTimes.UseVisualStyleBackColor = true;
            btnCarregarTimes.Click += btnCarregarTimes_Click;
            // 
            // frmTimes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 166);
            Controls.Add(btnCarregarTimes);
            Controls.Add(listBox2);
            Controls.Add(btnApagarTime);
            Controls.Add(btnCadastrartime);
            Controls.Add(txtCadastratTime);
            Controls.Add(txtNomeTime);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmTimes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadrastar Times";
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