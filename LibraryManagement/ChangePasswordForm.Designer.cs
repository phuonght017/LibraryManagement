namespace LibraryManagement
{
    partial class ChangePasswordForm
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
            confNewPassBox = new TextBox();
            newPassBox = new TextBox();
            currPassBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CancleBtn = new Button();
            SaveBtn = new Button();
            SuspendLayout();
            // 
            // confNewPassBox
            // 
            confNewPassBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            confNewPassBox.ForeColor = SystemColors.WindowFrame;
            confNewPassBox.Location = new Point(238, 203);
            confNewPassBox.Name = "confNewPassBox";
            confNewPassBox.Size = new Size(310, 29);
            confNewPassBox.TabIndex = 19;
            // 
            // newPassBox
            // 
            newPassBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newPassBox.ForeColor = SystemColors.WindowFrame;
            newPassBox.Location = new Point(238, 154);
            newPassBox.Name = "newPassBox";
            newPassBox.Size = new Size(310, 29);
            newPassBox.TabIndex = 18;
            // 
            // currPassBox
            // 
            currPassBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            currPassBox.ForeColor = SystemColors.WindowFrame;
            currPassBox.Location = new Point(238, 107);
            currPassBox.Name = "currPassBox";
            currPassBox.Size = new Size(310, 29);
            currPassBox.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(18, 60, 105);
            label4.Location = new Point(2, 207);
            label4.Name = "label4";
            label4.Size = new Size(217, 25);
            label4.TabIndex = 16;
            label4.Text = "Confirm new password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(18, 60, 105);
            label3.Location = new Point(40, 158);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 15;
            label3.Text = "New Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(18, 60, 105);
            label2.Location = new Point(11, 107);
            label2.Name = "label2";
            label2.Size = new Size(171, 25);
            label2.TabIndex = 14;
            label2.Text = "Current Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(172, 59, 97);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(329, 42);
            label1.TabIndex = 13;
            label1.Text = "CHANGE PASSWORD";
            // 
            // CancleBtn
            // 
            CancleBtn.BackColor = Color.FromArgb(172, 84, 114);
            CancleBtn.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CancleBtn.ForeColor = Color.FromArgb(238, 226, 220);
            CancleBtn.Location = new Point(286, 254);
            CancleBtn.Name = "CancleBtn";
            CancleBtn.Size = new Size(145, 50);
            CancleBtn.TabIndex = 22;
            CancleBtn.Text = "CANCLE";
            CancleBtn.UseVisualStyleBackColor = false;
            CancleBtn.Click += CancleBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(212, 59, 111);
            SaveBtn.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.ForeColor = Color.FromArgb(238, 226, 220);
            SaveBtn.Location = new Point(111, 254);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(145, 50);
            SaveBtn.TabIndex = 21;
            SaveBtn.Text = "SAVE";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 330);
            Controls.Add(CancleBtn);
            Controls.Add(SaveBtn);
            Controls.Add(confNewPassBox);
            Controls.Add(newPassBox);
            Controls.Add(currPassBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChangePasswordForm";
            Text = "ChangePasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox confNewPassBox;
        private TextBox newPassBox;
        private TextBox currPassBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button CancleBtn;
        private Button SaveBtn;
    }
}