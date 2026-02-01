namespace registradordetimes
{
    partial class frm_prc
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
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonFace;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showDataToolStripMenuItem, cadastrarTimeToolStripMenuItem, registerDataToolStripMenuItem, exitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // showDataToolStripMenuItem
            // 
            showDataToolStripMenuItem.Name = "showDataToolStripMenuItem";
            showDataToolStripMenuItem.Size = new Size(226, 26);
            showDataToolStripMenuItem.Text = "Mostrar jogadores";
            showDataToolStripMenuItem.Click += showDataToolStripMenuItem_Click;
            // 
            // cadastrarTimeToolStripMenuItem
            // 
            cadastrarTimeToolStripMenuItem.Name = "cadastrarTimeToolStripMenuItem";
            cadastrarTimeToolStripMenuItem.Size = new Size(226, 26);
            cadastrarTimeToolStripMenuItem.Text = "Cadastrar time";
            cadastrarTimeToolStripMenuItem.Click += cadastrarTimeToolStripMenuItem_Click;
            // 
            // registerDataToolStripMenuItem
            // 
            registerDataToolStripMenuItem.Name = "registerDataToolStripMenuItem";
            registerDataToolStripMenuItem.Size = new Size(226, 26);
            registerDataToolStripMenuItem.Text = "Cadastrar jogadores";
            registerDataToolStripMenuItem.Click += registerDataToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(226, 26);
            exitToolStripMenuItem.Text = "Sair";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 419);
            dataGridView1.TabIndex = 1;
            // 
            // frm_prc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frm_prc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrador de time";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem showDataToolStripMenuItem;
        private ToolStripMenuItem registerDataToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem cadastrarTimeToolStripMenuItem;
    }
}
