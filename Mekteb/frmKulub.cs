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
    public partial class frmKulub : Form
    {
        public frmKulub()
        {
            InitializeComponent();
        }

        Sql_connection connection = new Sql_connection();

        void SiyahidaGoster()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Kulublar", connection.Connect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void ElaveEt(string fennadi)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Kulublar (KulubAd) values (@p1) ", connection.Connect());
            command.Parameters.AddWithValue("@p1", fennadi);
            try
            {
                command.ExecuteNonQuery();
                connection.Connect().Close();
                MessageBox.Show("Elave edilidi");

            }
            catch (Exception)
            {
                MessageBox.Show("Axilli ol");
            }
            SiyahidaGoster();
        }

        void Yenile(string id,string yeni)
        {
            SqlCommand command = new SqlCommand("update Tbl_Kulublar set KulubAd = @p1 where Kulubid = @p2", connection.Connect());
            command.Parameters.AddWithValue("@p1", yeni);
            command.Parameters.AddWithValue("@p2", id);
            command.ExecuteNonQuery();
            connection.Connect().Close();
            MessageBox.Show("Yenilendi");
        }

        void Sil(string id)
        {
            SqlCommand command = new SqlCommand("Delete from Tbl_Kulublar where Kulubid = @p1", connection.Connect());
            command.Parameters.AddWithValue("@p1", id);
            command.ExecuteNonQuery();
            connection.Connect().Close();
            MessageBox.Show("Silindi");
            SiyahidaGoster();
        }
        private void frmKulub_Load(object sender, EventArgs e)
        {
           // SiyahidaGoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SiyahidaGoster();
        }

        

        private void btnElaveEt_Click(object sender, EventArgs e)
        {
            ElaveEt(txtKulubAd.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKulubId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtKulubAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Yenile(txtKulubId.Text, txtKulubAd.Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil(txtKulubId.Text);
        }
    }
}
