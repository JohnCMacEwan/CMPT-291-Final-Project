namespace CMPT291DB
{
    partial class RentalMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PickupDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReturnDatePicker = new System.Windows.Forms.DateTimePicker();
            this.BranchSelector = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RentalSearchButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.buttonReport1 = new System.Windows.Forms.Button();
            this.buttonReport2 = new System.Windows.Forms.Button();
            this.buttonReport3 = new System.Windows.Forms.Button();
            this.buttonReport4 = new System.Windows.Forms.Button();
            this.buttonReport5 = new System.Windows.Forms.Button();
            this.dataGridViewReports = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).BeginInit();
            this.SuspendLayout();
            // 
            // PickupDatePicker
            // 
            this.PickupDatePicker.Location = new System.Drawing.Point(12, 39);
            this.PickupDatePicker.Name = "PickupDatePicker";
            this.PickupDatePicker.Size = new System.Drawing.Size(250, 27);
            this.PickupDatePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pickup Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Return Date";
            // 
            // ReturnDatePicker
            // 
            this.ReturnDatePicker.Location = new System.Drawing.Point(12, 110);
            this.ReturnDatePicker.Name = "ReturnDatePicker";
            this.ReturnDatePicker.Size = new System.Drawing.Size(250, 27);
            this.ReturnDatePicker.TabIndex = 2;
            // 
            // BranchSelector
            // 
            this.BranchSelector.FormattingEnabled = true;
            this.BranchSelector.Location = new System.Drawing.Point(12, 181);
            this.BranchSelector.Name = "BranchSelector";
            this.BranchSelector.Size = new System.Drawing.Size(151, 28);
            this.BranchSelector.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Branch";
            // 
            // RentalSearchButton
            // 
            this.RentalSearchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RentalSearchButton.Location = new System.Drawing.Point(12, 221);
            this.RentalSearchButton.Name = "RentalSearchButton";
            this.RentalSearchButton.Size = new System.Drawing.Size(285, 64);
            this.RentalSearchButton.TabIndex = 6;
            this.RentalSearchButton.Text = "Search";
            this.RentalSearchButton.UseVisualStyleBackColor = true;
            this.RentalSearchButton.Click += new System.EventHandler(this.RentalSearchButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // buttonReport1
            // 
            this.buttonReport1.Location = new System.Drawing.Point(330, 221);
            this.buttonReport1.Name = "buttonReport1";
            this.buttonReport1.Size = new System.Drawing.Size(100, 40);
            this.buttonReport1.TabIndex = 7;
            this.buttonReport1.Text = "Report 1";
            this.buttonReport1.UseVisualStyleBackColor = true;
            this.buttonReport1.Click += new System.EventHandler(this.buttonReport1_Click);
            // 
            // buttonReport2
            // 
            this.buttonReport2.Location = new System.Drawing.Point(436, 221);
            this.buttonReport2.Name = "buttonReport2";
            this.buttonReport2.Size = new System.Drawing.Size(100, 40);
            this.buttonReport2.TabIndex = 8;
            this.buttonReport2.Text = "Report 2";
            this.buttonReport2.UseVisualStyleBackColor = true;
            this.buttonReport2.Click += new System.EventHandler(this.buttonReport2_Click);
            // 
            // buttonReport3
            // 
            this.buttonReport3.Location = new System.Drawing.Point(542, 221);
            this.buttonReport3.Name = "buttonReport3";
            this.buttonReport3.Size = new System.Drawing.Size(100, 40);
            this.buttonReport3.TabIndex = 9;
            this.buttonReport3.Text = "Report 3";
            this.buttonReport3.UseVisualStyleBackColor = true;
            this.buttonReport3.Click += new System.EventHandler(this.buttonReport3_Click);
            // 
            // buttonReport4
            // 
            this.buttonReport4.Location = new System.Drawing.Point(648, 221);
            this.buttonReport4.Name = "buttonReport4";
            this.buttonReport4.Size = new System.Drawing.Size(100, 40);
            this.buttonReport4.TabIndex = 10;
            this.buttonReport4.Text = "Report 4";
            this.buttonReport4.UseVisualStyleBackColor = true;
            this.buttonReport4.Click += new System.EventHandler(this.buttonReport4_Click);
            // 
            // buttonReport5
            // 
            this.buttonReport5.Location = new System.Drawing.Point(754, 221);
            this.buttonReport5.Name = "buttonReport5";
            this.buttonReport5.Size = new System.Drawing.Size(100, 40);
            this.buttonReport5.TabIndex = 11;
            this.buttonReport5.Text = "Report 5";
            this.buttonReport5.UseVisualStyleBackColor = true;
            this.buttonReport5.Click += new System.EventHandler(this.buttonReport5_Click);
            // 
            // dataGridViewReports
            // 
            this.dataGridViewReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReports.Location = new System.Drawing.Point(330, 12);
            this.dataGridViewReports.Name = "dataGridViewReports";
            this.dataGridViewReports.RowHeadersWidth = 51;
            this.dataGridViewReports.RowTemplate.Height = 29;
            this.dataGridViewReports.Size = new System.Drawing.Size(524, 200);
            this.dataGridViewReports.TabIndex = 12;
            // 
            // RentalMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 297);
            this.Controls.Add(this.dataGridViewReports);
            this.Controls.Add(this.buttonReport5);
            this.Controls.Add(this.buttonReport4);
            this.Controls.Add(this.buttonReport3);
            this.Controls.Add(this.buttonReport2);
            this.Controls.Add(this.buttonReport1);
            this.Controls.Add(this.RentalSearchButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BranchSelector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReturnDatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PickupDatePicker);
            this.Name = "RentalMain";
            this.Text = "Rental";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private DateTimePicker PickupDatePicker;
        private Label label1;
        private Label label2;
        private DateTimePicker ReturnDatePicker;
        private ComboBox BranchSelector;
        private Label label3;
        private Button RentalSearchButton;
        private FileSystemWatcher fileSystemWatcher1;
        private Button buttonReport1;
        private Button buttonReport2;
        private Button buttonReport3;
        private Button buttonReport4;
        private Button buttonReport5;
        private DataGridView dataGridViewReports;
    }
}

