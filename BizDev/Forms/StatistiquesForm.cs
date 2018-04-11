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
        double[] TotalConversions = new double[12];
        double[] TotalAbandons = new double[12];

        double TOTNew, TOTContacts, TOTConversions, TOTAbandons;
        

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
                TotalNew[i] = prospectProvider.TotalNew(annee, i + 1);
                TOTNew += TotalNew[i];
                TotalContacts[i] = prospectProvider.TotalContacts(annee, i + 1);
                TOTContacts += TotalContacts[i];
                TotalConversions[i] = prospectProvider.TotalConversions(annee, i + 1);
                TOTConversions += TotalConversions[i];
                TotalAbandons[i] = prospectProvider.TotalAbandons(annee, i + 1);
                TOTAbandons += TotalAbandons[i];
            }
        }

        private void AfficheDonnees()
        {
            TxtT01New.Text = TotalNew[0].ToString();
            TxtT01Contacts.Text = TotalContacts[0].ToString();
            TxtT01Conversions.Text = TotalConversions[0].ToString();
            TxtT01Abandons.Text = TotalAbandons[0].ToString();

            TxtT02New.Text = TotalNew[1].ToString();
            TxtT02Contacts.Text = TotalContacts[1].ToString();
            TxtT02Conversions.Text = TotalConversions[1].ToString();
            TxtT02Abandons.Text = TotalAbandons[1].ToString();

            TxtT03New.Text = TotalNew[2].ToString();
            TxtT03Contacts.Text = TotalContacts[2].ToString();
            TxtT03Conversions.Text = TotalConversions[2].ToString();
            TxtT03Abandons.Text = TotalAbandons[2].ToString();

            TxtT04New.Text = TotalNew[3].ToString();
            TxtT04Contacts.Text = TotalContacts[3].ToString();
            TxtT04Conversions.Text = TotalConversions[3].ToString();
            TxtT04Abandons.Text = TotalAbandons[3].ToString();

            TxtT05New.Text = TotalNew[4].ToString();
            TxtT05Contacts.Text = TotalContacts[4].ToString();
            TxtT05Conversions.Text = TotalConversions[4].ToString();
            TxtT05Abandons.Text = TotalAbandons[4].ToString();

            TxtT06New.Text = TotalNew[5].ToString();
            TxtT06Contacts.Text = TotalContacts[5].ToString();
            TxtT06Conversions.Text = TotalConversions[5].ToString();
            TxtT06Abandons.Text = TotalAbandons[5].ToString();

            TxtT07New.Text = TotalNew[6].ToString();
            TxtT07Contacts.Text = TotalContacts[6].ToString();
            TxtT07Conversions.Text = TotalConversions[6].ToString();
            TxtT07Abandons.Text = TotalAbandons[6].ToString();

            TxtT08New.Text = TotalNew[7].ToString();
            TxtT08Contacts.Text = TotalContacts[7].ToString();
            TxtT08Conversions.Text = TotalConversions[7].ToString();
            TxtT08Abandons.Text = TotalAbandons[7].ToString();

            TxtT09New.Text = TotalNew[8].ToString();
            TxtT09Contacts.Text = TotalContacts[8].ToString();
            TxtT09Conversions.Text = TotalConversions[8].ToString();
            TxtT09Abandons.Text = TotalAbandons[8].ToString();

            TxtT10New.Text = TotalNew[9].ToString();
            TxtT10Contacts.Text = TotalContacts[9].ToString();
            TxtT10Conversions.Text = TotalConversions[9].ToString();
            TxtT10Abandons.Text = TotalAbandons[9].ToString();

            TxtT11New.Text = TotalNew[10].ToString();
            TxtT11Contacts.Text = TotalContacts[10].ToString();
            TxtT11Conversions.Text = TotalConversions[10].ToString();
            TxtT11Abandons.Text = TotalAbandons[10].ToString();

            TxtT12New.Text = TotalNew[11].ToString();
            TxtT12Contacts.Text = TotalContacts[11].ToString();
            TxtT12Conversions.Text = TotalConversions[11].ToString();
            TxtT12Abandons.Text = TotalAbandons[11].ToString();



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
            AfficheDonnees();

            int Test = prospectProvider.TotalNew(2018, 4);
            Console.WriteLine("TEST : " + Test);

            fillChart();
        }

        #endregion
    }
}
