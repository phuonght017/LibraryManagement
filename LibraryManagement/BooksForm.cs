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
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
        }

        private void availableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (availableCheckBox.Checked && OutCheckBox.Checked)
            {
                OutCheckBox.Checked = false;
            }

            if (availableCheckBox.Checked)
            {
                SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from dbo.Books where [Available number] > 0", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.Aqua;
                conn.Close();
            }
            else if (!availableCheckBox.Checked && !OutCheckBox.Checked)
            {
                SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from dbo.Books", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.Aqua;
                conn.Close();
            }
        }

        private void OutCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (OutCheckBox.Checked && availableCheckBox.Checked)
            {
                availableCheckBox.Checked = false;
            }

            if (OutCheckBox.Checked)
            {
                SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from dbo.Books where [Available number] = 0", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.Aqua;
                conn.Close();
            }
            else if (!availableCheckBox.Checked && !OutCheckBox.Checked)
            {
                SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from dbo.Books", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.Aqua;
                conn.Close();
            }
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            AddBook f = new AddBook();
            f.ShowDialog();
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from dbo.Books", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.Aqua;
            conn.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            filteringBox.Enabled = true;
            SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Books WHERE CHARINDEX(@keyword, Title) > 0 OR CHARINDEX(@keyword, Author) > 0 OR CHARINDEX(@keyword, Publisher) > 0  ", conn);
            cmd.Parameters.AddWithValue("@keyword", SearchBox.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.Aqua;
            conn.Close();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from dbo.Books", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.Aqua;
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && dataGridView1.Rows[e.RowIndex].Cells["Book ID"].FormattedValue.ToString() != null)
            {
                EditBook f = new EditBook();
                f.PassData(dataGridView1.Rows[e.RowIndex].Cells["Book ID"].FormattedValue.ToString());
                f.ShowDialog();
            }
        }
    }
}
