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
            string defaultProductTypeBrand = "Fleeces/Hoodies/Sweatshirts/Polo Shirts/Shoes/Shorts/Sweatshirts/Tracksuit Bottoms";

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
            string defaultGender = "Mens/Womens";

            string[] individualBrands = defaultGender.Split('/');

            for (int s = 0; s < individualBrands.Length; s++)
            {
                cmbxGenderBrand.Items.Add(individualBrands[s]);
            }

        }

        bool validFindRequest = true;

        public string FindTableSearchQueryBrand()
        {

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
                return "SELECT [Product Discription], Quantity , Location FROM OurProducts WHERE [Mens Sizes]='" + brandSizeSearch + "' AND Colour = '" + brandColourSearch + "' AND Price BETWEEN '" + brandPriceMin + "' AND '" + brandPriceMax + "' AND Brands = '" + BrandSearch + "'";
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
                    cmbxProductTypeBrand.Text = "Not in stock";
                }

                if (cmbxProductTypeBrand.Text == "Sweatshirts")
                {
                    cmbxProductTypeBrand.Text = "Not in stock";
                }

                if (cmbxProductTypeBrand.Text == "Tracksuit Bottoms")
                {
                    cmbxProductTypeBrand.Text = "Not in stock";
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

                if (cmbxColourBrand.Text == "Biege")
                {
                    cmbxProductTypeBrand.Text = "Fleeces";

                    cmbxSizeBrand.Text = "M";

                    cmbxGenderBrand.Text = "Mens";
                }

                if (cmbxColourBrand.Text == "Red")
                {
                    cmbxProductTypeBrand.Text = "Hoodie";

                    cmbxSizeBrand.Text = "L";

                    cmbxGenderBrand.Text = "Mens";
                }

                if (cmbxColourBrand.Text == "Multi")
                {
                    cmbxProductTypeBrand.Text = "Polo Shirts";

                    cmbxSizeBrand.Text = "L";

                    cmbxGenderBrand.Text = "Mens";
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

            if(switchCounter == 4)
            {
                switchCounter = 0;
            }
        }

        private void cmbxGenderBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionGenderBrand();
        }

        private void cmbxGenderBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SmartItenmSelectionGenderBrand();
        }

        private void cmbxProductTypeBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionProductTypeBrand();
        }

        private void cmbxProductTypeBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SmartItenmSelectionProductTypeBrand();
        }

        private void cmbxSizeBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionColourBrand();
        }

        private void cmbxSizeBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SmartItenmSelectionColourBrand();
        }

        private void cmbxColourBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionColourBrand();
        }

        private void cmbxColourBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SmartItenmSelectionColourBrand();
        }
    }
}
