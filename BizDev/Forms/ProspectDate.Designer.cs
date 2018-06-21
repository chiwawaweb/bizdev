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
            this.BtnSave.Location = new System.Drawing.Point(137, 89);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(73, 23);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Enregistrer";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(51, 89);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(81, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Annuler";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // DtpDate
            // 
            this.DtpDate.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDate.Location = new System.Drawing.Point(51, 33);
            this.DtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.DtpDate.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(128, 26);
            this.DtpDate.TabIndex = 2;
            // 
            // ChkDelDate
            // 
            this.ChkDelDate.AutoSize = true;
            this.ChkDelDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkDelDate.Location = new System.Drawing.Point(51, 59);
            this.ChkDelDate.Margin = new System.Windows.Forms.Padding(2);
            this.ChkDelDate.Name = "ChkDelDate";
            this.ChkDelDate.Size = new System.Drawing.Size(129, 20);
            this.ChkDelDate.TabIndex = 3;
            this.ChkDelDate.Text = "Supprimer la date";
            this.ChkDelDate.UseVisualStyleBackColor = true;
            this.ChkDelDate.CheckedChanged += new System.EventHandler(this.ChkDelDate_CheckedChanged);
            // 
            // LblLegende
            // 
            this.LblLegende.AutoSize = true;
            this.LblLegende.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLegende.Location = new System.Drawing.Point(48, 15);
            this.LblLegende.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLegende.Name = "LblLegende";
            this.LblLegende.Size = new System.Drawing.Size(37, 16);
            this.LblLegende.TabIndex = 4;
            this.LblLegende.Text = "Date";
            // 
            // ProspectDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(264, 137);
            this.Controls.Add(this.LblLegende);
            this.Controls.Add(this.ChkDelDate);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProspectDate";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Date";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProspectDate_FormClosed);
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