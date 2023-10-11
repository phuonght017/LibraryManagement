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
    public partial class ReturnForm : Form
    {
        public ReturnForm()
        {
            InitializeComponent();
            borrowedListBox.Visible = false;
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(memberIDBox.Text) && int.TryParse(memberIDBox.Text, out int i))
            {
                borrowedListBox.Visible = true;
                SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
                conn.Open();
                string query = "select distinct br.[Borrow ID] as ID, std.Name as [Student name], bk.Title [Book title], br.[Borrowed date], br.[Expiration date] " +
                               "from dbo.Students std, dbo.Books bk, dbo.Manager mn, dbo.Borrowed br " +
                               "where br.[Student ID] = @ID and std.[Student ID] = br.[Student ID] " +
                               "and br.[Book ID] = bk.[Book ID] " +
                               "and br.[Borrow ID] not in (select [Borrow ID] FROM dbo.Returned)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", int.Parse(memberIDBox.Text));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                borrowedListBox.DataSource = dt;
                conn.Close();
            }
            borrowedListBox.Columns[0].ReadOnly = false;
        }

        private void CancleBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in borrowedListBox.Rows)
            {
                bool selected = Convert.ToBoolean(row.Cells["Selected"].Value);
                if (selected)
                {
                    DateTime today = DateTime.Today;
                    DateTime exdate = DateTime.Parse(row.Cells[5].Value.ToString().Trim());
                    bool overdue = false;
                    SqlConnection conn = new SqlConnection(MyGlobals.connectionStr);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into dbo.Returned values (@Borrow_ID, @Manager_ID, @Returned_date, @Overdue)", conn);
                    cmd.Parameters.AddWithValue("@Borrow_ID", int.Parse(row.Cells[1].Value.ToString().Trim()));
                    cmd.Parameters.AddWithValue("@Manager_ID", LoginForm.Manager_ID);
                    cmd.Parameters.AddWithValue("@Returned_date", today.Date);
                    if (DateTime.Compare(exdate, today) > 0)
                        overdue = true;
                    cmd.Parameters.AddWithValue("@Overdue", overdue);
                    cmd.ExecuteNonQuery();

                    SqlCommand update = new SqlCommand("update dbo.Books set [Available number] = [Available number] + 1", conn);
                    update.ExecuteNonQuery();
                    conn.Close();
                }
            }
            MessageBox.Show("changes saved !");
        }
    }
}
