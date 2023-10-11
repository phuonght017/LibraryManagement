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

namespace LibraryManagement
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into dbo.Books values(@Title, @Publisher, @Author, @Price, @Publish_Date, @Pages, @Description, @Total_number, @Available_number, @Location)", conn);
            cmd.Parameters.AddWithValue("@Title", titleBox.Text);
            cmd.Parameters.AddWithValue("@Publisher", publisherBox.Text);
            cmd.Parameters.AddWithValue("@Author", authorBox.Text);
            cmd.Parameters.AddWithValue("@Price", float.Parse(priceBox.Text));
            cmd.Parameters.AddWithValue("@Publish_Date", pubDateBox.Value);
            cmd.Parameters.AddWithValue("@Pages", int.Parse(pagesBox.Text));
            cmd.Parameters.AddWithValue("@Description", descriptionBox.Text);
            cmd.Parameters.AddWithValue("@Total_number", int.Parse(totalNumBox.Text));
            cmd.Parameters.AddWithValue("@Available_number", int.Parse(totalNumBox.Text));
            cmd.Parameters.AddWithValue("@Location", locationBox.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("new book added successfully !");
            this.Close();
        }

        private void CancleBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
