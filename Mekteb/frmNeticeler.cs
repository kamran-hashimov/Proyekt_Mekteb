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
    public partial class frmNeticeler : Form
    {
        public frmNeticeler()
        {
            InitializeComponent();
        }

        public string nomre;
        Sql_connection connection = new Sql_connection();
        
        private void Neticeler_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select FennAd,imtahan1,imtahan2,imtahan3,Proyekt,Ortalama,Veziyyet from Tbl_Neticeler inner join Tbl_Fennler on Tbl_Neticeler.Fennid = Tbl_Fennler.Fennid where Sagirdid = @p1", connection.Connect());
            command.Parameters.AddWithValue("@p1", nomre);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand command1 = new SqlCommand("Select Sagirdad,SagirdSoyad  from Tbl_Sagirdler where Sagirdid = @s1", connection.Connect());
            command1.Parameters.AddWithValue("@s1", nomre);
            SqlDataReader dr = command1.ExecuteReader();
            while (dr.Read())
            {
                this.Text = dr[0] + " " + dr[1];

            }
            connection.Connect().Close();

        }
    }
}
