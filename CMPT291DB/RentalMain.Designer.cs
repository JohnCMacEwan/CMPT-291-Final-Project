namespace CMPT291DB
{
    partial class CarsScreen
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
            BranchSelector = new ComboBox();
            label3 = new Label();
            RentalSearchButton = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
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
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 1;
            label1.Text = "Pickup Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
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
            // BranchSelector
            // 
            BranchSelector.FormattingEnabled = true;
            BranchSelector.Location = new Point(12, 181);
            BranchSelector.Name = "BranchSelector";
            BranchSelector.Size = new Size(151, 28);
            BranchSelector.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 158);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 5;
            label3.Text = "Branch";
            // 
            // RentalSearchButton
            // 
            RentalSearchButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RentalSearchButton.Location = new Point(12, 221);
            RentalSearchButton.Name = "RentalSearchButton";
            RentalSearchButton.Size = new Size(285, 64);
            RentalSearchButton.TabIndex = 6;
            RentalSearchButton.Text = "Search";
            RentalSearchButton.UseVisualStyleBackColor = true;
            RentalSearchButton.Click += RentalSearchButton_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // CarsScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 297);
            Controls.Add(RentalSearchButton);
            Controls.Add(label3);
            Controls.Add(BranchSelector);
            Controls.Add(label2);
            Controls.Add(ReturnDatePicker);
            Controls.Add(label1);
            Controls.Add(PickupDatePicker);
            Name = "CarsScreen";
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
        private ComboBox BranchSelector;
        private Label label3;
        private Button RentalSearchButton;
        private FileSystemWatcher fileSystemWatcher1;
    }
}
