namespace LibraryManagement
{
    partial class BooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksForm));
            pictureBox1 = new PictureBox();
            SearchBox = new TextBox();
            SearchBtn = new Button();
            filteringBox = new GroupBox();
            OutCheckBox = new CheckBox();
            availableCheckBox = new CheckBox();
            addBookBtn = new Button();
            dataGridView1 = new DataGridView();
            ResetBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            filteringBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(2, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // SearchBox
            // 
            SearchBox.Font = new Font("NSimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBox.ForeColor = SystemColors.WindowFrame;
            SearchBox.Location = new Point(178, 43);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(450, 29);
            SearchBox.TabIndex = 1;
            SearchBox.Text = " Search by title or author";
            SearchBox.UseWaitCursor = true;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(172, 59, 97);
            SearchBtn.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            SearchBtn.ForeColor = Color.FromArgb(238, 226, 220);
            SearchBtn.Location = new Point(645, 37);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(130, 45);
            SearchBtn.TabIndex = 2;
            SearchBtn.Text = "SEARCH";
            SearchBtn.UseMnemonic = false;
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // filteringBox
            // 
            filteringBox.BackColor = Color.White;
            filteringBox.Controls.Add(OutCheckBox);
            filteringBox.Controls.Add(availableCheckBox);
            filteringBox.Font = new Font("NSimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            filteringBox.ForeColor = SystemColors.ControlText;
            filteringBox.Location = new Point(178, 97);
            filteringBox.Name = "filteringBox";
            filteringBox.Size = new Size(450, 79);
            filteringBox.TabIndex = 3;
            filteringBox.TabStop = false;
            filteringBox.Text = "Filtering Settings:";
            // 
            // OutCheckBox
            // 
            OutCheckBox.AutoSize = true;
            OutCheckBox.Location = new Point(255, 42);
            OutCheckBox.Name = "OutCheckBox";
            OutCheckBox.Size = new Size(148, 23);
            OutCheckBox.TabIndex = 1;
            OutCheckBox.Text = "Out Of Stock";
            OutCheckBox.UseMnemonic = false;
            OutCheckBox.UseVisualStyleBackColor = true;
            OutCheckBox.CheckedChanged += OutCheckBox_CheckedChanged;
            // 
            // availableCheckBox
            // 
            availableCheckBox.AutoSize = true;
            availableCheckBox.Location = new Point(36, 42);
            availableCheckBox.Name = "availableCheckBox";
            availableCheckBox.Size = new Size(118, 23);
            availableCheckBox.TabIndex = 0;
            availableCheckBox.Text = "Available";
            availableCheckBox.UseMnemonic = false;
            availableCheckBox.UseVisualStyleBackColor = true;
            availableCheckBox.CheckedChanged += availableCheckBox_CheckedChanged;
            // 
            // addBookBtn
            // 
            addBookBtn.AutoSize = true;
            addBookBtn.BackColor = Color.FromArgb(214, 77, 123);
            addBookBtn.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addBookBtn.ForeColor = Color.FromArgb(238, 226, 220);
            addBookBtn.Location = new Point(851, 149);
            addBookBtn.Name = "addBookBtn";
            addBookBtn.Size = new Size(178, 45);
            addBookBtn.TabIndex = 4;
            addBookBtn.Text = "+ Add New Title";
            addBookBtn.UseMnemonic = false;
            addBookBtn.UseVisualStyleBackColor = false;
            addBookBtn.Click += addBookBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(238, 226, 220);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 191);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(996, 468);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.FromArgb(172, 40, 90);
            ResetBtn.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ResetBtn.ForeColor = Color.FromArgb(238, 226, 220);
            ResetBtn.Location = new Point(715, 148);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(130, 45);
            ResetBtn.TabIndex = 6;
            ResetBtn.Text = "Reset";
            ResetBtn.UseMnemonic = false;
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 226, 220);
            ClientSize = new Size(1054, 634);
            Controls.Add(ResetBtn);
            Controls.Add(dataGridView1);
            Controls.Add(addBookBtn);
            Controls.Add(filteringBox);
            Controls.Add(SearchBtn);
            Controls.Add(SearchBox);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "BooksForm";
            Text = "Books";
            Load += BooksForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            filteringBox.ResumeLayout(false);
            filteringBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox SearchBox;
        private Button SearchBtn;
        private GroupBox filteringBox;
        private CheckBox availableCheckBox;
        private CheckBox OutCheckBox;
        private Button addBookBtn;
        private DataGridView dataGridView1;
        private Button ResetBtn;
    }
}