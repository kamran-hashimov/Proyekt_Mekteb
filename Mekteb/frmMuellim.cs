using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mekteb
{
    public partial class frmMuellim : Form
    {
        public frmMuellim()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKulub frm = new frmKulub();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmFennler frm = new frmFennler();
            frm.Show();
        }

        private void btnSagirdEmeliyyatlari_Click(object sender, EventArgs e)
        {
            frmSagird frm = new frmSagird();
            frm.Show();
        }

        private void btnImtahanNeticeleri_Click(object sender, EventArgs e)
        {
            frmImtahanNeticeleri frm = new frmImtahanNeticeleri();
            frm.Show();
        }
    }
}
