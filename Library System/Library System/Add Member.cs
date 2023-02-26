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
    public partial class Add_Member : Form
    {
        public Add_Member()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm?","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
              
        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            TXT_id.Clear();
            TXT_Name.Clear();
            TXT_Contact.Clear();
            TXT_Email.Clear();
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            if (TXT_id.Text != "" && TXT_Name.Text != "" && TXT_Contact.Text != "" && TXT_Email.Text != "")
            {

            String ID = TXT_id.Text;
            String name = TXT_Name.Text;
            String mobile = TXT_Contact.Text;
            String email = TXT_Email.Text;


            con.Open();

            cmd = new SqlCommand("insert into AddMember values(@a,@b,@c,@d)", con);

            cmd.Parameters.AddWithValue("a", ID);
            cmd.Parameters.AddWithValue("b", name);
            cmd.Parameters.AddWithValue("c", mobile);
            cmd.Parameters.AddWithValue("d", email);

                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Book Added Successfully!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXT_id.Clear();
                    TXT_Name.Clear();
                    TXT_Contact.Clear();
                    TXT_Email.Clear();
                   
                }


            }
            else
            {
                MessageBox.Show("Please Fill All Details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            con.Close();



        }

        private void Add_Member_Load(object sender, EventArgs e)
        {
             con = new SqlConnection("Data Source=LAPTOP-ONE9JG64;Initial Catalog=BookLibrary;Integrated Security=True");
        }
    }
}
