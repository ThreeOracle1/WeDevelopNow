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
    public partial class UserControlGirlsSearchResultScreen : UserControl
    {
        public UserControlGirlsSearchResultScreen()
        {
            InitializeComponent();
        }

        private void btnGirlsResultsToHome_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.GirlsResultToHomeControlVisable();
        }

        private void btnBackToGirls_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.BackToGirlsControlVisable();
        }
    }
}
