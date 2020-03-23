﻿using System;
using System.Windows.Forms;

namespace Mekteb
{
    public partial class frmMekteb : Form
    {
        public frmMekteb()
        {
            InitializeComponent();
        }

        private void pcbSagird_Click(object sender, EventArgs e)
        {
            frmNeticeler frm = new frmNeticeler();
            frm.nomre = txtNomre.Text;
            frm.Show();
        }

        private void pcbMuellim_Click(object sender, EventArgs e)
        {
            frmMuellim frm = new frmMuellim();
            frm.Show();
        }
    }
}
