using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT291DB
{
    public partial class ReportsMain : Form
    {
        public SqlConnection sqlConnection;
        public SqlCommand sqlCommand;
        public SqlDataReader sqlDataReader;

        public ReportsMain()
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
        }

        // Event handlers for report buttons
        private void buttonReport1_Click(object sender, EventArgs e)
        {
            //test query
            try
            {
                sqlCommand.CommandText = "SELECT * FROM Car WHERE Availability = 0"; // Example query
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
