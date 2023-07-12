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
    public partial class addWali : Form
    {
        private string stringConnection = "data source=PRIBOEN\\PRIBOEN;" + "database=tugasAkhir; User ID=sa;Password=05012003";
        private SqlConnection koneksi;
        public addWali()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            cbNamaSiswa();
        }
        private void refreshform()
        {
            Wali_Murid wm = new Wali_Murid();
            wm.Show();
            this.Close();
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
                cbxNISN.Items.Add(dr.GetString(0));
            }
            dr.Close();
            koneksi.Close();

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (NIKtxt.Text == "")
            {
                MessageBox.Show("NIK TIDAK BOLEH KOSONG!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi = new SqlConnection(stringConnection);
                koneksi.Open();
                SqlCommand cmd = new SqlCommand("insert into wali_murid values(@NIK, @nama_wali, @pekerjaan, @jalan, @desa, @kecamatan, @kota_madya, @kode_pos, @status_wali, @NISN)", koneksi);
                cmd.Parameters.AddWithValue("@NIK", NIKtxt.Text);
                cmd.Parameters.AddWithValue("@nama_wali", nmWalitxt.Text);
                cmd.Parameters.AddWithValue("@pekerjaan", pekerjaanTxt.Text);
                cmd.Parameters.AddWithValue("@jalan", jalantxt.Text);
                cmd.Parameters.AddWithValue("@desa", desaTxt.Text);
                cmd.Parameters.AddWithValue("@kecamatan", kecamatanTxt.Text);
                cmd.Parameters.AddWithValue("@kota_madya", kotaTxt.Text);
                cmd.Parameters.AddWithValue("@kode_pos", double.Parse(posTxt.Text));
                cmd.Parameters.AddWithValue("@status_wali", statusTxt.Text);
                cmd.Parameters.AddWithValue("@NISN", nisnmuridTXT.Text);

                cmd.ExecuteNonQuery();
                koneksi.Close();

                MessageBox.Show("Data Berhasil Di Simpan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshform();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = new SqlCommand("update wali_murid set nama_wali = @nama_wali, pekerjaan = @pekerjaan, jalan = @jalan, desa = @desa, kecamatan = @kecamatan, kota_madya = @kota_madya, kode_pos = @kode_pos, status_wali = @status_wali, NISN = @NISN where NIK = @NIK", koneksi);
            cmd.Parameters.AddWithValue("@NIK", NIKtxt.Text);
            cmd.Parameters.AddWithValue("@nama_wali", nmWalitxt.Text);
            cmd.Parameters.AddWithValue("@pekerjaan", pekerjaanTxt.Text);
            cmd.Parameters.AddWithValue("@jalan", jalantxt.Text);
            cmd.Parameters.AddWithValue("@desa", desaTxt.Text);
            cmd.Parameters.AddWithValue("@kecamatan", kecamatanTxt.Text);
            cmd.Parameters.AddWithValue("@kota_madya", kotaTxt.Text);
            cmd.Parameters.AddWithValue("@kode_pos", double.Parse(posTxt.Text));
            cmd.Parameters.AddWithValue("@status_wali", statusTxt.Text);
            cmd.Parameters.AddWithValue("@NISN", nisnmuridTXT.Text);

            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("Data Berhasil Di Ubah!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Wali_Murid wm = new Wali_Murid();
            wm.Show();
        }

        private void cbxNISN_SelectedIndexChanged(object sender, EventArgs e)
        {
            koneksi.Open();
            string strs = "select NISN from dbo.Siswa where Nama_Siswa = @Nama_Siswa";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            string selectedName = cbxNISN.SelectedItem.ToString();
            cm.Parameters.AddWithValue("@Nama_Siswa", selectedName);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                string nisn = dr.GetString(0);
                nisnmuridTXT.Text = nisn;
            }
            else
            {
                nisnmuridTXT.Text = "";
            }

            dr.Close();
            koneksi.Close();
        }
    }
}
