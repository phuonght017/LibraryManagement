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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from dbo.Manager where [Manager ID] = @ID", conn);
            cmd.Parameters.AddWithValue("@ID", int.Parse(LoginForm.Manager_ID));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow dr = dt.Rows[0];
            managerIDBox.Text = dr[0].ToString();
            emailBox.Text = dr[6].ToString();
            nameBox.Text = dr[2].ToString();
            genderBox.Text = dr[4].ToString();
            phoneNumberBox.Text = dr[5].ToString();
            addressBox.Text = dr[7].ToString();
            conn.Close();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (EditBtn.Text == "EDIT")
            {
                EditBtn.Text = "SAVE";
                // text boxes are editable
                managerIDBox.Enabled = false;
                emailBox.Enabled = true;
                nameBox.Enabled = true;
                genderBox.Enabled = true;
                phoneNumberBox.Enabled = true;
                addressBox.Enabled = true;
                // text fore color is changed
                managerIDBox.ForeColor = Color.Black;
                emailBox.ForeColor = Color.Black;
                nameBox.ForeColor = Color.Black;
                genderBox.ForeColor = Color.Black;
                phoneNumberBox.ForeColor = Color.Black;
                addressBox.ForeColor = Color.Black;
            }
            else
            {
                EditBtn.Text = "EDIT";
                // text boxes cannot be edited
                managerIDBox.Enabled = false;
                emailBox.Enabled = false;
                nameBox.Enabled = false;
                genderBox.Enabled = false;
                phoneNumberBox.Enabled = false;
                addressBox.Enabled = false;
                // text forecolor is changed
                managerIDBox.ForeColor = Color.Gray;
                emailBox.ForeColor = Color.Gray;
                nameBox.ForeColor = Color.Gray;
                genderBox.ForeColor = Color.Gray;
                phoneNumberBox.ForeColor = Color.Gray;
                addressBox.ForeColor = Color.Gray;
                // update to db
                SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand("update dbo.Manager set Name = @Name, Email = @Email, Gender = @Gender, [Phone number] = @Phone_number, Address = @Address where [Manager ID] = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", int.Parse(LoginForm.Manager_ID));
                cmd.Parameters.AddWithValue("@Name", nameBox.Text);
                cmd.Parameters.AddWithValue("@Email", emailBox.Text);
                cmd.Parameters.AddWithValue("@Gender", genderBox.SelectedItem);
                cmd.Parameters.AddWithValue("@Phone_number", phoneNumberBox.Text);
                cmd.Parameters.AddWithValue("@Address", addressBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("changes saved !");
                conn.Close();
            }
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            ChangePasswordForm f = new ChangePasswordForm();
            f.ShowDialog();
        }
    }
}
