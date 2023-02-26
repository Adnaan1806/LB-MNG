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

namespace Library_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                TXT_password.UseSystemPasswordChar = false;
            }
            else
            {
                TXT_password.UseSystemPasswordChar = true;
            }
        }

        private void BTN_login_Click(object sender, EventArgs e)
        {
            if (TXT_username.Text == "")
            {
                MessageBox.Show("Enter the Username");
            }
            else if (TXT_password.Text == "")
            {
                MessageBox.Show("Enter the Password");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=LAPTOP-ONE9JG64;Initial Catalog=LoginForm;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("select * from lg where username = @uname and password = @pass", con);

                    cmd.Parameters.AddWithValue("@uname", TXT_username.Text);
                    cmd.Parameters.AddWithValue("@pass", TXT_password.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        this.Hide();
                        Dashboard d = new Dashboard();
                        d.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is invalid");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }
    }
}
