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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (staff_TU stu = new staff_TU())
            {
                stu.ShowDialog();
                this.Hide();
            }
        }

        private void clsbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (siswa sw = new siswa()) {
                sw.ShowDialog();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guru gr = new Guru();
            gr.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mata_pelajaran mp = new mata_pelajaran();
            mp.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Wali_Murid wm = new Wali_Murid();
            wm.Show();
            this.Close();
        }

        

        private void nilaisiswaBtn_Click(object sender, EventArgs e)
        {
            nilaisiswa ns = new nilaisiswa();
            ns.Show();
            this.Close();
        }

        private void jadpelbtn_Click(object sender, EventArgs e)
        {
            jadpel jp = new jadpel();
            jp.Show();
            this.Close();
        }
    }
}
