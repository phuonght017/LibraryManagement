namespace LibraryManagement
{
    partial class AddMember
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
            CancleBtn = new Button();
            SaveBtn = new Button();
            expirationBox = new TextBox();
            emailBox = new TextBox();
            phoneBox = new TextBox();
            nameBox = new TextBox();
            memberIDBox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            DOBBox = new DateTimePicker();
            genderBox = new ComboBox();
            SuspendLayout();
            // 
            // CancleBtn
            // 
            CancleBtn.BackColor = Color.FromArgb(172, 84, 114);
            CancleBtn.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CancleBtn.ForeColor = Color.FromArgb(238, 226, 220);
            CancleBtn.Location = new Point(332, 596);
            CancleBtn.Name = "CancleBtn";
            CancleBtn.Size = new Size(145, 50);
            CancleBtn.TabIndex = 41;
            CancleBtn.Text = "CANCLE";
            CancleBtn.UseVisualStyleBackColor = false;
            CancleBtn.Click += CancleBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(212, 59, 111);
            SaveBtn.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.ForeColor = Color.FromArgb(238, 226, 220);
            SaveBtn.Location = new Point(157, 596);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(145, 50);
            SaveBtn.TabIndex = 40;
            SaveBtn.Text = "SAVE";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // expirationBox
            // 
            expirationBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            expirationBox.ForeColor = SystemColors.WindowFrame;
            expirationBox.Location = new Point(209, 510);
            expirationBox.Name = "expirationBox";
            expirationBox.Size = new Size(310, 29);
            expirationBox.TabIndex = 37;
            // 
            // emailBox
            // 
            emailBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailBox.ForeColor = SystemColors.WindowFrame;
            emailBox.Location = new Point(209, 444);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(310, 29);
            emailBox.TabIndex = 36;
            // 
            // phoneBox
            // 
            phoneBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneBox.ForeColor = SystemColors.WindowFrame;
            phoneBox.Location = new Point(209, 376);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(310, 29);
            phoneBox.TabIndex = 35;
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameBox.ForeColor = SystemColors.WindowFrame;
            nameBox.Location = new Point(209, 174);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(310, 29);
            nameBox.TabIndex = 32;
            // 
            // memberIDBox
            // 
            memberIDBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            memberIDBox.ForeColor = SystemColors.WindowFrame;
            memberIDBox.Location = new Point(209, 102);
            memberIDBox.Name = "memberIDBox";
            memberIDBox.Size = new Size(310, 29);
            memberIDBox.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(18, 60, 105);
            label8.Location = new Point(25, 514);
            label8.Name = "label8";
            label8.Size = new Size(150, 25);
            label8.TabIndex = 28;
            label8.Text = "Expiration Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(18, 60, 105);
            label7.Location = new Point(66, 448);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 27;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(18, 60, 105);
            label6.Location = new Point(36, 380);
            label6.Name = "label6";
            label6.Size = new Size(148, 25);
            label6.TabIndex = 26;
            label6.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(18, 60, 105);
            label5.Location = new Point(66, 312);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 25;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(18, 60, 105);
            label4.Location = new Point(36, 244);
            label4.Name = "label4";
            label4.Size = new Size(128, 25);
            label4.TabIndex = 24;
            label4.Text = "Date Of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(18, 60, 105);
            label3.Location = new Point(66, 178);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 23;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(18, 60, 105);
            label2.Location = new Point(72, 106);
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
            label1.Location = new Point(25, 28);
            label1.Name = "label1";
            label1.Size = new Size(313, 42);
            label1.TabIndex = 21;
            label1.Text = "ADD NEW MEMBER";
            // 
            // DOBBox
            // 
            DOBBox.CalendarForeColor = SystemColors.ControlDarkDark;
            DOBBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DOBBox.Format = DateTimePickerFormat.Short;
            DOBBox.Location = new Point(209, 244);
            DOBBox.MinDate = new DateTime(1950, 10, 10, 0, 0, 0, 0);
            DOBBox.Name = "DOBBox";
            DOBBox.Size = new Size(144, 29);
            DOBBox.TabIndex = 42;
            // 
            // genderBox
            // 
            genderBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            genderBox.ForeColor = SystemColors.WindowFrame;
            genderBox.FormattingEnabled = true;
            genderBox.Items.AddRange(new object[] { "Male", "Female" });
            genderBox.Location = new Point(209, 308);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(144, 29);
            genderBox.TabIndex = 43;
            // 
            // AddMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 226, 220);
            ClientSize = new Size(584, 691);
            Controls.Add(genderBox);
            Controls.Add(DOBBox);
            Controls.Add(CancleBtn);
            Controls.Add(SaveBtn);
            Controls.Add(expirationBox);
            Controls.Add(emailBox);
            Controls.Add(phoneBox);
            Controls.Add(nameBox);
            Controls.Add(memberIDBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "AddMember";
            Text = "Add New Member";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancleBtn;
        private Button SaveBtn;
        private TextBox expirationBox;
        private TextBox emailBox;
        private TextBox phoneBox;
        private TextBox nameBox;
        private TextBox memberIDBox;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker DOBBox;
        private ComboBox genderBox;
    }
}