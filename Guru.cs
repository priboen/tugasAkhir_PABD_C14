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
    public partial class Guru : Form
    {
        public Guru()
        {
            InitializeComponent();
        }

        private void Guru_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tugasAkhirDataSet3.guru' table. You can move, or remove it, as needed.
            this.guruTableAdapter.Fill(this.tugasAkhirDataSet3.guru);

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForm mf = new MenuForm();
            mf.Show();
        }

        private void delGuru_Click(object sender, EventArgs e)
        {
            delete_guru dg = new delete_guru();
            dg.Show();
            this.Close();
        }

        private void guruFormBtn_Click(object sender, EventArgs e)
        {
            add_guru ag = new add_guru();
            ag.Show();
            this.Close();
        }
    }
}
