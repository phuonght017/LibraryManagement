namespace LibraryManagement
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            BooksBtn = new Button();
            MembersBtn = new Button();
            BorrowBtn = new Button();
            ReturnBtn = new Button();
            ManagerBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BooksBtn
            // 
            BooksBtn.BackColor = Color.FromArgb(237, 199, 183);
            BooksBtn.Cursor = Cursors.IBeam;
            BooksBtn.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BooksBtn.ForeColor = Color.FromArgb(172, 59, 97);
            BooksBtn.Location = new Point(96, 170);
            BooksBtn.Margin = new Padding(0);
            BooksBtn.Name = "BooksBtn";
            BooksBtn.Size = new Size(260, 50);
            BooksBtn.TabIndex = 0;
            BooksBtn.Text = "BOOKS";
            BooksBtn.UseVisualStyleBackColor = false;
            BooksBtn.Click += BooksBtn_Click;
            // 
            // MembersBtn
            // 
            MembersBtn.BackColor = Color.FromArgb(237, 199, 183);
            MembersBtn.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Bold, GraphicsUnit.Point);
            MembersBtn.ForeColor = Color.FromArgb(172, 59, 97);
            MembersBtn.ImageAlign = ContentAlignment.MiddleRight;
            MembersBtn.Location = new Point(96, 239);
            MembersBtn.Name = "MembersBtn";
            MembersBtn.Size = new Size(260, 50);
            MembersBtn.TabIndex = 1;
            MembersBtn.Text = "MEMBERS";
            MembersBtn.UseVisualStyleBackColor = false;
            MembersBtn.Click += MembersBtn_Click;
            // 
            // BorrowBtn
            // 
            BorrowBtn.BackColor = Color.FromArgb(237, 199, 183);
            BorrowBtn.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BorrowBtn.ForeColor = Color.FromArgb(172, 59, 97);
            BorrowBtn.Location = new Point(96, 313);
            BorrowBtn.Name = "BorrowBtn";
            BorrowBtn.Size = new Size(260, 50);
            BorrowBtn.TabIndex = 2;
            BorrowBtn.Text = "BORROW";
            BorrowBtn.UseVisualStyleBackColor = false;
            BorrowBtn.Click += BorrowBtn_Click;
            // 
            // ReturnBtn
            // 
            ReturnBtn.BackColor = Color.FromArgb(237, 199, 183);
            ReturnBtn.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Bold, GraphicsUnit.Point);
            ReturnBtn.ForeColor = Color.FromArgb(172, 59, 97);
            ReturnBtn.Location = new Point(96, 384);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(260, 50);
            ReturnBtn.TabIndex = 3;
            ReturnBtn.Text = "RETURN";
            ReturnBtn.UseVisualStyleBackColor = false;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // ManagerBtn
            // 
            ManagerBtn.BackColor = Color.FromArgb(237, 199, 183);
            ManagerBtn.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Bold, GraphicsUnit.Point);
            ManagerBtn.ForeColor = Color.FromArgb(172, 59, 97);
            ManagerBtn.Location = new Point(96, 455);
            ManagerBtn.Name = "ManagerBtn";
            ManagerBtn.Size = new Size(260, 50);
            ManagerBtn.TabIndex = 4;
            ManagerBtn.Text = "MANAGER";
            ManagerBtn.UseVisualStyleBackColor = false;
            ManagerBtn.Click += ManagerBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(124, -39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 272);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 226, 220);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(454, 541);
            Controls.Add(ManagerBtn);
            Controls.Add(ReturnBtn);
            Controls.Add(BorrowBtn);
            Controls.Add(MembersBtn);
            Controls.Add(BooksBtn);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuForm";
            Text = "Library Management System";
            FormClosing += MenuForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BooksBtn;
        private Button MembersBtn;
        private Button BorrowBtn;
        private Button ReturnBtn;
        private Button ManagerBtn;
        private PictureBox pictureBox1;
    }
}