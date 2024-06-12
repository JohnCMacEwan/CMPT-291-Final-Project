namespace CMPT291DB
{
    partial class MainMenu
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
            label1 = new Label();
            CarScreenButton = new Button();
            RentalScreenButton = new Button();
            ReportsScreenButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(508, 114);
            label1.TabIndex = 0;
            label1.Text = "Main Menu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CarScreenButton
            // 
            CarScreenButton.BackColor = Color.FromArgb(39, 157, 86);
            CarScreenButton.FlatStyle = FlatStyle.Flat;
            CarScreenButton.Font = new Font("Segoe UI", 14.25F);
            CarScreenButton.ForeColor = Color.White;
            CarScreenButton.Location = new Point(12, 126);
            CarScreenButton.Name = "CarScreenButton";
            CarScreenButton.Size = new Size(166, 64);
            CarScreenButton.TabIndex = 1;
            CarScreenButton.Text = "Cars";
            CarScreenButton.UseVisualStyleBackColor = false;
            CarScreenButton.Click += CarScreenButton_Click;
            // 
            // RentalScreenButton
            // 
            RentalScreenButton.BackColor = Color.FromArgb(39, 157, 86);
            RentalScreenButton.FlatStyle = FlatStyle.Flat;
            RentalScreenButton.Font = new Font("Segoe UI", 14.25F);
            RentalScreenButton.ForeColor = Color.White;
            RentalScreenButton.Location = new Point(184, 126);
            RentalScreenButton.Name = "RentalScreenButton";
            RentalScreenButton.Size = new Size(166, 64);
            RentalScreenButton.TabIndex = 2;
            RentalScreenButton.Text = "Rentals";
            RentalScreenButton.UseVisualStyleBackColor = false;
            RentalScreenButton.Click += RentalScreenButton_Click;
            // 
            // ReportsScreenButton
            // 
            ReportsScreenButton.BackColor = Color.FromArgb(39, 157, 86);
            ReportsScreenButton.FlatStyle = FlatStyle.Flat;
            ReportsScreenButton.Font = new Font("Segoe UI", 14.25F);
            ReportsScreenButton.ForeColor = Color.White;
            ReportsScreenButton.Location = new Point(356, 126);
            ReportsScreenButton.Name = "ReportsScreenButton";
            ReportsScreenButton.Size = new Size(166, 64);
            ReportsScreenButton.TabIndex = 3;
            ReportsScreenButton.Text = "Reports";
            ReportsScreenButton.UseVisualStyleBackColor = false;
            ReportsScreenButton.Click += ReportsScreenButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 54, 63);
            ClientSize = new Size(532, 202);
            Controls.Add(ReportsScreenButton);
            Controls.Add(RentalScreenButton);
            Controls.Add(CarScreenButton);
            Controls.Add(label1);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button CarScreenButton;
        private Button RentalScreenButton;
        private Button ReportsScreenButton;
    }
}