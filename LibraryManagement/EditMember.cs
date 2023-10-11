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
    public partial class EditMember : Form
    {
        int StudentID;
        public EditMember()
        {
            InitializeComponent();

        }

        internal void PassData(string StudentID)
        {
            this.StudentID = int.Parse(StudentID);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // update changes to DB
            SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE dbo.Students SET Name = @name, Age = @age, Gender = @gender, [Phone number] = @phone, Email = @email, [Membership expiration date] = @expDate WHERE [Student ID] = @id", conn);
            cmd.Parameters.AddWithValue("@id", this.StudentID);
            cmd.Parameters.AddWithValue("@name", nameBox.Text);
            cmd.Parameters.AddWithValue("@age", ageBox.Value);
            cmd.Parameters.AddWithValue("@gender", genderBox.SelectedItem);
            cmd.Parameters.AddWithValue("@phone", phoneBox.Text);
            cmd.Parameters.AddWithValue("@email", emailBox.Text);
            cmd.Parameters.AddWithValue("@expDate", new System.Data.SqlTypes.SqlDateTime(expirationBox.Value));

            cmd.ExecuteNonQuery();
            conn.Close();
            this.Close();
        }

        private void CancleBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowListLabel_Click(object sender, EventArgs e)
        {
            BooksBorrowedList f = new BooksBorrowedList();
            f.PassData(StudentID);
            f.ShowDialog();
        }

        private void EditMember_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Students WHERE [Student ID] = @id", conn);
            cmd.Parameters.AddWithValue("@id", this.StudentID);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            // fill data to text boxes
            DataRow dr = dt.Rows[0];
            memberIDBox.Text = dr[0].ToString().Trim();
            nameBox.Text = dr[1].ToString().Trim();
            ageBox.Value = int.Parse(dr[2].ToString().Trim());
            genderBox.SelectedItem = dr[3].ToString().Trim();
            phoneBox.Text = dr[4].ToString().Trim();
            emailBox.Text = dr[5].ToString().Trim();
            expirationBox.Value = DateTime.Parse(dr[6].ToString().Trim());
            conn.Close();
        }
    }
}
