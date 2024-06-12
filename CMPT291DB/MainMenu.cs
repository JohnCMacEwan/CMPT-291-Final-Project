using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT291DB
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void CarScreenButton_Click(object sender, EventArgs e)
        {
            CarsMain carsScreen = new CarsMain();
            carsScreen.FormClosed += new FormClosedEventHandler(ScreenClosed);
            carsScreen.Show();
            this.Hide();
        }

        private void RentalScreenButton_Click(object sender, EventArgs e)
        {
            RentalMain rentalMain = new RentalMain();
            rentalMain.FormClosed += new FormClosedEventHandler(ScreenClosed);
            rentalMain.Show();
            this.Hide();
        }

        private void ReportsScreenButton_Click(object sender, EventArgs e)
        {
            ReportsMain reportsMain = new ReportsMain();
            reportsMain.FormClosed += new FormClosedEventHandler(ScreenClosed);
            reportsMain.Show();
            this.Hide();
        }

        private void ScreenClosed(object sender, EventArgs e) { this.Show(); }
    }
}
