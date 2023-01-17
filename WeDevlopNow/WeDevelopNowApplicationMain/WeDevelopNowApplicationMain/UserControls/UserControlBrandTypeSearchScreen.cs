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
    public partial class UserControlBrandTypeSearchScreen : UserControl
    {
        public UserControlBrandTypeSearchScreen()
        {
            InitializeComponent();
        }

        private void btnBrandTypeToHome_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.BrandTypeToHomeControlVisable();
        }

        private void btnFindBrandType_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.BrandTypeToBrandTypeResultControlVisable();
        }
    }
}
