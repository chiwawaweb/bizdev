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
            this.ChkClientPro = new System.Windows.Forms.CheckBox();
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
            this.CbxPays.Location = new System.Drawing.Point(40, 466);
            this.CbxPays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbxPays.Name = "CbxPays";
            this.CbxPays.Size = new System.Drawing.Size(436, 28);
            this.CbxPays.TabIndex = 8;
            // 
            // TxtNom
            // 
            this.TxtNom.BackColor = System.Drawing.Color.Beige;
            this.TxtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorProvider.SetIconAlignment(this.TxtNom, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.TxtNom.Location = new System.Drawing.Point(40, 60);
            this.TxtNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(436, 26);
            this.TxtNom.TabIndex = 0;
            // 
            // CbxCategorie
            // 
            this.CbxCategorie.BackColor = System.Drawing.Color.Beige;
            this.CbxCategorie.FormattingEnabled = true;
            this.ErrorProvider.SetIconAlignment(this.CbxCategorie, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.CbxCategorie.Location = new System.Drawing.Point(41, 130);
            this.CbxCategorie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbxCategorie.Name = "CbxCategorie";
            this.CbxCategorie.Size = new System.Drawing.Size(436, 28);
            this.CbxCategorie.TabIndex = 1;
            // 
            // LblNbEmployes
            // 
            this.LblNbEmployes.AutoSize = true;
            this.LblNbEmployes.Location = new System.Drawing.Point(36, 180);
            this.LblNbEmployes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNbEmployes.Name = "LblNbEmployes";
            this.LblNbEmployes.Size = new System.Drawing.Size(78, 20);
            this.LblNbEmployes.TabIndex = 12;
            this.LblNbEmployes.Text = "Employés";
            // 
            // TxtNbEmployes
            // 
            this.TxtNbEmployes.BackColor = System.Drawing.Color.Beige;
            this.TxtNbEmployes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNbEmployes.Location = new System.Drawing.Point(40, 205);
            this.TxtNbEmployes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNbEmployes.MaxLength = 5;
            this.TxtNbEmployes.Name = "TxtNbEmployes";
            this.TxtNbEmployes.Size = new System.Drawing.Size(67, 26);
            this.TxtNbEmployes.TabIndex = 2;
            // 
            // LblCommentaires
            // 
            this.LblCommentaires.AutoSize = true;
            this.LblCommentaires.Location = new System.Drawing.Point(562, 263);
            this.LblCommentaires.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCommentaires.Name = "LblCommentaires";
            this.LblCommentaires.Size = new System.Drawing.Size(112, 20);
            this.LblCommentaires.TabIndex = 29;
            this.LblCommentaires.Text = "Commentaires";
            // 
            // TxtNotes
            // 
            this.TxtNotes.AcceptsReturn = true;
            this.TxtNotes.BackColor = System.Drawing.Color.Beige;
            this.TxtNotes.Location = new System.Drawing.Point(564, 288);
            this.TxtNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNotes.MaxLength = 20000;
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(466, 104);
            this.TxtNotes.TabIndex = 14;
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnEdit.Image = global::BizDev.Properties.Resources.icon_cadenas_16;
            this.BtnEdit.Location = new System.Drawing.Point(876, 775);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(39, 40);
            this.BtnEdit.TabIndex = 39;
            this.BtnEdit.TabStop = false;
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Visible = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(878, 35);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Fax";
            // 
            // TxtFax
            // 
            this.TxtFax.BackColor = System.Drawing.Color.Beige;
            this.TxtFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFax.Location = new System.Drawing.Point(882, 60);
            this.TxtFax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFax.Name = "TxtFax";
            this.TxtFax.Size = new System.Drawing.Size(148, 26);
            this.TxtFax.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(562, 188);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Web";
            // 
            // TxtWeb
            // 
            this.TxtWeb.BackColor = System.Drawing.Color.Beige;
            this.TxtWeb.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TxtWeb.Location = new System.Drawing.Point(564, 212);
            this.TxtWeb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtWeb.Name = "TxtWeb";
            this.TxtWeb.Size = new System.Drawing.Size(466, 26);
            this.TxtWeb.TabIndex = 13;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(560, 108);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(48, 20);
            this.LblEmail.TabIndex = 37;
            this.LblEmail.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.Beige;
            this.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TxtEmail.Location = new System.Drawing.Point(564, 132);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(466, 26);
            this.TxtEmail.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(718, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Portable";
            // 
            // TxtGsm
            // 
            this.TxtGsm.BackColor = System.Drawing.Color.Beige;
            this.TxtGsm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtGsm.Location = new System.Drawing.Point(723, 60);
            this.TxtGsm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtGsm.Name = "TxtGsm";
            this.TxtGsm.Size = new System.Drawing.Size(148, 26);
            this.TxtGsm.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(560, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Téléphone";
            // 
            // TxtTel
            // 
            this.TxtTel.BackColor = System.Drawing.Color.Beige;
            this.TxtTel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTel.Location = new System.Drawing.Point(564, 60);
            this.TxtTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(148, 26);
            this.TxtTel.TabIndex = 9;
            // 
            // LblPays
            // 
            this.LblPays.AutoSize = true;
            this.LblPays.Location = new System.Drawing.Point(36, 442);
            this.LblPays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPays.Name = "LblPays";
            this.LblPays.Size = new System.Drawing.Size(43, 20);
            this.LblPays.TabIndex = 26;
            this.LblPays.Text = "Pays";
            // 
            // LblVille
            // 
            this.LblVille.AutoSize = true;
            this.LblVille.Location = new System.Drawing.Point(135, 374);
            this.LblVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblVille.Name = "LblVille";
            this.LblVille.Size = new System.Drawing.Size(38, 20);
            this.LblVille.TabIndex = 24;
            this.LblVille.Text = "Ville";
            // 
            // TxtVille
            // 
            this.TxtVille.BackColor = System.Drawing.Color.Beige;
            this.TxtVille.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtVille.Location = new System.Drawing.Point(140, 398);
            this.TxtVille.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtVille.Name = "TxtVille";
            this.TxtVille.Size = new System.Drawing.Size(337, 26);
            this.TxtVille.TabIndex = 7;
            // 
            // LblCodePostal
            // 
            this.LblCodePostal.AutoSize = true;
            this.LblCodePostal.Location = new System.Drawing.Point(36, 374);
            this.LblCodePostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCodePostal.Name = "LblCodePostal";
            this.LblCodePostal.Size = new System.Drawing.Size(94, 20);
            this.LblCodePostal.TabIndex = 23;
            this.LblCodePostal.Text = "Code postal";
            // 
            // TxtCodePostal
            // 
            this.TxtCodePostal.BackColor = System.Drawing.Color.Beige;
            this.TxtCodePostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCodePostal.Location = new System.Drawing.Point(40, 398);
            this.TxtCodePostal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCodePostal.Name = "TxtCodePostal";
            this.TxtCodePostal.Size = new System.Drawing.Size(88, 26);
            this.TxtCodePostal.TabIndex = 6;
            // 
            // TxtComplement
            // 
            this.TxtComplement.BackColor = System.Drawing.Color.Beige;
            this.TxtComplement.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtComplement.Location = new System.Drawing.Point(40, 328);
            this.TxtComplement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtComplement.Name = "TxtComplement";
            this.TxtComplement.Size = new System.Drawing.Size(436, 26);
            this.TxtComplement.TabIndex = 5;
            // 
            // LblAdresse
            // 
            this.LblAdresse.AutoSize = true;
            this.LblAdresse.Location = new System.Drawing.Point(36, 263);
            this.LblAdresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAdresse.Name = "LblAdresse";
            this.LblAdresse.Size = new System.Drawing.Size(68, 20);
            this.LblAdresse.TabIndex = 22;
            this.LblAdresse.Text = "Adresse";
            // 
            // TxtAdresse
            // 
            this.TxtAdresse.BackColor = System.Drawing.Color.Beige;
            this.TxtAdresse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtAdresse.Location = new System.Drawing.Point(40, 288);
            this.TxtAdresse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAdresse.Name = "TxtAdresse";
            this.TxtAdresse.Size = new System.Drawing.Size(436, 26);
            this.TxtAdresse.TabIndex = 4;
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(36, 35);
            this.LblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(42, 20);
            this.LblNom.TabIndex = 20;
            this.LblNom.Text = "Nom";
            // 
            // LblCategorie
            // 
            this.LblCategorie.AutoSize = true;
            this.LblCategorie.Location = new System.Drawing.Point(36, 108);
            this.LblCategorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategorie.Name = "LblCategorie";
            this.LblCategorie.Size = new System.Drawing.Size(78, 20);
            this.LblCategorie.TabIndex = 10;
            this.LblCategorie.Text = "Catégorie";
            // 
            // TxtAbandon
            // 
            this.TxtAbandon.BackColor = System.Drawing.Color.LightCoral;
            this.TxtAbandon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAbandon.Location = new System.Drawing.Point(702, 475);
            this.TxtAbandon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAbandon.Name = "TxtAbandon";
            this.TxtAbandon.ReadOnly = true;
            this.TxtAbandon.Size = new System.Drawing.Size(120, 26);
            this.TxtAbandon.TabIndex = 45;
            this.TxtAbandon.TabStop = false;
            this.TxtAbandon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtConversion
            // 
            this.TxtConversion.BackColor = System.Drawing.Color.Gold;
            this.TxtConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConversion.Location = new System.Drawing.Point(702, 440);
            this.TxtConversion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtConversion.Name = "TxtConversion";
            this.TxtConversion.ReadOnly = true;
            this.TxtConversion.Size = new System.Drawing.Size(120, 26);
            this.TxtConversion.TabIndex = 44;
            this.TxtConversion.TabStop = false;
            this.TxtConversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPremierContact
            // 
            this.TxtPremierContact.BackColor = System.Drawing.Color.PaleGreen;
            this.TxtPremierContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPremierContact.Location = new System.Drawing.Point(702, 405);
            this.TxtPremierContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPremierContact.Name = "TxtPremierContact";
            this.TxtPremierContact.ReadOnly = true;
            this.TxtPremierContact.Size = new System.Drawing.Size(120, 26);
            this.TxtPremierContact.TabIndex = 43;
            this.TxtPremierContact.TabStop = false;
            this.TxtPremierContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnAbandon
            // 
            this.BtnAbandon.Location = new System.Drawing.Point(826, 474);
            this.BtnAbandon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAbandon.Name = "BtnAbandon";
            this.BtnAbandon.Size = new System.Drawing.Size(36, 34);
            this.BtnAbandon.TabIndex = 42;
            this.BtnAbandon.TabStop = false;
            this.BtnAbandon.Text = "...";
            this.BtnAbandon.UseVisualStyleBackColor = true;
            this.BtnAbandon.Click += new System.EventHandler(this.BtnAbandon_Click);
            // 
            // BtnConversion
            // 
            this.BtnConversion.Location = new System.Drawing.Point(826, 438);
            this.BtnConversion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnConversion.Name = "BtnConversion";
            this.BtnConversion.Size = new System.Drawing.Size(36, 34);
            this.BtnConversion.TabIndex = 41;
            this.BtnConversion.TabStop = false;
            this.BtnConversion.Text = "...";
            this.BtnConversion.UseVisualStyleBackColor = true;
            this.BtnConversion.Click += new System.EventHandler(this.BtnConversion_Click);
            // 
            // BtnPremierContact
            // 
            this.BtnPremierContact.Location = new System.Drawing.Point(826, 403);
            this.BtnPremierContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPremierContact.Name = "BtnPremierContact";
            this.BtnPremierContact.Size = new System.Drawing.Size(36, 34);
            this.BtnPremierContact.TabIndex = 40;
            this.BtnPremierContact.TabStop = false;
            this.BtnPremierContact.Text = "...";
            this.BtnPremierContact.UseVisualStyleBackColor = true;
            this.BtnPremierContact.Click += new System.EventHandler(this.BtnPremierContact_Click);
            // 
            // BtnAddLog
            // 
            this.BtnAddLog.Location = new System.Drawing.Point(40, 522);
            this.BtnAddLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddLog.Name = "BtnAddLog";
            this.BtnAddLog.Size = new System.Drawing.Size(198, 35);
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
            this.DgvLog.Location = new System.Drawing.Point(40, 566);
            this.DgvLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvLog.Name = "DgvLog";
            this.DgvLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLog.ShowCellErrors = false;
            this.DgvLog.ShowCellToolTips = false;
            this.DgvLog.ShowEditingIcon = false;
            this.DgvLog.ShowRowErrors = false;
            this.DgvLog.Size = new System.Drawing.Size(992, 200);
            this.DgvLog.TabIndex = 34;
            this.DgvLog.TabStop = false;
            // 
            // LblDatePremierContact
            // 
            this.LblDatePremierContact.AutoSize = true;
            this.LblDatePremierContact.Location = new System.Drawing.Point(562, 409);
            this.LblDatePremierContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDatePremierContact.Name = "LblDatePremierContact";
            this.LblDatePremierContact.Size = new System.Drawing.Size(131, 20);
            this.LblDatePremierContact.TabIndex = 35;
            this.LblDatePremierContact.Text = "Prise de contact :";
            // 
            // LblDateAbandon
            // 
            this.LblDateAbandon.AutoSize = true;
            this.LblDateAbandon.Location = new System.Drawing.Point(614, 480);
            this.LblDateAbandon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDateAbandon.Name = "LblDateAbandon";
            this.LblDateAbandon.Size = new System.Drawing.Size(82, 20);
            this.LblDateAbandon.TabIndex = 38;
            this.LblDateAbandon.Text = "Abandon :";
            // 
            // LblDateConversion
            // 
            this.LblDateConversion.AutoSize = true;
            this.LblDateConversion.Location = new System.Drawing.Point(598, 445);
            this.LblDateConversion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDateConversion.Name = "LblDateConversion";
            this.LblDateConversion.Size = new System.Drawing.Size(96, 20);
            this.LblDateConversion.TabIndex = 37;
            this.LblDateConversion.Text = "Conversion :";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(920, 775);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(112, 40);
            this.BtnSave.TabIndex = 36;
            this.BtnSave.TabStop = false;
            this.BtnSave.Text = "Enregistrer";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(798, 775);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(112, 40);
            this.BtnCancel.TabIndex = 37;
            this.BtnCancel.TabStop = false;
            this.BtnCancel.Text = "Annuler";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Location = new System.Drawing.Point(920, 775);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(112, 40);
            this.BtnClose.TabIndex = 38;
            this.BtnClose.TabStop = false;
            this.BtnClose.Text = "Fermer";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Visible = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ChkClientPro
            // 
            this.ChkClientPro.AutoSize = true;
            this.ChkClientPro.Location = new System.Drawing.Point(224, 208);
            this.ChkClientPro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkClientPro.Name = "ChkClientPro";
            this.ChkClientPro.Size = new System.Drawing.Size(253, 24);
            this.ChkClientPro.TabIndex = 3;
            this.ChkClientPro.Text = "Client en compte professionnel";
            this.ChkClientPro.UseVisualStyleBackColor = true;
            // 
            // ProspectEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(1057, 829);
            this.Controls.Add(this.ChkClientPro);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProspectEditForm";
            this.ShowIcon = false;
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
        private System.Windows.Forms.CheckBox ChkClientPro;
    }
}