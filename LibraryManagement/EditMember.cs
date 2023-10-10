﻿using System;
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
    public partial class EditMember : Form
    {
        public EditMember()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // update changes to DB
            this.Close();
        }

        private void CancleBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowListLabel_Click(object sender, EventArgs e)
        {
            BooksBorrowedList f =  new BooksBorrowedList();
            // pass data
            f.ShowDialog();
        }
    }
}
