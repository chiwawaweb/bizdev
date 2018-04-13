using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizDev.DTO;
using BizDev.DAL;

namespace BizDev.Forms
{
    public partial class StatistiquesForm : Form
    {
        int annee;

        double[] TotalNew = new double[12];
        double[] TotalContacts = new double[12];
        double[] PercentContacts = new double[12];
        double[] TotalConversions = new double[12];
        double[] PercentConversions = new double[12];
        double[] TotalAbandons = new double[12];
        double[] PercentAbandons = new double[12];

        double TOTNew, TOTContacts, TOTConversions, TOTAbandons;
        double PERNew, PERContacts, PERConversions, PERAbandons;
        

        ProspectProvider prospectProvider = new ProspectProvider();

        public StatistiquesForm(int _annee)
        {
            annee = _annee;

            InitializeComponent();
        }

        private void CalculDonnees(int annee)
        {
            /* Récupération des données */
            for (int i=0;i<12;i++)
            {
                /* Nouveaux prospects */
                TotalNew[i] = prospectProvider.TotalNew(annee, i + 1);
                TOTNew += TotalNew[i];

                /* Prises de contacts */
                TotalContacts[i] = prospectProvider.TotalContacts(annee, i + 1);
                TOTContacts += TotalContacts[i];
                
                /* Conversions */
                TotalConversions[i] = prospectProvider.TotalConversions(annee, i + 1);
                TOTConversions += TotalConversions[i];

                /* Abandons */
                TotalAbandons[i] = prospectProvider.TotalAbandons(annee, i + 1);
                TOTAbandons += TotalAbandons[i];
            }
        }

