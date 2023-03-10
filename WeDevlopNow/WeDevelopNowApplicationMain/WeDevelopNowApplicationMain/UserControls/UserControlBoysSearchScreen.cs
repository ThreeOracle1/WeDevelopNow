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
            string defaultProductTypeBoys = "Polo Shirts/Shoes";

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
            if (String.IsNullOrWhiteSpace(cmbxProductTypeBoys.Text))
            {
                validFindRequest = false;
            }

            if (String.IsNullOrWhiteSpace(cmbxSizeBoys.Text))
            {
                validFindRequest = false;
            }

            if (String.IsNullOrWhiteSpace(cmbxColourBoys.Text))
            {
                validFindRequest = false;
            }

            if (String.IsNullOrWhiteSpace(cmbxBrandBoys.Text))
            {
                validFindRequest = false;
            }

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

            return "SELECT [Product Discription], Brands , Quantity , Location FROM OurProducts WHERE [Product Type] ='" + BoysProductTypeSearch + "' AND [Boys Sizes] like '%" + BoysSizeSearch + "%' AND Colour = '" + BoysColourSearch + "' AND Price BETWEEN '" + BoysPriceMin + "' AND '" + BoysPriceMax + "' AND Brands = '" + BoysBrandSearch + "'";
        }

        public void SmartItenmSelectionProductTypeBoys()
        {
            if (cmbxProductTypeBoys.Text != null)
            {

                if (cmbxProductTypeBoys.Text == "Polo Shirts")
                {
                    cmbxSizeBoys.Text = "M";

                    cmbxColourBoys.Text = "Multi";

                    cmbxBrandBoys.Text = "Brand C";
                }

                if (cmbxProductTypeBoys.Text == "Shoes")
                {
                    cmbxSizeBoys.Text = "9.5";

                    cmbxColourBoys.Text = "Black";

                    cmbxBrandBoys.Text = "Brand C";
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

                if (cmbxColourBoys.Text == "Multi")
                {
                    cmbxProductTypeBoys.Text = "Polo Shirts";

                    cmbxSizeBoys.Text = "L";

                    cmbxBrandBoys.Text = "Brand C";
                }
            }
        }

        public void SmartItenmSelectionBrandBoys()
        {
            if (cmbxBrandBoys.Text != null)
            {

                if (cmbxProductTypeBoys.Text == "Brand C")
                {
                    if (cmbxProductTypeBoys.Text == "Shoes")
                    {
                        cmbxSizeBoys.Text = "M";

                        cmbxColourBoys.Text = "Black";
                    }
                }

                if (cmbxProductTypeBoys.Text == "Brand C")
                {
                    if (cmbxProductTypeBoys.Text == "Polo Shirts")
                    {
                        cmbxSizeBoys.Text = "L";

                        cmbxColourBoys.Text = "Multi";
                    }
                }

            }
        }

        private void cmbxProductTypeBoys_TextChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionProductTypeBoys();
        }

        private void cmbxSizeBoys_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbxColourBoys_TextChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionColourBoys();
        }

        private void cmbxBrandBoys_TextChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionBrandBoys();
        }
    }
}
