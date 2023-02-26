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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            if (TXT_Id.Text != "" && TXT_Bname.Text != "" && TXT_Bauthor.Text != "" && TXT_Qty.Text != "" && TXT_Price.Text != "")
            {
                String bId, bName, bAuthor, bPub;
                DateTime bPd;
                double bQty, bprice;

                bId = TXT_Id.Text;
                bName = TXT_Bname.Text;
                bAuthor = TXT_Bauthor.Text;
                bPub = TXT_Publ.Text;
                bPd = dateTimePicker_Date.Value;
                bQty = Convert.ToDouble(TXT_Qty.Text);
                bprice = Convert.ToDouble(TXT_Price.Text);

                con.Open();

                cmd = new SqlCommand("insert into Book values(@a,@b,@c,@d,@e,@f,@g)", con);

                cmd.Parameters.AddWithValue("a", bId);
                cmd.Parameters.AddWithValue("b", bName);
                cmd.Parameters.AddWithValue("c", bAuthor);
                cmd.Parameters.AddWithValue("d", bPub);
                cmd.Parameters.AddWithValue("e", bPd);
                cmd.Parameters.AddWithValue("f", bQty);
                cmd.Parameters.AddWithValue("g", bprice);

                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Book Added Successfully!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXT_Id.Clear();
                    TXT_Bname.Clear();
                    TXT_Bauthor.Clear();
                    TXT_Publ.Clear();
                    TXT_Qty.Clear();
                    TXT_Price.Clear();
                }


            }
            else
            {
                MessageBox.Show("Please Fill All Details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            con.Close();



        } 

        private void AddBook_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-ONE9JG64;Initial Catalog=BookLibrary;Integrated Security=True");
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All Data Will Be Deleted! ", "Are You Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
