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
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // save to db
            SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into dbo.Students values (@Name, @Age, @Gender, @Phone_number, @Email, @Membership_expiration_date)", conn);
            cmd.Parameters.AddWithValue("@Name", this.nameBox.Text);
            cmd.Parameters.AddWithValue("@Age", int.Parse(this.ageBox.Text));
            cmd.Parameters.AddWithValue("@Gender", this.genderBox.SelectedItem);
            cmd.Parameters.AddWithValue("@Phone_number", this.phoneBox.Text);
            cmd.Parameters.AddWithValue("@Email", this.emailBox.Text);
            cmd.Parameters.AddWithValue("@Membership_expiration_date", this.expirationBox.Value);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("new member added successfully !");
            this.Close();
        }

        private void CancleBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
