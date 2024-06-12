namespace CMPT291DB
{
    public partial class CarsMain : Form
    {
        public CarsMain()
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
