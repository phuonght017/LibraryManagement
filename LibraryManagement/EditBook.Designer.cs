namespace LibraryManagement
{
    partial class EditBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBook));
            CancleBtn = new Button();
            SaveBtn = new Button();
            locationBox = new TextBox();
            totalNumBox = new TextBox();
            descriptionBox = new TextBox();
            pagesBox = new TextBox();
            priceBox = new TextBox();
            authorBox = new TextBox();
            publisherBox = new TextBox();
            titleBox = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ShowListLabel = new Label();
            DeleteBtn = new Button();
            pubDateBox = new DateTimePicker();
            SuspendLayout();
            // 
            // CancleBtn
            // 
            CancleBtn.BackColor = Color.FromArgb(172, 84, 114);
            CancleBtn.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CancleBtn.ForeColor = Color.FromArgb(238, 226, 220);
            CancleBtn.Location = new Point(221, 654);
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
            SaveBtn.Location = new Point(47, 654);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(145, 50);
            SaveBtn.TabIndex = 40;
            SaveBtn.Text = "SAVE";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // locationBox
            // 
            locationBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            locationBox.ForeColor = SystemColors.WindowFrame;
            locationBox.Location = new Point(192, 572);
            locationBox.Name = "locationBox";
            locationBox.Size = new Size(310, 29);
            locationBox.TabIndex = 39;
            // 
            // totalNumBox
            // 
            totalNumBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            totalNumBox.ForeColor = SystemColors.WindowFrame;
            totalNumBox.Location = new Point(192, 511);
            totalNumBox.Name = "totalNumBox";
            totalNumBox.Size = new Size(310, 29);
            totalNumBox.TabIndex = 38;
            // 
            // descriptionBox
            // 
            descriptionBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionBox.ForeColor = SystemColors.WindowFrame;
            descriptionBox.Location = new Point(192, 462);
            descriptionBox.Name = "descriptionBox";
            descriptionBox.Size = new Size(310, 29);
            descriptionBox.TabIndex = 37;
            // 
            // pagesBox
            // 
            pagesBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pagesBox.ForeColor = SystemColors.WindowFrame;
            pagesBox.Location = new Point(192, 408);
            pagesBox.Name = "pagesBox";
            pagesBox.Size = new Size(310, 29);
            pagesBox.TabIndex = 36;
            // 
            // priceBox
            // 
            priceBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceBox.ForeColor = SystemColors.WindowFrame;
            priceBox.Location = new Point(192, 301);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(310, 29);
            priceBox.TabIndex = 34;
            // 
            // authorBox
            // 
            authorBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            authorBox.ForeColor = SystemColors.WindowFrame;
            authorBox.Location = new Point(192, 252);
            authorBox.Name = "authorBox";
            authorBox.Size = new Size(310, 29);
            authorBox.TabIndex = 33;
            // 
            // publisherBox
            // 
            publisherBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            publisherBox.ForeColor = SystemColors.WindowFrame;
            publisherBox.Location = new Point(192, 202);
            publisherBox.Name = "publisherBox";
            publisherBox.Size = new Size(310, 29);
            publisherBox.TabIndex = 32;
            // 
            // titleBox
            // 
            titleBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleBox.ForeColor = SystemColors.WindowFrame;
            titleBox.Location = new Point(192, 156);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(310, 29);
            titleBox.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(18, 60, 105);
            label10.Location = new Point(55, 571);
            label10.Name = "label10";
            label10.Size = new Size(89, 25);
            label10.TabIndex = 30;
            label10.Text = "Location";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(18, 60, 105);
            label9.Location = new Point(29, 510);
            label9.Name = "label9";
            label9.Size = new Size(134, 25);
            label9.TabIndex = 29;
            label9.Text = "Total Number";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(18, 60, 105);
            label8.Location = new Point(49, 462);
            label8.Name = "label8";
            label8.Size = new Size(114, 25);
            label8.TabIndex = 28;
            label8.Text = "Description";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(18, 60, 105);
            label7.Location = new Point(49, 408);
            label7.Name = "label7";
            label7.Size = new Size(64, 25);
            label7.TabIndex = 27;
            label7.Text = "Pages";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(18, 60, 105);
            label6.Location = new Point(49, 360);
            label6.Name = "label6";
            label6.Size = new Size(123, 25);
            label6.TabIndex = 26;
            label6.Text = "Publish Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(18, 60, 105);
            label5.Location = new Point(49, 306);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 25;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(18, 60, 105);
            label4.Location = new Point(47, 252);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 24;
            label4.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(18, 60, 105);
            label3.Location = new Point(47, 206);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 23;
            label3.Text = "Publisher";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(18, 60, 105);
            label2.Location = new Point(55, 156);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 22;
            label2.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(172, 59, 97);
            label1.Location = new Point(17, 20);
            label1.Name = "label1";
            label1.Size = new Size(176, 42);
            label1.TabIndex = 21;
            label1.Text = "EDIT TITLE";
            // 
            // ShowListLabel
            // 
            ShowListLabel.BackColor = Color.FromArgb(254, 183, 143);
            ShowListLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            ShowListLabel.ForeColor = Color.FromArgb(18, 60, 105);
            ShowListLabel.Location = new Point(1, 88);
            ShowListLabel.Name = "ShowListLabel";
            ShowListLabel.Size = new Size(583, 38);
            ShowListLabel.TabIndex = 44;
            ShowListLabel.Text = ">> Show list of students borrowing this book";
            ShowListLabel.TextAlign = ContentAlignment.MiddleCenter;
            ShowListLabel.Click += ShowListLabel_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.FromArgb(157, 0, 53);
            DeleteBtn.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.ForeColor = Color.FromArgb(238, 226, 220);
            DeleteBtn.Location = new Point(397, 654);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(145, 50);
            DeleteBtn.TabIndex = 45;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // pubDateBox
            // 
            pubDateBox.CalendarFont = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            pubDateBox.Format = DateTimePickerFormat.Short;
            pubDateBox.Location = new Point(192, 360);
            pubDateBox.Name = "pubDateBox";
            pubDateBox.Size = new Size(186, 23);
            pubDateBox.TabIndex = 46;
            // 
            // EditBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(238, 226, 220);
            ClientSize = new Size(584, 716);
            Controls.Add(pubDateBox);
            Controls.Add(DeleteBtn);
            Controls.Add(ShowListLabel);
            Controls.Add(CancleBtn);
            Controls.Add(SaveBtn);
            Controls.Add(locationBox);
            Controls.Add(totalNumBox);
            Controls.Add(descriptionBox);
            Controls.Add(pagesBox);
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
            Name = "EditBook";
            Text = "Edit Book Detail";
            Load += EditBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancleBtn;
        private Button SaveBtn;
        private TextBox locationBox;
        private TextBox totalNumBox;
        private TextBox descriptionBox;
        private TextBox pagesBox;
        private TextBox priceBox;
        private TextBox authorBox;
        private TextBox publisherBox;
        private TextBox titleBox;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label ShowListLabel;
        private Button DeleteBtn;
        private DateTimePicker pubDateBox;
    }
}