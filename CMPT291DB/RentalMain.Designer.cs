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
            PickupDatePicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            ReturnDatePicker = new DateTimePicker();
            PickupBranchSelector = new ComboBox();
            label3 = new Label();
            RentalSearchButton = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            DropoffBranchSelector = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // PickupDatePicker
            // 
            PickupDatePicker.Location = new Point(12, 39);
            PickupDatePicker.Name = "PickupDatePicker";
            PickupDatePicker.Size = new Size(250, 27);
            PickupDatePicker.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 28);
            label1.TabIndex = 1;
            label1.Text = "Pickup Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 79);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 3;
            label2.Text = "Return Date";
            // 
            // ReturnDatePicker
            // 
            ReturnDatePicker.Location = new Point(12, 110);
            ReturnDatePicker.Name = "ReturnDatePicker";
            ReturnDatePicker.Size = new Size(250, 27);
            ReturnDatePicker.TabIndex = 2;
            // 
            // PickupBranchSelector
            // 
            PickupBranchSelector.FormattingEnabled = true;
            PickupBranchSelector.Location = new Point(12, 181);
            PickupBranchSelector.Name = "PickupBranchSelector";
            PickupBranchSelector.Size = new Size(151, 28);
            PickupBranchSelector.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 150);
            label3.Name = "label3";
            label3.Size = new Size(147, 28);
            label3.TabIndex = 5;
            label3.Text = "Pickup Branch";
            // 
            // RentalSearchButton
            // 
            RentalSearchButton.BackColor = Color.FromArgb(39, 157, 86);
            RentalSearchButton.FlatAppearance.BorderColor = Color.Black;
            RentalSearchButton.FlatStyle = FlatStyle.Flat;
            RentalSearchButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            RentalSearchButton.ForeColor = Color.White;
            RentalSearchButton.Location = new Point(11, 299);
            RentalSearchButton.Name = "RentalSearchButton";
            RentalSearchButton.Size = new Size(285, 64);
            RentalSearchButton.TabIndex = 6;
            RentalSearchButton.Text = "Search";
            RentalSearchButton.UseVisualStyleBackColor = false;
            RentalSearchButton.Click += RentalSearchButton_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // DropoffBranchSelector
            // 
            DropoffBranchSelector.FormattingEnabled = true;
            DropoffBranchSelector.Location = new Point(12, 252);
            DropoffBranchSelector.Name = "DropoffBranchSelector";
            DropoffBranchSelector.Size = new Size(151, 28);
            DropoffBranchSelector.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 221);
            label4.Name = "label4";
            label4.Size = new Size(159, 28);
            label4.TabIndex = 8;
            label4.Text = "Dropoff Branch";
            // 
            // RentalMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 54, 63);
            ClientSize = new Size(312, 375);
            Controls.Add(label4);
            Controls.Add(DropoffBranchSelector);
            Controls.Add(RentalSearchButton);
            Controls.Add(label3);
            Controls.Add(PickupBranchSelector);
            Controls.Add(label2);
            Controls.Add(ReturnDatePicker);
            Controls.Add(label1);
            Controls.Add(PickupDatePicker);
            Name = "RentalMain";
            Text = "Rental";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker PickupDatePicker;
        private Label label1;
        private Label label2;
        private DateTimePicker ReturnDatePicker;
        private ComboBox PickupBranchSelector;
        private Label label3;
        private Button RentalSearchButton;
        private FileSystemWatcher fileSystemWatcher1;
        private Label label4;
        private ComboBox DropoffBranchSelector;
    }
}

