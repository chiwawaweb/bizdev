﻿namespace BizDev.Forms
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
            this.components = new System.ComponentModel.Container();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.LblNbEmployes = new System.Windows.Forms.Label();
            this.TxtNbEmployes = new System.Windows.Forms.TextBox();
            this.LblCommentaires = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DtpPremierContact = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabCoordonnees = new System.Windows.Forms.TabPage();
            this.TabJournal = new System.Windows.Forms.TabPage();
            this.BtnDelCategorie = new System.Windows.Forms.Button();
            this.LblCategorie = new System.Windows.Forms.Label();
            this.BtnAddCategorie = new System.Windows.Forms.Button();
            this.LsbCategories = new System.Windows.Forms.ListBox();
            this.CbxCategorie = new System.Windows.Forms.ComboBox();
            this.LblPays = new System.Windows.Forms.Label();
            this.CbxPays = new System.Windows.Forms.ComboBox();
            this.LblVille = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblCodePostal = new System.Windows.Forms.Label();
            this.TxtCodePostal = new System.Windows.Forms.TextBox();
            this.TxtComplement = new System.Windows.Forms.TextBox();
            this.LblAdresse = new System.Windows.Forms.Label();
            this.TxtAdresse = new System.Windows.Forms.TextBox();
            this.LblNom = new System.Windows.Forms.Label();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TabCommunication = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtWeb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtFax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtGsm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.ChkConverti = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ChkAbandon = new System.Windows.Forms.CheckBox();
            this.DtpAbandon = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TabCoordonnees.SuspendLayout();
            this.TabJournal.SuspendLayout();
            this.TabCommunication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // LblNbEmployes
            // 
            this.LblNbEmployes.AutoSize = true;
            this.LblNbEmployes.Location = new System.Drawing.Point(368, 17);
            this.LblNbEmployes.Name = "LblNbEmployes";
            this.LblNbEmployes.Size = new System.Drawing.Size(52, 13);
            this.LblNbEmployes.TabIndex = 27;
            this.LblNbEmployes.Text = "Employés";
            // 
            // TxtNbEmployes
            // 
            this.TxtNbEmployes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNbEmployes.Location = new System.Drawing.Point(371, 33);
            this.TxtNbEmployes.MaxLength = 5;
            this.TxtNbEmployes.Name = "TxtNbEmployes";
            this.TxtNbEmployes.Size = new System.Drawing.Size(46, 20);
            this.TxtNbEmployes.TabIndex = 26;
            // 
            // LblCommentaires
            // 
            this.LblCommentaires.AutoSize = true;
            this.LblCommentaires.Location = new System.Drawing.Point(368, 78);
            this.LblCommentaires.Name = "LblCommentaires";
            this.LblCommentaires.Size = new System.Drawing.Size(73, 13);
            this.LblCommentaires.TabIndex = 29;
            this.LblCommentaires.Text = "Commentaires";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(371, 94);
            this.textBox1.MaxLength = 5;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(314, 219);
            this.textBox1.TabIndex = 28;
            // 
            // DtpPremierContact
            // 
            this.DtpPremierContact.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpPremierContact.Location = new System.Drawing.Point(27, 23);
            this.DtpPremierContact.Name = "DtpPremierContact";
            this.DtpPremierContact.Size = new System.Drawing.Size(95, 20);
            this.DtpPremierContact.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Premier contact";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabCoordonnees);
            this.TabControl.Controls.Add(this.TabCommunication);
            this.TabControl.Controls.Add(this.TabJournal);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(705, 376);
            this.TabControl.TabIndex = 36;
            // 
            // TabCoordonnees
            // 
            this.TabCoordonnees.Controls.Add(this.LblPays);
            this.TabCoordonnees.Controls.Add(this.LblCommentaires);
            this.TabCoordonnees.Controls.Add(this.CbxPays);
            this.TabCoordonnees.Controls.Add(this.textBox1);
            this.TabCoordonnees.Controls.Add(this.LblVille);
            this.TabCoordonnees.Controls.Add(this.textBox2);
            this.TabCoordonnees.Controls.Add(this.LblCodePostal);
            this.TabCoordonnees.Controls.Add(this.TxtCodePostal);
            this.TabCoordonnees.Controls.Add(this.TxtComplement);
            this.TabCoordonnees.Controls.Add(this.LblAdresse);
            this.TabCoordonnees.Controls.Add(this.TxtAdresse);
            this.TabCoordonnees.Controls.Add(this.LblNbEmployes);
            this.TabCoordonnees.Controls.Add(this.TxtNbEmployes);
            this.TabCoordonnees.Controls.Add(this.LblNom);
            this.TabCoordonnees.Controls.Add(this.TxtNom);
            this.TabCoordonnees.Controls.Add(this.BtnDelCategorie);
            this.TabCoordonnees.Controls.Add(this.LblCategorie);
            this.TabCoordonnees.Controls.Add(this.BtnAddCategorie);
            this.TabCoordonnees.Controls.Add(this.LsbCategories);
            this.TabCoordonnees.Controls.Add(this.CbxCategorie);
            this.TabCoordonnees.Location = new System.Drawing.Point(4, 22);
            this.TabCoordonnees.Name = "TabCoordonnees";
            this.TabCoordonnees.Padding = new System.Windows.Forms.Padding(3);
            this.TabCoordonnees.Size = new System.Drawing.Size(697, 350);
            this.TabCoordonnees.TabIndex = 0;
            this.TabCoordonnees.Text = "Coordonnées";
            this.TabCoordonnees.UseVisualStyleBackColor = true;
            // 
            // TabJournal
            // 
            this.TabJournal.Controls.Add(this.dataGridView1);
            this.TabJournal.Controls.Add(this.label14);
            this.TabJournal.Controls.Add(this.ChkConverti);
            this.TabJournal.Controls.Add(this.DtpPremierContact);
            this.TabJournal.Controls.Add(this.dateTimePicker1);
            this.TabJournal.Controls.Add(this.ChkAbandon);
            this.TabJournal.Controls.Add(this.DtpAbandon);
            this.TabJournal.Location = new System.Drawing.Point(4, 22);
            this.TabJournal.Name = "TabJournal";
            this.TabJournal.Padding = new System.Windows.Forms.Padding(3);
            this.TabJournal.Size = new System.Drawing.Size(697, 350);
            this.TabJournal.TabIndex = 1;
            this.TabJournal.Text = "Journal";
            this.TabJournal.UseVisualStyleBackColor = true;
            // 
            // BtnDelCategorie
            // 
            this.BtnDelCategorie.Location = new System.Drawing.Point(320, 60);
            this.BtnDelCategorie.Name = "BtnDelCategorie";
            this.BtnDelCategorie.Size = new System.Drawing.Size(23, 23);
            this.BtnDelCategorie.TabIndex = 11;
            this.BtnDelCategorie.TabStop = false;
            this.BtnDelCategorie.Text = "-";
            this.BtnDelCategorie.UseVisualStyleBackColor = true;
            // 
            // LblCategorie
            // 
            this.LblCategorie.AutoSize = true;
            this.LblCategorie.Location = new System.Drawing.Point(19, 16);
            this.LblCategorie.Name = "LblCategorie";
            this.LblCategorie.Size = new System.Drawing.Size(52, 13);
            this.LblCategorie.TabIndex = 10;
            this.LblCategorie.Text = "Catégorie";
            // 
            // BtnAddCategorie
            // 
            this.BtnAddCategorie.Location = new System.Drawing.Point(320, 31);
            this.BtnAddCategorie.Name = "BtnAddCategorie";
            this.BtnAddCategorie.Size = new System.Drawing.Size(23, 23);
            this.BtnAddCategorie.TabIndex = 9;
            this.BtnAddCategorie.TabStop = false;
            this.BtnAddCategorie.Text = "+";
            this.BtnAddCategorie.UseVisualStyleBackColor = true;
            // 
            // LsbCategories
            // 
            this.LsbCategories.BackColor = System.Drawing.SystemColors.Control;
            this.LsbCategories.FormattingEnabled = true;
            this.LsbCategories.Location = new System.Drawing.Point(22, 61);
            this.LsbCategories.Name = "LsbCategories";
            this.LsbCategories.ScrollAlwaysVisible = true;
            this.LsbCategories.Size = new System.Drawing.Size(292, 43);
            this.LsbCategories.TabIndex = 8;
            this.LsbCategories.TabStop = false;
            // 
            // CbxCategorie
            // 
            this.CbxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCategorie.FormattingEnabled = true;
            this.CbxCategorie.Location = new System.Drawing.Point(22, 32);
            this.CbxCategorie.Name = "CbxCategorie";
            this.CbxCategorie.Size = new System.Drawing.Size(292, 21);
            this.CbxCategorie.TabIndex = 7;
            // 
            // LblPays
            // 
            this.LblPays.AutoSize = true;
            this.LblPays.Location = new System.Drawing.Point(19, 276);
            this.LblPays.Name = "LblPays";
            this.LblPays.Size = new System.Drawing.Size(30, 13);
            this.LblPays.TabIndex = 26;
            this.LblPays.Text = "Pays";
            // 
            // CbxPays
            // 
            this.CbxPays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxPays.FormattingEnabled = true;
            this.CbxPays.Location = new System.Drawing.Point(22, 292);
            this.CbxPays.Name = "CbxPays";
            this.CbxPays.Size = new System.Drawing.Size(292, 21);
            this.CbxPays.TabIndex = 25;
            // 
            // LblVille
            // 
            this.LblVille.AutoSize = true;
            this.LblVille.Location = new System.Drawing.Point(85, 232);
            this.LblVille.Name = "LblVille";
            this.LblVille.Size = new System.Drawing.Size(26, 13);
            this.LblVille.TabIndex = 24;
            this.LblVille.Text = "Ville";
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(88, 248);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 20);
            this.textBox2.TabIndex = 21;
            // 
            // LblCodePostal
            // 
            this.LblCodePostal.AutoSize = true;
            this.LblCodePostal.Location = new System.Drawing.Point(19, 232);
            this.LblCodePostal.Name = "LblCodePostal";
            this.LblCodePostal.Size = new System.Drawing.Size(63, 13);
            this.LblCodePostal.TabIndex = 23;
            this.LblCodePostal.Text = "Code postal";
            // 
            // TxtCodePostal
            // 
            this.TxtCodePostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCodePostal.Location = new System.Drawing.Point(22, 248);
            this.TxtCodePostal.Name = "TxtCodePostal";
            this.TxtCodePostal.Size = new System.Drawing.Size(60, 20);
            this.TxtCodePostal.TabIndex = 19;
            // 
            // TxtComplement
            // 
            this.TxtComplement.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtComplement.Location = new System.Drawing.Point(22, 202);
            this.TxtComplement.Name = "TxtComplement";
            this.TxtComplement.Size = new System.Drawing.Size(292, 20);
            this.TxtComplement.TabIndex = 18;
            // 
            // LblAdresse
            // 
            this.LblAdresse.AutoSize = true;
            this.LblAdresse.Location = new System.Drawing.Point(19, 160);
            this.LblAdresse.Name = "LblAdresse";
            this.LblAdresse.Size = new System.Drawing.Size(45, 13);
            this.LblAdresse.TabIndex = 22;
            this.LblAdresse.Text = "Adresse";
            // 
            // TxtAdresse
            // 
            this.TxtAdresse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtAdresse.Location = new System.Drawing.Point(22, 176);
            this.TxtAdresse.Name = "TxtAdresse";
            this.TxtAdresse.Size = new System.Drawing.Size(292, 20);
            this.TxtAdresse.TabIndex = 17;
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(19, 115);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(29, 13);
            this.LblNom.TabIndex = 20;
            this.LblNom.Text = "Nom";
            // 
            // TxtNom
            // 
            this.TxtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNom.Location = new System.Drawing.Point(22, 131);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(292, 20);
            this.TxtNom.TabIndex = 16;
            // 
            // TabCommunication
            // 
            this.TabCommunication.Controls.Add(this.label11);
            this.TabCommunication.Controls.Add(this.TxtWeb);
            this.TabCommunication.Controls.Add(this.label10);
            this.TabCommunication.Controls.Add(this.TxtEmail);
            this.TabCommunication.Controls.Add(this.label9);
            this.TabCommunication.Controls.Add(this.TxtFax);
            this.TabCommunication.Controls.Add(this.label8);
            this.TabCommunication.Controls.Add(this.TxtGsm);
            this.TabCommunication.Controls.Add(this.label7);
            this.TabCommunication.Controls.Add(this.TxtTel);
            this.TabCommunication.Location = new System.Drawing.Point(4, 22);
            this.TabCommunication.Name = "TabCommunication";
            this.TabCommunication.Size = new System.Drawing.Size(697, 350);
            this.TabCommunication.TabIndex = 2;
            this.TabCommunication.Text = "Communication";
            this.TabCommunication.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(288, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Web";
            // 
            // TxtWeb
            // 
            this.TxtWeb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtWeb.Location = new System.Drawing.Point(291, 263);
            this.TxtWeb.Name = "TxtWeb";
            this.TxtWeb.Size = new System.Drawing.Size(118, 20);
            this.TxtWeb.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtEmail.Location = new System.Drawing.Point(291, 222);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(118, 20);
            this.TxtEmail.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Fax";
            // 
            // TxtFax
            // 
            this.TxtFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFax.Location = new System.Drawing.Point(291, 178);
            this.TxtFax.Name = "TxtFax";
            this.TxtFax.Size = new System.Drawing.Size(118, 20);
            this.TxtFax.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Portable";
            // 
            // TxtGsm
            // 
            this.TxtGsm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtGsm.Location = new System.Drawing.Point(291, 129);
            this.TxtGsm.Name = "TxtGsm";
            this.TxtGsm.Size = new System.Drawing.Size(118, 20);
            this.TxtGsm.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Téléphone";
            // 
            // TxtTel
            // 
            this.TxtTel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTel.Location = new System.Drawing.Point(291, 84);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(118, 20);
            this.TxtTel.TabIndex = 26;
            // 
            // ChkConverti
            // 
            this.ChkConverti.AutoSize = true;
            this.ChkConverti.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkConverti.Location = new System.Drawing.Point(153, 7);
            this.ChkConverti.Name = "ChkConverti";
            this.ChkConverti.Size = new System.Drawing.Size(65, 17);
            this.ChkConverti.TabIndex = 30;
            this.ChkConverti.TabStop = false;
            this.ChkConverti.Text = "Converti";
            this.ChkConverti.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 31;
            this.dateTimePicker1.Visible = false;
            // 
            // ChkAbandon
            // 
            this.ChkAbandon.AutoSize = true;
            this.ChkAbandon.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkAbandon.Location = new System.Drawing.Point(285, 6);
            this.ChkAbandon.Name = "ChkAbandon";
            this.ChkAbandon.Size = new System.Drawing.Size(69, 17);
            this.ChkAbandon.TabIndex = 32;
            this.ChkAbandon.TabStop = false;
            this.ChkAbandon.Text = "Abandon";
            this.ChkAbandon.UseVisualStyleBackColor = true;
            // 
            // DtpAbandon
            // 
            this.DtpAbandon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpAbandon.Location = new System.Drawing.Point(285, 24);
            this.DtpAbandon.Name = "DtpAbandon";
            this.DtpAbandon.Size = new System.Drawing.Size(95, 20);
            this.DtpAbandon.TabIndex = 33;
            this.DtpAbandon.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 278);
            this.dataGridView1.TabIndex = 34;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(623, 394);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 36;
            this.BtnSave.Text = "Enregistrer";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(542, 394);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 37;
            this.BtnCancel.Text = "Annuler";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(623, 394);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 38;
            this.BtnClose.Text = "Fermer";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(498, 392);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(26, 26);
            this.BtnEdit.TabIndex = 39;
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // ProspectEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 436);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProspectEditForm";
            this.ShowInTaskbar = false;
            this.Text = "Fiche prospect";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.TabCoordonnees.ResumeLayout(false);
            this.TabCoordonnees.PerformLayout();
            this.TabJournal.ResumeLayout(false);
            this.TabJournal.PerformLayout();
            this.TabCommunication.ResumeLayout(false);
            this.TabCommunication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Label LblNbEmployes;
        private System.Windows.Forms.TextBox TxtNbEmployes;
        private System.Windows.Forms.Label LblCommentaires;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker DtpPremierContact;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabCoordonnees;
        private System.Windows.Forms.Label LblPays;
        private System.Windows.Forms.ComboBox CbxPays;
        private System.Windows.Forms.Label LblVille;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LblCodePostal;
        private System.Windows.Forms.TextBox TxtCodePostal;
        private System.Windows.Forms.TextBox TxtComplement;
        private System.Windows.Forms.Label LblAdresse;
        private System.Windows.Forms.TextBox TxtAdresse;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Button BtnDelCategorie;
        private System.Windows.Forms.Label LblCategorie;
        private System.Windows.Forms.Button BtnAddCategorie;
        private System.Windows.Forms.ListBox LsbCategories;
        private System.Windows.Forms.ComboBox CbxCategorie;
        private System.Windows.Forms.TabPage TabCommunication;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtWeb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtFax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtGsm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.TabPage TabJournal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox ChkConverti;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox ChkAbandon;
        private System.Windows.Forms.DateTimePicker DtpAbandon;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
    }
}