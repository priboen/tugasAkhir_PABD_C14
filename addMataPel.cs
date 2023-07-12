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
    public partial class addMataPel : Form
    {
        private string stringConnection = "data source=PRIBOEN\\PRIBOEN;" + "database=tugasAkhir; User ID=sa;Password=05012003";
        private SqlConnection koneksi;
        public addMataPel()
        {
            InitializeComponent();
        }
        private void refreshform()
        {
            mata_pelajaran mp = new mata_pelajaran();
            mp.Show();
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (IDtxt.Text == "")
            {
                MessageBox.Show("ID Mata Pelajaran TIDAK BOLEH KOSONG!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(stringConnection);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into mata_pelajaran values(@id_mapel, @nama_mapel, @tingkat_kelas)", con);
                cmd.Parameters.AddWithValue("@id_mapel", IDtxt.Text);
                cmd.Parameters.AddWithValue("@nama_mapel", namapeltxt.Text);
                cmd.Parameters.AddWithValue("@tingkat_kelas", kelastxt.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Berhasil Di Simpan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshform();

            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            koneksi = new SqlConnection(stringConnection);
            koneksi.Open();
            SqlCommand cmd = new SqlCommand("update mata_pelajaran set nama_mapel=@nama_mapel, tingkat_kelas=@tingkat_kelas where id_mapel=@id_mapel", koneksi);
            cmd.Parameters.AddWithValue("@id_mapel", IDtxt.Text);
            cmd.Parameters.AddWithValue("@nama_mapel", namapeltxt.Text);
            cmd.Parameters.AddWithValue("@tingkat_kelas", kelastxt.Text);
            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("Data Berhasil Di Ubah!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            mata_pelajaran mpl = new mata_pelajaran();
            mpl.Show();
        }
    }
}
