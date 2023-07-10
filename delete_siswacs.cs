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
    public partial class delete_siswacs : Form
    {
        private string stringConnection = "data source=PRIBOEN\\PRIBOEN;" + "database=tugasAkhir; User ID=sa;Password=05012003";
        private SqlConnection koneksi;
        public delete_siswacs()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            cbNamaSiswa();
        }

        private void cbNamaSiswa()
        {

            koneksi.Open();
            string str = "SELECT Nama_Siswa FROM Siswa";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataReader dr = cmd.ExecuteReader();
            DataSet ds = new DataSet();
            while (dr.Read())
            {
                cbxNamaSiswa.Items.Add(dr.GetString(0));
            }
            dr.Close();
            koneksi.Close();

        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = new SqlCommand("delete Siswa where NISN=@NISN", koneksi);
            cmd.Parameters.AddWithValue("@NISN", txtNISN.Text);
            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("Data Berhasil Di Hapus!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            siswa sw = new siswa();
            sw.Show();
            this.Close();
        }

        private void cbxNamaSiswa_SelectedIndexChanged(object sender, EventArgs e)
        {
            koneksi.Open();
            string strs = "select NISN from dbo.Siswa where Nama_Siswa = @Nama_Siswa";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            string selectedName = cbxNamaSiswa.SelectedItem.ToString();
            cm.Parameters.AddWithValue("@Nama_Siswa", selectedName);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                string nip = dr.GetString(0);
                txtNISN.Text = nip;
            }
            else
            {
                txtNISN.Text = "";
            }

            dr.Close();
            koneksi.Close();
        }
    }
}
