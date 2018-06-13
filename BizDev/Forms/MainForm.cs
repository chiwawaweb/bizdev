using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizDev.DAL;

namespace BizDev.Forms
{
    public partial class MainForm : Form
    {
        int largeurPage, hauteurPage;

        public MainForm()
        {
            InitializeComponent();

            ProspectProvider prospectProvider = new ProspectProvider();
            prospectProvider.CountAll();

            largeurPage = this.Size.Width;
            hauteurPage = this.Size.Height;

            OuvreListeProspects();

            Text = largeurPage.ToString()+" x "+hauteurPage.ToString();
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

        private void OuvreStatistiques()
        {
            if (Application.OpenForms["StatistiquesForm"] == null)
            {
                StatistiquesForm statistiquesForm = new StatistiquesForm(DateTime.Now.Year)
                {
                    MdiParent = this
                };
                statistiquesForm.Show();
            }
            else
            {
                Application.OpenForms["StatistiquesForm"].Activate();
            }
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

        private void TooStatistiquesProspects_Click(object sender, EventArgs e)
        {
            OuvreStatistiques();
        }

        private void TooProspects_Click(object sender, EventArgs e)
        {
            OuvreListeProspects();
        }

        private void TooProspectsStatistiques_Click(object sender, EventArgs e)
        {
            OuvreStatistiques();
        }

        #endregion


    }
}
