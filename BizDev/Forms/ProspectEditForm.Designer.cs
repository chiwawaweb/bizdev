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
            this.LblNbEmployes = new System.Windows.Forms.Label();
            this.TxtNbEmployes = new System.Windows.Forms.TextBox();
            this.LblCommentaires = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabCoordonnees = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtFax = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtWeb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtGsm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTel = new System.Windows.Forms.TextBox();
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
            this.BtnDelCategorie = new System.Windows.Forms.Button();
            this.LblCategorie = new System.Windows.Forms.Label();
            this.BtnAddCategorie = new System.Windows.Forms.Button();
            this.LsbCategories = new System.Windows.Forms.ListBox();
            this.CbxCategorie = new System.Windows.Forms.ComboBox();
            this.TabJournal = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAddLog = new System.Windows.Forms.Button();
            this.DgvLog = new System.Windows.Forms.DataGridView();
            this.ChkConverti = new System.Windows.Forms.CheckBox();
            this.DtpPremierContact = new System.Windows.Forms.DateTimePicker();
            this.DtpConverti = new System.Windows.Forms.DateTimePicker();
            this.ChkAbandon = new System.Windows.Forms.CheckBox();
            this.DtpAbandon = new System.Windows.Forms.DateTimePicker();
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
            this.ErrorProvider.ContainerControl = this;
            // 
            // LblNbEmployes
            // 
            this.LblNbEmployes.AutoSize = true;
            this.LblNbEmployes.Location = new System.Drawing.Point(552, 246);
            this.LblNbEmployes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNbEmployes.Name = "LblNbEmployes";
            this.LblNbEmployes.Size = new System.Drawing.Size(78, 20);
            this.LblNbEmployes.TabIndex = 27;
            this.LblNbEmployes.Text = "Employés";
            // 
            // TxtNbEmployes
            // 
            this.TxtNbEmployes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNbEmployes.Location = new System.Drawing.Point(556, 271);
            this.TxtNbEmployes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNbEmployes.MaxLength = 5;
            this.TxtNbEmployes.Name = "TxtNbEmployes";
            this.TxtNbEmployes.Size = new System.Drawing.Size(67, 26);
            this.TxtNbEmployes.TabIndex = 26;
            // 
            // LblCommentaires
            // 
            this.LblCommentaires.AutoSize = true;
            this.LblCommentaires.Location = new System.Drawing.Point(552, 318);
            this.LblCommentaires.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCommentaires.Name = "LblCommentaires";
            this.LblCommentaires.Size = new System.Drawing.Size(112, 20);
            this.LblCommentaires.TabIndex = 29;
            this.LblCommentaires.Text = "Commentaires";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Location = new System.Drawing.Point(556, 343);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.MaxLength = 5;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(469, 136);
            this.textBox1.TabIndex = 28;
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
            this.TabControl.TabIndex = 36;
            // 
            // TabCoordonnees
            // 
            this.TabCoordonnees.Controls.Add(this.label9);
            this.TabCoordonnees.Controls.Add(this.TxtFax);
            this.TabCoordonnees.Controls.Add(this.label11);
            this.TabCoordonnees.Controls.Add(this.TxtWeb);
            this.TabCoordonnees.Controls.Add(this.label10);
            this.TabCoordonnees.Controls.Add(this.TxtEmail);
            this.TabCoordonnees.Controls.Add(this.label8);
            this.TabCoordonnees.Controls.Add(this.TxtGsm);
            this.TabCoordonnees.Controls.Add(this.label7);
            this.TabCoordonnees.Controls.Add(this.TxtTel);
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
            this.TxtFax.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(555, 166);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Web";
            // 
            // TxtWeb
            // 
            this.TxtWeb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtWeb.Location = new System.Drawing.Point(560, 191);
            this.TxtWeb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtWeb.Name = "TxtWeb";
            this.TxtWeb.Size = new System.Drawing.Size(462, 26);
            this.TxtWeb.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(552, 97);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtEmail.Location = new System.Drawing.Point(556, 122);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(464, 26);
            this.TxtEmail.TabIndex = 36;
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
            this.TxtGsm.TabIndex = 32;
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
            this.TxtTel.TabIndex = 30;
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
            // CbxPays
            // 
            this.CbxPays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxPays.FormattingEnabled = true;
            this.CbxPays.Location = new System.Drawing.Point(33, 449);
            this.CbxPays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbxPays.Name = "CbxPays";
            this.CbxPays.Size = new System.Drawing.Size(436, 28);
            this.CbxPays.TabIndex = 25;
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
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(132, 382);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(337, 26);
            this.textBox2.TabIndex = 21;
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
            this.TxtCodePostal.TabIndex = 19;
            // 
            // TxtComplement
            // 
            this.TxtComplement.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtComplement.Location = new System.Drawing.Point(33, 311);
            this.TxtComplement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtComplement.Name = "TxtComplement";
            this.TxtComplement.Size = new System.Drawing.Size(436, 26);
            this.TxtComplement.TabIndex = 18;
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
            this.TxtAdresse.TabIndex = 17;
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(28, 177);
            this.LblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(42, 20);
            this.LblNom.TabIndex = 20;
            this.LblNom.Text = "Nom";
            // 
            // TxtNom
            // 
            this.TxtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNom.Location = new System.Drawing.Point(33, 202);
            this.TxtNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(436, 26);
            this.TxtNom.TabIndex = 16;
            // 
            // BtnDelCategorie
            // 
            this.BtnDelCategorie.Location = new System.Drawing.Point(480, 92);
            this.BtnDelCategorie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDelCategorie.Name = "BtnDelCategorie";
            this.BtnDelCategorie.Size = new System.Drawing.Size(34, 35);
            this.BtnDelCategorie.TabIndex = 11;
            this.BtnDelCategorie.TabStop = false;
            this.BtnDelCategorie.Text = "-";
            this.BtnDelCategorie.UseVisualStyleBackColor = true;
            this.BtnDelCategorie.Click += new System.EventHandler(this.BtnDelCategorie_Click);
            // 
            // LblCategorie
            // 
            this.LblCategorie.AutoSize = true;
            this.LblCategorie.Location = new System.Drawing.Point(28, 25);
            this.LblCategorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCategorie.Name = "LblCategorie";
            this.LblCategorie.Size = new System.Drawing.Size(78, 20);
            this.LblCategorie.TabIndex = 10;
            this.LblCategorie.Text = "Catégorie";
            // 
            // BtnAddCategorie
            // 
            this.BtnAddCategorie.Location = new System.Drawing.Point(480, 48);
            this.BtnAddCategorie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddCategorie.Name = "BtnAddCategorie";
            this.BtnAddCategorie.Size = new System.Drawing.Size(34, 35);
            this.BtnAddCategorie.TabIndex = 9;
            this.BtnAddCategorie.TabStop = false;
            this.BtnAddCategorie.Text = "+";
            this.BtnAddCategorie.UseVisualStyleBackColor = true;
            this.BtnAddCategorie.Click += new System.EventHandler(this.BtnAddCategorie_Click);
            // 
            // LsbCategories
            // 
            this.LsbCategories.BackColor = System.Drawing.SystemColors.Control;
            this.LsbCategories.FormattingEnabled = true;
            this.LsbCategories.ItemHeight = 20;
            this.LsbCategories.Location = new System.Drawing.Point(33, 94);
            this.LsbCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LsbCategories.Name = "LsbCategories";
            this.LsbCategories.ScrollAlwaysVisible = true;
            this.LsbCategories.Size = new System.Drawing.Size(436, 64);
            this.LsbCategories.TabIndex = 8;
            this.LsbCategories.TabStop = false;
            // 
            // CbxCategorie
            // 
            this.CbxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCategorie.FormattingEnabled = true;
            this.CbxCategorie.Location = new System.Drawing.Point(33, 49);
            this.CbxCategorie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbxCategorie.Name = "CbxCategorie";
            this.CbxCategorie.Size = new System.Drawing.Size(436, 28);
            this.CbxCategorie.TabIndex = 7;
            // 
            // TabJournal
            // 
            this.TabJournal.Controls.Add(this.checkBox1);
            this.TabJournal.Controls.Add(this.label14);
            this.TabJournal.Controls.Add(this.label2);
            this.TabJournal.Controls.Add(this.label1);
            this.TabJournal.Controls.Add(this.BtnAddLog);
            this.TabJournal.Controls.Add(this.DgvLog);
            this.TabJournal.Controls.Add(this.ChkConverti);
            this.TabJournal.Controls.Add(this.DtpPremierContact);
            this.TabJournal.Controls.Add(this.DtpConverti);
            this.TabJournal.Controls.Add(this.ChkAbandon);
            this.TabJournal.Controls.Add(this.DtpAbandon);
            this.TabJournal.Location = new System.Drawing.Point(4, 29);
            this.TabJournal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabJournal.Name = "TabJournal";
            this.TabJournal.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabJournal.Size = new System.Drawing.Size(1050, 545);
            this.TabJournal.TabIndex = 1;
            this.TabJournal.Text = "Historique";
            this.TabJournal.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(22, 11);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 24);
            this.checkBox1.TabIndex = 39;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "Prise de contact";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(186, 12);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 20);
            this.label14.TabIndex = 35;
            this.label14.Text = "Date de contact :";
            this.label14.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Date abandon :";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Date conversion :";
            this.label1.Visible = false;
            // 
            // BtnAddLog
            // 
            this.BtnAddLog.Location = new System.Drawing.Point(825, 85);
            this.BtnAddLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddLog.Name = "BtnAddLog";
            this.BtnAddLog.Size = new System.Drawing.Size(198, 35);
            this.BtnAddLog.TabIndex = 36;
            this.BtnAddLog.Text = "Ajouter un suivi";
            this.BtnAddLog.UseVisualStyleBackColor = true;
            // 
            // DgvLog
            // 
            this.DgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLog.Location = new System.Drawing.Point(22, 128);
            this.DgvLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvLog.Name = "DgvLog";
            this.DgvLog.Size = new System.Drawing.Size(1000, 402);
            this.DgvLog.TabIndex = 34;
            // 
            // ChkConverti
            // 
            this.ChkConverti.AutoSize = true;
            this.ChkConverti.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkConverti.Location = new System.Drawing.Point(80, 51);
            this.ChkConverti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkConverti.Name = "ChkConverti";
            this.ChkConverti.Size = new System.Drawing.Size(93, 24);
            this.ChkConverti.TabIndex = 30;
            this.ChkConverti.TabStop = false;
            this.ChkConverti.Text = "Converti";
            this.ChkConverti.UseVisualStyleBackColor = true;
            // 
            // DtpPremierContact
            // 
            this.DtpPremierContact.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpPremierContact.Location = new System.Drawing.Point(326, 8);
            this.DtpPremierContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpPremierContact.Name = "DtpPremierContact";
            this.DtpPremierContact.Size = new System.Drawing.Size(140, 26);
            this.DtpPremierContact.TabIndex = 34;
            this.DtpPremierContact.Visible = false;
            // 
            // DtpConverti
            // 
            this.DtpConverti.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpConverti.Location = new System.Drawing.Point(326, 48);
            this.DtpConverti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpConverti.Name = "DtpConverti";
            this.DtpConverti.Size = new System.Drawing.Size(140, 26);
            this.DtpConverti.TabIndex = 31;
            this.DtpConverti.Visible = false;
            // 
            // ChkAbandon
            // 
            this.ChkAbandon.AutoSize = true;
            this.ChkAbandon.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkAbandon.Location = new System.Drawing.Point(74, 91);
            this.ChkAbandon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkAbandon.Name = "ChkAbandon";
            this.ChkAbandon.Size = new System.Drawing.Size(100, 24);
            this.ChkAbandon.TabIndex = 32;
            this.ChkAbandon.TabStop = false;
            this.ChkAbandon.Text = "Abandon";
            this.ChkAbandon.UseVisualStyleBackColor = true;
            // 
            // DtpAbandon
            // 
            this.DtpAbandon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpAbandon.Location = new System.Drawing.Point(326, 88);
            this.DtpAbandon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpAbandon.Name = "DtpAbandon";
            this.DtpAbandon.Size = new System.Drawing.Size(140, 26);
            this.DtpAbandon.TabIndex = 33;
            this.DtpAbandon.Visible = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(934, 606);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(112, 35);
            this.BtnSave.TabIndex = 36;
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
            this.BtnClose.Text = "Fermer";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Visible = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(747, 603);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(34, 35);
            this.BtnEdit.TabIndex = 39;
            this.BtnEdit.UseVisualStyleBackColor = true;
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
            this.Text = "Fiche prospect";
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
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.TabPage TabJournal;
        private System.Windows.Forms.DataGridView DgvLog;
        private System.Windows.Forms.CheckBox ChkConverti;
        private System.Windows.Forms.DateTimePicker DtpConverti;
        private System.Windows.Forms.CheckBox ChkAbandon;
        private System.Windows.Forms.DateTimePicker DtpAbandon;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtWeb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtGsm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtFax;
        private System.Windows.Forms.Button BtnAddLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker DtpPremierContact;
    }
}