namespace MineSwipe
{
    partial class MainForm
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
            fichierToolStripMenuItem = new ToolStripMenuItem();
            nouvellePartieToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            débutantToolStripMenuItem = new ToolStripMenuItem();
            intermédiaireToolStripMenuItem = new ToolStripMenuItem();
            expertToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            aProposToolStripMenuItem = new ToolStripMenuItem();
            GameBoardView = new Controls.BoardView();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nouvellePartieToolStripMenuItem, toolStripMenuItem3, débutantToolStripMenuItem, intermédiaireToolStripMenuItem, expertToolStripMenuItem, toolStripMenuItem2, quitterToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(54, 20);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouvellePartieToolStripMenuItem
            // 
            nouvellePartieToolStripMenuItem.Name = "nouvellePartieToolStripMenuItem";
            nouvellePartieToolStripMenuItem.ShortcutKeys = Keys.F2;
            nouvellePartieToolStripMenuItem.Size = new Size(173, 22);
            nouvellePartieToolStripMenuItem.Text = "Nouvelle partie";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(170, 6);
            // 
            // débutantToolStripMenuItem
            // 
            débutantToolStripMenuItem.Name = "débutantToolStripMenuItem";
            débutantToolStripMenuItem.Size = new Size(173, 22);
            débutantToolStripMenuItem.Text = "Débutant";
            // 
            // intermédiaireToolStripMenuItem
            // 
            intermédiaireToolStripMenuItem.Name = "intermédiaireToolStripMenuItem";
            intermédiaireToolStripMenuItem.Size = new Size(173, 22);
            intermédiaireToolStripMenuItem.Text = "Intermédiaire";
            // 
            // expertToolStripMenuItem
            // 
            expertToolStripMenuItem.Name = "expertToolStripMenuItem";
            expertToolStripMenuItem.Size = new Size(173, 22);
            expertToolStripMenuItem.Text = "Expert";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(170, 6);
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(173, 22);
            quitterToolStripMenuItem.Text = "Quitter";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { aProposToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(24, 20);
            toolStripMenuItem1.Text = "?";
            // 
            // aProposToolStripMenuItem
            // 
            aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            aProposToolStripMenuItem.Size = new Size(131, 22);
            aProposToolStripMenuItem.Text = "A propos...";
            // 
            // GameBoardView
            // 
            GameBoardView.Location = new Point(52, 42);
            GameBoardView.Name = "GameBoardView";
            GameBoardView.Size = new Size(683, 364);
            GameBoardView.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GameBoardView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem nouvellePartieToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem débutantToolStripMenuItem;
        private ToolStripMenuItem intermédiaireToolStripMenuItem;
        private ToolStripMenuItem expertToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem aProposToolStripMenuItem;
        private Controls.BoardView GameBoardView;
    }
}
