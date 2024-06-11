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
    public partial class RentalPicker : Form
    {
        public SqlConnection sqlConnection;
        public SqlCommand sqlCommand;
        public SqlDataReader sqlDataReader;

        private Dictionary<int, string> branches = new Dictionary<int, string>();
        private string selected;

        private DateTime pickupDate;
        private DateTime dropoffDate;
        private int pickupBID;
        private decimal price;

        public RentalPicker(DateTime pickup, DateTime dropoff, int BID)
        {
            pickupDate = pickup;
            dropoffDate = dropoff;
            pickupBID = BID;
            // Connecting to personal database on my device.
            // TODO: Change server and database to match your SQL information.
            String connectionString = "Server = LAPTOP-UFO08P4O; Database = CMPT291_Project; Trusted_Connection = yes;";
            InitializeComponent();

            // Connecting to SQL
            sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }

            // Add branches from database to the branches dictionary
            try
            {
                // Query database to get all branch names from the branch table
                sqlCommand.CommandText = "select BID, BranchName from Branch";

                // Read the query and insert each value into the branches dictionary
                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    branches.Add(int.Parse(sqlDataReader["BID"].ToString()), sqlDataReader["BranchName"].ToString());
                }

                sqlDataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }

            try
            {
                sqlCommand.CommandText = "select C.VIN, C.Brand, C.Make, CT.Daily, CT.Weekly, CT.Monthly, R.PickupDate, R.DropoffDate, C.BID, B.BID from Car C, CarType CT, Rented R, Branch B" +
                    "\r\nwhere C.CarType = CT.CarType and C.VIN = R.VIN and B.BID = " + BID.ToString() + " and C.BID = B.BID and R.VIN not in (select VIN from Rented where ('" + pickupDate.ToString() + "' BETWEEN PickupDate and DropoffDate) and ('" + dropoffDate.ToString() + "' BETWEEN PickupDate and DropoffDate))";

                sqlDataReader = sqlCommand.ExecuteReader();

                CarTable.Rows.Clear();
                while (sqlDataReader.Read())
                {
                    decimal totalPrice = 0;

                    // Calculate total price based on the car type's monthly, weekly and daily prices.
                    int totalDays = (dropoff - pickup).Days + 2;
                    totalPrice = (totalDays / 30) * decimal.Parse(sqlDataReader["Monthly"].ToString());
                    totalDays = totalDays % 30;
                    totalPrice += (totalDays / 7) * decimal.Parse(sqlDataReader["Weekly"].ToString());
                    totalDays = totalDays % 7;
                    totalPrice += totalDays * decimal.Parse(sqlDataReader["Daily"].ToString());

                    CarTable.Rows.Add(sqlDataReader["VIN"].ToString(), sqlDataReader["Brand"].ToString(), sqlDataReader["Make"].ToString(), totalPrice);
                }

                sqlDataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }

            if (BID == -1) { BID = 0; };
            SearchingTextLabel.Text = "Searching for cars in " + branches[BID] + " between " + pickup.ToString("dd MMMM, yyyy") + " and " + dropoff.ToString("dd MMMM, yyyy");
        }

        public void RentalCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void RentalConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCommand.CommandText = "insert into Rented values ('" + pickupDate.ToString() + "', " + pickupBID.ToString() + ", '" + dropoffDate.ToString() + "', NULL, '" + selected + "', 0, NULL, " + price.ToString() + ")";
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "Error");
            }
            RentalSuccess rentalSuccessForm = new RentalSuccess();
            rentalSuccessForm.ShowDialog();
            Close();
        }

        private void CarTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            selected = CarTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            price = decimal.Parse(CarTable.Rows[e.RowIndex].Cells[3].Value.ToString());
            RentalPickerSelectionLabel.Text = selected;
            RentalConfirmButton.Enabled = true;
        }
    }
}
