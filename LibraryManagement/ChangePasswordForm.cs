using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // check curr password and compare new password then update to DB
            SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from dbo.Manager where [Manager ID] = @ID", conn);
            cmd.Parameters.AddWithValue("@ID", int.Parse(LoginForm.Manager_ID));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow dr = dt.Rows[0];
            if (currPassBox.Text == dr[1].ToString().Trim())
            {
                SqlCommand update = new SqlCommand("update dbo.Manager set Password = @New_Pass where [Manager ID] = @ID", conn);
                if (newPassBox.Text == confNewPassBox.Text)
                {
                    update.Parameters.AddWithValue("@ID", int.Parse(LoginForm.Manager_ID));
                    update.Parameters.AddWithValue("@New_pass", newPassBox.Text);
                    update.ExecuteNonQuery();
                }
                else
                {
                    string message = "confirmed password and new password is not matched. Please try again";
                    string cap = "Error confirming new password";
                    DialogResult loginError = MessageBox.Show(message, cap);
                }
                MessageBox.Show("changed saved !");
            }
            else
            {
                string message = "Incorrect password. Please try again";
                string cap = "Error confirming password";
                DialogResult loginError = MessageBox.Show(message, cap);
            }
            this.Close();
        }

        private void CancleBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
