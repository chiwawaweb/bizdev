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

        public StatistiquesForm()
        {
            InitializeComponent();
        }

        private void CalculDonnees()
        {
            /* Récupération des données */
            TNew = prospectProvider.TNew(0);
            TM1New = prospectProvider.TNew(-1);
            TM3New = prospectProvider.TNew(-3);
            TM6New = prospectProvider.TNew(-6);
            TM9New = prospectProvider.TNew(-9);
            TM12New = prospectProvider.TNew(-12);

            TContacts = prospectProvider.TContacts(0);
            PContacts = (TContacts / TNew) * 100;
            TM1Contacts = prospectProvider.TContacts(-1);
            PM1Contacts = (TM1Contacts / TM1New) * 100;
            TM3Contacts = prospectProvider.TContacts(-3);
            PM3Contacts = (TM3Contacts / TM3New) * 100;
            TM6Contacts = prospectProvider.TContacts(-6);
            PM6Contacts = (TM6Contacts / TM6New) * 100;
            TM9Contacts = prospectProvider.TContacts(-9);
            PM9Contacts = (TM9Contacts / TM9New) * 100;
            TM12Contacts = prospectProvider.TContacts(-12);
            PM12Contacts = (TM12Contacts / TM12New) * 100;

            TConversions = prospectProvider.TConversions(0);
            PConversions = (TConversions / TContacts) * 100;
            TM1Conversions = prospectProvider.TConversions(-1);
            PM1Conversions = (TM1Conversions / TM1Contacts) * 100;
            TM3Conversions = prospectProvider.TConversions(-3);
            PM3Conversions = (TM3Conversions / TM3Contacts) * 100;
            TM6Conversions = prospectProvider.TConversions(-6);
            PM6Conversions = (TM6Conversions / TM6Contacts) * 100;
            TM9Conversions = prospectProvider.TConversions(-9);
            PM9Conversions = (TM9Conversions / TM9Contacts) * 100;
            TM12Conversions = prospectProvider.TConversions(-12);
            PM12Conversions = (TM12Conversions / TM12Contacts) * 100;

            TAbandons = prospectProvider.TAbandons(0);
            PAbandons = (TAbandons / TNew) * 100;
            TM1Abandons = prospectProvider.TAbandons(-1);
            PM1Abandons = (TM1Abandons / TM1New) * 100;
            TM3Abandons = prospectProvider.TAbandons(-3);
            PM3Abandons = (TM3Abandons / TM3New) * 100;
            TM6Abandons = prospectProvider.TAbandons(-6);
            PM6Abandons = (TM6Abandons / TM6New) * 100;
            TM9Abandons = prospectProvider.TAbandons(-9);
            PM9Abandons = (TM9Abandons / TM9New) * 100;
            TM12Abandons = prospectProvider.TAbandons(-12);
            PM12Abandons = (TM12Abandons / TM12New) * 100;
        }

        private void AfficheDonnees()
        {
            TxtTNew.Text = TNew.ToString();
            TxtTM1New.Text = TM1New.ToString();
            TxtTM3New.Text = TM3New.ToString();
            TxtTM6New.Text = TM6New.ToString();
            TxtTM9New.Text = TM9New.ToString();
            TxtTM12New.Text = TM12New.ToString();

            TxtTContacts.Text = TContacts.ToString();
            TxtPContacts.Text = PContacts.ToString("0.00") + " %";
            TxtTM1Contacts.Text = TM1Contacts.ToString();
            TxtPM1Contacts.Text = PM1Contacts.ToString("0.00") + " %";
            TxtTM3Contacts.Text = TM3Contacts.ToString();
            TxtPM3Contacts.Text = PM3Contacts.ToString("0.00") + " %";
            TxtTM6Contacts.Text = TM6Contacts.ToString();
            TxtPM6Contacts.Text = PM6Contacts.ToString("0.00") + " %";
            TxtTM9Contacts.Text = TM9Contacts.ToString();
            TxtPM9Contacts.Text = PM9Contacts.ToString("0.00") + " %";
            TxtTM12Contacts.Text = TM12Contacts.ToString();
            TxtPM12Contacts.Text = PM12Contacts.ToString("0.00") + " %";

            TxtTConversions.Text = TConversions.ToString();
            TxtPConversions.Text = PConversions.ToString("0.00") + " %";
            TxtTM1Conversions.Text = TM1Conversions.ToString();
            TxtPM1Conversions.Text = PM1Conversions.ToString("0.00") + " %";
            TxtTM3Conversions.Text = TM3Conversions.ToString();
            TxtPM3Conversions.Text = PM3Conversions.ToString("0.00") + " %";
            TxtTM6Conversions.Text = TM6Conversions.ToString();
            TxtPM6Conversions.Text = PM6Conversions.ToString("0.00") + " %";
            TxtTM9Conversions.Text = TM9Conversions.ToString();
            TxtPM9Conversions.Text = PM9Conversions.ToString("0.00") + " %";
            TxtTM12Conversions.Text = TM12Conversions.ToString();
            TxtPM12Conversions.Text = PM12Conversions.ToString("0.00") + " %";

            TxtTAbandons.Text = TAbandons.ToString();
            TxtPAbandons.Text = PAbandons.ToString("0.00") + " %";
            TxtTM1Abandons.Text = TM1Abandons.ToString();
            TxtPM1Abandons.Text = PM1Abandons.ToString("0.00") + " %";
            TxtTM3Abandons.Text = TM3Abandons.ToString();
            TxtPM3Abandons.Text = PM3Abandons.ToString("0.00") + " %";
            TxtTM6Abandons.Text = TM6Abandons.ToString();
            TxtPM6Abandons.Text = PM6Abandons.ToString("0.00") + " %";
            TxtTM9Abandons.Text = TM9Abandons.ToString();
            TxtPM9Abandons.Text = PM9Abandons.ToString("0.00") + " %";
            TxtTM12Abandons.Text = TM12Abandons.ToString();
            TxtPM12Abandons.Text = PM12Abandons.ToString("0.00") + " %";
        }

        private void StatistiquesForm_Paint(object sender, PaintEventArgs e)
        {
            /*
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 178));
            e.Graphics.DrawLine(pen, 20, 10, 300, 100);
            */
        }

        

        private void fillChart()
        {
            //AddXY value in chart1 in series named as Salary  

            //ChaTotal.ChartAreas[0].AxisY.Maximum = 100;
            //ChaTotal.ChartAreas[0].BackColor = SystemColors.Control;
            
            ChaTotal.Series["Total"].Points.AddXY("Contacts", (PContacts/100).ToString("0.00"));
            ChaTotal.Series["Total"].Points.AddXY("Conversions", (PConversions/100).ToString("0.00"));
            ChaTotal.Series["Total"].Points.AddXY("Abandons", (PAbandons/100).ToString("0.00"));

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
            CalculDonnees();
            AfficheDonnees();

            int Test = prospectProvider.TNewMonth(2018, 4);
            Console.WriteLine("TEST : " + Test);

            fillChart();
        }

        #endregion
    }
}
