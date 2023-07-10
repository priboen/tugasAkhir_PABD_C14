using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasAkhir
{
    public partial class mata_pelajaran : Form
    {
        public mata_pelajaran()
        {
            InitializeComponent();
        }

        private void mata_pelajaran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tugasAkhirDataSet4.mata_pelajaran' table. You can move, or remove it, as needed.
            this.mata_pelajaranTableAdapter.Fill(this.tugasAkhirDataSet4.mata_pelajaran);

        }

        private void matapelFormBtn_Click(object sender, EventArgs e)
        {
            addMataPel amp = new addMataPel();
            amp.Show();
            this.Close();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForm mf = new MenuForm();
            mf.Show();
        }

        private void delMataPel_Click(object sender, EventArgs e)
        {
            hapus_mapel hm = new hapus_mapel();
            hm.Show();
            this.Close();
        }
    }
}
