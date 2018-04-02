using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BizDev.Forms
{
    public partial class ProspectsListForm : Form
    {
        public ProspectsListForm()
        {
            InitializeComponent();
        }

        private void NewProspect()
        {
            new ProspectEditForm().ShowDialog();
        }

        #region Gestion des événements

        private void TbnNew_Click(object sender, EventArgs e)
        {
            NewProspect();
        }
        
        #endregion
    }
}
