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
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibraryManagement
{
    public partial class LoginForm : Form
    {
        public static string Manager_ID;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string email = EmailBox.Text;
            string password = PasswordBox.Text;
            bool authorized = false;
            
            SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from dbo.Manager",conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = dt.Rows[i];
                if (email == dr[6].ToString().Trim() && password  == dr[1].ToString().Trim())
                {
                    authorized = true;
                    Manager_ID = dr[0].ToString().Trim();
                    MenuForm f1 = new MenuForm();
                    f1.Show();
                    this.Hide();
                    break;
                }
            }
            if (!authorized) 
            {
                string message = "Your user name or password is incorrect. Please try again";
                string cap = "Error Detected in Login";
                DialogResult loginError = MessageBox.Show(message, cap);
            }
        }
    }
}

public static class MyGlobals
{
    public static string connectionStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ProjectCode\\CSharp\\GitClone\\LibraryManagement\\Lib-DB\\Database2.mdf;Integrated Security=True;Connect Timeout=30";
}
