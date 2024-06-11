namespace Car_Rental_Screen_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            search1.Hide();
            homepage1.Show();
            homepage1.BringToFront();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            homepage1.Hide();
            search1.Show();
            search1.BringToFront();
        }
    }
}
