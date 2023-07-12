using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace tugasAkhir
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=PRIBOEN\PRIBOEN;Initial Catalog=tugasAkhir;User ID=sa;Password=05012003");

        private void logButton_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = usernameTxt.Text;
            user_password = passwordTxt.Text;

            try
            {
                String querry = "SELECT * FROM Login_new WHERE username = '" + usernameTxt.Text + "' AND  password = '" + passwordTxt.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry,conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count > 0 )
                {
                    username = usernameTxt.Text;
                    user_password = passwordTxt.Text;

                    MenuForm mf = new MenuForm();
                    mf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Gagal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTxt.Clear();
                    passwordTxt.Clear();

                    usernameTxt.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Clearlabel_Click(object sender, EventArgs e)
        {
            usernameTxt.Clear();
            passwordTxt.Clear();

            usernameTxt.Focus();
        }

        private void Exitlabel_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Apakah anda ingin keluar?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            sendcode sc = new sendcode();
            this.Hide();
            sc.Show();
        }
    }
}