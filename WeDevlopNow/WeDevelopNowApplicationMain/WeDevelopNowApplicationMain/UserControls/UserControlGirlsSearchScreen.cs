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
            string defaultProductTypeGirls = "Shorts/Sweatshirts/Tracksuit Bottoms";

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
            if (String.IsNullOrWhiteSpace(cmbxProductTypeGirls.Text))
            {
                validFindRequest = false;
            }

            if (String.IsNullOrWhiteSpace(cmbxSizeGirls.Text))
            {
                validFindRequest = false;
            }

            if (String.IsNullOrWhiteSpace(cmbxColourGirls.Text))
            {
                validFindRequest = false;
            }

            if (String.IsNullOrWhiteSpace(cmbxBrandGirls.Text))
            {
                validFindRequest = false;
            }


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

            return "SELECT [Product Discription], Brands, Quantity , Location FROM OurProducts WHERE [Product Type] ='" + girlsProductTypeSearch + "' AND [Girls Sizes] like '%" + girlsSizeSearch + "%' AND Colour = '" + girlsColourSearch + "' AND Price BETWEEN '" + girlsPriceMin + "' AND '" + girlsPriceMax + "' AND Brands = '" + girlsBrandSearch + "'";
        }

        public void SmartItenmSelectionProductTypeGirls()
        {
            if (cmbxProductTypeGirls.Text != null)
            {

                if (cmbxProductTypeGirls.Text == "Shorts")
                {
                    cmbxSizeGirls.Text = "M";

                    cmbxColourGirls.Text = "Pink";

                    cmbxBrandGirls.Text = "Brand B";
                }

                if (cmbxProductTypeGirls.Text == "Sweatshirts")
                {
                    cmbxSizeGirls.Text = "S";

                    cmbxColourGirls.Text = "Purple";

                    cmbxBrandGirls.Text = "Brand C";
                }

                if (cmbxProductTypeGirls.Text == "Tracksuit Bottoms")
                {
                    cmbxSizeGirls.Text = "L";

                    cmbxColourGirls.Text = "Red";

                    cmbxBrandGirls.Text = "Brand A";
                }
            }
        }

        public void SmartItenmSelectionColourGirls()
        {
            if (cmbxColourGirls.Text != null)
            {
                if (cmbxColourGirls.Text == "Pink")
                {
                    cmbxProductTypeGirls.Text = "Shorts";

                    cmbxSizeGirls.Text = "M";

                    cmbxBrandGirls.Text = "Brand B";
                }

                if (cmbxColourGirls.Text == "Purple")
                {
                    cmbxProductTypeGirls.Text = "Sweatshirts";

                    cmbxSizeGirls.Text = "S";

                    cmbxBrandGirls.Text = "Brand C";
                }

                if (cmbxColourGirls.Text == "Red")
                {
                    cmbxProductTypeGirls.Text = "Tracksuit Bottoms";

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
                    cmbxProductTypeGirls.Text = "Tracksuit Bottoms";

                    cmbxSizeGirls.Text = "L";

                    cmbxColourGirls.Text = "Red";
                }

                if (cmbxProductTypeGirls.Text == "Brand B")
                {
                    cmbxProductTypeGirls.Text = "Shorts";

                    cmbxSizeGirls.Text = "M";

                    cmbxColourGirls.Text = "Pink";
                }

                if (cmbxProductTypeGirls.Text == "Brand C")
                {
                    cmbxProductTypeGirls.Text = "Sweatshirts";

                    cmbxSizeGirls.Text = "S";

                    cmbxColourGirls.Text = "Purple";
                }
            }
        }

        private void cmbxProductTypeGirls_TextChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionProductTypeGirls();
        }

        private void cmbxSizeGirls_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void cmbxColourGirls_TextChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionColourGirls();
        }

        private void cmbxBrandGirls_TextChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionBrandGirls();
        }
    }
}