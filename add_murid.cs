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
    public partial class add_murid : Form
    {
        private string stringConnection = "data source=PRIBOEN\\PRIBOEN;" + "database=tugasAkhir; User ID=sa;Password=05012003";
        private SqlConnection koneksi;
        public add_murid()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            cbNamaTU();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            siswa sw = new siswa();
            sw.Show();
        }
        private void refreshform()
        {
            siswa sw = new siswa();
            sw.Show();
            this.Close();
        }

        private void cbNamaTU()
        {

            koneksi.Open();
            string str = "SELECT nama_TU FROM Staff_TU";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataReader dr = cmd.ExecuteReader();
            DataSet ds = new DataSet();
            while (dr.Read())
            {
               cbxTU.Items.Add(dr.GetString(0));
            }
            dr.Close();
            koneksi.Close();

        }

        private void cbxTU_SelectedIndexChanged(object sender, EventArgs e)
        {
            koneksi.Open();
            string strs = "select NIP from dbo.Staff_TU where nama_TU = @nama_TU";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            string selectedName = cbxTU.SelectedItem.ToString();
            cm.Parameters.AddWithValue("@nama_TU", selectedName);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                string nip = dr.GetString(0);
                NIPtxt.Text = nip;
            }
            else
            {
                NIPtxt.Text = "";
            }

            dr.Close();
            koneksi.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (NISNtxt.Text == "")
            {
                MessageBox.Show("NISN TIDAK BOLEH KOSONG!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi = new SqlConnection(stringConnection);
                koneksi.Open();
                SqlCommand cmd = new SqlCommand("insert into Siswa values(@NISN, @Nama_Siswa, @jenis_kel, @tgl_lahir, @jalan, @desa, @kecamatan, @kota_madya, @kode_pos, @nohp_ortu, @NIP)", koneksi);
                cmd.Parameters.AddWithValue("@NISN", NISNtxt.Text);
                cmd.Parameters.AddWithValue("@Nama_Siswa", namaSiswatxt.Text);
                cmd.Parameters.AddWithValue("@jenis_kel", cbxJenisKelamin.Text);
                cmd.Parameters.AddWithValue("@tgl_lahir", dtTglLahir.Text);
                cmd.Parameters.AddWithValue("@jalan", Jalantxt.Text);
                cmd.Parameters.AddWithValue("@desa", desatxt.Text);
                cmd.Parameters.AddWithValue("@kecamatan", kecamatantxt.Text);
                cmd.Parameters.AddWithValue("@kota_madya", kotatxt.Text);
                cmd.Parameters.AddWithValue("@kode_pos", double.Parse(postxt.Text));
                cmd.Parameters.AddWithValue("@nohp_ortu", hptxt.Text);
                cmd.Parameters.AddWithValue("@NIP", NIPtxt.Text);

                cmd.ExecuteNonQuery();
                koneksi.Close();

                MessageBox.Show("Data Berhasil Di Simpan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshform();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = new SqlCommand("update Siswa set Nama_Siswa = @Nama_Siswa, jenis_kel = @jenis_kel, tgl_lahir = @tgl_lahir, jalan = @jalan, desa = @desa, kecamatan = @kecamatan, kota_madya = @kota_madya, kode_pos = @kode_pos, nohp_ortu = @nohp_ortu, NIP = @NIP where NISN = @NISN", koneksi);
            cmd.Parameters.AddWithValue("@NISN", NISNtxt.Text);
            cmd.Parameters.AddWithValue("@Nama_Siswa", namaSiswatxt.Text);
            cmd.Parameters.AddWithValue("@jenis_kel", cbxJenisKelamin.Text);
            cmd.Parameters.AddWithValue("@tgl_lahir", dtTglLahir.Text);
            cmd.Parameters.AddWithValue("@jalan", Jalantxt.Text);
            cmd.Parameters.AddWithValue("@desa", desatxt.Text);
            cmd.Parameters.AddWithValue("@kecamatan", kecamatantxt.Text);
            cmd.Parameters.AddWithValue("@kota_madya", kotatxt.Text);
            cmd.Parameters.AddWithValue("@kode_pos", double.Parse(postxt.Text));
            cmd.Parameters.AddWithValue("@nohp_ortu", hptxt.Text);
            cmd.Parameters.AddWithValue("@NIP", NIPtxt.Text);

            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("Data Berhasil Di Ubah!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();
        }

    }
}
