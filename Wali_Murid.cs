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
    public partial class Wali_Murid : Form
    {
        public Wali_Murid()
        {
            InitializeComponent();
        }

        private void Wali_Murid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tugasAkhirDataSet6.wali_murid' table. You can move, or remove it, as needed.
            this.wali_muridTableAdapter1.Fill(this.tugasAkhirDataSet6.wali_murid);

        }

        private void add_updateBtn_Click(object sender, EventArgs e)
        {
            addWali aw = new addWali();
            aw.Show();
            this.Hide();
        }

        private void delwaliBtn_Click(object sender, EventArgs e)
        {
            delWali delw = new delWali();
            delw.Show();
            this.Hide();
        }

        private void clsbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForm mf = new MenuForm();
            mf.Show();
        }
    }
}
