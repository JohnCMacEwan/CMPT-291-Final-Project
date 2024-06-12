namespace CMPT291DB
{
    partial class CarsMain
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
            homepage1 = new CarsHomePage();
            search1 = new CarsSearchPage();
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 908);
            panel1.TabIndex = 0;
            // 
            // searchbtn
            // 
            searchbtn.BackColor = Color.FromArgb(39, 157, 86);
            searchbtn.FlatAppearance.BorderColor = Color.Black;
            searchbtn.FlatStyle = FlatStyle.Flat;
            searchbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchbtn.ForeColor = Color.White;
            searchbtn.Location = new Point(30, 225);
            searchbtn.Margin = new Padding(3, 4, 3, 4);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(166, 64);
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
            homebtn.Location = new Point(30, 136);
            homebtn.Margin = new Padding(3, 4, 3, 4);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(166, 64);
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
            panel2.Location = new Point(228, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1217, 908);
            panel2.TabIndex = 1;
            // 
            // homepage1
            // 
            homepage1.BackColor = Color.White;
            homepage1.BorderStyle = BorderStyle.FixedSingle;
            homepage1.ForeColor = Color.White;
            homepage1.Location = new Point(0, 0);
            homepage1.Margin = new Padding(3, 5, 3, 5);
            homepage1.Name = "homepage1";
            homepage1.Size = new Size(1216, 907);
            homepage1.TabIndex = 0;
            // 
            // search1
            // 
            search1.BackColor = Color.White;
            search1.BorderStyle = BorderStyle.FixedSingle;
            search1.Location = new Point(0, 0);
            search1.Margin = new Padding(3, 5, 3, 5);
            search1.Name = "search1";
            search1.Size = new Size(1216, 907);
            search1.TabIndex = 1;
            // 
            // CarsMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 908);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CarsMain";
            Text = "Cars";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button searchbtn;
        private Button homebtn;
        private Panel panel2;
        private CarsSearchPage search1;
        private CarsHomePage homepage1;
    }
}
