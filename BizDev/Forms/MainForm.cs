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
        public MainForm()
        {
            InitializeComponent();

            ProspectProvider prospectProvider = new ProspectProvider();
            prospectProvider.CountAll();
            
        }

        private void OuvreListeProspects()
        {
            ProspectsListForm prospectsListForm = new ProspectsListForm()
            {
                MdiParent = this
            };
            prospectsListForm.Show();
        }

        private void OuvreStatistiques()
        {
            StatistiquesForm statistiquesForm = new StatistiquesForm()
            {
                MdiParent = this
            };
            statistiquesForm.Show();
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

        #endregion


    }
}
