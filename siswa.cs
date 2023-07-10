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
    public partial class siswa : Form
    {
        private string stringConnection = "data source=PRIBOEN\\PRIBOEN;" + "database=tugasAkhir; User ID=sa;Password=05012003";
        private SqlConnection koneksi;
        public siswa()
        {
            InitializeComponent();
        }

        private void siswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tugasAkhirDataSet2.Siswa' table. You can move, or remove it, as needed.
            this.siswaTableAdapter.Fill(this.tugasAkhirDataSet2.Siswa);

        }

        private void siswaformBtn_Click(object sender, EventArgs e)
        {
            add_murid adm = new add_murid();
            adm.Show();
            this.Hide();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForm mf = new MenuForm();
            mf.Show();
        }

        private void delSiswa_Click(object sender, EventArgs e)
        {
            delete_siswacs delSiswa = new delete_siswacs();
            delSiswa.Show();
            this.Hide();
        }
    }
}
