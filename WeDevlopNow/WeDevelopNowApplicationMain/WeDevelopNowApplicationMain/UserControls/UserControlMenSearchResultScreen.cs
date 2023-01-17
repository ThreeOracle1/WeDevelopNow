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
    public partial class UserControlMenSearchResultScreen : UserControl
    {
        public UserControlMenSearchResultScreen()
        {
            InitializeComponent();
        }

        private void btnBackToMen_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.BackToMenControlVisable();
        }

        private void btnMenResultToHome_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.MenResultToHomeControlVisable();
        }
    }
}
