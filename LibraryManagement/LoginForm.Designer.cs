namespace LibraryManagement
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LoginBtn = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            EmailBox = new TextBox();
            PasswordBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(172, 59, 97);
            LoginBtn.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.FromArgb(238, 226, 220);
            LoginBtn.Location = new Point(140, 422);
            LoginBtn.Margin = new Padding(2);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(145, 50);
            LoginBtn.TabIndex = 0;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(-36, -11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(172, 59, 97);
            label1.Location = new Point(179, 67);
            label1.Name = "label1";
            label1.Size = new Size(236, 57);
            label1.TabIndex = 2;
            label1.Text = "LIBRARY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(202, 91, 128);
            label2.Location = new Point(166, 137);
            label2.Name = "label2";
            label2.Size = new Size(263, 29);
            label2.TabIndex = 3;
            label2.Text = "MANAGEMENT SYSTEM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(18, 60, 105);
            label3.Location = new Point(65, 286);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(18, 60, 105);
            label4.Location = new Point(27, 362);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // EmailBox
            // 
            EmailBox.BackColor = Color.FromArgb(238, 226, 220);
            EmailBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            EmailBox.ForeColor = SystemColors.WindowFrame;
            EmailBox.Location = new Point(140, 283);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(275, 33);
            EmailBox.TabIndex = 6;
            // 
            // PasswordBox
            // 
            PasswordBox.BackColor = Color.FromArgb(238, 226, 220);
            PasswordBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordBox.ForeColor = SystemColors.WindowFrame;
            PasswordBox.Location = new Point(140, 359);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(275, 33);
            PasswordBox.TabIndex = 7;
            PasswordBox.UseSystemPasswordChar = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 199, 183);
            ClientSize = new Size(454, 541);
            Controls.Add(PasswordBox);
            Controls.Add(EmailBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(LoginBtn);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "LoginForm";
            Text = "Login to Library Management System";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginBtn;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox EmailBox;
        private TextBox PasswordBox;
    }
}