namespace LibraryManagement
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            ChangePasswordBtn = new Button();
            EditBtn = new Button();
            addressBox = new TextBox();
            phoneNumberBox = new TextBox();
            nameBox = new TextBox();
            emailBox = new TextBox();
            managerIDBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            genderBox = new ComboBox();
            SuspendLayout();
            // 
            // ChangePasswordBtn
            // 
            ChangePasswordBtn.BackColor = Color.FromArgb(243, 140, 96);
            ChangePasswordBtn.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ChangePasswordBtn.ForeColor = Color.FromArgb(238, 226, 220);
            ChangePasswordBtn.Location = new Point(297, 386);
            ChangePasswordBtn.Name = "ChangePasswordBtn";
            ChangePasswordBtn.Size = new Size(217, 50);
            ChangePasswordBtn.TabIndex = 41;
            ChangePasswordBtn.Text = "CHANGE PASSWORD";
            ChangePasswordBtn.UseVisualStyleBackColor = false;
            ChangePasswordBtn.Click += ChangePasswordBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(212, 59, 111);
            EditBtn.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.FromArgb(238, 226, 220);
            EditBtn.Location = new Point(125, 386);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(145, 50);
            EditBtn.TabIndex = 40;
            EditBtn.Text = "EDIT";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // addressBox
            // 
            addressBox.Enabled = false;
            addressBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addressBox.ForeColor = SystemColors.InfoText;
            addressBox.Location = new Point(204, 334);
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(310, 29);
            addressBox.TabIndex = 36;
            // 
            // phoneNumberBox
            // 
            phoneNumberBox.Enabled = false;
            phoneNumberBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneNumberBox.ForeColor = SystemColors.InfoText;
            phoneNumberBox.Location = new Point(204, 286);
            phoneNumberBox.Name = "phoneNumberBox";
            phoneNumberBox.Size = new Size(310, 29);
            phoneNumberBox.TabIndex = 35;
            // 
            // nameBox
            // 
            nameBox.Enabled = false;
            nameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameBox.ForeColor = SystemColors.InfoText;
            nameBox.ImeMode = ImeMode.NoControl;
            nameBox.Location = new Point(204, 182);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(310, 29);
            nameBox.TabIndex = 33;
            // 
            // emailBox
            // 
            emailBox.Enabled = false;
            emailBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailBox.ForeColor = SystemColors.InfoText;
            emailBox.Location = new Point(204, 133);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(310, 29);
            emailBox.TabIndex = 32;
            // 
            // managerIDBox
            // 
            managerIDBox.BackColor = SystemColors.Window;
            managerIDBox.Enabled = false;
            managerIDBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            managerIDBox.ForeColor = SystemColors.InfoText;
            managerIDBox.Location = new Point(204, 86);
            managerIDBox.Name = "managerIDBox";
            managerIDBox.ReadOnly = true;
            managerIDBox.Size = new Size(310, 29);
            managerIDBox.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(18, 60, 105);
            label7.Location = new Point(56, 338);
            label7.Name = "label7";
            label7.Size = new Size(83, 25);
            label7.TabIndex = 27;
            label7.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(18, 60, 105);
            label6.Location = new Point(38, 290);
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
            label5.Location = new Point(61, 236);
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
            label4.Location = new Point(61, 186);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 24;
            label4.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(18, 60, 105);
            label3.Location = new Point(61, 137);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 23;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(18, 60, 105);
            label2.Location = new Point(58, 90);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 22;
            label2.Text = "Manager ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(172, 59, 97);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(258, 42);
            label1.TabIndex = 21;
            label1.Text = "Manager Profile";
            // 
            // genderBox
            // 
            genderBox.Enabled = false;
            genderBox.Items.AddRange(new object[] { "Female", "Male" });
            genderBox.Location = new Point(204, 235);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(121, 23);
            genderBox.TabIndex = 43;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 226, 220);
            ClientSize = new Size(584, 488);
            Controls.Add(genderBox);
            Controls.Add(ChangePasswordBtn);
            Controls.Add(EditBtn);
            Controls.Add(addressBox);
            Controls.Add(phoneNumberBox);
            Controls.Add(nameBox);
            Controls.Add(emailBox);
            Controls.Add(managerIDBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Cornsilk;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "ManagerForm";
            Text = "Manager Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ChangePasswordBtn;
        private Button EditBtn;
        private TextBox addressBox;
        private TextBox phoneNumberBox;
        private TextBox nameBox;
        private TextBox emailBox;
        private TextBox managerIDBox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox genderBox;
    }
}