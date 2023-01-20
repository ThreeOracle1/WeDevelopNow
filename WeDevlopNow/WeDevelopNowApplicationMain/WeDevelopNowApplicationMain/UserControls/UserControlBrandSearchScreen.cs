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
    public partial class UserControlBrandSearchScreen : UserControl
    {
        public UserControlBrandSearchScreen()
        {
            InitializeComponent();

            PopulateProductTypeDropdownBox();

            PopulateSizeDropdownBox();

            PopulateColourDropdownBox();

            PopulateGenderDropdownBox();
        }

        public void PopulateProductTypeDropdownBox()
        {
            string defaultProductTypeBrand = "Fleeces/Hoodies/Dresses & Skirts/Leggings & Tights/Sweatshirts/Polo Shirts/Shoes/Shorts/Sweatshirts/Tracksuit Bottoms";

            string[] individualProductType = defaultProductTypeBrand.Split('/');

            for (int i = 0; i < individualProductType.Length; i++)
            {
                cmbxProductTypeBrand.Items.Add(individualProductType[i]);
            }
        }

        public void PopulateSizeDropdownBox()
        {
            string defaultSizes = "S/M/L/XL/XXL";

            string[] individualSizes = defaultSizes.Split('/');

            for (int s = 0; s < individualSizes.Length; s++)
            {
                cmbxSizeBrand.Items.Add(individualSizes[s]);
            }
        }

        public void PopulateColourDropdownBox()
        {
            string defaultColours = "Black/Blue/Beige/Multi/Pink/Purple/Tan/Red";

            string[] individualColours = defaultColours.Split('/');

            for (int s = 0; s < individualColours.Length; s++)
            {
                cmbxColourBrand.Items.Add(individualColours[s]);
            }
        }

        public void PopulateGenderDropdownBox()
        {
            string defaultGender = "Mens/Womens/Boys/Girls";

            string[] individualBrands = defaultGender.Split('/');

            for (int s = 0; s < individualBrands.Length; s++)
            {
                cmbxGenderBrand.Items.Add(individualBrands[s]);
            }

        }

        bool validFindRequest = true;

        public string FindTableSearchQueryBrand()
        {
            if (String.IsNullOrWhiteSpace(cmbxProductTypeBrand.Text))
            {
                validFindRequest = false;
            }

            if (String.IsNullOrWhiteSpace(cmbxSizeBrand.Text))
            {
                validFindRequest = false;
            }

            if (String.IsNullOrWhiteSpace(cmbxColourBrand.Text))
            {
                validFindRequest = false;
            }

            if (String.IsNullOrWhiteSpace(cmbxGenderBrand.Text))
            {
                validFindRequest = false;
            }

            string brandProductTypeSearch = cmbxProductTypeBrand.Text;

            string brandSizeSearch = cmbxSizeBrand.Text;

            string brandColourSearch = cmbxColourBrand.Text;

            string brandGenderSearch = cmbxGenderBrand.Text;

            int brandPriceMin = 0;

            int brandPriceMax = 0;

            string BrandSearch = lblCurrentBrandSelected.Text;

            try
            {
                brandPriceMin = (int)Int64.Parse(txtbPriceMinBrand.Text);
            }

            catch
            {
                MessageBox.Show("Please enter a number for price min");

                validFindRequest = false;
            }

            try
            {
                brandPriceMax = (int)Int64.Parse(txtbPriceMaxBrand.Text);
            }

            catch
            {
                MessageBox.Show("Please enter a number for price max");

                validFindRequest = false;
            }

            if (brandPriceMin > brandPriceMax)
            {
                MessageBox.Show("Please enter a valid price range");

                validFindRequest = false;
            }
                return "SELECT [Product Discription], Quantity , Location FROM OurProducts WHERE [Mens Sizes] like '%" + brandSizeSearch + "%' AND Colour = '" + brandColourSearch + "' AND Price BETWEEN '" + brandPriceMin + "' AND '" + brandPriceMax + "' AND Brands = '" + BrandSearch + "'";
        }

        public void SmartItenmSelectionProductTypeBrand()
        {
            if (cmbxProductTypeBrand.Text != null)
            {
                if (cmbxProductTypeBrand.Text == "Fleeces")
                {
                    cmbxSizeBrand.Text = "M";

                    cmbxColourBrand.Text = "Beige";

                    cmbxProductTypeBrand.Text = "Brand A";
                }

                if (cmbxProductTypeBrand.Text == "Hoodies")
                {
                    cmbxSizeBrand.Text = "L";

                    cmbxColourBrand.Text = "Red";

                    cmbxProductTypeBrand.Text = "Brand A";
                }

                if (cmbxProductTypeBrand.Text == "Dresses & Skirts")
                {
                    cmbxSizeBrand.Text = "M";

                    cmbxColourBrand.Text = "Blue";

                    cmbxProductTypeBrand.Text = "Brand C";
                }

                if (cmbxProductTypeBrand.Text == "Leggings & Tights")
                {
                    cmbxColourBrand.Text = "Tan";

                    cmbxProductTypeBrand.Text = "Brand A";
                }

                if (cmbxProductTypeBrand.Text == "Polo Shirts")
                {
                    cmbxSizeBrand.Text = "M";

                    cmbxColourBrand.Text = "Multi";

                    cmbxProductTypeBrand.Text = "Brand A";
                }

                if (cmbxProductTypeBrand.Text == "Shoes")
                {
                    cmbxSizeBrand.Text = "9.5";

                    cmbxColourBrand.Text = "Black";

                    cmbxProductTypeBrand.Text = "Brand C";
                }

                if (cmbxProductTypeBrand.Text == "Shorts")
                {
                    cmbxSizeBrand.Text = "M";

                    cmbxColourBrand.Text = "Pink";

                    cmbxProductTypeBrand.Text = "Brand B";
                }

                if (cmbxProductTypeBrand.Text == "Sweatshirts")
                {
                    cmbxSizeBrand.Text = "S";

                    cmbxColourBrand.Text = "Purple";

                    cmbxProductTypeBrand.Text = "Brand C";
                }

                if (cmbxProductTypeBrand.Text == "Tracksuit Bottoms")
                {
                    cmbxSizeBrand.Text = "L";

                    cmbxColourBrand.Text = "Red";

                    cmbxProductTypeBrand.Text = "Brand A";
                }

            }
        }

        public void SmartItenmSelectionColourBrand()
        {
            if (cmbxColourBrand.Text != null)
            {
                if (cmbxColourBrand.Text == "Black")
                {
                    cmbxProductTypeBrand.Text = "Shoes";

                    cmbxSizeBrand.Text = "9.5";

                    cmbxGenderBrand.Text = "Mens";
                }

                if (cmbxColourBrand.Text == "Blue")
                {
                    cmbxProductTypeBrand.Text = "Dresses & Skirts";

                    cmbxSizeBrand.Text = "M";

                    cmbxGenderBrand.Text = "Womens";
                }

                if (cmbxColourBrand.Text == "Biege")
                {
                    cmbxProductTypeBrand.Text = "Fleeces";

                    cmbxSizeBrand.Text = "M";

                    cmbxGenderBrand.Text = "Mens";
                }

                if (cmbxColourBrand.Text == "Red")
                {
                    if (cmbxProductTypeBrand.Text == "Hoodie")
                    {
                        cmbxSizeBrand.Text = "L";

                        cmbxGenderBrand.Text = "Mens";
                    }
                }

                if (cmbxColourBrand.Text == "Red")
                {
                    if (cmbxProductTypeBrand.Text == "Tracksuit Bottoms")
                    {
                        cmbxSizeBrand.Text = "M";

                        cmbxGenderBrand.Text = "Womens";
                    }
                }

                if (cmbxColourBrand.Text == "Multi")
                {
                    cmbxProductTypeBrand.Text = "Polo Shirts";

                    cmbxSizeBrand.Text = "L";

                    cmbxGenderBrand.Text = "Mens";
                }

                if (cmbxColourBrand.Text == "Purple")
                {
                    cmbxProductTypeBrand.Text = "Sweatshirts";

                    cmbxSizeBrand.Text = "M";

                    cmbxGenderBrand.Text = "Womens";
                }

                if (cmbxColourBrand.Text == "Pink")
                {
                    if (cmbxProductTypeBrand.Text == "Sweatshirts")
                    {
                        cmbxSizeBrand.Text = "M";

                        cmbxGenderBrand.Text = "Womens";
                    }
                }

                if (cmbxColourBrand.Text == "Pink")
                {
                    if (cmbxProductTypeBrand.Text == "Shorts")
                    {
                        cmbxSizeBrand.Text = "M";

                        cmbxGenderBrand.Text = "Girls";
                    }
                }

                if (cmbxColourBrand.Text == "Tan")
                {
                    if (cmbxProductTypeBrand.Text == "Leggings & Tights")
                    {

                        cmbxGenderBrand.Text = "Womens";
                    }
                }
            }
        }


        public void SmartItenmSelectionGenderBrand()
        {
            if (cmbxGenderBrand.Text != null)
            {
                if (cmbxGenderBrand.Text == "Mens")
                {
                    cmbxProductTypeBrand.Text = "Fleeces";

                    cmbxSizeBrand.Text = "M";

                    cmbxColourBrand.Text = "Beige";
                }

                if (cmbxGenderBrand.Text == "Womens")
                {
                    cmbxProductTypeBrand.Text = "Dresses & Skirts";

                    cmbxSizeBrand.Text = "M";

                    cmbxColourBrand.Text = "Blue";
                }

                if (cmbxGenderBrand.Text == "Boys")
                {
                    cmbxProductTypeBrand.Text = "Polo Shirts";

                    cmbxSizeBrand.Text = "M";

                    cmbxColourBrand.Text = "Multi";
                }

                if (cmbxGenderBrand.Text == "Girls")
                {
                    cmbxProductTypeBrand.Text = "Shorts";

                    cmbxSizeBrand.Text = "M";

                    cmbxColourBrand.Text = "Pink";
                }
            }
        }

        public void SmartItenmSelectionBrandBrand()
        {
            if (cmbxGenderBrand.Text != null)
            {
                if (cmbxProductTypeBrand.Text != null)
                {

                    if (lblCurrentBrandSelected.Text == "Brand A")
                    {
                        cmbxProductTypeBrand.Text = "Hoddies";

                        cmbxSizeBrand.Text = "L";

                        cmbxGenderBrand.Text = "Mens";

                        cmbxColourBrand.Text = "Red";

                    }

                    if (lblCurrentBrandSelected.Text == "Brand B")
                    {
                        cmbxProductTypeBrand.Text = "Leggings & Tights";

                        cmbxGenderBrand.Text = "Womens";

                        cmbxColourBrand.Text = "Tan";

                    }

                    if (lblCurrentBrandSelected.Text == "Brand C")
                    {
                        cmbxProductTypeBrand.Text = "Polo Shirts";

                        cmbxGenderBrand.Text = "Boys";

                        cmbxColourBrand.Text = "Multi";
                    }

                    if (lblCurrentBrandSelected.Text == "Brand D")
                    {
                        cmbxProductTypeBrand.Text = "Sweatshirts";

                        cmbxGenderBrand.Text = "Womens";

                        cmbxColourBrand.Text = "Pink";
                    }
                }
            }
        }

        private void btnBrandToHome_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.BrandToHomeControlVisable();
        }

        private void btnFindBrand_Click(object sender, EventArgs e)
        {
            var formInstance1 = Form.ActiveForm as Form1;

            string sqlBrandStatementReady = FindTableSearchQueryBrand();

            formInstance1.userControlBrandSearchResultScreen1.BindDataGridBrandFindResult(sqlBrandStatementReady);

            if (validFindRequest == true)
            {
                formInstance1.BrandToBrandResultControlVisable();
            }

            validFindRequest = true;
        }

        int switchCounter = 1;

        private void btnSwitchBrand_Click(object sender, EventArgs e)
        {
            string[] currentBrandSelected = { "Brand A", "Brand B", "Brand C", "Brand D"};

            lblCurrentBrandSelected.Text = currentBrandSelected[switchCounter];

            switchCounter++;

            SmartItenmSelectionBrandBrand();

            if (switchCounter == 4)
            {
                switchCounter = 0;
            }
        }

        private void cmbxGenderBrand_TextChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionGenderBrand();
        }

        private void cmbxProductTypeBrand_TextChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionProductTypeBrand();
        }

        private void cmbxSizeBrand_TextChanged(object sender, EventArgs e)
        {
            // Future logic on size here
        }

        private void cmbxColourBrand_TextChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionColourBrand();
        }
    }
}
