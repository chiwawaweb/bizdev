﻿using BizDev.DAL;
using BizDev.DTO;
using BizDev.Library;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BizDev.Forms
{
    public partial class ProspectEditForm : Form
    {
        int idProspect, idRetourSuivi;
        string categorie, nom, adresse, complement, codePostal, ville, pays, tel, gsm, fax, email, 
            web, nbEmployes, notes;
        bool view, clientPro;
        DateTime createdAt, updatedAt;
        string datePremierContact, dateConversion, dateAbandon;

        MainForm owner;
        Prospect prospect;

        ProspectLogProvider prospectLogProvider = new ProspectLogProvider();

        Utils utils = new Utils();
        ProspectProvider prospectProvider = new ProspectProvider();

        private void BtnLink_Click(object sender, EventArgs e)
        {
            ViewWebPage();
        }

        private void ViewWebPage()
        {
            if (!string.IsNullOrWhiteSpace(TxtWeb.Text))
            {
                string url = TxtWeb.Text.Trim().ToLower();
                Process.Start("http://" + url);
            }
        }

        public ProspectEditForm(MainForm _owner, bool _view, int _idProspect=0)
        {
            idProspect = _idProspect;
            view = _view;
            owner = _owner;

            FormClosed += new FormClosedEventHandler(ProspectEditForm_FormClosed);

            InitializeComponent();

            /* Combobox catégories */
            var dsCategorie = new List<string>();
            dsCategorie.Add("");
            foreach (string categorie in prospectProvider.RetrieveCategories())
            {
                if (categorie+""!="")
                {
                    dsCategorie.Add(categorie);
                }
            }
            CbxCategorie.DataSource = dsCategorie;
            CbxCategorie.DisplayMember = "Categorie";

            /* Combobox pays */
            var dsPays = new List<string>();
            dsPays.Add("");
            foreach (string pays in prospectProvider.RetrievePays())
            {
                if (pays+""!="")
                {
                    dsPays.Add(pays);
                }
            }
            CbxPays.DataSource = dsPays;
            CbxPays.DisplayMember = "Pays";

            switch (view)
            {
                case false:
                    NewMode();
                    break;

                case true:
                    ViewMode();
                    break;
            }

            /* Redimensionne la page */
            this.Size = new Size(850, 670);
        }

        private void NewMode()
        {
            this.CancelButton = BtnCancel;
            BtnAddLog.Enabled = false;
            DgvLog.Enabled = false;
            GrpDates.Visible = false;
            BtnPremierContact.Visible = false;
            BtnConversion.Visible = false;
            BtnAbandon.Visible = false;
            LblDatePremierContact.Visible = false;
            LblDateConversion.Visible = false;
            LblDateAbandon.Visible = false;
            Text = "Nouveau prospect";
        }
        
        private void ViewMode()
        {
            /* Modification des contrôles */
            BtnSave.Visible = false;
            BtnCancel.Visible = false;
            BtnClose.Visible = true;
            BtnEdit.Visible = true;
            CbxCategorie.Enabled = false;
            TxtNom.ReadOnly = true;
            TxtNom.BackColor = Color.LightGray;
            TxtNom.TabStop = false;
            TxtAdresse.ReadOnly = true;
            TxtAdresse.BackColor = Color.LightGray;
            TxtAdresse.TabStop = false;
            TxtComplement.ReadOnly = true;
            TxtComplement.BackColor = Color.LightGray;
            TxtComplement.TabStop = false;
            TxtCodePostal.ReadOnly = true;
            TxtCodePostal.BackColor = Color.LightGray;
            TxtCodePostal.TabStop = false;
            TxtVille.ReadOnly = true;
            TxtVille.BackColor = Color.LightGray;
            TxtVille.TabStop = false;
            CbxPays.Enabled = false;
            CbxPays.BackColor = Color.LightGray;
            TxtTel.ReadOnly = true;
            TxtTel.BackColor = Color.LightGray;
            TxtTel.TabStop = false;
            TxtGsm.ReadOnly = true;
            TxtGsm.BackColor = Color.LightGray;
            TxtGsm.TabStop = false;
            TxtFax.ReadOnly = true;
            TxtFax.BackColor = Color.LightGray;
            TxtFax.TabStop = false;
            TxtEmail.ReadOnly = true;
            TxtEmail.BackColor = Color.LightGray;
            TxtEmail.TabStop = false;
            TxtWeb.ReadOnly = true;
            TxtWeb.BackColor = Color.LightGray;
            TxtWeb.TabStop = false;
            TxtNbEmployes.ReadOnly = true;
            TxtNbEmployes.BackColor = Color.LightGray;
            TxtNbEmployes.TabStop = false;
            ChkClientPro.Enabled = false;
            TxtNotes.ReadOnly = true;
            TxtNotes.BackColor = Color.LightGray;
            TxtNotes.TabStop = false;
            
            /* Récupération des données */
            prospect = prospectProvider.GetProspectById(idProspect);

            categorie = prospect.Categorie;
            nom = prospect.Nom;
            adresse = prospect.Adresse;
            complement = prospect.Complement;
            codePostal = prospect.CodePostal;
            ville = prospect.Ville;
            pays = prospect.Pays;
            tel = prospect.Tel;
            gsm = prospect.Gsm;
            fax = prospect.Fax;
            email = prospect.Email;
            web = prospect.Web;
            nbEmployes = prospect.NbEmployes;
            clientPro = prospect.ClientPro;
            notes = prospect.Notes;
            datePremierContact = prospect.DatePremierContact;
            dateConversion = prospect.DateConversion;
            dateAbandon = prospect.DateAbandon;
            createdAt = prospect.CreatedAt;
            updatedAt = prospect.UpdatedAt;

            /* Affichage des données */
            CbxCategorie.Text = categorie;
            TxtNom.Text = nom;
            TxtAdresse.Text = adresse;
            TxtComplement.Text = complement;
            TxtCodePostal.Text = codePostal;
            TxtVille.Text = ville;
            CbxPays.Text = pays;
            TxtTel.Text = tel;
            TxtFax.Text = fax;
            TxtGsm.Text = gsm;
            TxtEmail.Text = email;
            TxtWeb.Text = web;
            TxtNbEmployes.Text = nbEmployes;
            ChkClientPro.Checked = clientPro;
            TxtNotes.Text = notes;
            TxtPremierContact.Text = datePremierContact;
            TxtConversion.Text = dateConversion;
            TxtAbandon.Text = dateAbandon;

            Text = "Visualisation du prospect : " + nom;
        }

        private void Save()
        {
            /* Récuperation des données */
            categorie = utils.RemoveDiacritics(CbxCategorie.Text.ToUpper().Trim());
            nom = utils.RemoveDiacritics(TxtNom.Text.ToUpper().Trim());
            adresse = utils.RemoveDiacritics(TxtAdresse.Text.ToUpper().Trim());
            complement = utils.RemoveDiacritics(TxtComplement.Text.ToUpper().Trim());
            codePostal = utils.RemoveDiacritics(TxtCodePostal.Text.ToUpper().Trim());
            ville = utils.RemoveDiacritics(TxtVille.Text.ToUpper().Trim());
            pays = utils.RemoveDiacritics(CbxPays.Text.ToUpper().Trim());
            tel = utils.RemoveDiacritics(TxtTel.Text.ToUpper().Trim());
            gsm = utils.RemoveDiacritics(TxtGsm.Text.ToUpper().Trim());
            fax = utils.RemoveDiacritics(TxtFax.Text.ToUpper().Trim());
            email = utils.RemoveDiacritics(TxtEmail.Text.ToLower().Trim());
            web = utils.RemoveDiacritics(TxtWeb.Text.ToLower().Trim());
            nbEmployes = utils.RemoveDiacritics(TxtNbEmployes.Text.ToLower().Trim());
            clientPro = ChkClientPro.Checked;

            /* Vérification des données */
            bool erreurs = false;
            
            ErrorProvider.Clear();

            if (nom.Length<2)
            {
                erreurs = true;
                ErrorProvider.SetError(TxtNom, "Nom trop court");
            }

            if (utils.IsEmailValid(email)==false)
            {
                erreurs = true;
                ErrorProvider.SetError(TxtEmail, "Email incorrect");
            }

            /* Contrôle si erreurs */
            if (erreurs == false)
            {
                /* Aucune erreur, on continue */
                using (Context context = new Context())
                {
                    if (view == true)
                    {
                        UpdateDatabase();
                    }
                    else
                    {
                        AddDatabase();
                    }
                    Close();
                }
            }
        }

        private void AddDatabase()
        {
            Prospect prospect = new Prospect
            {
                Categorie = categorie,
                Nom = nom,
                Adresse = adresse,
                Complement = complement,
                CodePostal = codePostal,
                Ville = ville,
                Pays = pays,
                Tel = tel,
                Gsm = gsm,
                Fax = fax,
                Email = email,
                Web = web,
                NbEmployes = nbEmployes,
                ClientPro = clientPro,
                DatePremierContact = string.Empty,
                DateConversion = string.Empty,
                DateAbandon = string.Empty,
                Notes = notes,
                CreatedAt = DateTime.Now
            };

            prospectProvider.Create(prospect);
            idProspect = prospect.Id;
        }

        private void UpdateDatabase()
        {
            Prospect prospect = prospectProvider.GetProspectById(idProspect);

            prospect.Categorie = categorie;
            prospect.Nom = nom;
            prospect.Adresse = adresse;
            prospect.Complement = complement;
            prospect.CodePostal = codePostal;
            prospect.Ville = ville;
            prospect.Pays = pays;
            prospect.Tel = tel;
            prospect.Gsm = gsm;
            prospect.Fax = fax;
            prospect.Email = email;
            prospect.Web = web;
            prospect.NbEmployes = nbEmployes;
            prospect.ClientPro = clientPro;
            prospect.Notes = notes;
            prospect.DatePremierContact = datePremierContact;
            prospect.DateConversion = dateConversion;
            prospect.DateAbandon = dateAbandon;
            prospect.UpdatedAt = DateTime.Now;

            prospectProvider.Update(prospect);
        }

        public void MajDates()
        {
            prospect = prospectProvider.GetProspectById(idProspect);

            datePremierContact = prospect.DatePremierContact;
            dateConversion = prospect.DateConversion;
            dateAbandon = prospect.DateAbandon;

            /* Mise à jour de l'affichage des dates */
            TxtPremierContact.Text = datePremierContact;
            TxtConversion.Text = dateConversion;
            TxtAbandon.Text = dateAbandon;
        }

        public void RefreshData(int _idRetourSuivi=0)
        {
            idRetourSuivi = _idRetourSuivi;

            List<ProspectLog> list;
            list = prospectLogProvider.GetByProspectId(idProspect);

            CreateTable(list, _idRetourSuivi);
        }

        private void CreateTable(List<ProspectLog> list, int _idRetourSuivi)
        {
            idRetourSuivi = _idRetourSuivi;

            DgvLog.Rows.Clear();
            DgvLog.Columns.Clear();
            DgvLog.DefaultCellStyle.Font = new Font("Consolas", 10);

            /* Mise en forme */
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn
            {
                Name = "ID",
                HeaderText = "#",
                Width = 60,
                Visible = false
            };
            idCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn dateCol = new DataGridViewTextBoxColumn
            {
                Name = "DATE",
                HeaderText = "Date",
                Width = 90,
                Visible = true
            };
            dateCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dateCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn noteCol = new DataGridViewTextBoxColumn
            {
                Name = "NOTE",
                HeaderText = "Annotation",
                Width = 620,
                Visible = true
            };
            noteCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            /* Création des colonnes */
            DgvLog.Columns.Add(idCol);
            DgvLog.Columns.Add(dateCol);
            DgvLog.Columns.Add(noteCol);

            /* Ajout des lignes */
            for (int i = 0; i < list.Count; i++)
            {
                int number = DgvLog.Rows.Add();

                int id = list[i].Id;
                DateTime date = list[i].Date;
                string note = list[i].Note;

                DgvLog.Rows[number].Cells[0].Value = id;
                DgvLog.Rows[number].Cells[1].Value = date.ToString("dd/MM/yyyy");
                DgvLog.Rows[number].Cells[2].Value = note;

                /* pointe sur l'enregistrement courant */
                if (list[i].Id == this.idRetourSuivi)
                {
                    DgvLog.Rows[number].Cells[1].Selected = true;
                }
            }
        }

        private void Edit()
        {
            /*
            DialogResult result = MessageBox.Show("Etes-vous certain de vouloir modifier cette fiche ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
            */
                UpdateMode();
            /*
            }
            */
        }

        private void UpdateMode()
        {
            /* Modification des contrôles */
            BtnEdit.Visible = false;
            BtnClose.Visible = false;
            BtnCancel.Visible = true;
            BtnSave.Visible = true;
            Text = "Modification fiche prospect : " + nom;
            TxtNom.ReadOnly = false;
            TxtNom.TabStop = true;
            TxtNom.BackColor = Color.Beige;
            CbxCategorie.Enabled = true;
            TxtNbEmployes.ReadOnly = false;
            TxtNbEmployes.TabStop = true;
            TxtNbEmployes.BackColor = Color.Beige;
            ChkClientPro.Enabled = true;
            TxtAdresse.ReadOnly = false;
            TxtAdresse.TabStop = true;
            TxtAdresse.BackColor = Color.Beige;
            TxtComplement.ReadOnly = false;
            TxtComplement.TabStop = true;
            TxtComplement.BackColor = Color.Beige;
            TxtCodePostal.ReadOnly = false;
            TxtCodePostal.TabStop = true;
            TxtCodePostal.BackColor = Color.Beige;
            TxtVille.ReadOnly = false;
            TxtVille.TabStop = true;
            TxtVille.BackColor = Color.Beige;
            CbxPays.Enabled = true;
            CbxPays.BackColor = Color.Beige;
            TxtTel.ReadOnly = false;
            TxtTel.TabStop = true;
            TxtTel.BackColor = Color.Beige;
            TxtGsm.ReadOnly = false;
            TxtGsm.TabStop = true;
            TxtGsm.BackColor = Color.Beige;
            TxtFax.ReadOnly = false;
            TxtFax.TabStop = true;
            TxtFax.BackColor = Color.Beige;
            TxtEmail.ReadOnly = false;
            TxtEmail.TabStop = true;
            TxtEmail.BackColor = Color.Beige;
            TxtWeb.ReadOnly = false;
            TxtWeb.TabStop = true;
            TxtWeb.BackColor = Color.Beige;
            TxtNotes.ReadOnly = false;
            TxtNotes.TabStop = true;
            TxtNotes.BackColor = Color.Beige;
            TxtNom.Focus();
            TxtNom.Select(0, 0);
            this.CancelButton = BtnCancel;
        }

        #region Gestion des événements

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProspectEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            owner.RefreshData(idProspect);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void BtnPremierContact_Click(object sender, EventArgs e)
        {
            new ProspectDate(this, idProspect, "P").ShowDialog();
        }

        private void BtnConversion_Click(object sender, EventArgs e)
        {
            new ProspectDate(this, idProspect, "C").ShowDialog();
        }

        private void BtnAbandon_Click(object sender, EventArgs e)
        {
            new ProspectDate(this, idProspect, "A").ShowDialog();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void BtnAddLog_Click(object sender, EventArgs e)
        {
            new ProspectLogEditForm(this, idProspect).ShowDialog(this);
        }

        private void ProspectEditForm_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon(this.Icon, this.Icon.Size);
            RefreshData();
        }

        #endregion
    }
}
