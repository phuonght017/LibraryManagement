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
    public partial class MembersForm : Form
    {
        public MembersForm()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from dbo.Students", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.Aqua;
            conn.Close();
        }

        private void borrowingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BorrowingCheckBox.Checked && OverdueCheckBox.Checked)
            {
                OverdueCheckBox.Checked = false;
            }

            if (BorrowingCheckBox.Checked)
            {
                SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
                conn.Open();
                string query = "SELECT std.[Student ID], std.Name, std.Age, std.Gender, std.[Phone number], std.Email, std.[Membership expiration date]  " +
                               "FROM dbo.Students std, dbo.Borrowed br " +
                               "WHERE std.[Student ID] = br.[Student ID] " +
                               "AND br.[Borrow ID] NOT IN (SELECT [Borrow ID] FROM dbo.Returned)";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.Aqua;
                conn.Close();
            }
            else if (!BorrowingCheckBox.Checked && !OverdueCheckBox.Checked)
            {
                SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from dbo.Students", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.Aqua;
                conn.Close();
            }
        }

        private void OverdueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (OverdueCheckBox.Checked && BorrowingCheckBox.Checked)
            {
                BorrowingCheckBox.Checked = false;
            }

            if (OverdueCheckBox.Checked)
            {
                SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
                conn.Open();
                string query = "SELECT std.[Student ID], std.Name, std.Age, std.Gender, std.[Phone number], std.Email, std.[Membership expiration date]  " +
                               "FROM dbo.Students std, dbo.Borrowed br " +
                               "WHERE std.[Student ID] = br.[Student ID] " +
                               "AND br.[Expiration date] <= GETDATE() " +
                               "AND br.[Borrow ID] NOT IN (SELECT [Borrow ID] FROM dbo.Returned)";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.Aqua;
                conn.Close();
            }
            else if (!OverdueCheckBox.Checked && !BorrowingCheckBox.Checked)
            {
                SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from dbo.Students", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.Aqua;
                conn.Close();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Students WHERE CHARINDEX(@keyword, Name) > 0 OR CHARINDEX(@keyword, CAST([Student ID] AS VARCHAR(50))) > 0", conn);
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
            SqlCommand cmd = new SqlCommand("select * from dbo.Students", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[1].DefaultCellStyle.BackColor = Color.Aqua;
            conn.Close();

            BorrowingCheckBox.Checked = false;
            OverdueCheckBox.Checked = false;
        }

        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            AddMember f = new AddMember();
            f.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && dataGridView1.Rows[e.RowIndex].Cells["Student ID"].FormattedValue.ToString() != null)
            {
                EditMember f = new EditMember();
                f.PassData(dataGridView1.Rows[e.RowIndex].Cells["Student ID"].FormattedValue.ToString());
                f.ShowDialog();
            }
        }
    }
}
