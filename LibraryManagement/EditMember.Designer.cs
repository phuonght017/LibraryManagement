namespace LibraryManagement
{
    partial class EditMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMember));
            genderBox = new ComboBox();
            CancleBtn = new Button();
            SaveBtn = new Button();
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
            ShowListLabel = new Label();
            ageBox = new NumericUpDown();
            expirationBox = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)ageBox).BeginInit();
            SuspendLayout();
            // 
            // genderBox
            // 
            genderBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            genderBox.ForeColor = SystemColors.WindowFrame;
            genderBox.FormattingEnabled = true;
            genderBox.Items.AddRange(new object[] { "Male", "Female" });
            genderBox.Location = new Point(210, 345);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(144, 29);
            genderBox.TabIndex = 60;
            // 
            // CancleBtn
            // 
            CancleBtn.BackColor = Color.FromArgb(172, 84, 114);
            CancleBtn.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CancleBtn.ForeColor = Color.FromArgb(238, 226, 220);
            CancleBtn.Location = new Point(339, 617);
            CancleBtn.Name = "CancleBtn";
            CancleBtn.Size = new Size(145, 50);
            CancleBtn.TabIndex = 58;
            CancleBtn.Text = "CANCLE";
            CancleBtn.UseVisualStyleBackColor = false;
            CancleBtn.Click += CancleBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(212, 59, 111);
            SaveBtn.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.ForeColor = Color.FromArgb(238, 226, 220);
            SaveBtn.Location = new Point(164, 617);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(145, 50);
            SaveBtn.TabIndex = 57;
            SaveBtn.Text = "SAVE";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // emailBox
            // 
            emailBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailBox.ForeColor = SystemColors.WindowFrame;
            emailBox.Location = new Point(210, 481);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(310, 29);
            emailBox.TabIndex = 55;
            // 
            // phoneBox
            // 
            phoneBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneBox.ForeColor = SystemColors.WindowFrame;
            phoneBox.Location = new Point(210, 413);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(310, 29);
            phoneBox.TabIndex = 54;
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameBox.ForeColor = SystemColors.WindowFrame;
            nameBox.Location = new Point(210, 211);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(310, 29);
            nameBox.TabIndex = 53;
            // 
            // memberIDBox
            // 
            memberIDBox.Enabled = false;
            memberIDBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            memberIDBox.ForeColor = SystemColors.WindowFrame;
            memberIDBox.Location = new Point(210, 139);
            memberIDBox.Name = "memberIDBox";
            memberIDBox.Size = new Size(310, 29);
            memberIDBox.TabIndex = 52;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(18, 60, 105);
            label8.Location = new Point(26, 551);
            label8.Name = "label8";
            label8.Size = new Size(150, 25);
            label8.TabIndex = 51;
            label8.Text = "Expiration Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(18, 60, 105);
            label7.Location = new Point(67, 485);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 50;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(18, 60, 105);
            label6.Location = new Point(37, 417);
            label6.Name = "label6";
            label6.Size = new Size(148, 25);
            label6.TabIndex = 49;
            label6.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(18, 60, 105);
            label5.Location = new Point(67, 349);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 48;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(18, 60, 105);
            label4.Location = new Point(84, 280);
            label4.Name = "label4";
            label4.Size = new Size(47, 25);
            label4.TabIndex = 47;
            label4.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(18, 60, 105);
            label3.Location = new Point(67, 215);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 46;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(18, 60, 105);
            label2.Location = new Point(73, 143);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 45;
            label2.Text = "Member ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(172, 59, 97);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(319, 42);
            label1.TabIndex = 44;
            label1.Text = "Edit Member Profile";
            // 
            // ShowListLabel
            // 
            ShowListLabel.BackColor = Color.FromArgb(254, 183, 143);
            ShowListLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            ShowListLabel.ForeColor = Color.FromArgb(18, 60, 105);
            ShowListLabel.Location = new Point(1, 71);
            ShowListLabel.Name = "ShowListLabel";
            ShowListLabel.Size = new Size(583, 37);
            ShowListLabel.TabIndex = 61;
            ShowListLabel.Text = ">> Show list of books borrowed by this member";
            ShowListLabel.TextAlign = ContentAlignment.MiddleCenter;
            ShowListLabel.Click += ShowListLabel_Click;
            // 
            // ageBox
            // 
            ageBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ageBox.Location = new Point(210, 281);
            ageBox.Name = "ageBox";
            ageBox.Size = new Size(68, 29);
            ageBox.TabIndex = 62;
            // 
            // expirationBox
            // 
            expirationBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            expirationBox.Location = new Point(210, 548);
            expirationBox.Name = "expirationBox";
            expirationBox.Size = new Size(175, 29);
            expirationBox.TabIndex = 63;
            // 
            // EditMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 226, 220);
            ClientSize = new Size(584, 691);
            Controls.Add(expirationBox);
            Controls.Add(ageBox);
            Controls.Add(ShowListLabel);
            Controls.Add(genderBox);
            Controls.Add(CancleBtn);
            Controls.Add(SaveBtn);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "EditMember";
            Text = "Edit Member Profile";
            Load += EditMember_Load;
            ((System.ComponentModel.ISupportInitialize)ageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox genderBox;
        private Button CancleBtn;
        private Button SaveBtn;
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
        private Label ShowListLabel;
        private NumericUpDown ageBox;
        private DateTimePicker expirationBox;
    }
}