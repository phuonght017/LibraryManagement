namespace LibraryManagement
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            titleBox = new TextBox();
            publisherBox = new TextBox();
            authorBox = new TextBox();
            priceBox = new TextBox();
            pubDateBox = new TextBox();
            pagesBox = new TextBox();
            descriptionBox = new TextBox();
            totalNumBox = new TextBox();
            locationBox = new TextBox();
            SaveBtn = new Button();
            CancleBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(172, 59, 97);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(256, 42);
            label1.TabIndex = 0;
            label1.Text = "ADD NEW TITLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(18, 60, 105);
            label2.Location = new Point(59, 98);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(18, 60, 105);
            label3.Location = new Point(53, 145);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 2;
            label3.Text = "Publisher";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(18, 60, 105);
            label4.Location = new Point(53, 194);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 3;
            label4.Text = "Author";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(18, 60, 105);
            label5.Location = new Point(53, 244);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 4;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(18, 60, 105);
            label6.Location = new Point(53, 298);
            label6.Name = "label6";
            label6.Size = new Size(123, 25);
            label6.TabIndex = 5;
            label6.Text = "Publish Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(18, 60, 105);
            label7.Location = new Point(53, 346);
            label7.Name = "label7";
            label7.Size = new Size(64, 25);
            label7.TabIndex = 6;
            label7.Text = "Pages";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(18, 60, 105);
            label8.Location = new Point(53, 400);
            label8.Name = "label8";
            label8.Size = new Size(114, 25);
            label8.TabIndex = 7;
            label8.Text = "Description";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(18, 60, 105);
            label9.Location = new Point(53, 457);
            label9.Name = "label9";
            label9.Size = new Size(134, 25);
            label9.TabIndex = 8;
            label9.Text = "Total Number";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(18, 60, 105);
            label10.Location = new Point(53, 515);
            label10.Name = "label10";
            label10.Size = new Size(89, 25);
            label10.TabIndex = 9;
            label10.Text = "Location";
            // 
            // titleBox
            // 
            titleBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleBox.ForeColor = SystemColors.WindowFrame;
            titleBox.Location = new Point(196, 94);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(310, 29);
            titleBox.TabIndex = 10;
            // 
            // publisherBox
            // 
            publisherBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            publisherBox.ForeColor = SystemColors.WindowFrame;
            publisherBox.Location = new Point(196, 141);
            publisherBox.Name = "publisherBox";
            publisherBox.Size = new Size(310, 29);
            publisherBox.TabIndex = 11;
            // 
            // authorBox
            // 
            authorBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            authorBox.ForeColor = SystemColors.WindowFrame;
            authorBox.Location = new Point(196, 190);
            authorBox.Name = "authorBox";
            authorBox.Size = new Size(310, 29);
            authorBox.TabIndex = 12;
            // 
            // priceBox
            // 
            priceBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceBox.ForeColor = SystemColors.WindowFrame;
            priceBox.Location = new Point(196, 240);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(310, 29);
            priceBox.TabIndex = 13;
            // 
            // pubDateBox
            // 
            pubDateBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pubDateBox.ForeColor = SystemColors.WindowFrame;
            pubDateBox.Location = new Point(196, 294);
            pubDateBox.Name = "pubDateBox";
            pubDateBox.Size = new Size(310, 29);
            pubDateBox.TabIndex = 14;
            // 
            // pagesBox
            // 
            pagesBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pagesBox.ForeColor = SystemColors.WindowFrame;
            pagesBox.Location = new Point(196, 342);
            pagesBox.Name = "pagesBox";
            pagesBox.Size = new Size(310, 29);
            pagesBox.TabIndex = 15;
            // 
            // descriptionBox
            // 
            descriptionBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionBox.ForeColor = SystemColors.WindowFrame;
            descriptionBox.Location = new Point(196, 396);
            descriptionBox.Name = "descriptionBox";
            descriptionBox.Size = new Size(310, 29);
            descriptionBox.TabIndex = 16;
            // 
            // totalNumBox
            // 
            totalNumBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            totalNumBox.ForeColor = SystemColors.WindowFrame;
            totalNumBox.Location = new Point(196, 453);
            totalNumBox.Name = "totalNumBox";
            totalNumBox.Size = new Size(310, 29);
            totalNumBox.TabIndex = 17;
            // 
            // locationBox
            // 
            locationBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            locationBox.ForeColor = SystemColors.WindowFrame;
            locationBox.Location = new Point(196, 511);
            locationBox.Name = "locationBox";
            locationBox.Size = new Size(310, 29);
            locationBox.TabIndex = 18;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(212, 59, 111);
            SaveBtn.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.ForeColor = Color.FromArgb(238, 226, 220);
            SaveBtn.Location = new Point(144, 588);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(145, 50);
            SaveBtn.TabIndex = 19;
            SaveBtn.Text = "SAVE";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CancleBtn
            // 
            CancleBtn.BackColor = Color.FromArgb(172, 84, 114);
            CancleBtn.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CancleBtn.ForeColor = Color.FromArgb(238, 226, 220);
            CancleBtn.Location = new Point(319, 588);
            CancleBtn.Name = "CancleBtn";
            CancleBtn.Size = new Size(145, 50);
            CancleBtn.TabIndex = 20;
            CancleBtn.Text = "CANCLE";
            CancleBtn.UseVisualStyleBackColor = false;
            CancleBtn.Click += CancleBtn_Click;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 226, 220);
            ClientSize = new Size(584, 691);
            Controls.Add(CancleBtn);
            Controls.Add(SaveBtn);
            Controls.Add(locationBox);
            Controls.Add(totalNumBox);
            Controls.Add(descriptionBox);
            Controls.Add(pagesBox);
            Controls.Add(pubDateBox);
            Controls.Add(priceBox);
            Controls.Add(authorBox);
            Controls.Add(publisherBox);
            Controls.Add(titleBox);
            Controls.Add(label10);
            Controls.Add(label9);
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
            Name = "AddBook";
            Text = "Add New Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox titleBox;
        private TextBox publisherBox;
        private TextBox authorBox;
        private TextBox priceBox;
        private TextBox pubDateBox;
        private TextBox pagesBox;
        private TextBox descriptionBox;
        private TextBox totalNumBox;
        private TextBox locationBox;
        private Button SaveBtn;
        private Button CancleBtn;
    }
}