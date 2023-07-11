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
    public partial class jadpel : Form
    {
        public jadpel()
        {
            InitializeComponent();
        }

        private void jadpel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tugasAkhirDataSet12.jadwal_pelajaran' table. You can move, or remove it, as needed.
            this.jadwal_pelajaranTableAdapter1.Fill(this.tugasAkhirDataSet12.jadwal_pelajaran);

        }

        private void jadpelBtn_Click(object sender, EventArgs e)
        {
            add_japel ajp =  new add_japel();
            ajp.Show();
            this.Close();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            MenuForm mf = new MenuForm();
            mf.Show();
            this.Close();
        }

        private void delMataPel_Click(object sender, EventArgs e)
        {
            delete_jadpel dj = new delete_jadpel();
            dj.Show();
            this.Close();
        }
    }
}
