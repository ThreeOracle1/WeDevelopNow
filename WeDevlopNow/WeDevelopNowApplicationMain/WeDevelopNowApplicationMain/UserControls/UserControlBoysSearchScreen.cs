using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeDevelopNowApplicationMain
{
    public partial class UserControlBoysSearchScreen : UserControl
    {
        

        public UserControlBoysSearchScreen()
        {
            InitializeComponent();

            PopulateProductTypeDropdownBox();

            PopulateSizeDropdownBox();

            PopulateColourDropdownBox();

            PopulateBrandDropdownBox();
        }

        public void PopulateProductTypeDropdownBox()
        {
            string defaultProductTypeBoys = "Fleeces/Hoodies/Sweatshirts/Polo Shirts/Shoes/Shorts/Sweatshirts/Tracksuit Bottoms";

            string[] individualProductType = defaultProductTypeBoys.Split('/');

            for (int i = 0; i < individualProductType.Length; i++)
            {
                cmbxProductTypeBoys.Items.Add(individualProductType[i]);
            }
        }

        public void PopulateSizeDropdownBox()
        {
            string defaultSizes = "S/M/L/XL/XXL";

            string[] individualSizes = defaultSizes.Split('/');

            for (int s = 0; s < individualSizes.Length; s++)
            {
                cmbxSizeBoys.Items.Add(individualSizes[s]);
            }
        }

        public void PopulateColourDropdownBox()
        {
            string defaultColours = "Black/Blue/Beige/Multi/Pink/Purple/Tan/Red";

            string[] individualColours = defaultColours.Split('/');

            for (int s = 0; s < individualColours.Length; s++)
            {
                cmbxColourBoys.Items.Add(individualColours[s]);
            }
        }

        public void PopulateBrandDropdownBox()
        {
            string defaultBrands = "Brand A/Brand B/Brand C/Brand D";

            string[] individualBrands = defaultBrands.Split('/');

            for (int s = 0; s < individualBrands.Length; s++)
            {
                cmbxBrandBoys.Items.Add(individualBrands[s]);
            }

        }

        bool validFindRequest = true;

        private void btnBoysToHome_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.BoysToHomeControlVisable();
        }

        private void btnFindBoys_Click(object sender, EventArgs e)
        {
            var formInstance1 = Form.ActiveForm as Form1;

            string sqlBoysStatementReady = FindTableSearchQueryBoys();

            formInstance1.userControlBoysSearchResultScreen1.BindDataGridBoysFindResult(sqlBoysStatementReady);

            if (validFindRequest == true)
            {
                formInstance1.BoysToBoysResultControlVisable();
            }

            validFindRequest = true;
        }

        public string FindTableSearchQueryBoys()
        {

            string BoysProductTypeSearch = cmbxProductTypeBoys.Text;

            string BoysSizeSearch = cmbxSizeBoys.Text;

            string BoysColourSearch = cmbxColourBoys.Text;

            string BoysBrandSearch = cmbxBrandBoys.Text;

            int BoysPriceMin = 0;

            int BoysPriceMax = 0;

            try
            {
                BoysPriceMin = (int)Int64.Parse(txtbPriceMinBoys.Text);
            }

            catch
            {
                MessageBox.Show("Please enter a number for price min");

                validFindRequest = false;
            }

            try
            {
                BoysPriceMax = (int)Int64.Parse(txtbPriceMaxBoys.Text);
            }

            catch
            {
                MessageBox.Show("Please enter a number for price max");

                validFindRequest = false;
            }

            if (BoysPriceMin > BoysPriceMax)
            {
                MessageBox.Show("Please enter a valid price range");

                validFindRequest = false;
            }

            return "SELECT [Product Discription], Brands , Quantity , Location FROM OurProducts WHERE [Product Type] ='" + BoysProductTypeSearch + "' AND [Mens Sizes]='" + BoysSizeSearch + "' AND Colour = '" + BoysColourSearch + "' AND Price BETWEEN '" + BoysPriceMin + "' AND '" + BoysPriceMax + "' AND Brands = '" + BoysBrandSearch + "'";
        }

        public void SmartItenmSelectionProductTypeBoys()
        {
            if (cmbxProductTypeBoys.Text != null)
            {
                if (cmbxProductTypeBoys.Text == "Fleeces")
                {
                    cmbxSizeBoys.Text = "M";

                    cmbxColourBoys.Text = "Beige";

                    cmbxBrandBoys.Text = "Brand A";
                }

                if (cmbxProductTypeBoys.Text == "Hoodies")
                {
                    cmbxSizeBoys.Text = "L";

                    cmbxColourBoys.Text = "Red";

                    cmbxBrandBoys.Text = "Brand A";
                }

                if (cmbxProductTypeBoys.Text == "Polo Shirts")
                {
                    cmbxSizeBoys.Text = "M";

                    cmbxColourBoys.Text = "Multi";

                    cmbxBrandBoys.Text = "Brand A";
                }

                if (cmbxProductTypeBoys.Text == "Shoes")
                {
                    cmbxSizeBoys.Text = "9.5";

                    cmbxColourBoys.Text = "Black";

                    cmbxBrandBoys.Text = "Brand C";
                }

                if (cmbxProductTypeBoys.Text == "Shorts")
                {
                    cmbxBrandBoys.Text = "Not in stock";
                }

                if (cmbxProductTypeBoys.Text == "Sweatshirts")
                {
                    cmbxBrandBoys.Text = "Not in stock";
                }

                if (cmbxProductTypeBoys.Text == "Tracksuit Bottoms")
                {
                    cmbxBrandBoys.Text = "Not in stock";
                }
            }
        }

        public void SmartItenmSelectionColourBoys()
        {
            if (cmbxColourBoys.Text != null)
            {
                if (cmbxColourBoys.Text == "Black")
                {
                    cmbxProductTypeBoys.Text = "Shoes";

                    cmbxSizeBoys.Text = "9.5";

                    cmbxBrandBoys.Text = "Brand C";
                }

                if (cmbxColourBoys.Text == "Biege")
                {
                    cmbxProductTypeBoys.Text = "Fleeces";

                    cmbxSizeBoys.Text = "M";

                    cmbxBrandBoys.Text = "Brand A";
                }

                if (cmbxColourBoys.Text == "Red")
                {
                    cmbxProductTypeBoys.Text = "Hoodie";

                    cmbxSizeBoys.Text = "L";

                    cmbxBrandBoys.Text = "Brand A";
                }

                if (cmbxColourBoys.Text == "Multi")
                {
                    cmbxProductTypeBoys.Text = "Polo Shirts";

                    cmbxSizeBoys.Text = "L";

                    cmbxBrandBoys.Text = "Brand A";
                }
            }
        }

        public void SmartItenmSelectionBrandBoys()
        {
            if (cmbxBrandBoys.Text != null)
            {
                if (cmbxBrandBoys.Text == "Brand A")
                {
                    cmbxProductTypeBoys.Text = "Fleeces";

                    cmbxSizeBoys.Text = "M";

                    cmbxColourBoys.Text = "Beige";
                }

                if (cmbxProductTypeBoys.Text == "Brand C")
                {
                    cmbxProductTypeBoys.Text = "Shoes";

                    cmbxSizeBoys.Text = "M";

                    cmbxColourBoys.Text = "Black";
                }

                if (cmbxProductTypeBoys.Text == "Brand C")
                {
                    cmbxProductTypeBoys.Text = "Not in stock";
                }

                if (cmbxProductTypeBoys.Text == "Brand D")
                {
                    cmbxProductTypeBoys.Text = "Not in stock";
                }

            }
        }

        private void cmbxProductTypeBoys_SelectedIndexChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionProductTypeBoys();
        }

        private void cmbxProductTypeBoys_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SmartItenmSelectionProductTypeBoys();
        }

        private void cmbxSizeBoys_SelectedIndexChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionColourBoys();
        }

        private void cmbxSizeBoys_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SmartItenmSelectionColourBoys();
        }

        private void cmbxColourBoys_SelectedIndexChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionColourBoys();
        }

        private void cmbxColourBoys_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SmartItenmSelectionColourBoys();
        }

        private void cmbxBrandBoys_SelectedIndexChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionBrandBoys();
        }

        private void cmbxBrandBoys_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SmartItenmSelectionBrandBoys();
        }
    }
}
