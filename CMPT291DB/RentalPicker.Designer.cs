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
            SearchingTextLabel.AutoSize = true;
            SearchingTextLabel.Location = new Point(12, 9);
            SearchingTextLabel.Name = "SearchingTextLabel";
            SearchingTextLabel.Size = new Size(407, 20);
            SearchingTextLabel.TabIndex = 0;
            SearchingTextLabel.Text = "Searching for cars in BRANCH between PICKUP and RETURN";
            // 
            // CarTable
            // 
            CarTable.AllowUserToAddRows = false;
            CarTable.AllowUserToDeleteRows = false;
            CarTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarTable.Columns.AddRange(new DataGridViewColumn[] { VIN, Brand, Make, Price });
            CarTable.Location = new Point(12, 32);
            CarTable.Name = "CarTable";
            CarTable.ReadOnly = true;
            CarTable.RowHeadersWidth = 51;
            CarTable.Size = new Size(553, 253);
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
            RentalPickerSelectionLabel.AutoSize = true;
            RentalPickerSelectionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RentalPickerSelectionLabel.Location = new Point(12, 303);
            RentalPickerSelectionLabel.Name = "RentalPickerSelectionLabel";
            RentalPickerSelectionLabel.Size = new Size(337, 28);
            RentalPickerSelectionLabel.TabIndex = 3;
            RentalPickerSelectionLabel.Text = "Select a car you would like to rent";
            RentalPickerSelectionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RentalCancelButton
            // 
            RentalCancelButton.Location = new Point(96, 378);
            RentalCancelButton.Name = "RentalCancelButton";
            RentalCancelButton.Size = new Size(132, 44);
            RentalCancelButton.TabIndex = 4;
            RentalCancelButton.Text = "Cancel";
            RentalCancelButton.UseVisualStyleBackColor = true;
            RentalCancelButton.Click += RentalCancelButton_Click;
            // 
            // RentalConfirmButton
            // 
            RentalConfirmButton.Enabled = false;
            RentalConfirmButton.Location = new Point(345, 378);
            RentalConfirmButton.Name = "RentalConfirmButton";
            RentalConfirmButton.Size = new Size(132, 44);
            RentalConfirmButton.TabIndex = 5;
            RentalConfirmButton.Text = "Confirm";
            RentalConfirmButton.UseVisualStyleBackColor = true;
            RentalConfirmButton.Click += RentalConfirmButton_Click;
            // 
            // RentalPicker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 450);
            Controls.Add(RentalConfirmButton);
            Controls.Add(RentalCancelButton);
            Controls.Add(RentalPickerSelectionLabel);
            Controls.Add(CarTable);
            Controls.Add(SearchingTextLabel);
            Name = "RentalPicker";
            ((System.ComponentModel.ISupportInitialize)CarTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
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