using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeDevelopNowApplicationMain
{
    public partial class Form1 : Form
    {
        UserControlHomepage homepageInstance = new UserControlHomepage();

        public Form1()
        {
            InitializeComponent();

            DisableAllUserControlVisability();

            userControlHomepage2.Visible = true;
        }

        public void DisableAllUserControlVisability()
        {
            userControlBoysSearchResultScreen1.Visible = false;
            userControlBoysSearchScreen1.Visible = false;
            userControlBrandSearchResultScreen1.Visible = false;
            userControlBrandSearchScreen1.Visible = false;
            userControlBrandTypeSearchResultScreen1.Visible = false;
            userControlBrandTypeSearchScreen1.Visible = false;
            userControlGirlsSearchResultScreen1.Visible = false;
            userControlGirlsSearchScreen1.Visible = false;
            userControlMenSearchResultScreen1.Visible = false;
            userControlMenSearchScreen1.Visible = false;
            userControlWomenSearchResultScreen1.Visible = false;
            userControlWomenSearchScreen1.Visible = false;
            userControlHomepage2.Visible = false;
        }

        public void MenSearchPage()
        {
            userControlHomepage2.Visible = false;
            userControlMenSearchScreen1.Visible = true;
        }

        public void btnHome_Click(object sender, EventArgs e)
        {

        }

        public void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
