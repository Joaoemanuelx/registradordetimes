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
            menuStrip1.BackColor = Color.DarkGray;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(509, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showDataToolStripMenuItem, cadastrarTimeToolStripMenuItem, registerDataToolStripMenuItem, exitToolStripMenuItem });
            menuToolStripMenuItem.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuToolStripMenuItem.ForeColor = Color.Black;
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(55, 21);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // showDataToolStripMenuItem
            // 
            showDataToolStripMenuItem.Name = "showDataToolStripMenuItem";
            showDataToolStripMenuItem.Size = new Size(199, 22);
            showDataToolStripMenuItem.Text = "Mostrar jogadores";
            showDataToolStripMenuItem.Click += showDataToolStripMenuItem_Click;
            // 
            // cadastrarTimeToolStripMenuItem
            // 
            cadastrarTimeToolStripMenuItem.Name = "cadastrarTimeToolStripMenuItem";
            cadastrarTimeToolStripMenuItem.Size = new Size(199, 22);
            cadastrarTimeToolStripMenuItem.Text = "Cadastrar time";
            cadastrarTimeToolStripMenuItem.Click += cadastrarTimeToolStripMenuItem_Click;
            // 
            // registerDataToolStripMenuItem
            // 
            registerDataToolStripMenuItem.Name = "registerDataToolStripMenuItem";
            registerDataToolStripMenuItem.Size = new Size(199, 22);
            registerDataToolStripMenuItem.Text = "Cadastrar jogadores";
            registerDataToolStripMenuItem.Click += registerDataToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.ForeColor = Color.IndianRed;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(199, 22);
            exitToolStripMenuItem.Text = "Sair";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // dgvJogadores
            // 
            dgvJogadores.AllowUserToAddRows = false;
            dgvJogadores.AllowUserToDeleteRows = false;
            dgvJogadores.AllowUserToResizeColumns = false;
            dgvJogadores.AllowUserToResizeRows = false;
            dgvJogadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvJogadores.BackgroundColor = SystemColors.ButtonFace;
            dgvJogadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJogadores.Dock = DockStyle.Fill;
            dgvJogadores.Location = new Point(0, 27);
            dgvJogadores.Name = "dgvJogadores";
            dgvJogadores.ReadOnly = true;
            dgvJogadores.RowHeadersWidth = 51;
            dgvJogadores.Size = new Size(509, 352);
            dgvJogadores.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(509, 379);
            Controls.Add(dgvJogadores);
            Controls.Add(menuStrip1);
            Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
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
