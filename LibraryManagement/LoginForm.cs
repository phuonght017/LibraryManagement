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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (EmailBox.Text == "user123" && PasswordBox.Text == "123456")
            {
                MenuForm f1 = new MenuForm();
                f1.Show();
                this.Hide();
            }
            else
            {
                string message = "Your user name or password is incorrect. Please try again";
                string cap = "Error Detected in Login";
                DialogResult loginError = MessageBox.Show(message, cap);
            }
        }
    }
}
