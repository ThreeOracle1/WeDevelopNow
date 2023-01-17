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
    public partial class UserControlWomenSearchScreen : UserControl
    {
        public UserControlWomenSearchScreen()
        {
            InitializeComponent();
        }

        private void btnMenToHome_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.WomenToHomeControlVisable();
        }

        private void btnFindWomen_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.WomenToWomenResultControlVisable();
        }
    }
}
