namespace BizDev.Forms
{
    partial class MainForm
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TooQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.prospectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TooListeProspects = new System.Windows.Forms.ToolStripMenuItem();
            this.TooStatistiquesProspects = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.prospectsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(799, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TooQuitter});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // TooQuitter
            // 
            this.TooQuitter.Name = "TooQuitter";
            this.TooQuitter.Size = new System.Drawing.Size(180, 22);
            this.TooQuitter.Text = "Quitter";
            this.TooQuitter.Click += new System.EventHandler(this.TooQuitter_Click);
            // 
            // prospectsToolStripMenuItem
            // 
            this.prospectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TooListeProspects,
            this.TooStatistiquesProspects});
            this.prospectsToolStripMenuItem.Name = "prospectsToolStripMenuItem";
            this.prospectsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.prospectsToolStripMenuItem.Text = "Prospects";
            // 
            // TooListeProspects
            // 
            this.TooListeProspects.Name = "TooListeProspects";
            this.TooListeProspects.Size = new System.Drawing.Size(180, 22);
            this.TooListeProspects.Text = "Liste de prospects";
            this.TooListeProspects.Click += new System.EventHandler(this.TooListeProspects_Click);
            // 
            // TooStatistiquesProspects
            // 
            this.TooStatistiquesProspects.Name = "TooStatistiquesProspects";
            this.TooStatistiquesProspects.Size = new System.Drawing.Size(180, 22);
            this.TooStatistiquesProspects.Text = "Statistiques";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Location = new System.Drawing.Point(0, 524);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(799, 22);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 546);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BizDev";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prospectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TooQuitter;
        private System.Windows.Forms.ToolStripMenuItem TooListeProspects;
        private System.Windows.Forms.ToolStripMenuItem TooStatistiquesProspects;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.StatusStrip StatusStrip;
    }
}