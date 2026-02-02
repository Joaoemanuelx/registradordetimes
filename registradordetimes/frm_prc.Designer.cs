namespace registradordetimes
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            showDataToolStripMenuItem = new ToolStripMenuItem();
            cadastrarTimeToolStripMenuItem = new ToolStripMenuItem();
            registerDataToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            dgvJogadores = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJogadores).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonFace;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1000, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showDataToolStripMenuItem, cadastrarTimeToolStripMenuItem, registerDataToolStripMenuItem, exitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 19);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // showDataToolStripMenuItem
            // 
            showDataToolStripMenuItem.Name = "showDataToolStripMenuItem";
            showDataToolStripMenuItem.Size = new Size(180, 22);
            showDataToolStripMenuItem.Text = "Mostrar jogadores";
            showDataToolStripMenuItem.Click += showDataToolStripMenuItem_Click;
            // 
            // cadastrarTimeToolStripMenuItem
            // 
            cadastrarTimeToolStripMenuItem.Name = "cadastrarTimeToolStripMenuItem";
            cadastrarTimeToolStripMenuItem.Size = new Size(180, 22);
            cadastrarTimeToolStripMenuItem.Text = "Cadastrar time";
            cadastrarTimeToolStripMenuItem.Click += cadastrarTimeToolStripMenuItem_Click;
            // 
            // registerDataToolStripMenuItem
            // 
            registerDataToolStripMenuItem.Name = "registerDataToolStripMenuItem";
            registerDataToolStripMenuItem.Size = new Size(180, 22);
            registerDataToolStripMenuItem.Text = "Cadastrar jogadores";
            registerDataToolStripMenuItem.Click += registerDataToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Sair";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // dgvJogadores
            // 
            dgvJogadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJogadores.Location = new Point(0, 32);
            dgvJogadores.Margin = new Padding(4, 3, 4, 3);
            dgvJogadores.Name = "dgvJogadores";
            dgvJogadores.RowHeadersWidth = 51;
            dgvJogadores.Size = new Size(1000, 440);
            dgvJogadores.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 473);
            Controls.Add(dgvJogadores);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrador de Times";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJogadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem showDataToolStripMenuItem;
        private ToolStripMenuItem registerDataToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private DataGridView dgvJogadores;
        private ToolStripMenuItem cadastrarTimeToolStripMenuItem;
    }
}
