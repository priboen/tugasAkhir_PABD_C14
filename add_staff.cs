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
    public partial class add_staff : Form
    {
        private string stringConnection = "data source=PRIBOEN\\PRIBOEN;" + "database=tugasAkhir; User ID=sa;Password=05012003";
        private SqlConnection koneksi;
        public add_staff()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            staff_TU stu = new staff_TU();
            stu.Show();
        }

        private void clearform()
        {
            NIPtxt.Text = "";
            namaTUtxt.Text = "";
            hpTUtxt.Text = "";
            emailTUtxt.Text = "";
            jalanTUtxt.Text = "";
            desaTUtxt.Text = "";
            kecamatanTUtxt.Text ="";
            kotaTUtxt.Text = "";
            kodeposTUtxt.Text = "";
            clearbtn.Enabled = false;
        }

        private void refreshform()
        {
            staff_TU tu = new staff_TU();
            tu.Show();
            this.Close();
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            clearform();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (NIPtxt.Text == "")
            {
                MessageBox.Show("NIP TIDAK BOLEH KOSONG!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(stringConnection);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Staff_TU values(@NIP, @nama_TU, @nohp_TU, @email, @jalan, @desa, @kecamatan, @kota_madya, @kode_pos)", con);
                cmd.Parameters.AddWithValue("@NIP", NIPtxt.Text);
                cmd.Parameters.AddWithValue("@nama_TU", namaTUtxt.Text);
                cmd.Parameters.AddWithValue("@nohp_TU", hpTUtxt.Text);
                cmd.Parameters.AddWithValue("@email", emailTUtxt.Text);
                cmd.Parameters.AddWithValue("@jalan", jalanTUtxt.Text);
                cmd.Parameters.AddWithValue("@desa", desaTUtxt.Text);
                cmd.Parameters.AddWithValue("@kecamatan", kecamatanTUtxt.Text);
                cmd.Parameters.AddWithValue("@kota_madya", kotaTUtxt.Text);
                cmd.Parameters.AddWithValue("@kode_pos", double.Parse(kodeposTUtxt.Text));

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Berhasil Di Simpan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshform();
                
            }
            
        }

        private void ubahbtn_Click(object sender, EventArgs e)
        {
            koneksi = new SqlConnection(stringConnection);
            koneksi.Open();
            SqlCommand cmd = new SqlCommand("update Staff_TU set nama_TU = @nama_TU, nohp_TU=@nohp_TU, email=@email, jalan=@jalan, desa=@desa, kecamatan=@kecamatan, kota_madya=@kota_madya, kode_pos=@kode_pos where NIP=@NIP", koneksi);
            cmd.Parameters.AddWithValue("@NIP", NIPtxt.Text);
            cmd.Parameters.AddWithValue("@nama_TU", namaTUtxt.Text);
            cmd.Parameters.AddWithValue("@nohp_TU", hpTUtxt.Text);
            cmd.Parameters.AddWithValue("@email", emailTUtxt.Text);
            cmd.Parameters.AddWithValue("@jalan", jalanTUtxt.Text);
            cmd.Parameters.AddWithValue("@desa", desaTUtxt.Text);
            cmd.Parameters.AddWithValue("@kecamatan", kecamatanTUtxt.Text);
            cmd.Parameters.AddWithValue("@kota_madya", kotaTUtxt.Text);
            cmd.Parameters.AddWithValue("@kode_pos", double.Parse(kodeposTUtxt.Text));

            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("Data Berhasil Di Ubah!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();
        }
    }
}