        private void CreateTable()
        {
            DgvStats.Rows.Clear();
            DgvStats.Columns.Clear();
            DgvStats.DefaultCellStyle.Font = new Font("Consolas", 10);

            /* Mise en forme */
            DataGridViewTextBoxColumn labelCol = new DataGridViewTextBoxColumn
            {
                Name = "LABEL",
                HeaderText = "",
                Width = 130,
                Visible = true
            };
            labelCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            labelCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            labelCol.SortMode = DataGridViewColumnSortMode.NotSortable;

            DataGridViewTextBoxColumn janCol = new DataGridViewTextBoxColumn
            {
                Name = "JANVIER",
                HeaderText = "JAN",
                Width = 90,
                Visible = true
            };
            janCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            janCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            janCol.SortMode = DataGridViewColumnSortMode.NotSortable;

            DataGridViewTextBoxColumn fevCol = new DataGridViewTextBoxColumn
            {
                Name = "FEVRIER",
                HeaderText = "FEV",
                Width = 90,
                Visible = true
            };
            fevCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            fevCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            fevCol.SortMode = DataGridViewColumnSortMode.NotSortable;

            DataGridViewTextBoxColumn marCol = new DataGridViewTextBoxColumn
            {
                Name = "MARS",
                HeaderText = "MAR",
                Width = 65,
                Visible = true
            };
            marCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            marCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            marCol.SortMode = DataGridViewColumnSortMode.NotSortable;

            DataGridViewTextBoxColumn avrCol = new DataGridViewTextBoxColumn
            {
                Name = "AVRIL",
                HeaderText = "AVR",
                Width = 65,
                Visible = true
            };
            avrCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            avrCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            avrCol.SortMode = DataGridViewColumnSortMode.NotSortable;

            DataGridViewTextBoxColumn maiCol = new DataGridViewTextBoxColumn
            {
                Name = "MAI",
                HeaderText = "MAI",
                Width = 65,
                Visible = true
            };
            maiCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            maiCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            maiCol.SortMode = DataGridViewColumnSortMode.NotSortable;

            DataGridViewTextBoxColumn juiCol = new DataGridViewTextBoxColumn
            {
                Name = "JUIN",
                HeaderText = "JUI",
                Width = 65,
                Visible = true
            };
            juiCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            juiCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            juiCol.SortMode = DataGridViewColumnSortMode.NotSortable;

            DataGridViewTextBoxColumn julCol = new DataGridViewTextBoxColumn
            {
                Name = "JUILLET",
                HeaderText = "JUL",
                Width = 65,
                Visible = true
            };
            julCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            julCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            julCol.SortMode = DataGridViewColumnSortMode.NotSortable;

            DataGridViewTextBoxColumn aouCol = new DataGridViewTextBoxColumn
            {
                Name = "AOUT",
                HeaderText = "AOU",
                Width = 65,
                Visible = true
            };
            aouCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            aouCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            aouCol.SortMode = DataGridViewColumnSortMode.NotSortable;

            DataGridViewTextBoxColumn sepCol = new DataGridViewTextBoxColumn
            {
                Name = "SEPTEMBRE",
                HeaderText = "SEP",
                Width = 65,
                Visible = true
            };
            sepCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            sepCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            sepCol.SortMode = DataGridViewColumnSortMode.NotSortable;

            DataGridViewTextBoxColumn octCol = new DataGridViewTextBoxColumn
            {
                Name = "OCTOBRE",
                HeaderText = "OCT",
                Width = 65,
                Visible = true
            };
            octCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            octCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            octCol.SortMode = DataGridViewColumnSortMode.NotSortable;

            DataGridViewTextBoxColumn novCol = new DataGridViewTextBoxColumn
            {
                Name = "NOVEMBRE",
                HeaderText = "NOV",
                Width = 65,
                Visible = true
            };
            novCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            novCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            novCol.SortMode = DataGridViewColumnSortMode.NotSortable;

            DataGridViewTextBoxColumn decCol = new DataGridViewTextBoxColumn
            {
                Name = "DECEMBRE",
                HeaderText = "DEC",
                Width = 65,
                Visible = true
            };
            decCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            decCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            decCol.SortMode = DataGridViewColumnSortMode.NotSortable;

            DataGridViewTextBoxColumn totCol = new DataGridViewTextBoxColumn
            {
                Name = "TOTAL",
                HeaderText = "TOTAL",
                Width = 90,
                Visible = true
            };
            totCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            totCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            totCol.SortMode = DataGridViewColumnSortMode.NotSortable;

            /* Création des colonnes */
            DgvStats.Columns.Add(labelCol);
            DgvStats.Columns.Add(janCol);
            DgvStats.Columns.Add(fevCol);
            DgvStats.Columns.Add(marCol);
            DgvStats.Columns.Add(avrCol);
            DgvStats.Columns.Add(maiCol);
            DgvStats.Columns.Add(juiCol);
            DgvStats.Columns.Add(julCol);
            DgvStats.Columns.Add(aouCol);
            DgvStats.Columns.Add(sepCol);
            DgvStats.Columns.Add(octCol);
            DgvStats.Columns.Add(novCol);
            DgvStats.Columns.Add(decCol);
            DgvStats.Columns.Add(totCol);


            /* Ajout des lignes */
            int rowNew = DgvStats.Rows.Add();

            DgvStats.Rows[rowNew].Cells[0].Value = "Prospects";
            for (int i=0;i<12;i++)
            {
                DgvStats.Rows[rowNew].Cells[i+1].Value = TotalNew[i];
            }
            DgvStats.Rows[rowNew].Cells[13].Value = TOTNew;

            int rowContacts = DgvStats.Rows.Add();

            DgvStats.Rows[rowContacts].Cells[0].Value = "Contacts";
            for (int i = 0; i < 12; i++)
            {
                DgvStats.Rows[rowContacts].Cells[i + 1].Value = TotalContacts[i];
            }
            DgvStats.Rows[rowContacts].Cells[13].Value = TOTContacts;

            int rowConversions = DgvStats.Rows.Add();

            DgvStats.Rows[rowConversions].Cells[0].Value = "Conversions";
            for (int i = 0; i < 12; i++)
            {
                DgvStats.Rows[rowConversions].Cells[i + 1].Value = TotalConversions[i];
            }
            DgvStats.Rows[rowConversions].Cells[13].Value = TOTConversions;

            int rowAbandons = DgvStats.Rows.Add();

            DgvStats.Rows[rowAbandons].Cells[0].Value = "Abandons";
            for (int i = 0; i < 12; i++)
            {
                DgvStats.Rows[rowAbandons].Cells[i + 1].Value = TotalAbandons[i];
            }
            DgvStats.Rows[rowAbandons].Cells[13].Value = TOTAbandons;



        }

        

