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

        public Form1()
        {
            InitializeComponent();

            DisableAllUserControlVisability();
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
        }

        public void MenUserControlVisable()
        {
            var formInstance1 = Form.ActiveForm as Form1;

            if (formInstance1 != null)
            {
                formInstance1.userControlHomepage1.Visible = false;

                formInstance1.userControlMenSearchScreen1.Visible = true;
            }
        }

        public void MenToHomeControlVisable()
        {
            var formInstance1 = Form.ActiveForm as Form1;

            if (formInstance1 != null)
            {
                formInstance1.userControlMenSearchScreen1.Visible = false;

                formInstance1.userControlHomepage1.Visible = true;
            }
        }

        public void WomenUserControlVisable()
        {
            {
                var formInstance1 = Form.ActiveForm as Form1;

                if (formInstance1 != null)
                {
                    formInstance1.userControlHomepage1.Visible = false;

                    formInstance1.userControlWomenSearchScreen1.Visible = true;
                }
            }
        }

        public void WomenToHomeControlVisable()
        {
            var formInstance1 = Form.ActiveForm as Form1;

            if (formInstance1 != null)
            {
                formInstance1.userControlWomenSearchScreen1.Visible = false;

                formInstance1.userControlHomepage1.Visible = true;
            }
        }
        public void BoysUserControlVisable()
        {
            {
                var formInstance1 = Form.ActiveForm as Form1;

                if (formInstance1 != null)
                {
                    formInstance1.userControlHomepage1.Visible = false;

                    formInstance1.userControlBoysSearchScreen1.Visible = true;
                }
            }
        }

        public void BoysToHomeControlVisable()
        {
            var formInstance1 = Form.ActiveForm as Form1;

            if (formInstance1 != null)
            {
                formInstance1.userControlBoysSearchScreen1.Visible = false;

                formInstance1.userControlHomepage1.Visible = true;
            }
        }

        public void GirlsUserControlVisable()
        {
            {
                var formInstance1 = Form.ActiveForm as Form1;

                if (formInstance1 != null)
                {
                    formInstance1.userControlHomepage1.Visible = false;

                    formInstance1.userControlGirlsSearchScreen1.Visible = true;
                }
            }
        }

        public void GirlsToHomeControlVisable()
        {
            var formInstance1 = Form.ActiveForm as Form1;

            if (formInstance1 != null)
            {
                formInstance1.userControlGirlsSearchScreen1.Visible = false;

                formInstance1.userControlHomepage1.Visible = true;
            }
        }

        public void BrandUserControlVisable()
        {
            {
                var formInstance1 = Form.ActiveForm as Form1;

                if (formInstance1 != null)
                {
                    formInstance1.userControlHomepage1.Visible = false;

                    formInstance1.userControlBrandSearchScreen1.Visible = true;
                }
            }
        }

        public void BrandToHomeControlVisable()
        {
            var formInstance1 = Form.ActiveForm as Form1;

            if (formInstance1 != null)
            {
                formInstance1.userControlBrandSearchScreen1.Visible = false;

                formInstance1.userControlHomepage1.Visible = true;
            }
        }

        public void BrandTypeUserControlVisable()
        {
            {
                var formInstance1 = Form.ActiveForm as Form1;

                if (formInstance1 != null)
                {
                    formInstance1.userControlHomepage1.Visible = false;

                    formInstance1.userControlBrandTypeSearchScreen1.Visible = true;
                }
            }
        }

        public void BrandTypeToHomeControlVisable()
        {
            var formInstance1 = Form.ActiveForm as Form1;

            if (formInstance1 != null)
            {
                formInstance1.userControlBrandTypeSearchScreen1.Visible = false;

                formInstance1.userControlHomepage1.Visible = true;
            }
        }
    }
}