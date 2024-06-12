using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPT291DB
{
    public partial class CarsSearchPage : UserControl
    {
        private Form addForm = null;
        private string vin;
        private string brand;
        private string make;
        private string availability;
        private string licensePlate;
        private string carType;
        public CarsSearchPage()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection("user id = 291_Admin;" + "password=291ProjectAdmin;" + "server=localhost;" + "Trusted_Connection=yes;" + "database=CMPT291_Project;" + "connection timeout =30"))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (DataTable dt = new DataTable("Cars"))
                    {
                        string query = @"
                        SELECT * FROM Car 
                        WHERE 
                        VIN LIKE '%' + @SearchTerm + '%' OR 
                        Brand LIKE '%' + @SearchTerm + '%' OR 
                        Make LIKE '%' + @SearchTerm + '%' OR 
                        LicensePlate LIKE '%' + @SearchTerm + '%' OR 
                        Type LIKE '%' + @SearchTerm + '%'";
                        using (SqlCommand cmd = new SqlCommand(query, cn))
                        {
                            cmd.Parameters.AddWithValue("@SearchTerm", searchText.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                            recordCount.Text = $"Total records: {dataGridView1.RowCount}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                searchButton.PerformClick();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (addForm == null || addForm.IsDisposed)
            {
                addForm = new Form();
                addForm.Text = "Add New";
                addForm.Size = new Size(615, 406);
                

                Label label1 = new Label();
                label1.Text = "New Selection";
                label1.Font = new Font(label1.Font.FontFamily, 26, label1.Font.Style);
                label1.AutoSize = true;
                label1.Location = new Point(184, 11);

                addForm.Controls.Add(label1);

                // TextBox

                TextBox brandTextBox = new TextBox();
                TextBox makeTextBox = new TextBox();
                TextBox licenseTextBox = new TextBox();
                TextBox carTypeTextBox = new TextBox();
                TextBox vinTextBox = new TextBox();
                CheckBox availabilityCheck = new CheckBox();

                brandTextBox.Size = new Size(299, 23);
                makeTextBox.Size = new Size(299, 23);
                licenseTextBox.Size = new Size(299, 23);
                carTypeTextBox.Size = new Size(299, 23);
                vinTextBox.Size = new Size(299, 23);

                brandTextBox.Location = new Point(167, 90);
                makeTextBox.Location = new Point(167, 119);
                licenseTextBox.Location = new Point(167, 148);
                carTypeTextBox.Location = new Point(167, 177);
                vinTextBox.Location = new Point(167, 61);

                addForm.Controls.Add(brandTextBox);
                addForm.Controls.Add(makeTextBox);
                addForm.Controls.Add(availabilityCheck);
                addForm.Controls.Add(licenseTextBox);
                addForm.Controls.Add(carTypeTextBox);
                addForm.Controls.Add(vinTextBox);

                // Button

                Button addButton = new Button();
                addButton.FlatStyle = FlatStyle.Flat;
                addButton.FlatAppearance.BorderColor = Color.Black;
                Button cancelButton = new Button();
                cancelButton.FlatStyle = FlatStyle.Flat;
                cancelButton.FlatAppearance.BorderColor = Color.Black;
                cancelButton.Click += cancelButton_Click;

                addButton.Text = "Add";
                cancelButton.Text = "Cancel";
                addButton.Font = new Font(addButton.Font.FontFamily, 14, addButton.Font.Style);
                addButton.ForeColor = Color.White;
                addButton.BackColor = Color.FromArgb(39, 157, 86);
                cancelButton.Font = new Font(cancelButton.Font.FontFamily, 14, cancelButton.Font.Style);
                cancelButton.ForeColor = Color.White;
                cancelButton.BackColor = Color.FromArgb(51, 54, 63);

                addButton.Size = new Size(299, 34);
                cancelButton.Size = new Size(299, 34);

                addButton.Location = new Point(167, 250);
                cancelButton.Location = new Point(167, 290);

                addForm.Controls.Add(addButton);
                addForm.Controls.Add(cancelButton);

                // Button Labels

                Label brandLabel = new Label();
                Label makeLabel = new Label();
                Label licenseLabel = new Label();
                Label carTypeLabel = new Label();
                Label vinLabel = new Label();


                brandLabel.Text = "Brand";
                makeLabel.Text = "Make";
                availabilityCheck.Text = "Available";
                licenseLabel.Text = "License Plate";
                carTypeLabel.Text = "Car Type";
                vinLabel.Text = "VIN";

                brandLabel.AutoSize = true;
                makeLabel.AutoSize = true;
                availabilityCheck.AutoSize = true;
                licenseLabel.AutoSize = true;
                carTypeLabel.AutoSize = true;
                vinLabel.AutoSize = true;
                availabilityCheck.Checked = true;

                brandLabel.Location = new Point(99, 90);
                makeLabel.Location = new Point(103, 119);
                availabilityCheck.Location = new Point(167, 206);
                licenseLabel.Location = new Point(40, 148);
                carTypeLabel.Location = new Point(76, 175);
                vinLabel.Location = new Point(118, 61);

                brandLabel.Font = new Font(brandLabel.Font.FontFamily, 14, brandLabel.Font.Style);
                makeLabel.Font = new Font(makeLabel.Font.FontFamily, 14, makeLabel.Font.Style);
                availabilityCheck.Font = new Font(availabilityCheck.Font.FontFamily, 14, availabilityCheck.Font.Style);
                licenseLabel.Font = new Font(licenseLabel.Font.FontFamily, 14, licenseLabel.Font.Style);
                carTypeLabel.Font = new Font(carTypeLabel.Font.FontFamily, 14, carTypeLabel.Font.Style);
                vinLabel.Font = new Font(vinLabel.Font.FontFamily, 14, vinLabel.Font.Style);

                addForm.Controls.Add(vinLabel);
                addForm.Controls.Add(brandLabel);
                addForm.Controls.Add(makeLabel);
                addForm.Controls.Add(availabilityCheck);
                addForm.Controls.Add(licenseLabel);
                addForm.Controls.Add(carTypeLabel);
                
                addForm.Show();
                addForm.Location = new Point(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y - 420);
                Random randomNum = new Random();
                addButton.Click += (s, ev) =>
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection("user id = 291_Admin;" + "password=291ProjectAdmin;" + "server=localhost;" + "Trusted_Connection=yes;" + "database=CMPT291_Project;" + "connection timeout =30"))
                        {
                            if (cn.State == ConnectionState.Closed)
                                cn.Open();

                            string insertQuery = "INSERT INTO Car (VIN, Brand, Make, Availability, LicensePlate, Type, BID) VALUES (@VIN, @Brand, @Make, @Availability, @LicensePlate, @Type, @BID)";

                            using (SqlCommand cmd = new SqlCommand(insertQuery, cn))
                            {
                                cmd.Parameters.AddWithValue("@VIN", vinTextBox.Text);
                                cmd.Parameters.AddWithValue("@Brand", brandTextBox.Text);
                                cmd.Parameters.AddWithValue("@Make", makeTextBox.Text);
                                cmd.Parameters.AddWithValue("@Availability", availabilityCheck.Checked);
                                cmd.Parameters.AddWithValue("@LicensePlate", licenseTextBox.Text);
                                cmd.Parameters.AddWithValue("@Type", carTypeTextBox.Text);
                                cmd.Parameters.AddWithValue("@BID", randomNum.Next(1, 5));
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Car added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        addForm.Close();
                        searchButton.PerformClick();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Message.Contains("FK__Car__Type__"))
                        {
                            MessageBox.Show("Please enter a valid car type!", "Error!");
                        }
                        else if (ex.Message.Contains("CK_Car_VIN") || ex.Message.Contains("column 'VIN'"))
                        {
                            MessageBox.Show("Invalid VIN! VIN must be 17 characters long!", "Error!");
                        }
                        else if (ex.Message.Contains("column 'LicensePlate'"))
                        {
                            MessageBox.Show("Invalid license plate! License plates are six characters long!", "Error!");
                        }
                        else if (ex.Message.Contains("PK__Car__"))
                        {
                            MessageBox.Show("Duplicate VIN!", "Error!");
                        }
                        else if (ex.Message.Contains("UQ__Car__"))
                        {
                            MessageBox.Show("Duplicate license plate!", "Error!");
                        }
                        else
                        {
                            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                };
            }
            else
            {
                addForm.BringToFront();
            }
        }

        private void modifybtn_Click(object sender, EventArgs e)
        {
            if (addForm == null || addForm.IsDisposed)
            {
                addForm = new Form();
                addForm.Text = "Modify Selection";
                addForm.Size = new Size(615, 406);

                Label label1 = new Label();
                label1.Text = "Modify Selection";
                label1.Font = new Font(label1.Font.FontFamily, 26, label1.Font.Style);
                label1.AutoSize = true;
                label1.Location = new Point(163, 0);

                addForm.Controls.Add(label1);

                // TextBox

                TextBox brandTextBox = new TextBox();
                TextBox makeTextBox = new TextBox();
                TextBox licenseTextBox = new TextBox();
                TextBox carTypeTextBox = new TextBox();
                TextBox vinTextBox = new TextBox();
                CheckBox availabilityCheck = new CheckBox();

                brandTextBox.Size = new Size(299, 23);
                makeTextBox.Size = new Size(299, 23);
                licenseTextBox.Size = new Size(299, 23);
                carTypeTextBox.Size = new Size(299, 23);
                vinTextBox.Size = new Size(299, 23);

                brandTextBox.Location = new Point(167, 90);
                makeTextBox.Location = new Point(167, 119);
                licenseTextBox.Location = new Point(167, 148);
                carTypeTextBox.Location = new Point(167, 177);
                vinTextBox.Location = new Point(167, 61);

                // Populate TextBox with information

                brandTextBox.Text = brand;
                makeTextBox.Text = make;
                licenseTextBox.Text = licensePlate;
                carTypeTextBox.Text = carType;
                vinTextBox.Text = vin;
                vinTextBox.ReadOnly = true;

                if (availability == "true")
                {
                    availabilityCheck.Checked = true;
                }
                else
                {
                    availabilityCheck.Checked = false;
                }


                addForm.Controls.Add(brandTextBox);
                addForm.Controls.Add(makeTextBox);
                addForm.Controls.Add(licenseTextBox);
                addForm.Controls.Add(carTypeTextBox);
                addForm.Controls.Add(vinTextBox);

                // Button

                Button modifyButton = new Button();
                modifyButton.FlatStyle = FlatStyle.Flat;
                modifyButton.FlatAppearance.BorderColor = Color.Black;
                Button cancelButton = new Button();
                cancelButton.FlatStyle = FlatStyle.Flat;
                cancelButton.FlatAppearance.BorderColor = Color.Black;
                cancelButton.Click += cancelButton_Click;

                modifyButton.Text = "Save Changes";
                cancelButton.Text = "Cancel";
                modifyButton.Font = new Font(modifyButton.Font.FontFamily, 14, modifyButton.Font.Style);
                modifyButton.ForeColor = Color.White;
                modifyButton.BackColor = Color.FromArgb(39, 157, 86);
                cancelButton.Font = new Font(cancelButton.Font.FontFamily, 14, cancelButton.Font.Style);
                cancelButton.ForeColor = Color.White;
                cancelButton.BackColor = Color.FromArgb(51, 54, 63);

                modifyButton.Size = new Size(299, 34);
                cancelButton.Size = new Size(299, 34);

                modifyButton.Location = new Point(167, 250);
                cancelButton.Location = new Point(167, 290);

                addForm.Controls.Add(modifyButton);
                addForm.Controls.Add(cancelButton);

                // Button Labels
                Label brandLabel = new Label();
                Label makeLabel = new Label();
                Label licenseLabel = new Label();
                Label carTypeLabel = new Label();
                Label vinLabel = new Label();

                vinLabel.Text = "Brand";
                brandLabel.Text = "Brand";
                makeLabel.Text = "Make";
                licenseLabel.Text = "License Plate";
                carTypeLabel.Text = "Car Type";
                vinLabel.Text = "VIN";
                availabilityCheck.Text = "Available";

                vinLabel.AutoSize = true;
                brandLabel.AutoSize = true;
                makeLabel.AutoSize = true;
                licenseLabel.AutoSize = true;
                carTypeLabel.AutoSize = true;
                vinLabel.AutoSize = true;
                availabilityCheck.AutoSize = true;

                vinLabel.Location = new Point(118, 61);
                brandLabel.Location = new Point(99, 90);
                makeLabel.Location = new Point(103, 119);
                availabilityCheck.Location = new Point(167, 206);
                licenseLabel.Location = new Point(40, 148);
                carTypeLabel.Location = new Point(76, 175);
                vinLabel.Location = new Point(118, 61);

                brandLabel.Font = new Font(brandLabel.Font.FontFamily, 14, brandLabel.Font.Style);
                makeLabel.Font = new Font(makeLabel.Font.FontFamily, 14, makeLabel.Font.Style);
                availabilityCheck.Font = new Font(availabilityCheck.Font.FontFamily, 14, availabilityCheck.Font.Style);
                licenseLabel.Font = new Font(licenseLabel.Font.FontFamily, 14, licenseLabel.Font.Style);
                carTypeLabel.Font = new Font(carTypeLabel.Font.FontFamily, 14, carTypeLabel.Font.Style);
                vinLabel.Font = new Font(vinLabel.Font.FontFamily, 14, vinLabel.Font.Style);

                addForm.Controls.Add(brandLabel);
                addForm.Controls.Add(makeLabel);
                addForm.Controls.Add(availabilityCheck);
                addForm.Controls.Add(licenseLabel);
                addForm.Controls.Add(carTypeLabel);
                addForm.Controls.Add(vinLabel);

                addForm.Show();
                addForm.Location = new Point(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y - 420);
                modifyButton.Click += (s, ev) =>
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection("user id = 291_Admin;" + "password=291ProjectAdmin;" + "server=localhost;" + "Trusted_Connection=yes;" + "database=CMPT291_Project;" + "connection timeout =30"))
                        {
                            if (cn.State == ConnectionState.Closed)
                                cn.Open();
                            string modifyQuery = "UPDATE Car SET Brand = @Brand, Make = @Make, Availability = @Availability, LicensePlate = @LicensePlate, Type = @Type WHERE VIN = @VIN";

                            using (SqlCommand cmd = new SqlCommand(modifyQuery, cn))
                            {
                                cmd.Parameters.AddWithValue("@VIN", vinTextBox.Text);
                                cmd.Parameters.AddWithValue("@Brand", brandTextBox.Text);
                                cmd.Parameters.AddWithValue("@Make", makeTextBox.Text);
                                cmd.Parameters.AddWithValue("@Availability", availabilityCheck.Checked);
                                cmd.Parameters.AddWithValue("@LicensePlate", licenseTextBox.Text);
                                cmd.Parameters.AddWithValue("@Type", carTypeTextBox.Text);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        vin = vinTextBox.Text;
                        brand = brandTextBox.Text;
                        make = makeTextBox.Text;
                        availability = availabilityCheck.Checked.ToString().ToLower();
                        licensePlate = licenseTextBox.Text;
                        carType = carTypeTextBox.Text;

                        MessageBox.Show("Car modified successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        addForm.Close();
                        searchButton.PerformClick();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Message.Contains("FK__Car__Type__"))
                        {
                            MessageBox.Show("Please enter a valid car type!", "Error!");
                        }
                        else if (ex.Message.Contains("CK_Car_VIN") || ex.Message.Contains("column 'VIN'"))
                        {
                            MessageBox.Show("Invalid VIN! VIN must be 17 characters long!", "Error!");
                        }
                        else if (ex.Message.Contains("column 'LicensePlate'"))
                        {
                            MessageBox.Show("Invalid license plate! License plates are six characters long!", "Error!");
                        }
                        else if (ex.Message.Contains("PK__Car__"))
                        {
                            MessageBox.Show("Duplicate VIN!", "Error!");
                        }
                        else if (ex.Message.Contains("UQ__Car__"))
                        {
                            MessageBox.Show("Duplicate license plate!", "Error!");
                        }
                        else
                        {
                            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                };
            }
            else
            {
                addForm.BringToFront();
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("Closing");
            addForm.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowindex = dataGridView1.CurrentRow.Index;

            try
            {
                // Check if the clicked cell is not a header and a valid row
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    modifybtn.BackColor = Color.FromArgb(255, 199, 0);
                    deletebtn.BackColor = Color.Red;
                    modifybtn.Enabled = true;
                    deletebtn.Enabled = true;
                    System.Diagnostics.Debug.WriteLine(availability);

                    // Retrieve data from the selected row
                    vin = selectedRow.Cells["VIN"].Value.ToString();
                    brand = selectedRow.Cells["Brand"].Value.ToString();
                    make = selectedRow.Cells["Make"].Value.ToString();
                    availability = selectedRow.Cells["Availability"].Value.ToString().ToLower();
                    licensePlate = selectedRow.Cells["LicensePlate"].Value.ToString();
                    carType = selectedRow.Cells["Type"].Value.ToString();
                    System.Diagnostics.Debug.WriteLine(availability);
                    // Print the retrieved data to the standard output (console)

                    MessageBox.Show($"SELECTED ROW [{rowindex}] VIN: {vin}, Brand: {brand}, Make: {make}, Availability: {availability}, License Plate: {licensePlate}, Car Type: {carType}", "Selected");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }


            System.Diagnostics.Debug.WriteLine(rowindex);
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection("user id = 291_Admin;" + "password=291ProjectAdmin;" + "server=localhost;" + "Trusted_Connection=yes;" + "database=CMPT291_Project;" + "connection timeout =30"))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();

                    string deleteQuery = "DELETE FROM Car WHERE VIN = @VIN";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, cn))
                    {
                        cmd.Parameters.AddWithValue("@VIN", vin);
                        cmd.Parameters.AddWithValue("@Brand", brand);
                        cmd.Parameters.AddWithValue("@Make", make);
                        cmd.Parameters.AddWithValue("@Availability", availability);
                        cmd.Parameters.AddWithValue("@LicensePlate", licensePlate);
                        cmd.Parameters.AddWithValue("@Type", carType);
                        cmd.ExecuteNonQuery();
                    }
                }
                searchButton.PerformClick();
                MessageBox.Show("Car deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
