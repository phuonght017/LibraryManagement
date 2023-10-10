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
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
        }

        private void availableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (availableCheckBox.Checked && OutCheckBox.Checked)
            {
                OutCheckBox.Checked = false;
            }

            // filtering ...
        }

        private void OutCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (OutCheckBox.Checked && availableCheckBox.Checked)
            {
                availableCheckBox.Checked = false;
            }

            // filtering ...
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            AddBook f = new AddBook();
            f.ShowDialog();
        }
    }
}
