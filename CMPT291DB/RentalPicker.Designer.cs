namespace CMPT291DB
{
    partial class RentalPicker
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            SearchingTextLabel = new Label();
            CarTable = new DataGridView();
            VIN = new DataGridViewTextBoxColumn();
            Brand = new DataGridViewTextBoxColumn();
            Make = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            RentalPickerSelectionLabel = new Label();
            RentalCancelButton = new Button();
            RentalConfirmButton = new Button();
            ((System.ComponentModel.ISupportInitialize)CarTable).BeginInit();
            SuspendLayout();
            // 
            // SearchingTextLabel
            // 
            SearchingTextLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchingTextLabel.ForeColor = Color.White;
            SearchingTextLabel.Location = new Point(12, 20);
            SearchingTextLabel.Name = "SearchingTextLabel";
            SearchingTextLabel.Size = new Size(612, 23);
            SearchingTextLabel.TabIndex = 0;
            SearchingTextLabel.Text = "Searching for cars in BRANCH between PICKUP and RETURN";
            // 
            // CarTable
            // 
            CarTable.AllowUserToAddRows = false;
            CarTable.AllowUserToDeleteRows = false;
            CarTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CarTable.BackgroundColor = Color.FromArgb(41, 44, 53);
            CarTable.BorderStyle = BorderStyle.None;
            CarTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 44, 53);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 44, 53);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CarTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CarTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarTable.Columns.AddRange(new DataGridViewColumn[] { VIN, Brand, Make, Price });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(41, 44, 53);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(61, 64, 73);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            CarTable.DefaultCellStyle = dataGridViewCellStyle2;
            CarTable.EnableHeadersVisualStyles = false;
            CarTable.GridColor = Color.Black;
            CarTable.Location = new Point(40, 59);
            CarTable.MultiSelect = false;
            CarTable.Name = "CarTable";
            CarTable.ReadOnly = true;
            CarTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(41, 44, 53);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(61, 64, 73);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            CarTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            CarTable.RowHeadersWidth = 51;
            CarTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CarTable.Size = new Size(552, 253);
            CarTable.TabIndex = 1;
            CarTable.CellClick += CarTable_CellClick;
            // 
            // VIN
            // 
            VIN.HeaderText = "VIN";
            VIN.MinimumWidth = 6;
            VIN.Name = "VIN";
            VIN.ReadOnly = true;
            VIN.Width = 125;
            // 
            // Brand
            // 
            Brand.HeaderText = "Brand";
            Brand.MinimumWidth = 6;
            Brand.Name = "Brand";
            Brand.ReadOnly = true;
            Brand.Width = 125;
            // 
            // Make
            // 
            Make.HeaderText = "Make";
            Make.MinimumWidth = 6;
            Make.Name = "Make";
            Make.ReadOnly = true;
            Make.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 125;
            // 
            // RentalPickerSelectionLabel
            // 
            RentalPickerSelectionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RentalPickerSelectionLabel.ForeColor = Color.White;
            RentalPickerSelectionLabel.Location = new Point(12, 315);
            RentalPickerSelectionLabel.Name = "RentalPickerSelectionLabel";
            RentalPickerSelectionLabel.Size = new Size(612, 50);
            RentalPickerSelectionLabel.TabIndex = 3;
            RentalPickerSelectionLabel.Text = "Select a car you would like to rent";
            RentalPickerSelectionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RentalCancelButton
            // 
            RentalCancelButton.BackColor = Color.FromArgb(39, 157, 86);
            RentalCancelButton.FlatAppearance.BorderColor = Color.Black;
            RentalCancelButton.FlatStyle = FlatStyle.Flat;
            RentalCancelButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RentalCancelButton.ForeColor = Color.White;
            RentalCancelButton.Location = new Point(96, 378);
            RentalCancelButton.Name = "RentalCancelButton";
            RentalCancelButton.Size = new Size(132, 44);
            RentalCancelButton.TabIndex = 4;
            RentalCancelButton.Text = "Cancel";
            RentalCancelButton.UseVisualStyleBackColor = false;
            RentalCancelButton.Click += RentalCancelButton_Click;
            // 
            // RentalConfirmButton
            // 
            RentalConfirmButton.BackColor = Color.FromArgb(39, 157, 86);
            RentalConfirmButton.Enabled = false;
            RentalConfirmButton.FlatAppearance.BorderColor = Color.Black;
            RentalConfirmButton.FlatStyle = FlatStyle.Flat;
            RentalConfirmButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RentalConfirmButton.ForeColor = Color.White;
            RentalConfirmButton.Location = new Point(345, 378);
            RentalConfirmButton.Name = "RentalConfirmButton";
            RentalConfirmButton.Size = new Size(132, 44);
            RentalConfirmButton.TabIndex = 5;
            RentalConfirmButton.Text = "Confirm";
            RentalConfirmButton.UseVisualStyleBackColor = false;
            RentalConfirmButton.Click += RentalConfirmButton_Click;
            // 
            // RentalPicker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 54, 63);
            ClientSize = new Size(636, 450);
            Controls.Add(RentalConfirmButton);
            Controls.Add(RentalCancelButton);
            Controls.Add(RentalPickerSelectionLabel);
            Controls.Add(CarTable);
            Controls.Add(SearchingTextLabel);
            Name = "RentalPicker";
            ((System.ComponentModel.ISupportInitialize)CarTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label SearchingTextLabel;
        private DataGridView CarTable;
        private DataGridViewTextBoxColumn VIN;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn Make;
        private DataGridViewTextBoxColumn Price;
        private Label RentalPickerSelectionLabel;
        private Button RentalCancelButton;
        private Button RentalConfirmButton;
    }
}