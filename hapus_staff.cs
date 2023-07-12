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
    public partial class hapus_staff : Form
    {
        private string stringConnection = "data source=PRIBOEN\\PRIBOEN;" + "database=tugasAkhir; User ID=sa;Password=05012003";
        private SqlConnection koneksi;
        public hapus_staff()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            cbNamaTU();
        }

        private void clsbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MenuForm mf = new MenuForm();
            mf.ShowDialog();
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
                cbxNamaTU.Items.Add(dr.GetString(0));
            }
            dr.Close();
            koneksi.Close();

        }

        private void cbxNamaTU_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            koneksi.Open();
            string strs = "select NIP from dbo.Staff_TU where nama_TU = @nama_TU";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            string selectedName = cbxNamaTU.SelectedItem.ToString();
            cm.Parameters.AddWithValue("@nama_TU", selectedName);
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
            SqlCommand cmd = new SqlCommand("delete Staff_TU where NIP=@NIP",koneksi);
            cmd.Parameters.AddWithValue("@NIP", txtNIP.Text);
            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("Data Berhasil Di Hapus!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            staff_TU stu = new staff_TU();
            stu.Show();
        }
    }
}
