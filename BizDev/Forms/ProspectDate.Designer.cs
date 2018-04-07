namespace BizDev.Forms
{
    partial class ProspectDate
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
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.ChkDelDate = new System.Windows.Forms.CheckBox();
            this.LblLegende = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(272, 188);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(109, 35);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Enregistrer";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(145, 188);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(121, 35);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Annuler";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // DtpDate
            // 
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDate.Location = new System.Drawing.Point(39, 84);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(153, 26);
            this.DtpDate.TabIndex = 2;
            // 
            // ChkDelDate
            // 
            this.ChkDelDate.AutoSize = true;
            this.ChkDelDate.Location = new System.Drawing.Point(169, 139);
            this.ChkDelDate.Name = "ChkDelDate";
            this.ChkDelDate.Size = new System.Drawing.Size(160, 24);
            this.ChkDelDate.TabIndex = 3;
            this.ChkDelDate.Text = "Supprimer la date";
            this.ChkDelDate.UseVisualStyleBackColor = true;
            this.ChkDelDate.CheckedChanged += new System.EventHandler(this.ChkDelDate_CheckedChanged);
            // 
            // LblLegende
            // 
            this.LblLegende.AutoSize = true;
            this.LblLegende.Location = new System.Drawing.Point(141, 38);
            this.LblLegende.Name = "LblLegende";
            this.LblLegende.Size = new System.Drawing.Size(14, 20);
            this.LblLegende.TabIndex = 4;
            this.LblLegende.Text = "-";
            // 
            // ProspectDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 258);
            this.Controls.Add(this.LblLegende);
            this.Controls.Add(this.ChkDelDate);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProspectDate";
            this.ShowInTaskbar = false;
            this.Text = "Date";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.CheckBox ChkDelDate;
        private System.Windows.Forms.Label LblLegende;
    }
}