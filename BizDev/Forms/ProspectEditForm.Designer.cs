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
            this.CbxPays = new System.Windows.Forms.ComboBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.CbxCategorie = new System.Windows.Forms.ComboBox();
            this.LblNbEmployes = new System.Windows.Forms.Label();
            this.TxtNbEmployes = new System.Windows.Forms.TextBox();
            this.LblCommentaires = new System.Windows.Forms.Label();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtFax = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtWeb = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtGsm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.LblPays = new System.Windows.Forms.Label();
            this.LblVille = new System.Windows.Forms.Label();
            this.TxtVille = new System.Windows.Forms.TextBox();
            this.LblCodePostal = new System.Windows.Forms.Label();
            this.TxtCodePostal = new System.Windows.Forms.TextBox();
            this.TxtComplement = new System.Windows.Forms.TextBox();
            this.LblAdresse = new System.Windows.Forms.Label();
            this.TxtAdresse = new System.Windows.Forms.TextBox();
            this.LblNom = new System.Windows.Forms.Label();
            this.LblCategorie = new System.Windows.Forms.Label();
            this.TxtAbandon = new System.Windows.Forms.TextBox();
            this.TxtConversion = new System.Windows.Forms.TextBox();
            this.TxtPremierContact = new System.Windows.Forms.TextBox();
            this.BtnAbandon = new System.Windows.Forms.Button();
            this.BtnConversion = new System.Windows.Forms.Button();
            this.BtnPremierContact = new System.Windows.Forms.Button();
            this.BtnAddLog = new System.Windows.Forms.Button();
            this.DgvLog = new System.Windows.Forms.DataGridView();
            this.LblDatePremierContact = new System.Windows.Forms.Label();
            this.LblDateAbandon = new System.Windows.Forms.Label();
            this.LblDateConversion = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider.ContainerControl = this;
            // 
            // CbxPays
            // 
            this.CbxPays.BackColor = System.Drawing.Color.Beige;
            this.CbxPays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxPays.FormattingEnabled = true;
            this.ErrorProvider.SetIconAlignment(this.CbxPays, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.CbxPays.Location = new System.Drawing.Point(27, 303);
            this.CbxPays.Name = "CbxPays";
            this.CbxPays.Size = new System.Drawing.Size(292, 21);
            this.CbxPays.TabIndex = 7;
            // 
            // TxtNom
            // 
            this.TxtNom.BackColor = System.Drawing.Color.Beige;
            this.TxtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorProvider.SetIconAlignment(this.TxtNom, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.TxtNom.Location = new System.Drawing.Point(27, 39);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(292, 20);
            this.TxtNom.TabIndex = 0;
            // 
            // CbxCategorie
            // 
            this.CbxCategorie.BackColor = System.Drawing.Color.Beige;
            this.CbxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCategorie.FormattingEnabled = true;
            this.ErrorProvider.SetIconAlignment(this.CbxCategorie, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.CbxCategorie.Location = new System.Drawing.Point(27, 86);
            this.CbxCategorie.Name = "CbxCategorie";
            this.CbxCategorie.Size = new System.Drawing.Size(292, 21);
            this.CbxCategorie.TabIndex = 1;
            this.CbxCategorie.TabStop = false;
            // 
            // LblNbEmployes
            // 
            this.LblNbEmployes.AutoSize = true;
            this.LblNbEmployes.Location = new System.Drawing.Point(24, 117);
            this.LblNbEmployes.Name = "LblNbEmployes";
            this.LblNbEmployes.Size = new System.Drawing.Size(52, 13);
            this.LblNbEmployes.TabIndex = 12;
            this.LblNbEmployes.Text = "Employés";
            // 
            // TxtNbEmployes
            // 
            this.TxtNbEmployes.BackColor = System.Drawing.Color.Beige;
            this.TxtNbEmployes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNbEmployes.Location = new System.Drawing.Point(27, 133);
            this.TxtNbEmployes.MaxLength = 5;
            this.TxtNbEmployes.Name = "TxtNbEmployes";
            this.TxtNbEmployes.Size = new System.Drawing.Size(46, 20);
            this.TxtNbEmployes.TabIndex = 2;
            // 
            // LblCommentaires
            // 
            this.LblCommentaires.AutoSize = true;
            this.LblCommentaires.Location = new System.Drawing.Point(375, 171);
            this.LblCommentaires.Name = "LblCommentaires";
            this.LblCommentaires.Size = new System.Drawing.Size(73, 13);
            this.LblCommentaires.TabIndex = 29;
            this.LblCommentaires.Text = "Commentaires";
            // 
            // TxtNotes
            // 
            this.TxtNotes.AcceptsReturn = true;
            this.TxtNotes.BackColor = System.Drawing.Color.Beige;
            this.TxtNotes.Location = new System.Drawing.Point(376, 187);
            this.TxtNotes.MaxLength = 20000;
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(314, 69);
            this.TxtNotes.TabIndex = 13;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(588, 504);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(23, 23);
            this.BtnEdit.TabIndex = 39;
            this.BtnEdit.TabStop = false;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Visible = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(585, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Fax";
            // 
            // TxtFax
            // 
            this.TxtFax.BackColor = System.Drawing.Color.Beige;
            this.TxtFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFax.Location = new System.Drawing.Point(588, 39);
            this.TxtFax.Name = "TxtFax";
            this.TxtFax.Size = new System.Drawing.Size(100, 20);
            this.TxtFax.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(375, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Web";
            // 
            // TxtWeb
            // 
            this.TxtWeb.BackColor = System.Drawing.Color.Beige;
            this.TxtWeb.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TxtWeb.Location = new System.Drawing.Point(376, 138);
            this.TxtWeb.Name = "TxtWeb";
            this.TxtWeb.Size = new System.Drawing.Size(309, 20);
            this.TxtWeb.TabIndex = 12;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(373, 70);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(32, 13);
            this.LblEmail.TabIndex = 37;
            this.LblEmail.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.Beige;
            this.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TxtEmail.Location = new System.Drawing.Point(376, 86);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(311, 20);
            this.TxtEmail.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Portable";
            // 
            // TxtGsm
            // 
            this.TxtGsm.BackColor = System.Drawing.Color.Beige;
            this.TxtGsm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtGsm.Location = new System.Drawing.Point(482, 39);
            this.TxtGsm.Name = "TxtGsm";
            this.TxtGsm.Size = new System.Drawing.Size(100, 20);
            this.TxtGsm.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Téléphone";
            // 
            // TxtTel
            // 
            this.TxtTel.BackColor = System.Drawing.Color.Beige;
            this.TxtTel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTel.Location = new System.Drawing.Point(376, 39);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(100, 20);
            this.TxtTel.TabIndex = 8;
            // 
            // LblPays
            // 
            this.LblPays.AutoSize = true;
            this.LblPays.Location = new System.Drawing.Point(24, 287);
            this.LblPays.Name = "LblPays";
            this.LblPays.Size = new System.Drawing.Size(30, 13);
            this.LblPays.TabIndex = 26;
            this.LblPays.Text = "Pays";
            // 
            // LblVille
            // 
            this.LblVille.AutoSize = true;
            this.LblVille.Location = new System.Drawing.Point(90, 243);
            this.LblVille.Name = "LblVille";
            this.LblVille.Size = new System.Drawing.Size(26, 13);
            this.LblVille.TabIndex = 24;
            this.LblVille.Text = "Ville";
            // 
            // TxtVille
            // 
            this.TxtVille.BackColor = System.Drawing.Color.Beige;
            this.TxtVille.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtVille.Location = new System.Drawing.Point(93, 259);
            this.TxtVille.Name = "TxtVille";
            this.TxtVille.Size = new System.Drawing.Size(226, 20);
            this.TxtVille.TabIndex = 6;
            // 
            // LblCodePostal
            // 
            this.LblCodePostal.AutoSize = true;
            this.LblCodePostal.Location = new System.Drawing.Point(24, 243);
            this.LblCodePostal.Name = "LblCodePostal";
            this.LblCodePostal.Size = new System.Drawing.Size(63, 13);
            this.LblCodePostal.TabIndex = 23;
            this.LblCodePostal.Text = "Code postal";
            // 
            // TxtCodePostal
            // 
            this.TxtCodePostal.BackColor = System.Drawing.Color.Beige;
            this.TxtCodePostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCodePostal.Location = new System.Drawing.Point(27, 259);
            this.TxtCodePostal.Name = "TxtCodePostal";
            this.TxtCodePostal.Size = new System.Drawing.Size(60, 20);
            this.TxtCodePostal.TabIndex = 5;
            // 
            // TxtComplement
            // 
            this.TxtComplement.BackColor = System.Drawing.Color.Beige;
            this.TxtComplement.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtComplement.Location = new System.Drawing.Point(27, 213);
            this.TxtComplement.Name = "TxtComplement";
            this.TxtComplement.Size = new System.Drawing.Size(292, 20);
            this.TxtComplement.TabIndex = 4;
            // 
            // LblAdresse
            // 
            this.LblAdresse.AutoSize = true;
            this.LblAdresse.Location = new System.Drawing.Point(24, 171);
            this.LblAdresse.Name = "LblAdresse";
            this.LblAdresse.Size = new System.Drawing.Size(45, 13);
            this.LblAdresse.TabIndex = 22;
            this.LblAdresse.Text = "Adresse";
            // 
            // TxtAdresse
            // 
            this.TxtAdresse.BackColor = System.Drawing.Color.Beige;
            this.TxtAdresse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtAdresse.Location = new System.Drawing.Point(27, 187);
            this.TxtAdresse.Name = "TxtAdresse";
            this.TxtAdresse.Size = new System.Drawing.Size(292, 20);
            this.TxtAdresse.TabIndex = 3;
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(24, 23);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(29, 13);
            this.LblNom.TabIndex = 20;
            this.LblNom.Text = "Nom";
            // 
            // LblCategorie
            // 
            this.LblCategorie.AutoSize = true;
            this.LblCategorie.Location = new System.Drawing.Point(24, 70);
            this.LblCategorie.Name = "LblCategorie";
            this.LblCategorie.Size = new System.Drawing.Size(52, 13);
            this.LblCategorie.TabIndex = 10;
            this.LblCategorie.Text = "Catégorie";
            // 
            // TxtAbandon
            // 
            this.TxtAbandon.BackColor = System.Drawing.Color.LightCoral;
            this.TxtAbandon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAbandon.Location = new System.Drawing.Point(468, 309);
            this.TxtAbandon.Name = "TxtAbandon";
            this.TxtAbandon.ReadOnly = true;
            this.TxtAbandon.Size = new System.Drawing.Size(81, 20);
            this.TxtAbandon.TabIndex = 45;
            this.TxtAbandon.TabStop = false;
            this.TxtAbandon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtConversion
            // 
            this.TxtConversion.BackColor = System.Drawing.Color.Gold;
            this.TxtConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConversion.Location = new System.Drawing.Point(468, 286);
            this.TxtConversion.Name = "TxtConversion";
            this.TxtConversion.ReadOnly = true;
            this.TxtConversion.Size = new System.Drawing.Size(81, 20);
            this.TxtConversion.TabIndex = 44;
            this.TxtConversion.TabStop = false;
            this.TxtConversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPremierContact
            // 
            this.TxtPremierContact.BackColor = System.Drawing.Color.PaleGreen;
            this.TxtPremierContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPremierContact.Location = new System.Drawing.Point(468, 263);
            this.TxtPremierContact.Name = "TxtPremierContact";
            this.TxtPremierContact.ReadOnly = true;
            this.TxtPremierContact.Size = new System.Drawing.Size(81, 20);
            this.TxtPremierContact.TabIndex = 43;
            this.TxtPremierContact.TabStop = false;
            this.TxtPremierContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnAbandon
            // 
            this.BtnAbandon.Location = new System.Drawing.Point(551, 308);
            this.BtnAbandon.Name = "BtnAbandon";
            this.BtnAbandon.Size = new System.Drawing.Size(24, 22);
            this.BtnAbandon.TabIndex = 42;
            this.BtnAbandon.TabStop = false;
            this.BtnAbandon.Text = "...";
            this.BtnAbandon.UseVisualStyleBackColor = true;
            this.BtnAbandon.Click += new System.EventHandler(this.BtnAbandon_Click);
            // 
            // BtnConversion
            // 
            this.BtnConversion.Location = new System.Drawing.Point(551, 285);
            this.BtnConversion.Name = "BtnConversion";
            this.BtnConversion.Size = new System.Drawing.Size(24, 22);
            this.BtnConversion.TabIndex = 41;
            this.BtnConversion.TabStop = false;
            this.BtnConversion.Text = "...";
            this.BtnConversion.UseVisualStyleBackColor = true;
            this.BtnConversion.Click += new System.EventHandler(this.BtnConversion_Click);
            // 
            // BtnPremierContact
            // 
            this.BtnPremierContact.Location = new System.Drawing.Point(551, 262);
            this.BtnPremierContact.Name = "BtnPremierContact";
            this.BtnPremierContact.Size = new System.Drawing.Size(24, 22);
            this.BtnPremierContact.TabIndex = 40;
            this.BtnPremierContact.TabStop = false;
            this.BtnPremierContact.Text = "...";
            this.BtnPremierContact.UseVisualStyleBackColor = true;
            this.BtnPremierContact.Click += new System.EventHandler(this.BtnPremierContact_Click);
            // 
            // BtnAddLog
            // 
            this.BtnAddLog.Location = new System.Drawing.Point(25, 339);
            this.BtnAddLog.Name = "BtnAddLog";
            this.BtnAddLog.Size = new System.Drawing.Size(132, 23);
            this.BtnAddLog.TabIndex = 36;
            this.BtnAddLog.TabStop = false;
            this.BtnAddLog.Text = "Ajouter une annotation";
            this.BtnAddLog.UseVisualStyleBackColor = true;
            this.BtnAddLog.Click += new System.EventHandler(this.BtnAddLog_Click);
            // 
            // DgvLog
            // 
            this.DgvLog.AllowUserToAddRows = false;
            this.DgvLog.AllowUserToDeleteRows = false;
            this.DgvLog.AllowUserToResizeColumns = false;
            this.DgvLog.AllowUserToResizeRows = false;
            this.DgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvLog.Location = new System.Drawing.Point(25, 368);
            this.DgvLog.Name = "DgvLog";
            this.DgvLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLog.ShowCellErrors = false;
            this.DgvLog.ShowCellToolTips = false;
            this.DgvLog.ShowEditingIcon = false;
            this.DgvLog.ShowRowErrors = false;
            this.DgvLog.Size = new System.Drawing.Size(660, 130);
            this.DgvLog.TabIndex = 34;
            this.DgvLog.TabStop = false;
            // 
            // LblDatePremierContact
            // 
            this.LblDatePremierContact.AutoSize = true;
            this.LblDatePremierContact.Location = new System.Drawing.Point(375, 266);
            this.LblDatePremierContact.Name = "LblDatePremierContact";
            this.LblDatePremierContact.Size = new System.Drawing.Size(90, 13);
            this.LblDatePremierContact.TabIndex = 35;
            this.LblDatePremierContact.Text = "Prise de contact :";
            // 
            // LblDateAbandon
            // 
            this.LblDateAbandon.AutoSize = true;
            this.LblDateAbandon.Location = new System.Drawing.Point(409, 312);
            this.LblDateAbandon.Name = "LblDateAbandon";
            this.LblDateAbandon.Size = new System.Drawing.Size(56, 13);
            this.LblDateAbandon.TabIndex = 38;
            this.LblDateAbandon.Text = "Abandon :";
            // 
            // LblDateConversion
            // 
            this.LblDateConversion.AutoSize = true;
            this.LblDateConversion.Location = new System.Drawing.Point(399, 289);
            this.LblDateConversion.Name = "LblDateConversion";
            this.LblDateConversion.Size = new System.Drawing.Size(66, 13);
            this.LblDateConversion.TabIndex = 37;
            this.LblDateConversion.Text = "Conversion :";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(617, 504);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 36;
            this.BtnSave.TabStop = false;
            this.BtnSave.Text = "Enregistrer";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(537, 504);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 37;
            this.BtnCancel.TabStop = false;
            this.BtnCancel.Text = "Annuler";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Location = new System.Drawing.Point(617, 504);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 38;
            this.BtnClose.TabStop = false;
            this.BtnClose.Text = "Fermer";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Visible = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ProspectEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(722, 542);
            this.Controls.Add(this.BtnAddLog);
            this.Controls.Add(this.TxtAbandon);
            this.Controls.Add(this.DgvLog);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.TxtConversion);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.TxtPremierContact);
            this.Controls.Add(this.BtnAbandon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnConversion);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnPremierContact);
            this.Controls.Add(this.TxtFax);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LblDatePremierContact);
            this.Controls.Add(this.LblDateAbandon);
            this.Controls.Add(this.TxtWeb);
            this.Controls.Add(this.LblDateConversion);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.CbxCategorie);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblCategorie);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblNom);
            this.Controls.Add(this.TxtGsm);
            this.Controls.Add(this.TxtNbEmployes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblNbEmployes);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.TxtAdresse);
            this.Controls.Add(this.LblPays);
            this.Controls.Add(this.LblAdresse);
            this.Controls.Add(this.LblCommentaires);
            this.Controls.Add(this.TxtComplement);
            this.Controls.Add(this.CbxPays);
            this.Controls.Add(this.TxtCodePostal);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.LblCodePostal);
            this.Controls.Add(this.LblVille);
            this.Controls.Add(this.TxtVille);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProspectEditForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fiche prospect";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProspectEditForm_FormClosed);
            this.Load += new System.EventHandler(this.ProspectEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Label LblNbEmployes;
        private System.Windows.Forms.TextBox TxtNbEmployes;
        private System.Windows.Forms.Label LblCommentaires;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label LblPays;
        private System.Windows.Forms.ComboBox CbxPays;
        private System.Windows.Forms.Label LblVille;
        private System.Windows.Forms.TextBox TxtVille;
        private System.Windows.Forms.Label LblCodePostal;
        private System.Windows.Forms.TextBox TxtCodePostal;
        private System.Windows.Forms.TextBox TxtComplement;
        private System.Windows.Forms.Label LblAdresse;
        private System.Windows.Forms.TextBox TxtAdresse;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Label LblCategorie;
        private System.Windows.Forms.ComboBox CbxCategorie;
        private System.Windows.Forms.DataGridView DgvLog;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtWeb;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtGsm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtFax;
        private System.Windows.Forms.Button BtnAddLog;
        private System.Windows.Forms.Label LblDateAbandon;
        private System.Windows.Forms.Label LblDateConversion;
        private System.Windows.Forms.Label LblDatePremierContact;
        private System.Windows.Forms.Button BtnPremierContact;
        private System.Windows.Forms.TextBox TxtAbandon;
        private System.Windows.Forms.TextBox TxtConversion;
        private System.Windows.Forms.TextBox TxtPremierContact;
        private System.Windows.Forms.Button BtnAbandon;
        private System.Windows.Forms.Button BtnConversion;
    }
}