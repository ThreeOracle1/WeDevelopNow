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

        private void btnHomeMen_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.MenUserControlVisable();
        }

        private void btnHomeWomen_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.WomenUserControlVisable();
        }

        private void btnHomeBoys_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.BoysUserControlVisable();
        }

        private void btnHomeGirls_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.GirlsUserControlVisable();
        }

        private void btnHomeBrand_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.BrandUserControlVisable();
        }

        private void btnHomeBrandType_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.BrandTypeUserControlVisable();
        }
    }
}
