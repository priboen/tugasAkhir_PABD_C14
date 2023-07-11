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
    public partial class nilaisiswa : Form
    {
        public nilaisiswa()
        {
            InitializeComponent();
        }

        private void nilaisiswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tugasAkhirDataSet7.nilai' table. You can move, or remove it, as needed.
            this.nilaiTableAdapter.Fill(this.tugasAkhirDataSet7.nilai);

        }

        private void addnilaiBtn_Click(object sender, EventArgs e)
        {
            addNilai an = new addNilai();
            an.Show();
            this.Close();
        }

        private void delnilaiBtn_Click(object sender, EventArgs e)
        {
            deletelNilai dn = new deletelNilai(); 
            dn.Show();
            this.Close();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForm mf = new MenuForm();
            mf.Show();
        }
    }
}
