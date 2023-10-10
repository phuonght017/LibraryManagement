namespace LibraryManagement
{
    partial class ReturnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnForm));
            CancleBtn = new Button();
            SendBtn = new Button();
            memberIDBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SearchBtn = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CancleBtn
            // 
            CancleBtn.BackColor = Color.FromArgb(172, 84, 114);
            CancleBtn.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CancleBtn.ForeColor = Color.FromArgb(238, 226, 220);
            CancleBtn.Location = new Point(337, 556);
            CancleBtn.Name = "CancleBtn";
            CancleBtn.Size = new Size(145, 50);
            CancleBtn.TabIndex = 54;
            CancleBtn.Text = "CANCLE";
            CancleBtn.UseVisualStyleBackColor = false;
            // 
            // SendBtn
            // 
            SendBtn.BackColor = Color.FromArgb(212, 59, 111);
            SendBtn.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            SendBtn.ForeColor = Color.FromArgb(238, 226, 220);
            SendBtn.Location = new Point(107, 556);
            SendBtn.Name = "SendBtn";
            SendBtn.Size = new Size(145, 50);
            SendBtn.TabIndex = 53;
            SendBtn.Text = "SEND";
            SendBtn.UseVisualStyleBackColor = false;
            // 
            // memberIDBox
            // 
            memberIDBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            memberIDBox.ForeColor = SystemColors.WindowFrame;
            memberIDBox.Location = new Point(157, 103);
            memberIDBox.Name = "memberIDBox";
            memberIDBox.RightToLeft = RightToLeft.No;
            memberIDBox.Size = new Size(239, 29);
            memberIDBox.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(18, 60, 105);
            label2.Location = new Point(27, 107);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 48;
            label2.Text = "Member ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(172, 59, 97);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(240, 42);
            label1.TabIndex = 47;
            label1.Text = "RETURN BOOK";
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(172, 59, 97);
            SearchBtn.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SearchBtn.ForeColor = Color.FromArgb(238, 226, 220);
            SearchBtn.Location = new Point(418, 96);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(130, 40);
            SearchBtn.TabIndex = 55;
            SearchBtn.Text = "SEARCH";
            SearchBtn.UseMnemonic = false;
            SearchBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(72, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(445, 312);
            dataGridView1.TabIndex = 56;
            // 
            // ReturnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 226, 220);
            ClientSize = new Size(584, 671);
            Controls.Add(dataGridView1);
            Controls.Add(SearchBtn);
            Controls.Add(CancleBtn);
            Controls.Add(SendBtn);
            Controls.Add(memberIDBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "ReturnForm";
            Text = "Return Book";
            Load += ReturnForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CancleBtn;
        private Button SendBtn;
        private TextBox memberIDBox;
        private Label label2;
        private Label label1;
        private Button SearchBtn;
        private DataGridView dataGridView1;
    }
}