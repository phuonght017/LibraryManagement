using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void BooksBtn_Click(object sender, EventArgs e)
        {
            BooksForm f = new BooksForm();
            f.ShowDialog();
        }

        private void MembersBtn_Click(object sender, EventArgs e)
        {
            MembersForm f = new MembersForm();
            f.ShowDialog();
        }

        private void BorrowBtn_Click(object sender, EventArgs e)
        {
            BorrowForm f = new BorrowForm();
            f.ShowDialog();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            ReturnForm f = new ReturnForm();
            f.ShowDialog();
        }

        private void ManagerBtn_Click(object sender, EventArgs e)
        {
            ManagerForm f = new ManagerForm();
            f.ShowDialog();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
