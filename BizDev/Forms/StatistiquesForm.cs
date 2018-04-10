﻿using System;
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
            TNew = prospectProvider.TNew(0);
            //PNew = 100;
            TM1New = prospectProvider.TNew(-1);
            //PM1New = (TM1New / TNew) * 100;
            TM3New = prospectProvider.TNew(-3);
            //PM3New = (TM3New / TNew) * 100;
            TM6New = prospectProvider.TNew(-6);

            TM9New = prospectProvider.TNew(-9);

            TM12New = prospectProvider.TNew(-12);
            //PM12New = (TM12New / TNew) * 100;

            TContacts = prospectProvider.TContacts(0);
            //PContacts = (TContacts / TNew) * 100;
            TM1Contacts = prospectProvider.TContacts(-1);
            //PM1Contacts = (TM1Contacts / TContacts) * 100;
            TM3Contacts = prospectProvider.TContacts(-3);

            TM6Contacts = prospectProvider.TContacts(-6);

            TM9Contacts = prospectProvider.TContacts(-9);

            TM12Contacts = prospectProvider.TContacts(-12);
            //PM12Contacts = (TM12Contacts / TContacts) * 100;

            TConversions = prospectProvider.TConversions(0);
            PConversions = (TConversions / TNew) * 100;
            TM1Conversions = prospectProvider.TConversions(-1);
            //PM1Conversions = (TM1Conversions / TConversions) * 100;
            TM3Conversions = prospectProvider.TConversions(-3);

            TM6Conversions = prospectProvider.TConversions(-6);

            TM9Conversions = prospectProvider.TConversions(-9);

            TM12Conversions = prospectProvider.TConversions(-12);
            //PM12Conversions = (TM12Conversions / TConversions) * 100;

            TAbandons = prospectProvider.TAbandons(0);
            //PAbandons = (TAbandons / TNew) * 100;
            TM1Abandons = prospectProvider.TAbandons(-1);
            //PM1Abandons = (TM1Abandons / TNew) * 100;
            TM3Abandons = prospectProvider.TAbandons(-3);

            TM6Abandons = prospectProvider.TAbandons(-6);

            TM9Abandons = prospectProvider.TAbandons(-9);

            TM12Abandons = prospectProvider.TAbandons(-12);
            //PM12Abandons = (TM12Abandons / TNew) * 100;
        }

        private void AfficheDonnees()
        {
            TxtTNew.Text = TNew.ToString();
            TxtPNew.Text = PNew.ToString("0.00") + " %";
            TxtTM1New.Text = TM1New.ToString();
            TxtPM1New.Text = PM1New.ToString("0.00") + " %";
            TxtTM3New.Text = TM3New.ToString();
            TxtPM3New.Text = PM3New.ToString("0.00") + " %";
            TxtTM6New.Text = TM6New.ToString();
            TxtPM6New.Text = PM6New.ToString("0.00") + " %";
            TxtTM9New.Text = TM9New.ToString();
            TxtPM9New.Text = PM9New.ToString("0.00") + " %";
            TxtTM12New.Text = TM12New.ToString();
            TxtPM12New.Text = PM12New.ToString("0.00") + " %";

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
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 178));
            e.Graphics.DrawLine(pen, 20, 10, 300, 100);
        }

        private void StatistiquesForm_Load(object sender, EventArgs e)
        {
            CalculDonnees();
            AfficheDonnees();
        }

        #region Gestion des événements

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