        private void fillChart()
        {
            ChaTotal.Series["Prospects"].Points.AddXY("Janvier", TotalNew[0].ToString());
            ChaTotal.Series["Prospects"].Points.AddXY("Février", TotalNew[1].ToString());
            ChaTotal.Series["Prospects"].Points.AddXY("Mars", TotalNew[2].ToString());
            ChaTotal.Series["Prospects"].Points.AddXY("Avril", TotalNew[3].ToString());
            ChaTotal.Series["Prospects"].Points.AddXY("Mai", TotalNew[4].ToString());
            ChaTotal.Series["Prospects"].Points.AddXY("Juin", TotalNew[5].ToString());
            ChaTotal.Series["Prospects"].Points.AddXY("Juillet", TotalNew[6].ToString());
            ChaTotal.Series["Prospects"].Points.AddXY("Août", TotalNew[7].ToString());
            ChaTotal.Series["Prospects"].Points.AddXY("Septembre", TotalNew[8].ToString());
            ChaTotal.Series["Prospects"].Points.AddXY("Octobre", TotalNew[9].ToString());
            ChaTotal.Series["Prospects"].Points.AddXY("Novembre", TotalNew[10].ToString());
            ChaTotal.Series["Prospects"].Points.AddXY("Décembre", TotalNew[11].ToString());
            ChaTotal.Series["Prospects"].Color = Color.Blue;

            ChaTotal.Series["Contacts"].Points.AddXY("Janvier", TotalContacts[0].ToString());
            ChaTotal.Series["Contacts"].Points.AddXY("Février", TotalContacts[1].ToString());
            ChaTotal.Series["Contacts"].Points.AddXY("Mars", TotalContacts[2].ToString());
            ChaTotal.Series["Contacts"].Points.AddXY("Avril", TotalContacts[3].ToString());
            ChaTotal.Series["Contacts"].Points.AddXY("Mai", TotalContacts[4].ToString());
            ChaTotal.Series["Contacts"].Points.AddXY("Juin", TotalContacts[5].ToString());
            ChaTotal.Series["Contacts"].Points.AddXY("Juillet", TotalContacts[6].ToString());
            ChaTotal.Series["Contacts"].Points.AddXY("Août", TotalContacts[7].ToString());
            ChaTotal.Series["Contacts"].Points.AddXY("Septembre", TotalContacts[8].ToString());
            ChaTotal.Series["Contacts"].Points.AddXY("Octobre", TotalContacts[9].ToString());
            ChaTotal.Series["Contacts"].Points.AddXY("Novembre", TotalContacts[10].ToString());
            ChaTotal.Series["Contacts"].Points.AddXY("Décembre", TotalContacts[11].ToString());

            ChaTotal.Series["Conversions"].Points.AddXY("Janvier", TotalConversions[0].ToString());
            ChaTotal.Series["Conversions"].Points.AddXY("Février", TotalConversions[1].ToString());
            ChaTotal.Series["Conversions"].Points.AddXY("Mars", TotalConversions[2].ToString());
            ChaTotal.Series["Conversions"].Points.AddXY("Avril", TotalConversions[3].ToString());
            ChaTotal.Series["Conversions"].Points.AddXY("Mai", TotalConversions[4].ToString());
            ChaTotal.Series["Conversions"].Points.AddXY("Juin", TotalConversions[5].ToString());
            ChaTotal.Series["Conversions"].Points.AddXY("Juillet", TotalConversions[6].ToString());
            ChaTotal.Series["Conversions"].Points.AddXY("Août", TotalConversions[7].ToString());
            ChaTotal.Series["Conversions"].Points.AddXY("Septembre", TotalConversions[8].ToString());
            ChaTotal.Series["Conversions"].Points.AddXY("Octobre", TotalConversions[9].ToString());
            ChaTotal.Series["Conversions"].Points.AddXY("Novembre", TotalConversions[10].ToString());
            ChaTotal.Series["Conversions"].Points.AddXY("Décembre", TotalConversions[11].ToString());

            ChaTotal.Series["Abandons"].Points.AddXY("Janvier", TotalAbandons[0].ToString());
            ChaTotal.Series["Abandons"].Points.AddXY("Février", TotalAbandons[1].ToString());
            ChaTotal.Series["Abandons"].Points.AddXY("Mars", TotalAbandons[2].ToString());
            ChaTotal.Series["Abandons"].Points.AddXY("Avril", TotalAbandons[3].ToString());
            ChaTotal.Series["Abandons"].Points.AddXY("Mai", TotalAbandons[4].ToString());
            ChaTotal.Series["Abandons"].Points.AddXY("Juin", TotalAbandons[5].ToString());
            ChaTotal.Series["Abandons"].Points.AddXY("Juillet", TotalAbandons[6].ToString());
            ChaTotal.Series["Abandons"].Points.AddXY("Août", TotalAbandons[7].ToString());
            ChaTotal.Series["Abandons"].Points.AddXY("Septembre", TotalAbandons[8].ToString());
            ChaTotal.Series["Abandons"].Points.AddXY("Octobre", TotalAbandons[9].ToString());
            ChaTotal.Series["Abandons"].Points.AddXY("Novembre", TotalAbandons[10].ToString());
            ChaTotal.Series["Abandons"].Points.AddXY("Décembre", TotalAbandons[11].ToString());

            ChaTotal.BackColor = SystemColors.Control;
            
            //chart title  
            //ChaTotal.Titles.Add("Salary Chart");
        }

        #region Gestion des événements

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StatistiquesForm_Load(object sender, EventArgs e)
        {
            CalculDonnees(DateTime.Now.Year);
            CreateTable();

            int Test = prospectProvider.TotalNew(2018, 4);
            Console.WriteLine("TEST : " + Test);

            fillChart();
        }

        #endregion
    }
}
