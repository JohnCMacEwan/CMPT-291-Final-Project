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
            dataGridViewReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReports.Location = new Point(12, 12);
            dataGridViewReports.Name = "dataGridViewReports";
            dataGridViewReports.RowHeadersWidth = 51;
            dataGridViewReports.Size = new Size(524, 255);
            dataGridViewReports.TabIndex = 0;
            // 
            // buttonReport1
            // 
            buttonReport1.Location = new Point(12, 290);
            buttonReport1.Name = "buttonReport1";
            buttonReport1.Size = new Size(100, 40);
            buttonReport1.TabIndex = 1;
            buttonReport1.Text = "Report 1";
            buttonReport1.UseVisualStyleBackColor = true;
            // 
            // buttonReport2
            // 
            buttonReport2.Location = new Point(118, 290);
            buttonReport2.Name = "buttonReport2";
            buttonReport2.Size = new Size(100, 40);
            buttonReport2.TabIndex = 2;
            buttonReport2.Text = "Report 2";
            buttonReport2.UseVisualStyleBackColor = true;
            // 
            // buttonReport3
            // 
            buttonReport3.Location = new Point(224, 290);
            buttonReport3.Name = "buttonReport3";
            buttonReport3.Size = new Size(100, 40);
            buttonReport3.TabIndex = 3;
            buttonReport3.Text = "Report 3";
            buttonReport3.UseVisualStyleBackColor = true;
            // 
            // buttonReport4
            // 
            buttonReport4.Location = new Point(330, 290);
            buttonReport4.Name = "buttonReport4";
            buttonReport4.Size = new Size(100, 40);
            buttonReport4.TabIndex = 4;
            buttonReport4.Text = "Report 4";
            buttonReport4.UseVisualStyleBackColor = true;
            // 
            // buttonReport5
            // 
            buttonReport5.Location = new Point(436, 290);
            buttonReport5.Name = "buttonReport5";
            buttonReport5.Size = new Size(100, 40);
            buttonReport5.TabIndex = 5;
            buttonReport5.Text = "Report 5";
            buttonReport5.UseVisualStyleBackColor = true;
            // 
            // ReportsMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 54, 63);
            ClientSize = new Size(548, 342);
            Controls.Add(buttonReport5);
            Controls.Add(buttonReport4);
            Controls.Add(buttonReport3);
            Controls.Add(buttonReport2);
            Controls.Add(buttonReport1);
            Controls.Add(dataGridViewReports);
            Name = "ReportsMain";
            Text = "ReportsMain";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReports).EndInit();
            ResumeLayout(false);
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