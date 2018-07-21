﻿using BizDev.DAL;
using BizDev.DTO;
using BizDev.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BizDev.Forms
{
    public partial class MainForm : Form
    {
        int idRetour;

        Utils utils = new Utils();
        ProspectProvider prospectProvider = new ProspectProvider();

        public MainForm()
        {
            InitializeComponent();
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
            int totalProspects = prospectProvider.CountAll();

            TssNbProspect.Text = "Résultats : " + nbResults.ToString() +  " / " + totalProspects;

            CreateTable(list);
            TxtSearch.Focus();
        }

        private void CreateTable(List<Prospect> list)
        {
            DgvProspects.Rows.Clear();
            DgvProspects.Columns.Clear();
            DgvProspects.DefaultCellStyle.Font = new Font("Consolas", 10);

            DgvProspects.DoubleBuffered(true);

            /* Alternance des couleurs de lignes */
            DgvProspects.RowsDefaultCellStyle.BackColor = Color.LightGreen;
            DgvProspects.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            /* Hauteur de l'entête */
            DgvProspects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvProspects.EnableHeadersVisualStyles = false;
            DgvProspects.ColumnHeadersHeight = 30;

            DgvProspects.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas",11, FontStyle.Bold);

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
                HeaderText = "NOM",
                Width = 400
            };
            nomCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn adresseCol = new DataGridViewTextBoxColumn
            {
                Name = "ADRESSE",
                HeaderText = "ADRESSE",
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
            cpCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DataGridViewTextBoxColumn villeCol = new DataGridViewTextBoxColumn
            {
                Name = "VILLE",
                HeaderText = "VILLE",
                Width = 190
            };
            villeCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn telephoneCol = new DataGridViewTextBoxColumn
            {
                Name = "TEL",
                HeaderText = "TEL",
                Width = 160
            };
            telephoneCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn datePremierContactCol = new DataGridViewTextBoxColumn
            {
                Name = "DATE_PREMIERCONTACT",
                HeaderText = "CONTACT",
                Width = 100
            };
            datePremierContactCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datePremierContactCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn dateConversionCol = new DataGridViewTextBoxColumn
            {
                Name = "DATE_CONVERSION",
                HeaderText = "CONVERSION",
                Width = 100
            };
            dateConversionCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dateConversionCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn dateAbandonCol = new DataGridViewTextBoxColumn
            {
                Name = "DATE_ABANDON",
                HeaderText = "ABANDON",
                Width = 100
            };
            dateAbandonCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dateAbandonCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn categorieCol = new DataGridViewTextBoxColumn
            {
                Name = "CATEGORIE",
                HeaderText = "CATEGORIE",
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

        private void ResetSearch()
        {
            TxtSearch.Text = string.Empty;
            RefreshData();
            TxtSearch.Focus();
        }

        private void ExportProspects()
        {
            string exportFileName;

            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.Filter = "Fichiers CSV (*.csv)|*.csv";
            saveFileDialog.FileName = "cbc.csv";
            saveFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                exportFileName = saveFileDialog.FileName;

                List<Prospect> list;
                list = prospectProvider.GetAll();

                using (StreamWriter sw = new StreamWriter
                    (@exportFileName, false, Encoding.GetEncoding("utf-32")))
                {
                    /* Ente du fichier */
                    string entete = "Id\tNom\tAdresse\tComplément\tCP\tVille\tPays\tNb\tContact\tConversion\tAbandon\tCatégorie";
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
                        sw.Write(abandon);
                        sw.Write("\t");
                        sw.WriteLine(categorie);
                    }
                }
                MessageBox.Show("L'exportation a été réalisée avec succès !", "Exportation terminée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OpenNewClient()
        {
            ClientEditForm clientEditForm = new ClientEditForm();
            clientEditForm.ShowDialog();
        }

        #region Gestion des événements

        private void TooQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
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

        private void TsbView_Click(object sender, EventArgs e)
        {
            ViewProspect();
        }

        private void DgvProspects_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ViewProspect();
        }

        private void TsbNew_Click(object sender, EventArgs e)
        {
            NewProspect();
        }

        private void exporterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportProspects();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAboutBox();
        }
        
        private void OpenAboutBox()
        {
            AboutBoxForm frm = new AboutBoxForm();
            frm.ShowDialog();
        }

        private void TxbExport_Click(object sender, EventArgs e)
        {
            ExportProspects();
        }

        

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                NewProspect();
            }
        }

        private void nouveauClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewClient();
        }

        #endregion


    }
}
