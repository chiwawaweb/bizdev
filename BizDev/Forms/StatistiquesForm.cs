﻿using System;
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
    public partial class StatistiquesForm : Form
    {
        public StatistiquesForm()
        {
            InitializeComponent();
        }

        private void StatistiquesForm_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            e.Graphics.DrawLine(pen, 20, 10, 300, 100);
        }
    }
}
