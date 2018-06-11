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
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.TbnNew = new System.Windows.Forms.ToolStripButton();
            this.TbnView = new System.Windows.Forms.ToolStripButton();
            this.DgvProspects = new System.Windows.Forms.DataGridView();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.LblSearch = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProspects)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TbnNew,
            this.TbnView});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ToolStrip.Size = new System.Drawing.Size(1428, 31);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // TbnNew
            // 
            this.TbnNew.Image = global::BizDev.Properties.Resources.icon_new_24;
            this.TbnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TbnNew.Name = "TbnNew";
            this.TbnNew.Size = new System.Drawing.Size(132, 28);
            this.TbnNew.Text = "Nouveau prospect";
            this.TbnNew.Click += new System.EventHandler(this.TbnNew_Click);
            // 
            // TbnView
            // 
            this.TbnView.Image = global::BizDev.Properties.Resources.icon_view_24;
            this.TbnView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TbnView.Name = "TbnView";
            this.TbnView.Size = new System.Drawing.Size(101, 28);
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
            this.DgvProspects.Location = new System.Drawing.Point(0, 95);
            this.DgvProspects.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DgvProspects.MultiSelect = false;
            this.DgvProspects.Name = "DgvProspects";
            this.DgvProspects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProspects.ShowCellErrors = false;
            this.DgvProspects.ShowCellToolTips = false;
            this.DgvProspects.ShowEditingIcon = false;
            this.DgvProspects.ShowRowErrors = false;
            this.DgvProspects.Size = new System.Drawing.Size(1428, 504);
            this.DgvProspects.TabIndex = 1;
            this.DgvProspects.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvProspects_CellMouseDoubleClick);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(154, 53);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(539, 23);
            this.TxtSearch.TabIndex = 2;
            this.TxtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyUp);
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Location = new System.Drawing.Point(15, 56);
            this.LblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(104, 17);
            this.LblSearch.TabIndex = 3;
            this.LblSearch.Text = "Rechercher :";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(701, 53);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(112, 23);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "Chercher";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(821, 53);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(112, 23);
            this.BtnReset.TabIndex = 5;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // ProspectsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 564);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.LblSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.DgvProspects);
            this.Controls.Add(this.ToolStrip);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ProspectsListForm";
            this.ShowIcon = false;
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
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnReset;
    }
}