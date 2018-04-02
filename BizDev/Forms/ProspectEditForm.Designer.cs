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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDelCategorie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(100, 96);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(239, 20);
            this.TxtNom.TabIndex = 0;
            // 
            // CbxCategorie
            // 
            this.CbxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Catégorie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom";
            // 
            // BtnDelCategorie
            // 
            this.BtnDelCategorie.Location = new System.Drawing.Point(722, 97);
            this.BtnDelCategorie.Name = "BtnDelCategorie";
            this.BtnDelCategorie.Size = new System.Drawing.Size(26, 23);
            this.BtnDelCategorie.TabIndex = 6;
            this.BtnDelCategorie.Text = "-";
            this.BtnDelCategorie.UseVisualStyleBackColor = true;
            this.BtnDelCategorie.Click += new System.EventHandler(this.BtnDelCategorie_Click);
            // 
            // ProspectEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDelCategorie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDelCategorie;
    }
}