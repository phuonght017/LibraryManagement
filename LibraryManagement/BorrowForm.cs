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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagement
{
    public partial class BorrowForm : Form
    {
        public BorrowForm()
        {
            InitializeComponent();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            // get data from text boxes
            ComboState obj = bookBox.SelectedItem as ComboState;
            int book_id = obj.ID;
            int student_id = int.Parse(MemberIDBox.SelectedItem.ToString());
            // insert new row into table Borrow
            SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT dbo.Borrowed VALUES(@book_id, @student_id, @manager_id, @borrowed_date, @exp_date)", conn);
            cmd.Parameters.AddWithValue("@book_id", book_id);
            cmd.Parameters.AddWithValue("@student_id", student_id);
            cmd.Parameters.AddWithValue("@manager_id", LoginForm.Manager_ID);
            cmd.Parameters.AddWithValue("@borrowed_date", borrowDateBox.Value);
            cmd.Parameters.AddWithValue("@exp_date", returnDateBox.Value);
            cmd.ExecuteNonQuery();
            
            // update available number of book
            SqlCommand cmd1 = new SqlCommand("UPDATE dbo.Books SET [Available number] = [Available number] - 1 WHERE [Book ID] = @id", conn);
            cmd1.Parameters.AddWithValue("@id", book_id);
            MessageBox.Show("Borrow book successfully!" );
            cmd1.ExecuteNonQuery();
            conn.Close();
            this.Close();
        }

        private void CancleBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            // Load Student ID to MemberIDBox
            SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
            conn.Open();
            string query = "SELECT [Student ID] FROM dbo.Students ORDER BY [Student ID] ASC";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
                MemberIDBox.Items.Add(dt.Rows[i][0].ToString());

            // Load Books to MemberIDBox
            query = "SELECT [Book ID], [Title], [Author] FROM dbo.Books WHERE [Available number] > 0";
            SqlCommand cmd1 = new SqlCommand(query, conn);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            List<ComboState> list = new List<ComboState>();
            int book_id;
            string book_info;
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                book_id = int.Parse(dt1.Rows[i][0].ToString());
                book_info = dt1.Rows[i][1].ToString() + " - " + dt1.Rows[i][2].ToString();
                list.Add(new ComboState() { ID = book_id, Name = book_info });
            }
            bookBox.DataSource = list;
            bookBox.ValueMember = "ID";
            bookBox.DisplayMember = "Name";
            conn.Close();
        }

        private void MemberIDBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
            conn.Open();
            string query = "SELECT Name FROM dbo.Students WHERE [Student ID] = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(MemberIDBox.SelectedItem.ToString()));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            memberNameBox.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }
    }


}
