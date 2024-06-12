using System.Data;
using System.Data.SqlClient;

namespace CMPT291DB
{
    public partial class RentalMain : Form
    {
        public SqlConnection sqlConnection;
        public SqlCommand sqlCommand;
        public SqlDataReader sqlDataReader;

        public RentalMain()
        {
            // Connecting to personal database on my device.
            // TODO: Change server and database to match your SQL information.
            String connectionString = "Server = LAPTOP-UFO08P4O; Database = CMPT291_Project; Trusted_Connection = yes;";
            InitializeComponent();

            // Initialize sqlCommand with a placeholder SqlCommand object.
            sqlCommand = new SqlCommand();

            // Connecting to SQL
            sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                sqlCommand.Connection = sqlConnection;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }

            // Add branches from database to the branch selector
            try
            {
                // Query database to get all branch names from the branch table
                sqlCommand.CommandText = "select BranchName from Branch order by BID";

                // Read the query and insert each value into the branch selector
                sqlDataReader = sqlCommand.ExecuteReader();

                PickupBranchSelector.Items.Clear();
                DropoffBranchSelector.Items.Clear();

                while (sqlDataReader.Read())
                {
                    PickupBranchSelector.Items.Add(sqlDataReader["BranchName"].ToString());
                    DropoffBranchSelector.Items.Add(sqlDataReader["BranchName"].ToString());
                }

                PickupBranchSelector.SelectedIndex = 0;
                DropoffBranchSelector.SelectedIndex = 0;

                sqlDataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }
        }

        // Search button clicked
        public void RentalSearchButton_Click(object sender, EventArgs e)
        {
            // Open the rental picker screen, and pass the pickup, dropoff and BID values to it.
            DateTime pickup = PickupDatePicker.Value;
            DateTime dropoff = ReturnDatePicker.Value;
            if ((dropoff - pickup).Days < 0 || (pickup - DateTime.Now).Days < 0 || (dropoff - DateTime.Now).Days < 0)
            {
                MessageBox.Show("Please enter a valid pickup and dropoff date", "Error");
                return;
            }
            int pickupBID = PickupBranchSelector.SelectedIndex + 1;
            int dropoffBID = DropoffBranchSelector.SelectedIndex + 1;
            RentalPicker rentalPickerForm = new RentalPicker(pickup, dropoff, pickupBID, dropoffBID);
            rentalPickerForm.Text = PickupBranchSelector.Text + "'s Available Cars";
            rentalPickerForm.Show();
        }
    }
}

