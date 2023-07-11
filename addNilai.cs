using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasAkhir
{
    public partial class addNilai : Form
    {
        private string stringConnection = "data source=PRIBOEN\\PRIBOEN;" + "database=tugasAkhir; User ID=sa;Password=05012003";
        private SqlConnection koneksi;
        double val;
        public addNilai()
        {
            InitializeComponent();
            autoID();
            cbSiswa();
            cbMapel();
        }
        private void refreshform()
        {
            nilaisiswa ns = new nilaisiswa();
            ns.Show();
            this.Close();
        }
        private void autoID()
        {
            koneksi = new SqlConnection(stringConnection);
            koneksi.Open();
            SqlCommand cmd = new SqlCommand("Select count (id_nilai) from dbo.nilai", koneksi);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            koneksi.Close();
            i++;
            idNilai.Text = "NIL" + val + i.ToString();
        }
        private void cbSiswa()
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
        private void cbMapel()
        {
            koneksi.Open();
            string str = "SELECT nama_mapel FROM mata_pelajaran";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataReader dr = cmd.ExecuteReader();
            DataSet ds = new DataSet();
            while (dr.Read())
            {
                cbxMapel.Items.Add(dr.GetString(0));
            }
            dr.Close();
            koneksi.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            
            if (cbxNISN.Text == "")
            {
                MessageBox.Show("NISN Siswa TIDAK BOLEH KOSONG!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(stringConnection);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into nilai values(@id_nilai, @NISN, @nilai, @id_mapel)", con);
                cmd.Parameters.AddWithValue("@id_nilai", idNilai.Text);
                cmd.Parameters.AddWithValue("@NISN", NISNlabel.Text);
                cmd.Parameters.AddWithValue("@nilai", txtNilaiSiswa.Text);
                cmd.Parameters.AddWithValue("@id_mapel", idMapel.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Berhasil Di Simpan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshform();

            }
        }

        private void cbxMapel_SelectedIndexChanged(object sender, EventArgs e)
        {
            koneksi.Open();
            string strs = "select id_mapel from dbo.mata_pelajaran where nama_mapel = @nama_mapel";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            string selectedName = cbxMapel.SelectedItem.ToString();
            cm.Parameters.AddWithValue("@nama_mapel", selectedName);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                string nip = dr.GetString(0);
                idMapel.Text = nip;
            }
            else
            {
                idMapel.Text = "";
            }

            dr.Close();
            koneksi.Close();
        }

        private void cbxNISN_SelectedIndexChanged(object sender, EventArgs e)
        {
            koneksi.Open();
            string strs = "select NISN from dbo.Siswa where nama_siswa = @nama_siswa";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            string selectedName = cbxNISN.SelectedItem.ToString();
            cm.Parameters.AddWithValue("@nama_siswa", selectedName);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                string nip = dr.GetString(0);
                NISNlabel.Text = nip;
            }
            else
            {
                NISNlabel.Text = "";
            }

            dr.Close();
            koneksi.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            txtNilaiSiswa.Text = "";

        }
    }
}
