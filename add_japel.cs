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
    public partial class add_japel : Form
    {
        
        private string stringConnection = "data source=PRIBOEN\\PRIBOEN;" + "database=tugasAkhir; User ID=sa;Password=05012003";
        private SqlConnection koneksi;
        private SqlConnection conn;
        public add_japel()
        {
            InitializeComponent();
            cbNamaMapel();
            cbNamaGuru();
        }
        private void refreshform()
        {
            jadpel jp = new jadpel();
            jp.Show();
            this.Close();
        }
        private void cbNamaGuru()
        {
            conn = new SqlConnection(stringConnection);
            conn.Open();
            string str = "SELECT nama_guru FROM guru";
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataSet ds = new DataSet();
            while (dr.Read())
            {
                cbxGuru.Items.Add(dr.GetString(0));
            }
            dr.Close();
            conn.Close();
        }
        private void cbNamaMapel()
        {
            koneksi = new SqlConnection(stringConnection);
            koneksi.Open();
            string strs = "SELECT nama_mapel FROM mata_pelajaran";
            SqlCommand cmde = new SqlCommand(strs, koneksi);
            SqlDataReader drr = cmde.ExecuteReader();
            DataSet dst = new DataSet();
            while (drr.Read())
            {
                cbxNamaMapel.Items.Add(drr.GetString(0));
            }
            drr.Close();
            koneksi.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (IdJPTXT.Text == "")
            {
                MessageBox.Show("ID Jadwal Pelajaran TIDAK BOLEH KOSONG!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi = new SqlConnection(stringConnection);
                koneksi.Open();
                SqlCommand cmd = new SqlCommand("insert into jadwal_pelajaran values(@id_jadwal, @nama_mapel, @id_mapel, @tingkat_pelajaran, @hari, @jam, @NIP)", koneksi);
                cmd.Parameters.AddWithValue("@id_jadwal", IdJPTXT.Text);
                cmd.Parameters.AddWithValue("@nama_mapel", cbxNamaMapel.Text);
                cmd.Parameters.AddWithValue("@id_mapel", idMapel.Text);
                cmd.Parameters.AddWithValue("@tingkat_pelajaran", cbxKelas.Text);
                cmd.Parameters.AddWithValue("@hari", cbxHari.Text);
                cmd.Parameters.AddWithValue("@jam", jamtxt.Text);
                cmd.Parameters.AddWithValue("@NIP", NIPtxt.Text);

                cmd.ExecuteNonQuery();
                koneksi.Close();

                MessageBox.Show("Data Berhasil Di Simpan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshform();
            }
        }
        private void cbxNamaMapel_SelectedIndexChanged(object sender, EventArgs e)
        {
            koneksi = new SqlConnection(stringConnection);
            koneksi.Open();
            string strs = "select id_mapel from dbo.mata_pelajaran where nama_mapel = @nama_mapel";
            SqlCommand cmde = new SqlCommand(strs, koneksi);
            string selectedMapel= cbxNamaMapel.SelectedItem.ToString();
            cmde.Parameters.AddWithValue("@nama_mapel", selectedMapel);
            SqlDataReader drr = cmde.ExecuteReader();
            if (drr.Read())
            {
                string idMp = drr.GetString(0);
                idMapel.Text = idMp;
            }
            else
            {
                idMapel.Text = "";
            }

            drr.Close();
            koneksi.Close();
        }

        private void cbxGuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            koneksi = new SqlConnection(stringConnection);
            koneksi.Open();
            string str = "select NIP from dbo.guru where nama_guru = @nama_guru";
            SqlCommand cm = new SqlCommand(str, koneksi);
            string selectedName = cbxGuru.SelectedItem.ToString();
            cm.Parameters.AddWithValue("@nama_guru", selectedName);
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            koneksi = new SqlConnection(stringConnection);
            koneksi.Open();
            SqlCommand cmd = new SqlCommand("update jadwal_pelajaran set nama_mapel = @nama_mapel, id_mapel = @id_mapel, tingkat_pelajaran = @tingkat_pelajaran, hari = @hari, jam = @jam, NIP = @NIP where id_jadwal = @id_jadwal", koneksi);
            cmd.Parameters.AddWithValue("@id_jadwal", IdJPTXT.Text);
            cmd.Parameters.AddWithValue("@nama_mapel", cbxNamaMapel.Text);
            cmd.Parameters.AddWithValue("@id_mapel", idMapel.Text);
            cmd.Parameters.AddWithValue("@tingkat_pelajaran", cbxKelas.Text);
            cmd.Parameters.AddWithValue("@hari", cbxHari.Text);
            cmd.Parameters.AddWithValue("@jam", jamtxt.Text);
            cmd.Parameters.AddWithValue("@NIP", NIPtxt.Text);

            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("Data Berhasil Di Ubah!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void add_japel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tugasAkhirDataSet9.guru' table. You can move, or remove it, as needed.
            this.guruTableAdapter.Fill(this.tugasAkhirDataSet9.guru);

        }
    }
}
