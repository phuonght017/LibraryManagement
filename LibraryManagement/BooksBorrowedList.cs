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
    public partial class BooksBorrowedList : Form
    {
        int StudentID;
        public BooksBorrowedList()
        {
            InitializeComponent();
        }
        internal void PassData(int StudentID)
        {
            this.StudentID = StudentID;
        }

        private void BooksBorrowedList_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
            conn.Open();
            string query = "SELECT b.[Book ID], b.Title, b.Publisher, b.Author, b.Price, b.[Publish Date], b.Pages, b.Description, b.Location " +
                           "FROM dbo.Books b, dbo.Borrowed br " +
                           "WHERE br.[Student ID] = @id " +
                           "AND b.[Book ID] = br.[Book ID] " +
                           "AND br.[Borrow ID] NOT IN (SELECT [Borrow ID] FROM dbo.Returned) ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", this.StudentID);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
