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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CMPT291DB
{
    public partial class ReportsMain : Form
    {

        private readonly string connectionString = "Server = LAPTOP-UFO08P4O; Database = CMPT291_Project; Trusted_Connection = yes;";

        public ReportsMain()
        {
            InitializeComponent();
            
        }

        // Event handlers for report buttons
        private void buttonReport1_Click(object? sender, EventArgs e)
        {
            string query = @"
                SELECT
                    CONCAT(e.FirstName, ' ', e.LastName) AS EmployeeName,
                    COUNT(r.RID) AS NumRentals,
                    SUM(r.TotalPrice) AS TotalRevenue
                FROM
                    Rented r
                INNER JOIN Employee e ON r.EID = e.EID
                GROUP BY
                    CONCAT(e.FirstName, ' ', e.LastName)
                ORDER BY
                    TotalRevenue DESC;";
            ExecuteQueryAndDisplayResults(query, "Most Popular Employee by Revenue");

        }

        private void buttonReport2_Click(object sender, EventArgs e)
        {
           

            string query = @"
                    SELECT
                        b.BranchName,
                    COUNT(r.RID) AS NumRentals,
                        SUM(r.TotalPrice) AS TotalRevenue
                    FROM
                        Rented r
                    INNER JOIN Branch b ON r.PickUpBID = b.BID
                    GROUP BY
                         b.BranchName
                    ORDER BY
                        TotalRevenue DESC;";

            ExecuteQueryAndDisplayResults(query, "Revenue by Branch");

        }

        private void buttonReport3_Click(object sender, EventArgs e)
        {
           
            string query = @"
                SELECT 
                    c.Brand,
                    COUNT(*) AS RentalCount
                FROM 
                    Rented r
                JOIN 
                    Car c ON r.VIN = c.VIN
                GROUP BY 
                    c.Brand
                ORDER BY 
                    COUNT(*) DESC;";

            ExecuteQueryAndDisplayResults(query, "Rental Counts by Car Brand");

        }

        private void buttonReport4_Click(object sender, EventArgs e)
        {
           
            string query = @"
                    WITH RentalCounts AS (
                        SELECT
                            MONTH(PickUpDate) AS RentalMonth,
                            COUNT(*) AS RentalCount
                        FROM
                            Rented
                        GROUP BY
                            MONTH(PickUpDate)
                        HAVING
                            COUNT(*) >= 2
                    )
                    SELECT
                        RentalMonth,
                        RentalCount
                    FROM
                        RentalCounts
                    WHERE
                        RentalCount = (SELECT MAX(RentalCount) FROM RentalCounts);";

            ExecuteQueryAndDisplayResults(query,  "Most Popular Rental Month");

        }

        private void buttonReport5_Click(object sender, EventArgs e)
        {
            string query = @"
                    SELECT
                        b.BranchName,
                    COUNT(r.RID) AS NumRentals,
                        SUM(r.TotalPrice) AS TotalRevenue
                    FROM
                        Rented r
                    INNER JOIN Branch b ON r.PickUpBID = b.BID
                    WHERE
                        r.PickUpDate BETWEEN '2023-05-10' AND '2023-09-15'
                    GROUP BY
                        b.BranchName;";

            ExecuteQueryAndDisplayResults(query, "Rentals Between May 10, 2023 and September 15, 2023");

        }

        private void ExecuteQueryAndDisplayResults(string query, string reportName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    dataGridViewReports.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving data: " + ex.Message);
                }
            }
        }
    }
}