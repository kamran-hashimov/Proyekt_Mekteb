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
    public partial class frmFennler : Form
    {
        public frmFennler()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.Tbl_FennlerTableAdapter ds = new DataSet1TableAdapters.Tbl_FennlerTableAdapter();
        private void frmFennler_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = ds.FennSiyahisi();
        }

        private void btnElaveEt_Click(object sender, EventArgs e)
        {
            ds.FennElaveEt(txtFennAd.Text);
        }

        private void btnSiyahi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= ds.FennSiyahisi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.FennSil(byte.Parse(txtFennId.Text));
        }

        private void btnDeyisdir_Click(object sender, EventArgs e)
        {
            ds.FennDeyisdir(txtFennAd.Text,byte.Parse(txtFennId.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFennId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtFennAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
