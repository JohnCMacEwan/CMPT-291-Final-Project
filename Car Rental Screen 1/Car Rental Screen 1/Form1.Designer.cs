namespace Car_Rental_Screen_1
{
    partial class Form1
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
            panel1 = new Panel();
            searchbtn = new Button();
            homebtn = new Button();
            panel2 = new Panel();
            homepage1 = new homepage();
            search1 = new search();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 54, 63);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(searchbtn);
            panel1.Controls.Add(homebtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 681);
            panel1.TabIndex = 0;
            // 
            // searchbtn
            // 
            searchbtn.BackColor = Color.FromArgb(39, 157, 86);
            searchbtn.FlatAppearance.BorderColor = Color.Black;
            searchbtn.FlatStyle = FlatStyle.Flat;
            searchbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchbtn.ForeColor = Color.White;
            searchbtn.Location = new Point(26, 169);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(145, 48);
            searchbtn.TabIndex = 1;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = false;
            searchbtn.Click += searchbtn_Click;
            // 
            // homebtn
            // 
            homebtn.BackColor = Color.FromArgb(39, 157, 86);
            homebtn.FlatAppearance.BorderColor = Color.Black;
            homebtn.FlatStyle = FlatStyle.Flat;
            homebtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            homebtn.ForeColor = Color.White;
            homebtn.Location = new Point(26, 102);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(145, 48);
            homebtn.TabIndex = 0;
            homebtn.Text = "Home";
            homebtn.UseVisualStyleBackColor = false;
            homebtn.Click += homebtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(homepage1);
            panel2.Controls.Add(search1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1064, 681);
            panel2.TabIndex = 1;
            // 
            // homepage1
            // 
            homepage1.BackColor = Color.White;
            homepage1.BorderStyle = BorderStyle.FixedSingle;
            homepage1.ForeColor = Color.White;
            homepage1.Location = new Point(0, 0);
            homepage1.Name = "homepage1";
            homepage1.Size = new Size(1064, 681);
            homepage1.TabIndex = 0;
            // 
            // search1
            // 
            search1.BackColor = Color.White;
            search1.BorderStyle = BorderStyle.FixedSingle;
            search1.Location = new Point(0, 0);
            search1.Name = "search1";
            search1.Size = new Size(1064, 681);
            search1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Car Rental Screen";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button searchbtn;
        private Button homebtn;
        private Panel panel2;
        private search search1;
        private homepage homepage1;
    }
}
