namespace LibraryManagement
{
    partial class MembersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembersForm));
            pictureBox1 = new PictureBox();
            SearchBox = new TextBox();
            SearchBtn = new Button();
            filteringBox = new GroupBox();
            OverdueCheckBox = new CheckBox();
            BorrowingCheckBox = new CheckBox();
            addMemberBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            filteringBox.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(2, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // SearchBox
            // 
            SearchBox.Font = new Font("NSimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBox.ForeColor = SystemColors.WindowFrame;
            SearchBox.Location = new Point(178, 43);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(450, 29);
            SearchBox.TabIndex = 2;
            SearchBox.Text = " Search by name or member ID";
            SearchBox.UseWaitCursor = true;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(172, 59, 97);
            SearchBtn.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            SearchBtn.ForeColor = Color.FromArgb(238, 226, 220);
            SearchBtn.Location = new Point(645, 37);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(130, 45);
            SearchBtn.TabIndex = 3;
            SearchBtn.Text = "SEARCH";
            SearchBtn.UseMnemonic = false;
            SearchBtn.UseVisualStyleBackColor = false;
            // 
            // filteringBox
            // 
            filteringBox.BackColor = Color.White;
            filteringBox.Controls.Add(OverdueCheckBox);
            filteringBox.Controls.Add(BorrowingCheckBox);
            filteringBox.Font = new Font("NSimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            filteringBox.ForeColor = SystemColors.ControlText;
            filteringBox.Location = new Point(178, 97);
            filteringBox.Name = "filteringBox";
            filteringBox.Size = new Size(468, 79);
            filteringBox.TabIndex = 4;
            filteringBox.TabStop = false;
            filteringBox.Text = "Filtering Settings:";
            // 
            // OverdueCheckBox
            // 
            OverdueCheckBox.AutoSize = true;
            OverdueCheckBox.Location = new Point(255, 42);
            OverdueCheckBox.Name = "OverdueCheckBox";
            OverdueCheckBox.Size = new Size(198, 23);
            OverdueCheckBox.TabIndex = 1;
            OverdueCheckBox.Text = "Overdue borrowing";
            OverdueCheckBox.UseMnemonic = false;
            OverdueCheckBox.UseVisualStyleBackColor = true;
            OverdueCheckBox.CheckedChanged += OverdueCheckBox_CheckedChanged;
            // 
            // BorrowingCheckBox
            // 
            BorrowingCheckBox.AutoSize = true;
            BorrowingCheckBox.Location = new Point(36, 42);
            BorrowingCheckBox.Name = "BorrowingCheckBox";
            BorrowingCheckBox.Size = new Size(178, 23);
            BorrowingCheckBox.TabIndex = 0;
            BorrowingCheckBox.Text = "Borrowing books";
            BorrowingCheckBox.UseMnemonic = false;
            BorrowingCheckBox.UseVisualStyleBackColor = true;
            BorrowingCheckBox.CheckedChanged += borrowingCheckBox_CheckedChanged;
            // 
            // addMemberBtn
            // 
            addMemberBtn.AutoSize = true;
            addMemberBtn.BackColor = Color.FromArgb(214, 77, 123);
            addMemberBtn.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addMemberBtn.ForeColor = Color.FromArgb(238, 226, 220);
            addMemberBtn.Location = new Point(847, 226);
            addMemberBtn.Name = "addMemberBtn";
            addMemberBtn.Size = new Size(178, 45);
            addMemberBtn.TabIndex = 5;
            addMemberBtn.Text = "+ Add New Member";
            addMemberBtn.UseMnemonic = false;
            addMemberBtn.UseVisualStyleBackColor = false;
            addMemberBtn.Click += addMemberBtn_Click;
            // 
            // MembersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 226, 220);
            ClientSize = new Size(1054, 681);
            Controls.Add(addMemberBtn);
            Controls.Add(filteringBox);
            Controls.Add(SearchBtn);
            Controls.Add(SearchBox);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "MembersForm";
            Text = "Members";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            filteringBox.ResumeLayout(false);
            filteringBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox SearchBox;
        private Button SearchBtn;
        private GroupBox filteringBox;
        private CheckBox OverdueCheckBox;
        private CheckBox BorrowingCheckBox;
        private Button addMemberBtn;
    }
}