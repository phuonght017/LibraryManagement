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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (EditBtn.Text == "Edit")
            {
                EditBtn.Text = "Save";
                // text boxes are editable
                managerIDBox.ReadOnly = false;
                emailBox.ReadOnly = false;
                nameBox.ReadOnly = false;
                genderBox.ReadOnly = false;
                phoneNumberBox.ReadOnly = false;
                addressBox.ReadOnly = false;
                // text fore color is changed
                managerIDBox.ForeColor = Color.Gray;
                emailBox.ForeColor = Color.Gray;
                nameBox.ForeColor = Color.Gray;
                genderBox.ForeColor = Color.Gray;
                phoneNumberBox.ForeColor = Color.Gray;
                addressBox.ForeColor = Color.Gray;
            }
            else
            {
                EditBtn.Text = "Edit";
                // text boxes cannot be edited
                managerIDBox.ReadOnly = true;
                emailBox.ReadOnly = true;
                nameBox.ReadOnly = true;
                genderBox.ReadOnly = true;
                phoneNumberBox.ReadOnly = true;
                addressBox.ReadOnly = true;
                // text forecolor is changed
                managerIDBox.ForeColor = Color.Black;
                emailBox.ForeColor = Color.Black;
                nameBox.ForeColor = Color.Black;
                genderBox.ForeColor = Color.Black;
                phoneNumberBox.ForeColor = Color.Black;
                addressBox.ForeColor = Color.Black;
                // update to db
            }
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            ChangePasswordForm f = new ChangePasswordForm();
            f.ShowDialog();
        }
    }
}
