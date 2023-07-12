using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace tugasAkhir
{
    public partial class sendcode : Form
    {
        string OTPCode;
        public static string to;
        public sendcode()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            OTPCode=(rand.Next(999999)).ToString();
            to = (txtEmail.Text).ToString();

        }
    }
}
