namespace Car_Rental_Screen_1
{
    partial class search
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            deletebtn = new Button();
            modifybtn = new Button();
            addbtn = new Button();
            label3 = new Label();
            searchButton = new Button();
            dataGridView1 = new DataGridView();
            recordCount = new Label();
            searchText = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(369, 0);
            label1.Name = "label1";
            label1.Size = new Size(279, 40);
            label1.TabIndex = 0;
            label1.Text = "SEARCH DATABASE";
            // 
            // panel1
            // 
            panel1.Controls.Add(deletebtn);
            panel1.Controls.Add(modifybtn);
            panel1.Controls.Add(addbtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(recordCount);
            panel1.Controls.Add(searchText);
            panel1.Location = new Point(12, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 625);
            panel1.TabIndex = 1;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.FromArgb(51, 54, 63);
            deletebtn.Enabled = false;
            deletebtn.FlatAppearance.BorderColor = Color.Black;
            deletebtn.FlatStyle = FlatStyle.Flat;
            deletebtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deletebtn.ForeColor = Color.White;
            deletebtn.Location = new Point(796, 566);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(231, 48);
            deletebtn.TabIndex = 11;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // modifybtn
            // 
            modifybtn.BackColor = Color.FromArgb(51, 54, 63);
            modifybtn.Enabled = false;
            modifybtn.FlatAppearance.BorderColor = Color.Black;
            modifybtn.FlatStyle = FlatStyle.Flat;
            modifybtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modifybtn.ForeColor = Color.White;
            modifybtn.Location = new Point(559, 566);
            modifybtn.Name = "modifybtn";
            modifybtn.Size = new Size(231, 48);
            modifybtn.TabIndex = 10;
            modifybtn.Text = "Modify";
            modifybtn.UseVisualStyleBackColor = false;
            modifybtn.Click += modifybtn_Click;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.FromArgb(39, 157, 86);
            addbtn.FlatAppearance.BorderColor = Color.Black;
            addbtn.FlatStyle = FlatStyle.Flat;
            addbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addbtn.ForeColor = Color.White;
            addbtn.Location = new Point(322, 566);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(231, 48);
            addbtn.TabIndex = 9;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 1);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 8;
            label3.Text = "Search:";
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(39, 157, 86);
            searchButton.FlatAppearance.BorderColor = Color.Black;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(873, 3);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(154, 23);
            searchButton.TabIndex = 7;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(51, 54, 63);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 32);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1024, 528);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // recordCount
            // 
            recordCount.AutoSize = true;
            recordCount.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recordCount.Location = new Point(0, 572);
            recordCount.Name = "recordCount";
            recordCount.Size = new Size(185, 32);
            recordCount.TabIndex = 5;
            recordCount.Text = "Total Records: 0";
            // 
            // searchText
            // 
            searchText.Location = new Point(82, 3);
            searchText.Name = "searchText";
            searchText.Size = new Size(785, 23);
            searchText.TabIndex = 4;
            searchText.KeyPress += searchText_KeyPress;
            // 
            // search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "search";
            Size = new Size(1062, 679);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label recordCount;
        private TextBox searchText;
        private Label label3;
        private Button searchButton;
        private Button deletebtn;
        private Button modifybtn;
        private Button addbtn;
    }
}
