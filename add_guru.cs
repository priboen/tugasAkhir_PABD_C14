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
    public partial class add_guru : Form
    {
        private string stringConnection = "data source=PRIBOEN\\PRIBOEN;" + "database=tugasAkhir; User ID=sa;Password=05012003";
        private SqlConnection koneksi;
        public add_guru()
        {
            InitializeComponent();
        }

        private void refreshform()
        {
            Guru gr = new Guru();
            gr.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Guru gr = new Guru();
            gr.Show();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (NIPtxt.Text == "")
            {
                MessageBox.Show("NIP TIDAK BOLEH KOSONG!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(stringConnection);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into guru values(@NIP, @nama_guru, @jenis_kel, @nohp_guru, @jalan, @desa, @kecamatan, @kota_madya, @kode_pos)", con);
                cmd.Parameters.AddWithValue("@NIP", NIPtxt.Text);
                cmd.Parameters.AddWithValue("@nama_guru", namatxt.Text);
                cmd.Parameters.AddWithValue("@jenis_kel", cbxJenisKelamin.Text);
                cmd.Parameters.AddWithValue("@nohp_guru", hptxt.Text);
                cmd.Parameters.AddWithValue("@jalan", jalantxt.Text);
                cmd.Parameters.AddWithValue("@desa", desatxt.Text);
                cmd.Parameters.AddWithValue("@kecamatan", kectxt.Text);
                cmd.Parameters.AddWithValue("@kota_madya", kotatxt.Text);
                cmd.Parameters.AddWithValue("@kode_pos", double.Parse(postxt.Text));

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
            SqlCommand cmd = new SqlCommand("update guru set nama_guru=@nama_guru, nohp_guru=@nohp_guru, jalan=@jalan, desa=@desa, kecamatan=@kecamatan, kota_madya=@kota_madya, kode_pos=@kode_pos where NIP=@NIP", koneksi);
            cmd.Parameters.AddWithValue("@NIP", NIPtxt.Text);
            cmd.Parameters.AddWithValue("@nama_guru", namatxt.Text);
            cmd.Parameters.AddWithValue("@nohp_guru", hptxt.Text);
            cmd.Parameters.AddWithValue("@jalan", jalantxt.Text);
            cmd.Parameters.AddWithValue("@desa", desatxt.Text);
            cmd.Parameters.AddWithValue("@kecamatan", kectxt.Text);
            cmd.Parameters.AddWithValue("@kota_madya", kotatxt.Text);
            cmd.Parameters.AddWithValue("@kode_pos", double.Parse(postxt.Text));

            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("Data Berhasil Di Ubah!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            NIPtxt.Text = "";
            namatxt.Text = "";
            hptxt.Text = "";
            jalantxt.Text = "";
            desatxt.Text = "";
            kectxt.Text = "";
            kotatxt.Text = "";
            postxt.Text = "";
            clearBtn.Enabled = false;
        }
    }
}
