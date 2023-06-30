namespace T31_projetobase
{
    partial class frmPrincipal
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
            menuStrip1 = new MenuStrip();
            dToolStripMenuItem = new ToolStripMenuItem();
            algoritimo01ToolStripMenuItem1 = new ToolStripMenuItem();
            algoritimo02ToolStripMenuItem1 = new ToolStripMenuItem();
            algoritimo03ToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            fecharToolStripMenuItem1 = new ToolStripMenuItem();
            dToolStripMenuItem1 = new ToolStripMenuItem();
            aPIsToolStripMenuItem = new ToolStripMenuItem();
            relatoriosToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dToolStripMenuItem, dToolStripMenuItem1, aPIsToolStripMenuItem, relatoriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dToolStripMenuItem
            // 
            dToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { algoritimo01ToolStripMenuItem1, algoritimo02ToolStripMenuItem1, algoritimo03ToolStripMenuItem1, toolStripMenuItem1, toolStripSeparator2, fecharToolStripMenuItem1 });
            dToolStripMenuItem.Name = "dToolStripMenuItem";
            dToolStripMenuItem.Size = new Size(71, 20);
            dToolStripMenuItem.Text = "Exercicios";
            // 
            // algoritimo01ToolStripMenuItem1
            // 
            algoritimo01ToolStripMenuItem1.Name = "algoritimo01ToolStripMenuItem1";
            algoritimo01ToolStripMenuItem1.Size = new Size(180, 22);
            algoritimo01ToolStripMenuItem1.Text = "Algoritimo 01";
            // 
            // algoritimo02ToolStripMenuItem1
            // 
            algoritimo02ToolStripMenuItem1.Name = "algoritimo02ToolStripMenuItem1";
            algoritimo02ToolStripMenuItem1.Size = new Size(180, 22);
            algoritimo02ToolStripMenuItem1.Text = "Algoritimo 02";
            // 
            // algoritimo03ToolStripMenuItem1
            // 
            algoritimo03ToolStripMenuItem1.Name = "algoritimo03ToolStripMenuItem1";
            algoritimo03ToolStripMenuItem1.Size = new Size(180, 22);
            algoritimo03ToolStripMenuItem1.Text = "Algoritimo 03";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // fecharToolStripMenuItem1
            // 
            fecharToolStripMenuItem1.Name = "fecharToolStripMenuItem1";
            fecharToolStripMenuItem1.Size = new Size(180, 22);
            fecharToolStripMenuItem1.Text = "Fechar";
            fecharToolStripMenuItem1.Click += fecharToolStripMenuItem1_Click;
            // 
            // dToolStripMenuItem1
            // 
            dToolStripMenuItem1.Name = "dToolStripMenuItem1";
            dToolStripMenuItem1.Size = new Size(103, 20);
            dToolStripMenuItem1.Text = "banco de dados";
            // 
            // aPIsToolStripMenuItem
            // 
            aPIsToolStripMenuItem.Name = "aPIsToolStripMenuItem";
            aPIsToolStripMenuItem.Size = new Size(42, 20);
            aPIsToolStripMenuItem.Text = "APIs";
            // 
            // relatoriosToolStripMenuItem
            // 
            relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            relatoriosToolStripMenuItem.Size = new Size(71, 20);
            relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(225, 22);
            toolStripMenuItem1.Text = "Torre de hanoi Recursividade";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "Projeto";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dToolStripMenuItem;
        private ToolStripMenuItem dToolStripMenuItem1;
        private ToolStripMenuItem aPIsToolStripMenuItem;
        private ToolStripMenuItem relatoriosToolStripMenuItem;
        private ToolStripMenuItem algoritimo01ToolStripMenuItem;
        private ToolStripMenuItem algoritimo02ToolStripMenuItem;
        private ToolStripMenuItem algoritimo03ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem fecharToolStripMenuItem;
        private ToolStripMenuItem algoritimo01ToolStripMenuItem1;
        private ToolStripMenuItem algoritimo02ToolStripMenuItem1;
        private ToolStripMenuItem algoritimo03ToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem fecharToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}