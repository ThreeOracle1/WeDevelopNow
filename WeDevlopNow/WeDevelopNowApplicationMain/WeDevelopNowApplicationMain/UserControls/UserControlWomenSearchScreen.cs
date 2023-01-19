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
            string defaultProductTypeWomen = "Fleeces/Hoodies/Sweatshirts/Polo Shirts/Shoes/Shorts/Sweatshirts/Tracksuit Bottoms";

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
                if (cmbxProductTypeWomen.Text == "Fleeces")
                {
                    cmbxSizeWomen.Text = "M";

                    cmbxColourWomen.Text = "Beige";

                    cmbxBrandWomen.Text = "Brand A";
                }

                if (cmbxProductTypeWomen.Text == "Hoodies")
                {
                    cmbxSizeWomen.Text = "L";

                    cmbxColourWomen.Text = "Red";

                    cmbxBrandWomen.Text = "Brand A";
                }

                if (cmbxProductTypeWomen.Text == "Polo Shirts")
                {
                    cmbxSizeWomen.Text = "M";

                    cmbxColourWomen.Text = "Multi";

                    cmbxBrandWomen.Text = "Brand A";
                }

                if (cmbxProductTypeWomen.Text == "Shoes")
                {
                    cmbxSizeWomen.Text = "9.5";

                    cmbxColourWomen.Text = "Black";

                    cmbxBrandWomen.Text = "Brand C";
                }

                if (cmbxProductTypeWomen.Text == "Shorts")
                {
                    cmbxBrandWomen.Text = "Not in stock";
                }

                if (cmbxProductTypeWomen.Text == "Sweatshirts")
                {
                    cmbxBrandWomen.Text = "Not in stock";
                }

                if (cmbxProductTypeWomen.Text == "Tracksuit Bottoms")
                {
                    cmbxBrandWomen.Text = "Not in stock";
                }
            }
        }

        public void SmartItenmSelectionColourWomen()
        {
            if (cmbxColourWomen.Text != null)
            {
                if (cmbxColourWomen.Text == "Black")
                {
                    cmbxProductTypeWomen.Text = "Shoes";

                    cmbxSizeWomen.Text = "9.5";

                    cmbxBrandWomen.Text = "Brand C";
                }

                if (cmbxColourWomen.Text == "Biege")
                {
                    cmbxProductTypeWomen.Text = "Fleeces";

                    cmbxSizeWomen.Text = "M";

                    cmbxBrandWomen.Text = "Brand A";
                }

                if (cmbxColourWomen.Text == "Red")
                {
                    cmbxProductTypeWomen.Text = "Hoodie";

                    cmbxSizeWomen.Text = "L";

                    cmbxBrandWomen.Text = "Brand A";
                }

                if (cmbxColourWomen.Text == "Multi")
                {
                    cmbxProductTypeWomen.Text = "Polo Shirts";

                    cmbxSizeWomen.Text = "L";

                    cmbxBrandWomen.Text = "Brand A";
                }
            }
        }

        public void SmartItenmSelectionBrandWomen()
        {
            if (cmbxBrandWomen.Text != null)
            {
                if (cmbxBrandWomen.Text == "Brand A")
                {
                    cmbxProductTypeWomen.Text = "Fleeces";

                    cmbxSizeWomen.Text = "M";

                    cmbxColourWomen.Text = "Beige";
                }

                if (cmbxProductTypeWomen.Text == "Brand C")
                {
                    cmbxProductTypeWomen.Text = "Shoes";

                    cmbxSizeWomen.Text = "M";

                    cmbxColourWomen.Text = "Black";
                }

                if (cmbxProductTypeWomen.Text == "Brand C")
                {
                    cmbxProductTypeWomen.Text = "Not in stock";
                }

                if (cmbxProductTypeWomen.Text == "Brand D")
                {
                    cmbxProductTypeWomen.Text = "Not in stock";
                }

            }
        }

        private void cmbxProductTypeWomen_SelectedIndexChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionProductTypeWomen();
        }

        private void cmbxProductTypeWomen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SmartItenmSelectionProductTypeWomen();
        }

        private void cmbxSizeWomen_SelectedIndexChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionColourWomen();
        }

        private void cmbxSizeWomen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SmartItenmSelectionColourWomen();
        }

        private void cmbxColourWomen_SelectedIndexChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionColourWomen();
        }

        private void cmbxColourWomen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SmartItenmSelectionColourWomen();
        }

        private void cmbxBrandWomen_SelectedIndexChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionBrandWomen();
        }

        private void cmbxBrandWomen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SmartItenmSelectionBrandWomen();
        }
    }
}
