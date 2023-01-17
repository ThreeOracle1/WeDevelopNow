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
    public partial class UserControlBoysSearchResultScreen : UserControl
    {
        public UserControlBoysSearchResultScreen()
        {
            InitializeComponent();
        }

        private void btnBackToBoys_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.BackToBoysControlVisable();
        }

        private void btnBoysResultToHome_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.BoysResultToHomeControlVisable();
        }
    }
}
