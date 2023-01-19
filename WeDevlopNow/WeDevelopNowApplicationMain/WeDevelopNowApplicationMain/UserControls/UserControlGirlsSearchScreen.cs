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
    public partial class UserControlGirlsSearchScreen : UserControl
    {
        public UserControlGirlsSearchScreen()
        {
            InitializeComponent();

            PopulateProductTypeDropdownBox();

            PopulateSizeDropdownBox();

            PopulateColourDropdownBox();

            PopulateBrandDropdownBox();
        }

        public void PopulateProductTypeDropdownBox()
        {
            string defaultProductTypeGirls = "Fleeces/Hoodies/Sweatshirts/Polo Shirts/Shoes/Shorts/Sweatshirts/Tracksuit Bottoms";

            string[] individualProductType = defaultProductTypeGirls.Split('/');

            for (int i = 0; i < individualProductType.Length; i++)
            {
                cmbxProductTypeGirls.Items.Add(individualProductType[i]);
            }
        }

        public void PopulateSizeDropdownBox()
        {
            string defaultSizes = "S/M/L/XL/XXL";

            string[] individualSizes = defaultSizes.Split('/');

            for (int s = 0; s < individualSizes.Length; s++)
            {
                cmbxSizeGirls.Items.Add(individualSizes[s]);
            }
        }

        public void PopulateColourDropdownBox()
        {
            string defaultColours = "Black/Blue/Beige/Multi/Pink/Purple/Tan/Red";

            string[] individualColours = defaultColours.Split('/');

            for (int s = 0; s < individualColours.Length; s++)
            {
                cmbxColourGirls.Items.Add(individualColours[s]);
            }
        }

        public void PopulateBrandDropdownBox()
        {
            string defaultBrands = "Brand A/Brand B/Brand C/Brand D";

            string[] individualBrands = defaultBrands.Split('/');

            for (int s = 0; s < individualBrands.Length; s++)
            {
                cmbxBrandGirls.Items.Add(individualBrands[s]);
            }

        }

        bool validFindRequest = true;

        private void btnGirlsToHome_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.GirlsToHomeControlVisable();
        }

        private void btnFindGirls_Click(object sender, EventArgs e)
        {
            var formInstance1 = Form.ActiveForm as Form1;

            string sqlGirlsStatementReady = FindTableSearchQueryGirls();

            formInstance1.userControlGirlsSearchResultScreen1.BindDataGridGirlsFindResult(sqlGirlsStatementReady);

            if (validFindRequest == true)
            {
                formInstance1.GirlsToGirlsResultControlVisable();
            }

            validFindRequest = true;
        }

        public string FindTableSearchQueryGirls()
        {

            string girlsProductTypeSearch = cmbxProductTypeGirls.Text;

            string girlsSizeSearch = cmbxSizeGirls.Text;

            string girlsColourSearch = cmbxColourGirls.Text;

            string girlsBrandSearch = cmbxBrandGirls.Text;

            int girlsPriceMin = 0;

            int girlsPriceMax = 0;

            try
            {
                girlsPriceMin = (int)Int64.Parse(txtbPriceMinGirls.Text);
            }

            catch
            {
                MessageBox.Show("Please enter a number for price min");

                validFindRequest = false;
            }

            try
            {
                girlsPriceMax = (int)Int64.Parse(txtbPriceMaxGirls.Text);
            }

            catch
            {
                MessageBox.Show("Please enter a number for price max");

                validFindRequest = false;
            }

            if (girlsPriceMin > girlsPriceMax)
            {
                MessageBox.Show("Please enter a valid price range");

                validFindRequest = false;
            }

            return "SELECT [Product Type], [Girls Sizes], Colour, Price, Brands, Quantity FROM OurProducts WHERE [Product Type] ='" + girlsProductTypeSearch + "' AND [Mens Sizes]='" + girlsSizeSearch + "' AND Colour = '" + girlsColourSearch + "' AND Price BETWEEN '" + girlsPriceMin + "' AND '" + girlsPriceMax + "' AND Brands = '" + girlsBrandSearch + "'";
        }

        public void SmartItenmSelectionProductTypeGirls()
        {
            if (cmbxProductTypeGirls.Text != null)
            {
                if (cmbxProductTypeGirls.Text == "Fleeces")
                {
                    cmbxSizeGirls.Text = "M";

                    cmbxColourGirls.Text = "Beige";

                    cmbxBrandGirls.Text = "Brand A";
                }

                if (cmbxProductTypeGirls.Text == "Hoodies")
                {
                    cmbxSizeGirls.Text = "L";

                    cmbxColourGirls.Text = "Red";

                    cmbxBrandGirls.Text = "Brand A";
                }

                if (cmbxProductTypeGirls.Text == "Polo Shirts")
                {
                    cmbxSizeGirls.Text = "M";

                    cmbxColourGirls.Text = "Multi";

                    cmbxBrandGirls.Text = "Brand A";
                }

                if (cmbxProductTypeGirls.Text == "Shoes")
                {
                    cmbxSizeGirls.Text = "9.5";

                    cmbxColourGirls.Text = "Black";

                    cmbxBrandGirls.Text = "Brand C";
                }

                if (cmbxProductTypeGirls.Text == "Shorts")
                {
                    cmbxBrandGirls.Text = "Not in stock";
                }

                if (cmbxProductTypeGirls.Text == "Sweatshirts")
                {
                    cmbxBrandGirls.Text = "Not in stock";
                }

                if (cmbxProductTypeGirls.Text == "Tracksuit Bottoms")
                {
                    cmbxBrandGirls.Text = "Not in stock";
                }
            }
        }

        public void SmartItenmSelectionColourGirls()
        {
            if (cmbxColourGirls.Text != null)
            {
                if (cmbxColourGirls.Text == "Black")
                {
                    cmbxProductTypeGirls.Text = "Shoes";

                    cmbxSizeGirls.Text = "9.5";

                    cmbxBrandGirls.Text = "Brand C";
                }

                if (cmbxColourGirls.Text == "Biege")
                {
                    cmbxProductTypeGirls.Text = "Fleeces";

                    cmbxSizeGirls.Text = "M";

                    cmbxBrandGirls.Text = "Brand A";
                }

                if (cmbxColourGirls.Text == "Red")
                {
                    cmbxProductTypeGirls.Text = "Hoodie";

                    cmbxSizeGirls.Text = "L";

                    cmbxBrandGirls.Text = "Brand A";
                }

                if (cmbxColourGirls.Text == "Multi")
                {
                    cmbxProductTypeGirls.Text = "Polo Shirts";

                    cmbxSizeGirls.Text = "L";

                    cmbxBrandGirls.Text = "Brand A";
                }
            }
        }

        public void SmartItenmSelectionBrandGirls()
        {
            if (cmbxBrandGirls.Text != null)
            {
                if (cmbxBrandGirls.Text == "Brand A")
                {
                    cmbxProductTypeGirls.Text = "Fleeces";

                    cmbxSizeGirls.Text = "M";

                    cmbxColourGirls.Text = "Beige";
                }

                if (cmbxProductTypeGirls.Text == "Brand C")
                {
                    cmbxProductTypeGirls.Text = "Shoes";

                    cmbxSizeGirls.Text = "M";

                    cmbxColourGirls.Text = "Black";
                }

                if (cmbxProductTypeGirls.Text == "Brand C")
                {
                    cmbxProductTypeGirls.Text = "Not in stock";
                }

                if (cmbxProductTypeGirls.Text == "Brand D")
                {
                    cmbxProductTypeGirls.Text = "Not in stock";
                }

            }
        }

        private void cmbxProductTypeGirls_SelectedIndexChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionProductTypeGirls();
        }

        private void cmbxProductTypeGirls_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SmartItenmSelectionProductTypeGirls();
        }

        private void cmbxSizeGirls_SelectedIndexChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionColourGirls();
        }

        private void cmbxSizeGirls_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SmartItenmSelectionColourGirls();
        }

        private void cmbxColourGirls_SelectedIndexChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionColourGirls();
        }

        private void cmbxColourGirls_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SmartItenmSelectionColourGirls();
        }

        private void cmbxBrandGirls_SelectedIndexChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionBrandGirls();
        }

        private void cmbxBrandGirls_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SmartItenmSelectionBrandGirls();
        }
    }
}