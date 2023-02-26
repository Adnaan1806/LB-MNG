using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    public partial class Dashboard1 : Form
    {
        public Dashboard1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook a = new AddBook();
            a.Show();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook v = new ViewBook();
            v.Show();
        }

        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Member m = new Add_Member();
            m.Show();
        }

        private void viewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMember v = new ViewMember();
            v.Show();
        }
    }
}
