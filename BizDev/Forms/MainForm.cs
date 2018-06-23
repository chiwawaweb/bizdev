using BizDev.DAL;
using BizDev.DTO;
using BizDev.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BizDev.Forms
{
    public partial class MainForm : Form
    {
        int idRetour, largeurPage, hauteurPage;

        Utils utils = new Utils();
        ProspectProvider prospectProvider = new ProspectProvider();
        

        public MainForm()
        {
            InitializeComponent();

            prospectProvider.CountAll(); // * à supprimer 
        }

        public void RefreshData(int _idRetour = 0, bool firstLine = false)
        {
            if (_idRetour != 0)
            {
                idRetour = _idRetour;
            }

            List<Prospect> list;
            list = prospectProvider.Search(utils.RemoveDiacritics(TxtSearch.Text.Trim()));

            if (firstLine == true)
            {
                idRetour = 0;
            }

            /* Compte le nombre de résultats */
            int nbResults = list.Count();

            TssNbProspect.Text = "Nombre de prospects : " + nbResults.ToString();

            CreateTable(list);
            TxtSearch.Focus();
        }

        private void CreateTable(List<Prospect> list)
        {
            DgvProspects.Rows.Clear();
            DgvProspects.Columns.Clear();
            DgvProspects.DefaultCellStyle.Font = new Font("Consolas", 10);

            /* Mise en forme */
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn
            {
                Name = "ID",
                HeaderText = "#",
                Width = 60,
                Visible = true
            };
            idCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn nomCol = new DataGridViewTextBoxColumn
            {
                Name = "NOM",
                HeaderText = "Nom du prospect",
                Width = 400
            };
            nomCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn adresseCol = new DataGridViewTextBoxColumn
            {
                Name = "ADRESSE",
                HeaderText = "Adresse du prospect",
                Width = 350
            };
            adresseCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn cpCol = new DataGridViewTextBoxColumn
            {
                Name = "CP",
                HeaderText = "C.P.",
                Width = 60
            };
            cpCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn villeCol = new DataGridViewTextBoxColumn
            {
                Name = "VILLE",
                HeaderText = "Ville",
                Width = 190
            };
            villeCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn telephoneCol = new DataGridViewTextBoxColumn
            {
                Name = "TEL",
                HeaderText = "Téléphone du prospect",
                Width = 160
            };
            telephoneCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn datePremierContactCol = new DataGridViewTextBoxColumn
            {
                Name = "DATE_PREMIERCONTACT",
                HeaderText = "Contact",
                Width = 100
            };
            datePremierContactCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datePremierContactCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn dateConversionCol = new DataGridViewTextBoxColumn
            {
                Name = "DATE_CONVERSION",
                HeaderText = "Conversion",
                Width = 100
            };
            dateConversionCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dateConversionCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn dateAbandonCol = new DataGridViewTextBoxColumn
            {
                Name = "DATE_ABANDON",
                HeaderText = "Abandon",
                Width = 100
            };
            dateAbandonCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dateAbandonCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn categorieCol = new DataGridViewTextBoxColumn
            {
                Name = "CATEGORIE",
                HeaderText = "Catégorie",
                Width = 350
            };
            categorieCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            /* Création des colonnes */
            DgvProspects.Columns.Add(idCol);
            DgvProspects.Columns.Add(nomCol);
            DgvProspects.Columns.Add(adresseCol);
            DgvProspects.Columns.Add(cpCol);
            DgvProspects.Columns.Add(villeCol);
            DgvProspects.Columns.Add(telephoneCol);
            DgvProspects.Columns.Add(datePremierContactCol);
            DgvProspects.Columns.Add(dateConversionCol);
            DgvProspects.Columns.Add(dateAbandonCol);
            DgvProspects.Columns.Add(categorieCol);

            /* Ajout des lignes */
            for (int i = 0; i < list.Count; i++)
            {
                int number = DgvProspects.Rows.Add();

                int id = list[i].Id;
                string nom = list[i].Nom.Trim();
                string adresse = (list[i].Adresse + " " + list[i].Complement).Trim();
                string codePostal = list[i].CodePostal;
                string ville = list[i].Ville;
                string telephone = list[i].Tel;
                string datePremierContact = list[i].DatePremierContact;
                string dateConversion = list[i].DateConversion;
                string dateAbandon = list[i].DateAbandon;
                string categorie = list[i].Categorie;

                DgvProspects.Rows[number].Cells[0].Value = id.ToString("00000");
                DgvProspects.Rows[number].Cells[1].Value = nom;
                DgvProspects.Rows[number].Cells[2].Value = adresse;
                DgvProspects.Rows[number].Cells[3].Value = codePostal;
                DgvProspects.Rows[number].Cells[4].Value = ville;
                DgvProspects.Rows[number].Cells[5].Value = telephone;
                DgvProspects.Rows[number].Cells[6].Value = datePremierContact;
                DgvProspects.Rows[number].Cells[7].Value = dateConversion;
                DgvProspects.Rows[number].Cells[8].Value = dateAbandon;
                DgvProspects.Rows[number].Cells[9].Value = categorie;

                /* Sélection du client par idRetour */
                if (list[i].Id == idRetour)
                {
                    DgvProspects.Rows[number].Cells[1].Selected = true;
                }
            }
        }

        private void OuvreListeProspects()
        {
            if (Application.OpenForms["ProspectsListForm"] == null)
            {
                ProspectsListForm prospectsListForm = new ProspectsListForm(largeurPage, hauteurPage)
                {
                    MdiParent = this
                };
                prospectsListForm.Show();
            }
            else
            {
                Application.OpenForms["ProspectsListForm"].Activate();
            }
        }

        private void ExportProspects()
        {

        }

        private void ResetSearch()
        {
            TxtSearch.Text = string.Empty;
            RefreshData();
            TxtSearch.Focus();
        }

        #region Gestion des événements

        private void TooQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TooListeProspects_Click(object sender, EventArgs e)
        {
            OuvreListeProspects();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            //largeurPage = this.Size.Width;
            //hauteurPage = this.Size.Height;
            
            RefreshData();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetSearch();
        }

        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            RefreshData();
        }

        private void exporterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportProspects();
        }

        private void TooProspects_Click(object sender, EventArgs e)
        {
            OuvreListeProspects();
        }

        #endregion

    }
}
