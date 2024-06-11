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
    public partial class RentalSuccess : Form
    {
        public RentalSuccess()
        {
            InitializeComponent();
        }

        private void RentalSuccessFinishButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
