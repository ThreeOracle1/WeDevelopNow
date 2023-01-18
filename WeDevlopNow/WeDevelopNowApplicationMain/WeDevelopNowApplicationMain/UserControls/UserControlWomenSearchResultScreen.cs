using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeDevelopNowApplicationMain
{
    public partial class UserControlWomenSearchResultScreen : UserControl
    {
        public UserControlWomenSearchResultScreen()
        {
            InitializeComponent();
        }

        private void btnBackToWomen_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.BackToWomenControlVisable();
        }

        private void btnWomenResultToHome_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.WomenResultToHomeControlVisable();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
