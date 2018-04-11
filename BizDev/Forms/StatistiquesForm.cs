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

        double TNew, TContacts, TConversions, TAbandons;
        double PNew, PContacts, PConversions, PAbandons;
        double TM1New, TM1Contacts, TM1Conversions, TM1Abandons;
        double PM1New, PM1Contacts, PM1Conversions, PM1Abandons;
        double TM3New, TM3Contacts, TM3Conversions, TM3Abandons;
        double PM3New, PM3Contacts, PM3Conversions, PM3Abandons;
        double TM6New, TM6Contacts, TM6Conversions, TM6Abandons;
        double PM6New, PM6Contacts, PM6Conversions, PM6Abandons;
        double TM9New, TM9Contacts, TM9Conversions, TM9Abandons;
        double PM9New, PM9Contacts, PM9Conversions, PM9Abandons;
        double TM12New, TM12Contacts, TM12Conversions, TM12Abandons;
        double PM12New, PM12Contacts, PM12Conversions, PM12Abandons;

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
                TotalContacts[i] = prospectProvider.TotalContacts(annee, i + 1);
                TotalConversions[i] = prospectProvider.TotalConversions(annee, i + 1);
                TotalAbandons[i] = prospectProvider.TotalAbandons(annee, i + 1);
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

            /*
            ChaTotal.Series["M1"].Points.AddXY("Contacts", (PM1Contacts/100).ToString("0.00"));
            ChaTotal.Series["M1"].Points.AddXY("Conversions", (PM1Conversions/100).ToString("0.00"));
            ChaTotal.Series["M1"].Points.AddXY("Abandons", (PM1Abandons/100).ToString("0.00"));

            ChaTotal.Series["M3"].Points.AddXY("Contacts", (PM3Contacts / 100).ToString("0.00"));
            ChaTotal.Series["M3"].Points.AddXY("Conversions", (PM3Conversions / 100).ToString("0.00"));
            ChaTotal.Series["M3"].Points.AddXY("Abandons", (PM3Abandons / 100).ToString("0.00"));

            ChaTotal.Series["M6"].Points.AddXY("Contacts", (PM6Contacts / 100).ToString("0.00"));
            ChaTotal.Series["M6"].Points.AddXY("Conversions", (PM6Conversions / 100).ToString("0.00"));
            ChaTotal.Series["M6"].Points.AddXY("Abandons", (PM6Abandons / 100).ToString("0.00"));

            ChaTotal.Series["M9"].Points.AddXY("Contacts", (PM9Contacts / 100).ToString("0.00"));
            ChaTotal.Series["M9"].Points.AddXY("Conversions", (PM9Conversions / 100).ToString("0.00"));
            ChaTotal.Series["M9"].Points.AddXY("Abandons", (PM9Abandons / 100).ToString("0.00"));

            ChaTotal.Series["M12"].Points.AddXY("Contacts", (PM12Contacts / 100).ToString("0.00"));
            ChaTotal.Series["M12"].Points.AddXY("Conversions", (PM12Conversions / 100).ToString("0.00"));
            ChaTotal.Series["M12"].Points.AddXY("Abandons", (PM12Abandons / 100).ToString("0.00"));
            */
            ChaTotal.BackColor = SystemColors.Control;
            
            //ChaTotal.Series["Salary"].Points.AddXY("Gurmeet", "10000");
            //ChaTotal.Series["Salary"].Points.AddXY("Suresh", "8500");
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
