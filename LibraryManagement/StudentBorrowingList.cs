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
    public partial class StudentBorrowingList : Form
    {
        int BookID;
        public StudentBorrowingList()
        {
            InitializeComponent();
        }

        internal void PassData(int BookID)
        {
            this.BookID = BookID;
        }

        private void StudentBorrowingList_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
            conn.Open();
            string query = "SELECT std.[Student ID], std.Name, std.[Phone number], std.Email  " +
                           "FROM dbo.Students std, dbo.Borrowed br " +
                           "WHERE br.[Book ID] = @id " +
                           "AND std.[Student ID] = br.[Student ID] " +
                           "AND br.[Borrow ID] NOT IN (SELECT [Borrow ID] FROM dbo.Returned) ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", this.BookID);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
