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
    
    public partial class delete_jadpel : Form
    {
        private string stringConnection = "data source=PRIBOEN\\PRIBOEN;" + "database=tugasAkhir; User ID=sa;Password=05012003";
        private SqlConnection koneksi;
        public delete_jadpel()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            cbIDMapel();
        }
        private void cbIDMapel()
        {

            koneksi.Open();
            string str = "SELECT id_jadwal FROM jadwal_pelajaran";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataReader dr = cmd.ExecuteReader();
            DataSet ds = new DataSet();
            while (dr.Read())
            {
                cbxID.Items.Add(dr.GetString(0));
            }
            dr.Close();
            koneksi.Close();

        }

        private void clsbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            jadpel jp = new jadpel();
            jp.Show();

        }

        private void cbxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            koneksi.Open();
            string strs = "select id_jadwal from dbo.jadwal_pelajaran";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            string selectedName = cbxID.SelectedItem.ToString();
            cm.Parameters.AddWithValue("@id_jadwal", selectedName);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                string nip = dr.GetString(0);
                namaMP.Text = nip;
            }
            else
            {
                namaMP.Text = "";
            }

            dr.Close();
            koneksi.Close();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = new SqlCommand("delete jadwal_pelajaran where id_jadwal=@id_jadwal", koneksi);
            cmd.Parameters.AddWithValue("@id_jadwal", cbxID.Text);
            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("Data Berhasil Di Hapus!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            jadpel jp = new jadpel();
            jp.Show();
        }
    }
}
