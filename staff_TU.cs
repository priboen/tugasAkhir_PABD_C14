using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasAkhir
{
    public partial class staff_TU : Form
    {
        private string stringConnection = "data source=PRIBOEN\\PRIBOEN;" + "database=tugasAkhir; User ID=sa;Password=05012003";
        private SqlConnection koneksi;
        public staff_TU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm mf = new MenuForm();
            mf.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_staff tambahStaff = new add_staff();
            tambahStaff.Show();
            this.Close();
        }

        private void staff_TU_Load(object sender, EventArgs e)
        {


            // TODO: This line of code loads data into the 'tugasAkhirDataSet1.Staff_TU' table. You can move, or remove it, as needed.
            this.staff_TUTableAdapter1.Fill(this.tugasAkhirDataSet1.Staff_TU);
            koneksi = new SqlConnection(stringConnection);
            string str = "select * from dbo.Staff_TU";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
            

        }

        private void delStaff_Click(object sender, EventArgs e)
        {
            hapus_staff hs = new hapus_staff();
            hs.Show();
            this.Close();
        }
    }
}
