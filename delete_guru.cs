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
    public partial class delete_guru : Form
    {
        private string stringConnection = "data source=PRIBOEN\\PRIBOEN;" + "database=tugasAkhir; User ID=sa;Password=05012003";
        private SqlConnection koneksi;
        public delete_guru()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            cbNamaGuru();
        }
        private void cbNamaGuru()
        {

            koneksi.Open();
            string str = "SELECT nama_guru FROM guru";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataReader dr = cmd.ExecuteReader();
            DataSet ds = new DataSet();
            while (dr.Read())
            {
                cbxNamaGuru.Items.Add(dr.GetString(0));
            }
            dr.Close();
            koneksi.Close();

        }

        private void clsbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Guru gr = new Guru();
            gr.Show();
        }

        private void cbxNamaGuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            koneksi.Open();
            string strs = "select NIP from dbo.guru where nama_guru = @nama_guru";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            string selectedName = cbxNamaGuru.SelectedItem.ToString();
            cm.Parameters.AddWithValue("@nama_guru", selectedName);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                string nip = dr.GetString(0);
                txtNIP.Text = nip;
            }
            else
            {
                txtNIP.Text = "";
            }

            dr.Close();
            koneksi.Close();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = new SqlCommand("delete guru where NIP=@NIP", koneksi);
            cmd.Parameters.AddWithValue("@NIP", txtNIP.Text);
            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("Data Berhasil Di Hapus!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Guru gr = new Guru();
            gr.Show();
        }
    }
}
