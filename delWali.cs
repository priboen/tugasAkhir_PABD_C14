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
    public partial class delWali : Form
    {
        private string stringConnection = "data source=PRIBOEN\\PRIBOEN;" + "database=tugasAkhir; User ID=sa;Password=05012003";
        private SqlConnection koneksi;
        public delWali()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            cbNamaWali();
        }
        private void cbNamaWali()
        {

            koneksi.Open();
            string str = "SELECT nama_wali FROM wali_murid";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataReader dr = cmd.ExecuteReader();
            DataSet ds = new DataSet();
            while (dr.Read())
            {
                cbxNamaWali.Items.Add(dr.GetString(0));
            }
            dr.Close();
            koneksi.Close();

        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = new SqlCommand("delete wali_murid where NIK=@NIK", koneksi);
            cmd.Parameters.AddWithValue("@NIK", txtNIK.Text);
            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("Data Berhasil Di Hapus!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Wali_Murid wm = new Wali_Murid();
            wm.Show();
            this.Close();
        }

        private void cbxNamaWali_SelectedIndexChanged(object sender, EventArgs e)
        {
            koneksi.Open();
            string strs = "select NIK from dbo.wali_murid where nama_wali = @nama_wali";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            string selectedName = cbxNamaWali.SelectedItem.ToString();
            cm.Parameters.AddWithValue("@nama_wali", selectedName);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                string nip = dr.GetString(0);
                txtNIK.Text = nip;
            }
            else
            {
                txtNIK.Text = "";
            }

            dr.Close();
            koneksi.Close();
        }
    }
}
