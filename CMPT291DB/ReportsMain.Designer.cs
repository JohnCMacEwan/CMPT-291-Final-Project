namespace CMPT291DB
{
    partial class ReportsMain
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
            dataGridViewReports = new DataGridView();
            buttonReport1 = new Button();
            buttonReport2 = new Button();
            buttonReport3 = new Button();
            buttonReport4 = new Button();
            buttonReport5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReports).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewReports
            // 
            dataGridViewReports.BackgroundColor = Color.White;
            dataGridViewReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReports.Location = new Point(10, 9);
            dataGridViewReports.Margin = new Padding(3, 2, 3, 2);
            dataGridViewReports.Name = "dataGridViewReports";
            dataGridViewReports.RowHeadersWidth = 51;
            dataGridViewReports.Size = new Size(458, 191);
            dataGridViewReports.TabIndex = 0;
            // 
            // buttonReport1
            // 
            buttonReport1.BackColor = Color.FromArgb(39, 157, 86);
            buttonReport1.ForeColor = Color.White;
            buttonReport1.Location = new Point(10, 218);
            buttonReport1.Margin = new Padding(3, 2, 3, 2);
            buttonReport1.Name = "buttonReport1";
            buttonReport1.Size = new Size(88, 30);
            buttonReport1.TabIndex = 1;
            buttonReport1.Text = "Report 1";
            buttonReport1.UseVisualStyleBackColor = false;
            buttonReport1.Click += buttonReport1_Click;
            // 
            // buttonReport2
            // 
            buttonReport2.BackColor = Color.FromArgb(39, 157, 86);
            buttonReport2.ForeColor = Color.White;
            buttonReport2.Location = new Point(103, 218);
            buttonReport2.Margin = new Padding(3, 2, 3, 2);
            buttonReport2.Name = "buttonReport2";
            buttonReport2.Size = new Size(88, 30);
            buttonReport2.TabIndex = 2;
            buttonReport2.Text = "Report 2";
            buttonReport2.UseVisualStyleBackColor = false;
            buttonReport2.Click += buttonReport2_Click;
            // 
            // buttonReport3
            // 
            buttonReport3.BackColor = Color.FromArgb(39, 157, 86);
            buttonReport3.ForeColor = Color.White;
            buttonReport3.Location = new Point(196, 218);
            buttonReport3.Margin = new Padding(3, 2, 3, 2);
            buttonReport3.Name = "buttonReport3";
            buttonReport3.Size = new Size(88, 30);
            buttonReport3.TabIndex = 3;
            buttonReport3.Text = "Report 3";
            buttonReport3.UseVisualStyleBackColor = false;
            buttonReport3.Click += buttonReport3_Click;
            // 
            // buttonReport4
            // 
            buttonReport4.BackColor = Color.FromArgb(39, 157, 86);
            buttonReport4.ForeColor = Color.White;
            buttonReport4.Location = new Point(289, 218);
            buttonReport4.Margin = new Padding(3, 2, 3, 2);
            buttonReport4.Name = "buttonReport4";
            buttonReport4.Size = new Size(88, 30);
            buttonReport4.TabIndex = 4;
            buttonReport4.Text = "Report 4";
            buttonReport4.UseVisualStyleBackColor = false;
            buttonReport4.Click += buttonReport4_Click;
            // 
            // buttonReport5
            // 
            buttonReport5.BackColor = Color.FromArgb(39, 157, 86);
            buttonReport5.ForeColor = Color.White;
            buttonReport5.Location = new Point(382, 218);
            buttonReport5.Margin = new Padding(3, 2, 3, 2);
            buttonReport5.Name = "buttonReport5";
            buttonReport5.Size = new Size(88, 30);
            buttonReport5.TabIndex = 5;
            buttonReport5.Text = "Report 5";
            buttonReport5.UseVisualStyleBackColor = false;
            buttonReport5.Click += buttonReport5_Click;
            // 
           
            // 
            // ReportsMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 54, 63);
            ClientSize = new Size(480, 256);
            Controls.Add(buttonReport5);
            Controls.Add(buttonReport4);
            Controls.Add(buttonReport3);
            Controls.Add(buttonReport2);
            Controls.Add(buttonReport1);
            Controls.Add(dataGridViewReports);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReportsMain";
            Text = "ReportsMain";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewReports;
        private Button buttonReport1;
        private Button buttonReport2;
        private Button buttonReport3;
        private Button buttonReport4;
        private Button buttonReport5;
        
    }
}