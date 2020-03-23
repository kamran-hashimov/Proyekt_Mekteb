using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mekteb
{
    public partial class frmImtahanNeticeleri : Form
    {
        public frmImtahanNeticeleri()
        {
            InitializeComponent();
        }

        Sql_connection connection = new Sql_connection();

        DataSet1TableAdapters.Tbl_NeticelerTableAdapter ds = new DataSet1TableAdapters.Tbl_NeticelerTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NeticeSiyahisi(int.Parse(txtSagirdId.Text));
        }

        private void frmImtahanNeticeleri_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Tbl_Fennler", connection.Connect());
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbFenn.DisplayMember = "FennAd";
            cmbFenn.ValueMember = "FennId";
            cmbFenn.DataSource = dt;
            connection.Connect().Close();
        }
        int neticeid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            neticeid = int.Parse(txtSagirdId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmbFenn.SelectedIndex =int.Parse(dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
            txtSagirdId.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtImt1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtImt2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtImt3.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtProyekt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtOrtalama.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtVeziyyet.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
        int imt1, imt2, imt3, proyekt;
        double ortalama;
        private void btnHesabla_Click(object sender, EventArgs e)
        {
            
            
            //string veziyyet;
            imt1 = Convert.ToInt32(txtImt1.Text);
            imt2 = Convert.ToInt32(txtImt2.Text);
            imt3 = Convert.ToInt32(txtImt3.Text);
            proyekt = Convert.ToInt32(txtProyekt.Text);
            ortalama = (imt1 + imt2 + imt3 + proyekt) / 4;
            txtOrtalama.Text = ortalama.ToString();
            if (ortalama>=50)
            {
                txtVeziyyet.Text = "True";
            }
            else
            {
                txtVeziyyet.Text = "False";
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            ds.NeticeYenile(byte.Parse(cmbFenn.SelectedValue.ToString()), int.Parse(txtSagirdId.Text), byte.Parse(txtImt1.Text), byte.Parse(txtImt2.Text), byte.Parse(txtImt3.Text), byte.Parse(proyekt.ToString()), int.Parse(txtOrtalama.Text), bool.Parse(txtVeziyyet.Text), neticeid);
        }
    }
}
