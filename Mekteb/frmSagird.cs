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
    public partial class frmSagird : Form
    {
        public frmSagird()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();

        Sql_connection connection = new Sql_connection();

        private void frmSagird_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.SagirdData();
            SqlCommand command = new SqlCommand("Select * from Tbl_Kulublar", connection.Connect());
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbKulub.DisplayMember = "KulubAd";
            cmbKulub.ValueMember = "KulubId";
            cmbKulub.DataSource = dt;
            connection.Connect().Close();
        }
        string c="";
        private void btnElaveEt_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked)
            {
                c = "Qadin";
            }
            else
            {
                c = "Kisi";
            }
            ds.SagirdElaveEt(txtSagirdAdi.Text,txtSoyad.Text,byte.Parse(cmbKulub.SelectedValue.ToString()),c);
        }

        private void btnSiyahi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.SagirdData();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.SagirdSil(int.Parse(txtSagirdId.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSagirdId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSagirdAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbKulub.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()== "Qadin")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }

        private void btnDeyisdir_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                c = "Qadin";
            }
            else
            {
                c = "Kisi";
            }
            ds.SagirdDeyisdir(txtSagirdAdi.Text, txtSoyad.Text, byte.Parse(cmbKulub.SelectedValue.ToString()), c, int.Parse(txtSagirdId.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.SagirdGetir(txtAxtar.Text);
        }
    }
}
