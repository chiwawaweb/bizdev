namespace BizDev.Forms
{
    partial class ProspectEditForm
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
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.CbxCategorie = new System.Windows.Forms.ComboBox();
            this.LsbCategories = new System.Windows.Forms.ListBox();
            this.BtnAddCategorie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(100, 85);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(171, 20);
            this.TxtNom.TabIndex = 0;
            // 
            // CbxCategorie
            // 
            this.CbxCategorie.FormattingEnabled = true;
            this.CbxCategorie.Location = new System.Drawing.Point(100, 48);
            this.CbxCategorie.Name = "CbxCategorie";
            this.CbxCategorie.Size = new System.Drawing.Size(239, 21);
            this.CbxCategorie.TabIndex = 1;
            // 
            // LsbCategories
            // 
            this.LsbCategories.FormattingEnabled = true;
            this.LsbCategories.Location = new System.Drawing.Point(456, 48);
            this.LsbCategories.Name = "LsbCategories";
            this.LsbCategories.Size = new System.Drawing.Size(292, 43);
            this.LsbCategories.TabIndex = 2;
            // 
            // BtnAddCategorie
            // 
            this.BtnAddCategorie.Location = new System.Drawing.Point(362, 48);
            this.BtnAddCategorie.Name = "BtnAddCategorie";
            this.BtnAddCategorie.Size = new System.Drawing.Size(75, 23);
            this.BtnAddCategorie.TabIndex = 3;
            this.BtnAddCategorie.Text = "->";
            this.BtnAddCategorie.UseVisualStyleBackColor = true;
            this.BtnAddCategorie.Click += new System.EventHandler(this.BtnAddCategorie_Click);
            // 
            // ProspectEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAddCategorie);
            this.Controls.Add(this.LsbCategories);
            this.Controls.Add(this.CbxCategorie);
            this.Controls.Add(this.TxtNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProspectEditForm";
            this.ShowInTaskbar = false;
            this.Text = "Fiche prospect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.ComboBox CbxCategorie;
        private System.Windows.Forms.ListBox LsbCategories;
        private System.Windows.Forms.Button BtnAddCategorie;
    }
}