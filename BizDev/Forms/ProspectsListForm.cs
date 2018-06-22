using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizDev.DAL;
using BizDev.DTO;
using BizDev.Library;
using System.IO;

namespace BizDev.Forms
{
    public partial class ProspectsListForm : Form
    {
        int idRetour, hauteurPage, largeurPage;

        Utils utils = new Utils();
        ProspectProvider prospectProvider = new ProspectProvider();
        //Form owner;

        public ProspectsListForm(int largeur, int hauteur, int _idRetour=0)
        {
            //owner = _owner;
            idRetour = _idRetour;
            hauteurPage = hauteur;
            largeurPage = largeur;

            InitializeComponent();

            // placement du form dans le coin sup/gauche
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
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

            LblNbResults.Text = "Nombre de prospects : " + nbResults.ToString();

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
                Width = 300
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

        private void NewProspect()
        {
            new ProspectEditForm(this, false).ShowDialog();
        }

        private void ViewProspect()
        {
            if (DgvProspects.RowCount > 0)
            {
                idRetour = int.Parse(DgvProspects.CurrentRow.Cells[0].Value.ToString());
                new ProspectEditForm(this, true, idRetour).ShowDialog();
            }
        }

        private void SearchProspect()
        {
            RefreshData();
        }

        private void ResetSearch()
        {
            TxtSearch.Text = string.Empty;
            SearchProspect();
            TxtSearch.Focus();
        }

        private void FiltreProspectsNonContactes()
        {
            TxtSearch.Enabled = false;
            BtnSearch.Enabled = false;
            BtnReset.Enabled = false;
        }

        private void ExportProspects()
        {
            List<Prospect> list;
            list = prospectProvider.GetAll();

            string exportFileName = "cbc.csv";
            string exportPath = "";

            using (StreamWriter sw = new StreamWriter
                (@"c:\cbc\"+ exportFileName, false, System.Text.Encoding.GetEncoding("utf-32")))
            {
                /* Ente du fichier */
                string entete = "Id\tCatégorie\tNom\tAdresse\tComplément\tCP\tVille\tPays\tNb\tContact\tConversion\tAbandon";
                sw.WriteLine(entete);

                /* Ajoute les lignes */
                for (int i = 0; i < list.Count; i++)
                {
                    
                    string id = list[i].Id.ToString("00000");
                    string categorie = list[i].Categorie.ToString();
                    string nom = list[i].Nom;
                    string adresse = list[i].Adresse;
                    string complement = list[i].Complement;
                    string codePostal = list[i].CodePostal;
                    string ville = list[i].Ville;
                    string pays = list[i].Pays;
                    string nbEmployes = list[i].NbEmployes.ToString();
                    string contact = list[i].DatePremierContact.ToString();
                    string conversion = list[i].DateConversion.ToString();
                    string abandon = list[i].DateAbandon.ToString();


                    sw.Write(id);
                    sw.Write("\t");
                    sw.Write(categorie);
                    sw.Write("\t");
                    sw.Write(nom);
                    sw.Write("\t");
                    sw.Write(adresse);
                    sw.Write("\t");
                    sw.Write(complement);
                    sw.Write("\t");
                    sw.Write(codePostal);
                    sw.Write("\t");
                    sw.Write(ville);
                    sw.Write("\t");
                    sw.Write(pays);
                    sw.Write("\t");
                    sw.Write(nbEmployes);
                    sw.Write("\t");
                    sw.Write(contact);
                    sw.Write("\t");
                    sw.Write(conversion);
                    sw.Write("\t");
                    sw.WriteLine(abandon);
                }

                    /*
                    DataSet1TableAdapters.binsTA ta = new DataSet1TableAdapters.binsTA();
                    DataSet1.binsDataTable dt = ta.GetData();
                    foreach (DataSet1.binsRow row in dt.Rows)
                    {
                        sw.Write(row.ID.ToString());
                        sw.Write("|");
                        sw.WriteLine(row.description);
                    }
                    */
            }
        }

        #region Gestion des événements

        private void TbnNew_Click(object sender, EventArgs e)
        {
            NewProspect();
        }

        private void TbnView_Click(object sender, EventArgs e)
        {
            ViewProspect();
        }

        private void ProspectsListForm_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon(this.Icon, this.Icon.Size);
            RefreshData();
        }

        private void DgvProspects_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ViewProspect();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchProspect();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetSearch();
        }

        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            SearchProspect();
        }

        private void ChkContacts_CheckedChanged(object sender, EventArgs e)
        {
            SearchProspect();
        }

        private void ChkConversions_CheckedChanged(object sender, EventArgs e)
        {
            SearchProspect();
        }

        private void ProspectsListForm_Shown(object sender, EventArgs e)
        {
            this.Size = new Size(largeurPage - 20, hauteurPage - 120);
        }

        private void TbnExport_Click(object sender, EventArgs e)
        {
            ExportProspects();
        }

        private void ChkAbandons_CheckedChanged(object sender, EventArgs e)
        {
            SearchProspect();
        }

        private void prospectsNonContactésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiltreProspectsNonContactes();
        }

        #endregion
    }
}
