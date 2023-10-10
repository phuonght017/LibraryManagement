namespace LibraryManagement
{
    partial class BorrowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowForm));
            CancleBtn = new Button();
            SendBtn = new Button();
            memberIDBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            nameBox = new Label();
            memberNameBox = new TextBox();
            bookBox = new ComboBox();
            borrowDateBox = new DateTimePicker();
            returnDateBox = new DateTimePicker();
            SuspendLayout();
            // 
            // CancleBtn
            // 
            CancleBtn.BackColor = Color.FromArgb(172, 84, 114);
            CancleBtn.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CancleBtn.ForeColor = Color.FromArgb(238, 226, 220);
            CancleBtn.Location = new Point(334, 523);
            CancleBtn.Name = "CancleBtn";
            CancleBtn.Size = new Size(145, 50);
            CancleBtn.TabIndex = 41;
            CancleBtn.Text = "CANCLE";
            CancleBtn.UseVisualStyleBackColor = false;
            CancleBtn.Click += CancleBtn_Click;
            // 
            // SendBtn
            // 
            SendBtn.BackColor = Color.FromArgb(212, 59, 111);
            SendBtn.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            SendBtn.ForeColor = Color.FromArgb(238, 226, 220);
            SendBtn.Location = new Point(110, 523);
            SendBtn.Name = "SendBtn";
            SendBtn.Size = new Size(145, 50);
            SendBtn.TabIndex = 40;
            SendBtn.Text = "SEND";
            SendBtn.UseVisualStyleBackColor = false;
            SendBtn.Click += SendBtn_Click;
            // 
            // memberIDBox
            // 
            memberIDBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            memberIDBox.ForeColor = SystemColors.WindowFrame;
            memberIDBox.Location = new Point(205, 110);
            memberIDBox.Name = "memberIDBox";
            memberIDBox.RightToLeft = RightToLeft.No;
            memberIDBox.Size = new Size(310, 29);
            memberIDBox.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(18, 60, 105);
            label5.Location = new Point(47, 411);
            label5.Name = "label5";
            label5.Size = new Size(119, 25);
            label5.TabIndex = 25;
            label5.Text = "Return Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(18, 60, 105);
            label4.Location = new Point(47, 343);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 24;
            label4.Text = "Borrow Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(18, 60, 105);
            label3.Location = new Point(69, 267);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 23;
            label3.Text = "Book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(18, 60, 105);
            label2.Location = new Point(60, 114);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 22;
            label2.Text = "Member ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(172, 59, 97);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(259, 42);
            label1.TabIndex = 21;
            label1.Text = "BORROW BOOK";
            // 
            // nameBox
            // 
            nameBox.AutoSize = true;
            nameBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            nameBox.ForeColor = Color.FromArgb(18, 60, 105);
            nameBox.Location = new Point(28, 183);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(144, 25);
            nameBox.TabIndex = 42;
            nameBox.Text = "Member Name";
            // 
            // memberNameBox
            // 
            memberNameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            memberNameBox.ForeColor = SystemColors.WindowFrame;
            memberNameBox.Location = new Point(205, 183);
            memberNameBox.Name = "memberNameBox";
            memberNameBox.Size = new Size(310, 29);
            memberNameBox.TabIndex = 43;
            // 
            // bookBox
            // 
            bookBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bookBox.FormattingEnabled = true;
            bookBox.Location = new Point(205, 263);
            bookBox.Name = "bookBox";
            bookBox.Size = new Size(310, 29);
            bookBox.TabIndex = 44;
            // 
            // borrowDateBox
            // 
            borrowDateBox.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            borrowDateBox.Location = new Point(205, 343);
            borrowDateBox.Name = "borrowDateBox";
            borrowDateBox.Size = new Size(235, 23);
            borrowDateBox.TabIndex = 45;
            // 
            // returnDateBox
            // 
            returnDateBox.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            returnDateBox.Location = new Point(205, 413);
            returnDateBox.Name = "returnDateBox";
            returnDateBox.Size = new Size(235, 23);
            returnDateBox.TabIndex = 46;
            // 
            // BorrowForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(238, 226, 220);
            ClientSize = new Size(584, 671);
            Controls.Add(returnDateBox);
            Controls.Add(borrowDateBox);
            Controls.Add(bookBox);
            Controls.Add(memberNameBox);
            Controls.Add(nameBox);
            Controls.Add(CancleBtn);
            Controls.Add(SendBtn);
            Controls.Add(memberIDBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "BorrowForm";
            Text = "Borrow Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancleBtn;
        private Button SendBtn;
        private TextBox locationBox;
        private TextBox totalNumBox;
        private TextBox descriptionBox;
        private TextBox pagesBox;
        private TextBox pubDateBox;
        private TextBox memberIDBox;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label nameBox;
        private TextBox memberNameBox;
        private ComboBox bookBox;
        private DateTimePicker borrowDateBox;
        private DateTimePicker returnDateBox;
    }
}