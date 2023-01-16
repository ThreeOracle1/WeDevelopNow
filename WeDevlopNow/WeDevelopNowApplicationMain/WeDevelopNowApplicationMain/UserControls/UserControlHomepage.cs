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
    public partial class UserControlHomepage : UserControl
    {
        

        public UserControlHomepage()
        {
            InitializeComponent();
        }

        private void btnMen_Click(object sender, EventArgs e, UserControlHomepage userControlHomepage, UserControlMenSearchScreen userControlMenSearchScreen)
        {
            userControlHomepage.Visible = false;
            userControlMenSearchScreen.Visible = true;
        }
    }
}
