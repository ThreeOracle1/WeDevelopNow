using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Xml.Linq;

namespace WeDevelopNowApplicationMain
{
    public partial class UserControlWomenSearchScreen : UserControl
    {
        public UserControlWomenSearchScreen()
        {
            InitializeComponent();

            PopulateProductTypeDropdownBox();

            PopulateSizeDropdownBox();

            PopulateColourDropdownBox();

            PopulateBrandDropdownBox();
        }

        public void PopulateProductTypeDropdownBox()
        {
            string defaultProductTypeWomen = "Dresses & Skirts/Leggings & Tights/Sweatshirts";

            string[] individualProductType = defaultProductTypeWomen.Split('/');

            for (int i = 0; i < individualProductType.Length; i++)
            {
                cmbxProductTypeWomen.Items.Add(individualProductType[i]);
            }
        }

        public void PopulateSizeDropdownBox()
        {
            string defaultSizes = "S/M/L/XL/XXL";

            string[] individualSizes = defaultSizes.Split('/');

            for (int s = 0; s < individualSizes.Length; s++)
            {
                cmbxSizeWomen.Items.Add(individualSizes[s]);
            }
        }

        public void PopulateColourDropdownBox()
        {
            string defaultColours = "Black/Blue/Beige/Multi/Pink/Purple/Tan/Red";

            string[] individualColours = defaultColours.Split('/');

            for (int s = 0; s < individualColours.Length; s++)
            {
                cmbxColourWomen.Items.Add(individualColours[s]);
            }
        }


        public void PopulateBrandDropdownBox()
        {
            string defaultBrands = "Brand A/Brand B/Brand C/Brand D";

            string[] individualBrands = defaultBrands.Split('/');

            for (int s = 0; s < individualBrands.Length; s++)
            {
                cmbxBrandWomen.Items.Add(individualBrands[s]);
            }

        }

        bool validFindRequest = true;

        public string FindTableSearchQueryWomen()
        {
            if (String.IsNullOrWhiteSpace(cmbxProductTypeWomen.Text))
            {
                validFindRequest = false;
            }

            if (String.IsNullOrWhiteSpace(cmbxSizeWomen.Text))
            {
                validFindRequest = false;
            }

            if (String.IsNullOrWhiteSpace(cmbxColourWomen.Text))
            {
                validFindRequest = false;
            }

            if (String.IsNullOrWhiteSpace(cmbxBrandWomen.Text))
            {
                validFindRequest = false;
            }



            string womenProductTypeSearch = cmbxProductTypeWomen.Text;

            string womenSizeSearch = cmbxSizeWomen.Text;

            string womenColourSearch = cmbxColourWomen.Text;

            string womenBrandSearch = cmbxBrandWomen.Text;

            int womenPriceMin = 0;

            int womenPriceMax = 0;

            try
            {
                womenPriceMin = (int)Int64.Parse(txtbPriceMinWomen.Text);
            }

            catch
            {
                MessageBox.Show("Please enter a number for price min");

                validFindRequest = false;
            }

            try
            {
                womenPriceMax = (int)Int64.Parse(txtbPriceMaxWomen.Text);
            }

            catch
            {
                MessageBox.Show("Please enter a number for price max");

                validFindRequest = false;
            }

            if (womenPriceMin > womenPriceMax)
            {
                MessageBox.Show("Please enter a valid price range");

                validFindRequest = false;
            }

            return "SELECT [Product Discription], Brands , Quantity, Location FROM OurProducts WHERE [Product Type] ='" + womenProductTypeSearch + "' AND [Womens Sizes] like'%" + womenSizeSearch + "%' AND Colour = '" + womenColourSearch + "' AND Price BETWEEN '" + womenPriceMin + "' AND '" + womenPriceMax + "' AND Brands = '" + womenBrandSearch + "'";
        }





        private void btnMenToHome_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.WomenToHomeControlVisable();
        }

        private void btnFindWomen_Click(object sender, EventArgs e)
        {
            var formInstance1 = Form.ActiveForm as Form1;

            string sqlWomenStatementReady = FindTableSearchQueryWomen();

            formInstance1.userControlWomenSearchResultScreen1.BindDataGridWomenFindResult(sqlWomenStatementReady);

            if (validFindRequest == true)
            {
                formInstance1.WomenToWomenResultControlVisable();
            }

            validFindRequest = true;

        }

        public void SmartItenmSelectionProductTypeWomen()
        {
            if (cmbxProductTypeWomen.Text != null)
            {
                if (cmbxProductTypeWomen.Text == "Dresses & Skirts")
                {
                    cmbxSizeWomen.Text = "M";

                    cmbxColourWomen.Text = "Blue";

                    cmbxBrandWomen.Text = "Brand C";
                }

                if (cmbxProductTypeWomen.Text == "Leggings & Tights")
                {
                    cmbxColourWomen.Text = "Tan";

                    cmbxBrandWomen.Text = "Brand B";
                }

                if (cmbxProductTypeWomen.Text == "Sweatshirts")
                {
                    cmbxSizeWomen.Text = "M";

                    cmbxColourWomen.Text = "Pink";

                    cmbxBrandWomen.Text = "Brand D";
                }
            }
        }

        public void SmartItenmSelectionColourWomen()
        {
            if (cmbxColourWomen.Text != null)
            {
                if (cmbxColourWomen.Text == "Blue")
                {
                    cmbxProductTypeWomen.Text = "Dresses & Skirts";

                    cmbxSizeWomen.Text = "M";

                    cmbxBrandWomen.Text = "Brand C";
                }

                if (cmbxColourWomen.Text == "Tan")
                {
                    cmbxProductTypeWomen.Text = "Leggings & Tights";

                    cmbxSizeWomen.Text = "M";

                    cmbxBrandWomen.Text = "Brand B";
                }

                if (cmbxColourWomen.Text == "Pink")
                {
                    cmbxProductTypeWomen.Text = "Sweatshirts";

                    cmbxSizeWomen.Text = "M";

                    cmbxBrandWomen.Text = "Brand D";
                }
            }
        }

        public void SmartItenmSelectionBrandWomen()
        {
            if (cmbxBrandWomen.Text != null)
            {
                if (cmbxBrandWomen.Text == "Brand B")
                {
                    cmbxProductTypeWomen.Text = "Leggings & Tights";

                    cmbxSizeWomen.Text = "M";

                    cmbxColourWomen.Text = "Tan";
                }

                if (cmbxProductTypeWomen.Text == "Brand C")
                {
                    cmbxProductTypeWomen.Text = "Dresses & Skirts";

                    cmbxSizeWomen.Text = "M";

                    cmbxColourWomen.Text = "Blue";
                }

                if (cmbxProductTypeWomen.Text == "Brand D")
                {
                    cmbxProductTypeWomen.Text = "Sweatshirts";

                    cmbxSizeWomen.Text = "M";

                    cmbxColourWomen.Text = "Pink";
                }
            }
        }

        private void cmbxProductTypeWomen_TextChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionProductTypeWomen();
        }

        private void cmbxSizeWomen_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbxColourWomen_TextChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionColourWomen();
        }

        private void cmbxBrandWomen_TextChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionBrandWomen();
        }
    }
}
