namespace BizDev.Forms
{
    partial class ClientEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.CbxEntreprise = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RbtStandard = new System.Windows.Forms.RadioButton();
            this.RbtPartners = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CbxPays = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtAdresse1 = new System.Windows.Forms.TextBox();
            this.TxtCP = new System.Windows.Forms.TextBox();
            this.TxtVille = new System.Windows.Forms.TextBox();
            this.CbxCivilite = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtNumInterne = new System.Windows.Forms.TextBox();
            this.TxtAdresse2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(51, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom        :";
            // 
            // TxtNom
            // 
            this.TxtNom.BackColor = System.Drawing.Color.Beige;
            this.TxtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNom.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNom.Location = new System.Drawing.Point(189, 167);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(316, 30);
            this.TxtNom.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(51, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prénom     :";
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.BackColor = System.Drawing.Color.Beige;
            this.TxtPrenom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPrenom.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrenom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtPrenom.Location = new System.Drawing.Point(189, 203);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(316, 30);
            this.TxtPrenom.TabIndex = 5;
            // 
            // CbxEntreprise
            // 
            this.CbxEntreprise.BackColor = System.Drawing.Color.Beige;
            this.CbxEntreprise.Enabled = false;
            this.CbxEntreprise.FormattingEnabled = true;
            this.CbxEntreprise.Location = new System.Drawing.Point(189, 87);
            this.CbxEntreprise.Name = "CbxEntreprise";
            this.CbxEntreprise.Size = new System.Drawing.Size(573, 30);
            this.CbxEntreprise.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(51, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Entreprise :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(51, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Compte     :";
            // 
            // RbtStandard
            // 
            this.RbtStandard.AutoSize = true;
            this.RbtStandard.Checked = true;
            this.RbtStandard.Location = new System.Drawing.Point(189, 52);
            this.RbtStandard.Name = "RbtStandard";
            this.RbtStandard.Size = new System.Drawing.Size(108, 26);
            this.RbtStandard.TabIndex = 0;
            this.RbtStandard.TabStop = true;
            this.RbtStandard.Text = "STANDARD";
            this.RbtStandard.UseVisualStyleBackColor = true;
            this.RbtStandard.CheckedChanged += new System.EventHandler(this.RbtStandard_CheckedChanged);
            // 
            // RbtPartners
            // 
            this.RbtPartners.AutoSize = true;
            this.RbtPartners.Location = new System.Drawing.Point(303, 52);
            this.RbtPartners.Name = "RbtPartners";
            this.RbtPartners.Size = new System.Drawing.Size(108, 26);
            this.RbtPartners.TabIndex = 1;
            this.RbtPartners.TabStop = true;
            this.RbtPartners.Text = "PARTNERS";
            this.RbtPartners.UseVisualStyleBackColor = true;
            this.RbtPartners.CheckedChanged += new System.EventHandler(this.RbtPartners_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BizDev.Properties.Resources.logo_cbc_noir_300dpi;
            this.pictureBox1.Location = new System.Drawing.Point(757, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(51, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Adresse    :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(51, 320);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "CP / Ville :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(51, 356);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 22);
            this.label8.TabIndex = 19;
            this.label8.Text = "Pays       :";
            // 
            // CbxPays
            // 
            this.CbxPays.BackColor = System.Drawing.Color.Beige;
            this.CbxPays.FormattingEnabled = true;
            this.CbxPays.Location = new System.Drawing.Point(189, 353);
            this.CbxPays.Name = "CbxPays";
            this.CbxPays.Size = new System.Drawing.Size(316, 30);
            this.CbxPays.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 455);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(902, 150);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.TabStop = false;
            // 
            // TxtAdresse1
            // 
            this.TxtAdresse1.BackColor = System.Drawing.Color.Beige;
            this.TxtAdresse1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtAdresse1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdresse1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtAdresse1.Location = new System.Drawing.Point(189, 239);
            this.TxtAdresse1.Name = "TxtAdresse1";
            this.TxtAdresse1.Size = new System.Drawing.Size(316, 30);
            this.TxtAdresse1.TabIndex = 6;
            // 
            // TxtCP
            // 
            this.TxtCP.BackColor = System.Drawing.Color.Beige;
            this.TxtCP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCP.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtCP.Location = new System.Drawing.Point(189, 312);
            this.TxtCP.Name = "TxtCP";
            this.TxtCP.Size = new System.Drawing.Size(78, 30);
            this.TxtCP.TabIndex = 7;
            // 
            // TxtVille
            // 
            this.TxtVille.BackColor = System.Drawing.Color.Beige;
            this.TxtVille.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtVille.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVille.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtVille.Location = new System.Drawing.Point(273, 312);
            this.TxtVille.Name = "TxtVille";
            this.TxtVille.Size = new System.Drawing.Size(232, 30);
            this.TxtVille.TabIndex = 8;
            // 
            // CbxCivilite
            // 
            this.CbxCivilite.BackColor = System.Drawing.Color.Beige;
            this.CbxCivilite.FormattingEnabled = true;
            this.CbxCivilite.Location = new System.Drawing.Point(189, 123);
            this.CbxCivilite.Name = "CbxCivilite";
            this.CbxCivilite.Size = new System.Drawing.Size(134, 30);
            this.CbxCivilite.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(51, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 22);
            this.label7.TabIndex = 26;
            this.label7.Text = "Civilité   :";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(817, 630);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(140, 33);
            this.BtnSave.TabIndex = 27;
            this.BtnSave.TabStop = false;
            this.BtnSave.Text = "Enregistrer";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(686, 630);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(125, 33);
            this.BtnCancel.TabIndex = 28;
            this.BtnCancel.TabStop = false;
            this.BtnCancel.Text = "Annuler";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(51, 397);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 22);
            this.label10.TabIndex = 30;
            this.label10.Text = "N° interne :";
            // 
            // TxtNumInterne
            // 
            this.TxtNumInterne.BackColor = System.Drawing.Color.Beige;
            this.TxtNumInterne.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNumInterne.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumInterne.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtNumInterne.Location = new System.Drawing.Point(189, 394);
            this.TxtNumInterne.Name = "TxtNumInterne";
            this.TxtNumInterne.Size = new System.Drawing.Size(142, 30);
            this.TxtNumInterne.TabIndex = 9;
            // 
            // TxtAdresse2
            // 
            this.TxtAdresse2.BackColor = System.Drawing.Color.Beige;
            this.TxtAdresse2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtAdresse2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdresse2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtAdresse2.Location = new System.Drawing.Point(189, 276);
            this.TxtAdresse2.Name = "TxtAdresse2";
            this.TxtAdresse2.Size = new System.Drawing.Size(316, 30);
            this.TxtAdresse2.TabIndex = 31;
            // 
            // ClientEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1018, 702);
            this.Controls.Add(this.TxtAdresse2);
            this.Controls.Add(this.TxtNumInterne);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CbxCivilite);
            this.Controls.Add(this.TxtVille);
            this.Controls.Add(this.TxtCP);
            this.Controls.Add(this.TxtAdresse1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CbxPays);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RbtPartners);
            this.Controls.Add(this.RbtStandard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbxEntreprise);
            this.Controls.Add(this.TxtPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ClientEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Compte client";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPrenom;
        private System.Windows.Forms.ComboBox CbxEntreprise;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RbtStandard;
        private System.Windows.Forms.RadioButton RbtPartners;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CbxPays;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtAdresse1;
        private System.Windows.Forms.TextBox TxtCP;
        private System.Windows.Forms.TextBox TxtVille;
        private System.Windows.Forms.ComboBox CbxCivilite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtNumInterne;
        private System.Windows.Forms.TextBox TxtAdresse2;
    }
}