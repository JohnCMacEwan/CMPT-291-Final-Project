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
                sqlCommand.CommandText = "select BranchName from Branch";

                // Read the query and insert each value into the branch selector
                sqlDataReader = sqlCommand.ExecuteReader();

                BranchSelector.Items.Clear();

                while (sqlDataReader.Read())
                {
                    BranchSelector.Items.Add(sqlDataReader["BranchName"].ToString());
                }

                BranchSelector.SelectedIndex = 0;

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
            int BID = BranchSelector.SelectedIndex;
            RentalPicker rentalPickerForm = new RentalPicker(pickup, dropoff, BID);
            rentalPickerForm.Text = BranchSelector.Text + "'s Available Cars";
            rentalPickerForm.Show();
        }
        // Event handlers for report buttons
        private void buttonReport1_Click(object sender, EventArgs e)
        {
            //test query
            try
            {
                sqlCommand.CommandText = "SELECT * FROM Cars WHERE IsAvailable = 1"; // Example query
                sqlDataReader = sqlCommand.ExecuteReader();
                var dataTable = new DataTable();
                dataTable.Load(sqlDataReader);
                dataGridViewReports.DataSource = dataTable;
                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
           
        }

        private void buttonReport2_Click(object sender, EventArgs e)
        {
            // SQL query to display Report 2
        }

        private void buttonReport3_Click(object sender, EventArgs e)
        {
            //SQL query to and display Report 3
        }

        private void buttonReport4_Click(object sender, EventArgs e)
        {
            //SQL query to and display Report 4
        }

        private void buttonReport5_Click(object sender, EventArgs e)
        {
            // SQL query to and display Report 5
        }
    }
}

