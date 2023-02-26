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
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-ONE9JG64;Initial Catalog=BookLibrary;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Book";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        int bid;
       Int64 rowId;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-ONE9JG64;Initial Catalog=BookLibrary;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Book where b_Id = " + bid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);

            rowId = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            TXT_name.Text = ds.Tables[0].Rows[0][1].ToString();
            TXT_author.Text = ds.Tables[0].Rows[0][2].ToString();
            TXT_publ.Text = ds.Tables[0].Rows[0][3].ToString();
            TXT_date.Text = ds.Tables[0].Rows[0][4].ToString();
            TXT_qty.Text = ds.Tables[0].Rows[0][5].ToString();
            TXT_price.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void BTN_cancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void TXT_bookName_TextChanged(object sender, EventArgs e)
        {
            if (TXT_bookName.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-ONE9JG64;Initial Catalog=BookLibrary;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Book where b_Name LIKE '"+TXT_bookName.Text+"%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-ONE9JG64;Initial Catalog=BookLibrary;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Book";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void BTN_Refresh_Click(object sender, EventArgs e)
        {
            TXT_bookName.Clear();
            panel2.Visible = false;
        }

        private void BTN_update_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Data Will Be Updated, Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String bName, bAuthor, bPub, bPd; ;
                double bQty, bprice;

                bName = TXT_name.Text;
                bAuthor = TXT_author.Text;
                bPub = TXT_publ.Text;
                bPd = TXT_date.Text;
                bQty = Convert.ToDouble(TXT_qty.Text);
                bprice = Convert.ToDouble(TXT_price.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-ONE9JG64;Initial Catalog=BookLibrary;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update Book set b_Name = '" + bName + "',b_Author = '" + bAuthor + "',b_Pub = '" + bPub + "',b_Pdate = '" + bPd + "',b_quantity = " + bQty + ",b_Price = " + bprice + " where b_Id = " + rowId + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);
            }

            

            
        }

        private void BTN_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Deleted, Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-ONE9JG64;Initial Catalog=BookLibrary;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from Book where b_Id = "+rowId+"";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);

            }
        }
    }
}
