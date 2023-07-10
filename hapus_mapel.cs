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
    public partial class hapus_mapel : Form
    {
        private string stringConnection = "data source=PRIBOEN\\PRIBOEN;" + "database=tugasAkhir; User ID=sa;Password=05012003";
        private SqlConnection koneksi;
        public hapus_mapel()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            cbNamaPel();
        }
        private void cbNamaPel()
        {

            koneksi.Open();
            string str = "SELECT nama_mapel FROM mata_pelajaran";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataReader dr = cmd.ExecuteReader();
            DataSet ds = new DataSet();
            while (dr.Read())
            {
                cbxNamaPel.Items.Add(dr.GetString(0));
            }
            dr.Close();
            koneksi.Close();

        }

        private void cbxNamaPel_SelectedIndexChanged(object sender, EventArgs e)
        {
            koneksi.Open();
            string strs = "select id_mapel from dbo.mata_pelajaran where nama_mapel = @nama_mapel";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            string selectedName = cbxNamaPel.SelectedItem.ToString();
            cm.Parameters.AddWithValue("@nama_mapel", selectedName);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                string idmp = dr.GetString(0);
                txtID.Text = idmp;
            }
            else
            {
                txtID.Text = "";
            }

            dr.Close();
            koneksi.Close();
        }

        private void clsbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            mata_pelajaran mp = new mata_pelajaran();
            mp.Show();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = new SqlCommand("delete mata_pelajaran where id_mapel=@id_mapel", koneksi);
            cmd.Parameters.AddWithValue("@id_mapel", txtID.Text);
            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("Data Berhasil Di Hapus!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            mata_pelajaran mp = new mata_pelajaran();
            mp.Show();
        }
    }
}
