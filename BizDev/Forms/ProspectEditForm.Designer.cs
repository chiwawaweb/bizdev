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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabCoordonnees = new System.Windows.Forms.TabPage();
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
            this.TabJournal = new System.Windows.Forms.TabPage();
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
            this.BtnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TabCoordonnees.SuspendLayout();
            this.TabJournal.SuspendLayout();
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
            this.CbxPays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxPays.FormattingEnabled = true;
            this.ErrorProvider.SetIconAlignment(this.CbxPays, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.CbxPays.Location = new System.Drawing.Point(33, 449);
            this.CbxPays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbxPays.Name = "CbxPays";
            this.CbxPays.Size = new System.Drawing.Size(436, 28);
            this.CbxPays.TabIndex = 7;
            // 
            // TxtNom
            // 
            this.TxtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorProvider.SetIconAlignment(this.TxtNom, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.TxtNom.Location = new System.Drawing.Point(33, 49);
            this.TxtNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(436, 26);
            this.TxtNom.TabIndex = 2;
            // 
            // CbxCategorie
            // 
            this.CbxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCategorie.FormattingEnabled = true;
            this.ErrorProvider.SetIconAlignment(this.CbxCategorie, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.CbxCategorie.Location = new System.Drawing.Point(33, 122);
            this.CbxCategorie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbxCategorie.Name = "CbxCategorie";
            this.CbxCategorie.Size = new System.Drawing.Size(436, 28);
            this.CbxCategorie.TabIndex = 0;
            this.CbxCategorie.TabStop = false;
            // 
            // LblNbEmployes
            // 
            this.LblNbEmployes.AutoSize = true;
            this.LblNbEmployes.Location = new System.Drawing.Point(28, 169);
            this.LblNbEmployes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNbEmployes.Name = "LblNbEmployes";
            this.LblNbEmployes.Size = new System.Drawing.Size(78, 20);
            this.LblNbEmployes.TabIndex = 12;
            this.LblNbEmployes.Text = "Employés";
            // 
            // TxtNbEmployes
            // 
            this.TxtNbEmployes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNbEmployes.Location = new System.Drawing.Point(33, 194);
            this.TxtNbEmployes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNbEmployes.MaxLength = 5;
            this.TxtNbEmployes.Name = "TxtNbEmployes";
            this.TxtNbEmployes.Size = new System.Drawing.Size(67, 26);
            this.TxtNbEmployes.TabIndex = 1;
            // 
            // LblCommentaires
            // 
            this.LblCommentaires.AutoSize = true;
            this.LblCommentaires.Location = new System.Drawing.Point(555, 246);
            this.LblCommentaires.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCommentaires.Name = "LblCommentaires";
            this.LblCommentaires.Size = new System.Drawing.Size(112, 20);
            this.LblCommentaires.TabIndex = 29;
            this.LblCommentaires.Text = "Commentaires";
            // 
            // TxtNotes
            // 
            this.TxtNotes.AcceptsReturn = true;
            this.TxtNotes.Location = new System.Drawing.Point(556, 271);
            this.TxtNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNotes.MaxLength = 20000;
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(469, 209);
            this.TxtNotes.TabIndex = 13;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabCoordonnees);
            this.TabControl.Controls.Add(this.TabJournal);
            this.TabControl.Location = new System.Drawing.Point(18, 18);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1058, 578);
            this.TabControl.TabIndex = 0;
            this.TabControl.TabStop = false;
            // 
            // TabCoordonnees
            // 
            this.TabCoordonnees.Controls.Add(this.label9);
            this.TabCoordonnees.Controls.Add(this.TxtFax);
            this.TabCoordonnees.Controls.Add(this.label11);
            this.TabCoordonnees.Controls.Add(this.TxtWeb);
            this.TabCoordonnees.Controls.Add(this.LblEmail);
            this.TabCoordonnees.Controls.Add(this.TxtEmail);
            this.TabCoordonnees.Controls.Add(this.label8);
            this.TabCoordonnees.Controls.Add(this.TxtGsm);
            this.TabCoordonnees.Controls.Add(this.label7);
            this.TabCoordonnees.Controls.Add(this.TxtTel);
            this.TabCoordonnees.Controls.Add(this.LblPays);
            this.TabCoordonnees.Controls.Add(this.LblCommentaires);
            this.TabCoordonnees.Controls.Add(this.CbxPays);
            this.TabCoordonnees.Controls.Add(this.TxtNotes);
            this.TabCoordonnees.Controls.Add(this.LblVille);
            this.TabCoordonnees.Controls.Add(this.TxtVille);
            this.TabCoordonnees.Controls.Add(this.LblCodePostal);
            this.TabCoordonnees.Controls.Add(this.TxtCodePostal);
            this.TabCoordonnees.Controls.Add(this.TxtComplement);
            this.TabCoordonnees.Controls.Add(this.LblAdresse);
            this.TabCoordonnees.Controls.Add(this.TxtAdresse);
            this.TabCoordonnees.Controls.Add(this.LblNbEmployes);
            this.TabCoordonnees.Controls.Add(this.TxtNbEmployes);
            this.TabCoordonnees.Controls.Add(this.LblNom);
            this.TabCoordonnees.Controls.Add(this.TxtNom);
            this.TabCoordonnees.Controls.Add(this.LblCategorie);
            this.TabCoordonnees.Controls.Add(this.CbxCategorie);
            this.TabCoordonnees.Location = new System.Drawing.Point(4, 29);
            this.TabCoordonnees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabCoordonnees.Name = "TabCoordonnees";
            this.TabCoordonnees.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabCoordonnees.Size = new System.Drawing.Size(1050, 545);
            this.TabCoordonnees.TabIndex = 0;
            this.TabCoordonnees.Text = "Coordonnées";
            this.TabCoordonnees.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(870, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Fax";
            // 
            // TxtFax
            // 
            this.TxtFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFax.Location = new System.Drawing.Point(874, 49);
            this.TxtFax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFax.Name = "TxtFax";
            this.TxtFax.Size = new System.Drawing.Size(148, 26);
            this.TxtFax.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(555, 177);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Web";
            // 
            // TxtWeb
            // 
            this.TxtWeb.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TxtWeb.Location = new System.Drawing.Point(556, 202);
            this.TxtWeb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtWeb.Name = "TxtWeb";
            this.TxtWeb.Size = new System.Drawing.Size(462, 26);
            this.TxtWeb.TabIndex = 12;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(552, 97);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(48, 20);
            this.LblEmail.TabIndex = 37;
            this.LblEmail.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TxtEmail.Location = new System.Drawing.Point(556, 122);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(464, 26);
            this.TxtEmail.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(711, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Portable";
            // 
            // TxtGsm
            // 
            this.TxtGsm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtGsm.Location = new System.Drawing.Point(716, 49);
            this.TxtGsm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtGsm.Name = "TxtGsm";
            this.TxtGsm.Size = new System.Drawing.Size(148, 26);
            this.TxtGsm.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(552, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Téléphone";
            // 
            // TxtTel
            // 
            this.TxtTel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTel.Location = new System.Drawing.Point(556, 49);
            this.TxtTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(148, 26);
            this.TxtTel.TabIndex = 8;
            // 
            // LblPays
            // 
            this.LblPays.AutoSize = true;
            this.LblPays.Location = new System.Drawing.Point(28, 425);
            this.LblPays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPays.Name = "LblPays";
            this.LblPays.Size = new System.Drawing.Size(43, 20);
            this.LblPays.TabIndex = 26;
            this.LblPays.Text = "Pays";
            // 
            // LblVille
            // 
            this.LblVille.AutoSize = true;
            this.LblVille.Location = new System.Drawing.Point(128, 357);
            this.LblVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblVille.Name = "LblVille";
            this.LblVille.Size = new System.Drawing.Size(38, 20);
            this.LblVille.TabIndex = 24;
            this.LblVille.Text = "Ville";
            // 
            // TxtVille
            // 
            this.TxtVille.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtVille.Location = new System.Drawing.Point(132, 382);
            this.TxtVille.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtVille.Name = "TxtVille";
            this.TxtVille.Size = new System.Drawing.Size(337, 26);
            this.TxtVille.TabIndex = 6;
            // 
            // LblCodePostal
            // 
            this.LblCodePostal.AutoSize = true;
            this.LblCodePostal.Location = new System.Drawing.Point(28, 357);
            this.LblCodePostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCodePostal.Name = "LblCodePostal";
            this.LblCodePostal.Size = new System.Drawing.Size(94, 20);
            this.LblCodePostal.TabIndex = 23;
            this.LblCodePostal.Text = "Code postal";
            // 
            // TxtCodePostal
            // 
            this.TxtCodePostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCodePostal.Location = new System.Drawing.Point(33, 382);
            this.TxtCodePostal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCodePostal.Name = "TxtCodePostal";
            this.TxtCodePostal.Size = new System.Drawing.Size(88, 26);
            this.TxtCodePostal.TabIndex = 5;
            // 
            // TxtComplement
            // 
            this.TxtComplement.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtComplement.Location = new System.Drawing.Point(33, 311);
            this.TxtComplement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtComplement.Name = "TxtComplement";
            this.TxtComplement.Size = new System.Drawing.Size(436, 26);
            this.TxtComplement.TabIndex = 4;
            // 
            // LblAdresse
            // 
            this.LblAdresse.AutoSize = true;
            this.LblAdresse.Location = new System.Drawing.Point(28, 246);
            this.LblAdresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAdresse.Name = "LblAdresse";
            this.LblAdresse.Size = new System.Drawing.Size(68, 20);
            this.LblAdresse.TabIndex = 22;
            this.LblAdresse.Text = "Adresse";
            // 
            // TxtAdresse
            // 
            this.TxtAdresse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtAdresse.Location = new System.Drawing.Point(33, 271);
            this.TxtAdresse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAdresse.Name = "TxtAdresse";
            this.TxtAdresse.Size = new System.Drawing.Size(436, 26);
            this.TxtAdresse.TabIndex = 3;
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(28, 25);
            this.LblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(42, 20);
            this.LblNom.TabIndex = 20;
            this.LblNom.Text = "Nom";
            // 
            // LblCategorie
            // 
            this.LblCategorie.AutoSize = true;
            this.LblCategorie.Location = new System.Drawing.Point(28, 97);
            this.LblCategorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategorie.Name = "LblCategorie";
            this.LblCategorie.Size = new System.Drawing.Size(78, 20);
            this.LblCategorie.TabIndex = 10;
            this.LblCategorie.Text = "Catégorie";
            // 
            // TabJournal
            // 
            this.TabJournal.Controls.Add(this.TxtAbandon);
            this.TabJournal.Controls.Add(this.TxtConversion);
            this.TabJournal.Controls.Add(this.TxtPremierContact);
            this.TabJournal.Controls.Add(this.BtnAbandon);
            this.TabJournal.Controls.Add(this.BtnConversion);
            this.TabJournal.Controls.Add(this.BtnPremierContact);
            this.TabJournal.Controls.Add(this.BtnAddLog);
            this.TabJournal.Controls.Add(this.DgvLog);
            this.TabJournal.Controls.Add(this.LblDatePremierContact);
            this.TabJournal.Controls.Add(this.LblDateAbandon);
            this.TabJournal.Controls.Add(this.LblDateConversion);
            this.TabJournal.Location = new System.Drawing.Point(4, 29);
            this.TabJournal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabJournal.Name = "TabJournal";
            this.TabJournal.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabJournal.Size = new System.Drawing.Size(1050, 545);
            this.TabJournal.TabIndex = 1;
            this.TabJournal.Text = "Historique";
            this.TabJournal.UseVisualStyleBackColor = true;
            // 
            // TxtAbandon
            // 
            this.TxtAbandon.BackColor = System.Drawing.Color.LightCoral;
            this.TxtAbandon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAbandon.Location = new System.Drawing.Point(862, 22);
            this.TxtAbandon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAbandon.Name = "TxtAbandon";
            this.TxtAbandon.ReadOnly = true;
            this.TxtAbandon.Size = new System.Drawing.Size(120, 26);
            this.TxtAbandon.TabIndex = 45;
            this.TxtAbandon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtConversion
            // 
            this.TxtConversion.BackColor = System.Drawing.Color.Gold;
            this.TxtConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConversion.Location = new System.Drawing.Point(514, 20);
            this.TxtConversion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtConversion.Name = "TxtConversion";
            this.TxtConversion.ReadOnly = true;
            this.TxtConversion.Size = new System.Drawing.Size(120, 26);
            this.TxtConversion.TabIndex = 44;
            this.TxtConversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPremierContact
            // 
            this.TxtPremierContact.BackColor = System.Drawing.Color.PaleGreen;
            this.TxtPremierContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPremierContact.Location = new System.Drawing.Point(160, 20);
            this.TxtPremierContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPremierContact.Name = "TxtPremierContact";
            this.TxtPremierContact.ReadOnly = true;
            this.TxtPremierContact.Size = new System.Drawing.Size(120, 26);
            this.TxtPremierContact.TabIndex = 43;
            this.TxtPremierContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnAbandon
            // 
            this.BtnAbandon.Location = new System.Drawing.Point(987, 18);
            this.BtnAbandon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAbandon.Name = "BtnAbandon";
            this.BtnAbandon.Size = new System.Drawing.Size(36, 34);
            this.BtnAbandon.TabIndex = 42;
            this.BtnAbandon.Text = "...";
            this.BtnAbandon.UseVisualStyleBackColor = true;
            // 
            // BtnConversion
            // 
            this.BtnConversion.Location = new System.Drawing.Point(639, 18);
            this.BtnConversion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnConversion.Name = "BtnConversion";
            this.BtnConversion.Size = new System.Drawing.Size(36, 34);
            this.BtnConversion.TabIndex = 41;
            this.BtnConversion.Text = "...";
            this.BtnConversion.UseVisualStyleBackColor = true;
            // 
            // BtnPremierContact
            // 
            this.BtnPremierContact.Location = new System.Drawing.Point(285, 18);
            this.BtnPremierContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPremierContact.Name = "BtnPremierContact";
            this.BtnPremierContact.Size = new System.Drawing.Size(36, 34);
            this.BtnPremierContact.TabIndex = 40;
            this.BtnPremierContact.Text = "...";
            this.BtnPremierContact.UseVisualStyleBackColor = true;
            // 
            // BtnAddLog
            // 
            this.BtnAddLog.Location = new System.Drawing.Point(22, 77);
            this.BtnAddLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddLog.Name = "BtnAddLog";
            this.BtnAddLog.Size = new System.Drawing.Size(198, 35);
            this.BtnAddLog.TabIndex = 36;
            this.BtnAddLog.TabStop = false;
            this.BtnAddLog.Text = "Ajouter un suivi";
            this.BtnAddLog.UseVisualStyleBackColor = true;
            // 
            // DgvLog
            // 
            this.DgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLog.Location = new System.Drawing.Point(22, 122);
            this.DgvLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvLog.Name = "DgvLog";
            this.DgvLog.Size = new System.Drawing.Size(1000, 408);
            this.DgvLog.TabIndex = 34;
            this.DgvLog.TabStop = false;
            // 
            // LblDatePremierContact
            // 
            this.LblDatePremierContact.AutoSize = true;
            this.LblDatePremierContact.Location = new System.Drawing.Point(21, 25);
            this.LblDatePremierContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDatePremierContact.Name = "LblDatePremierContact";
            this.LblDatePremierContact.Size = new System.Drawing.Size(131, 20);
            this.LblDatePremierContact.TabIndex = 35;
            this.LblDatePremierContact.Text = "Prise de contact :";
            // 
            // LblDateAbandon
            // 
            this.LblDateAbandon.AutoSize = true;
            this.LblDateAbandon.Location = new System.Drawing.Point(774, 26);
            this.LblDateAbandon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDateAbandon.Name = "LblDateAbandon";
            this.LblDateAbandon.Size = new System.Drawing.Size(82, 20);
            this.LblDateAbandon.TabIndex = 38;
            this.LblDateAbandon.Text = "Abandon :";
            // 
            // LblDateConversion
            // 
            this.LblDateConversion.AutoSize = true;
            this.LblDateConversion.Location = new System.Drawing.Point(411, 25);
            this.LblDateConversion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDateConversion.Name = "LblDateConversion";
            this.LblDateConversion.Size = new System.Drawing.Size(96, 20);
            this.LblDateConversion.TabIndex = 37;
            this.LblDateConversion.Text = "Conversion :";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(934, 606);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(112, 35);
            this.BtnSave.TabIndex = 36;
            this.BtnSave.TabStop = false;
            this.BtnSave.Text = "Enregistrer";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(813, 606);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(112, 35);
            this.BtnCancel.TabIndex = 37;
            this.BtnCancel.TabStop = false;
            this.BtnCancel.Text = "Annuler";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(934, 606);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(112, 35);
            this.BtnClose.TabIndex = 38;
            this.BtnClose.TabStop = false;
            this.BtnClose.Text = "Fermer";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Visible = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(896, 606);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(34, 35);
            this.BtnEdit.TabIndex = 39;
            this.BtnEdit.TabStop = false;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Visible = false;
            // 
            // ProspectEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 671);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProspectEditForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fiche prospect";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProspectEditForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.TabCoordonnees.ResumeLayout(false);
            this.TabCoordonnees.PerformLayout();
            this.TabJournal.ResumeLayout(false);
            this.TabJournal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Label LblNbEmployes;
        private System.Windows.Forms.TextBox TxtNbEmployes;
        private System.Windows.Forms.Label LblCommentaires;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabCoordonnees;
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
        private System.Windows.Forms.TabPage TabJournal;
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