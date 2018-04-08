namespace BizDev.Forms
{
    partial class ProspectsListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProspectsListForm));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.TbnNew = new System.Windows.Forms.ToolStripButton();
            this.TbnView = new System.Windows.Forms.ToolStripButton();
            this.DgvProspects = new System.Windows.Forms.DataGridView();
            this.ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProspects)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TbnNew,
            this.TbnView});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1270, 25);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // TbnNew
            // 
            this.TbnNew.Image = ((System.Drawing.Image)(resources.GetObject("TbnNew.Image")));
            this.TbnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TbnNew.Name = "TbnNew";
            this.TbnNew.Size = new System.Drawing.Size(124, 22);
            this.TbnNew.Text = "Nouveau prospect";
            this.TbnNew.Click += new System.EventHandler(this.TbnNew_Click);
            // 
            // TbnView
            // 
            this.TbnView.Image = ((System.Drawing.Image)(resources.GetObject("TbnView.Image")));
            this.TbnView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TbnView.Name = "TbnView";
            this.TbnView.Size = new System.Drawing.Size(93, 22);
            this.TbnView.Text = "Visualisation";
            this.TbnView.Click += new System.EventHandler(this.TbnView_Click);
            // 
            // DgvProspects
            // 
            this.DgvProspects.AllowUserToAddRows = false;
            this.DgvProspects.AllowUserToDeleteRows = false;
            this.DgvProspects.AllowUserToResizeColumns = false;
            this.DgvProspects.AllowUserToResizeRows = false;
            this.DgvProspects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProspects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProspects.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvProspects.Location = new System.Drawing.Point(0, 28);
            this.DgvProspects.MultiSelect = false;
            this.DgvProspects.Name = "DgvProspects";
            this.DgvProspects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProspects.ShowCellErrors = false;
            this.DgvProspects.ShowCellToolTips = false;
            this.DgvProspects.ShowEditingIcon = false;
            this.DgvProspects.ShowRowErrors = false;
            this.DgvProspects.Size = new System.Drawing.Size(1270, 549);
            this.DgvProspects.TabIndex = 1;
            this.DgvProspects.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvProspects_CellMouseDoubleClick);
            // 
            // ProspectsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 577);
            this.Controls.Add(this.DgvProspects);
            this.Controls.Add(this.ToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProspectsListForm";
            this.ShowInTaskbar = false;
            this.Text = "Liste de prospects";
            this.Load += new System.EventHandler(this.ProspectsListForm_Load);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProspects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton TbnNew;
        private System.Windows.Forms.DataGridView DgvProspects;
        private System.Windows.Forms.ToolStripButton TbnView;
    }
}