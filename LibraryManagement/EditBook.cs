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
    public partial class EditBook : Form
    {
        int BookID;
        public EditBook()
        {
            InitializeComponent();
        }

        private void EditBook_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Books WHERE [Book ID] = @id", conn);
            cmd.Parameters.AddWithValue("@id", this.BookID);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            // fill data to text boxes
            DataRow dr = dt.Rows[0];
            titleBox.Text = dr[1].ToString().Trim();
            publisherBox.Text = dr[2].ToString().Trim();
            authorBox.Text = dr[3].ToString().Trim();
            priceBox.Text = dr[4].ToString().Trim();
            pubDateBox.Value = DateTime.Parse(dr[5].ToString().Trim());
            pagesBox.Text = dr[6].ToString().Trim();
            descriptionBox.Text = dr[7].ToString().Trim();
            totalNumBox.Text = dr[8].ToString().Trim();
            locationBox.Text = dr[10].ToString().Trim();
            conn.Close();
        }

        internal void PassData(string BookID)
        {
            this.BookID = int.Parse(BookID);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // update to DB
            SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE dbo.Books SET Title = @title, Publisher = @publisher, Author = @author, Price = @price, [Publish Date] = @pubDate, Pages = @pages, Description = @descr, [Total number] = @totalNum, Location = @location WHERE [Book ID] = @id", conn);
            cmd.Parameters.AddWithValue("@id", this.BookID);
            cmd.Parameters.AddWithValue("@title", titleBox.Text);
            cmd.Parameters.AddWithValue("@publisher", publisherBox.Text);
            cmd.Parameters.AddWithValue("@author", authorBox.Text);
            cmd.Parameters.AddWithValue("@price", float.Parse(priceBox.Text));
            cmd.Parameters.AddWithValue("@pubDate", new System.Data.SqlTypes.SqlDateTime(pubDateBox.Value));
            cmd.Parameters.AddWithValue("@pages", int.Parse(pagesBox.Text));
            cmd.Parameters.AddWithValue("@descr", descriptionBox.Text);
            cmd.Parameters.AddWithValue("@totalNum", int.Parse(totalNumBox.Text));
            cmd.Parameters.AddWithValue("@location", locationBox.Text);
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
            StudentBorrowingList f = new StudentBorrowingList();
            f.PassData(this.BookID);
            f.ShowDialog();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // delete book
            SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("DELETE FROM dbo.Returned WHERE [Borrow ID] IN (SELECT [Borrow ID] FROM dbo.Borrowed WHERE [Book ID] = @id)", conn);
            cmd2.Parameters.AddWithValue("@id", this.BookID);
            cmd2.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("DELETE FROM dbo.Borrowed WHERE [Book ID] = @id", conn);
            cmd1.Parameters.AddWithValue("@id", this.BookID);
            cmd1.ExecuteNonQuery();
            SqlCommand cmd = new SqlCommand("DELETE FROM dbo.Books WHERE [Book ID] = @id", conn);
            cmd.Parameters.AddWithValue("@id", this.BookID);
            cmd.ExecuteNonQuery();
            
            
            conn.Close();
            this.Close();
        }
    }
}
