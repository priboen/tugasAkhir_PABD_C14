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
    }
}
