using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void borrowingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BorrowingCheckBox.Checked && OverdueCheckBox.Checked)
            {
                OverdueCheckBox.Checked = false;
            }

            // filtering ...
        }

        private void OverdueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (OverdueCheckBox.Checked && BorrowingCheckBox.Checked)
            {
                BorrowingCheckBox.Checked = false;
            }

            // filtering ...
        }

        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            AddMember f = new AddMember();
            f.ShowDialog();
        }
    }
}
