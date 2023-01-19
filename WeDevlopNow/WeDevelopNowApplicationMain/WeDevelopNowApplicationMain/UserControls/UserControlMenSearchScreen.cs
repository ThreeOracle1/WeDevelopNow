using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Xml.Linq;

namespace WeDevelopNowApplicationMain
{
    public partial class UserControlMenSearchScreen : UserControl
    {

        public UserControlMenSearchScreen()
        {
            InitializeComponent();

            PopulateProductTypeDropdownBox();

            PopulateSizeDropdownBox();

            PopulateColourDropdownBox();

            PopulateBrandDropdownBox();
        }

        public void PopulateProductTypeDropdownBox()
        {
            string defaultProductTypeMen = "Fleeces/Hoodies/Sweatshirts/Polo Shirts/Shoes/Shorts/Sweatshirts/Tracksuit Bottoms";

            string[] individualProductType = defaultProductTypeMen.Split('/');

            for (int i = 0; i < individualProductType.Length; i++)
            {
                cmbxProductTypeMen.Items.Add(individualProductType[i]);
            }
        }

        public void PopulateSizeDropdownBox()
        {
            string defaultSizes = "S/M/L/XL/XXL";

            string[] individualSizes = defaultSizes.Split('/');

            for (int s = 0; s < individualSizes.Length; s++)
            {
                cmbxSizeMen.Items.Add(individualSizes[s]);
            }
        }

        public void PopulateColourDropdownBox()
        {
            string defaultColours = "Black/Blue/Beige/Multi/Pink/Purple/Tan/Red";

            string[] individualColours = defaultColours.Split('/');

            for (int s = 0; s < individualColours.Length; s++)
            {
                cmbxColourMen.Items.Add(individualColours[s]);
            }
        }

        public void PopulateBrandDropdownBox()
        {
            string defaultBrands = "Brand A/Brand B/Brand C/Brand D";

            string[] individualBrands = defaultBrands.Split('/');

            for (int s = 0; s < individualBrands.Length; s++)
            {
                cmbxBrandMen.Items.Add(individualBrands[s]);
            }

        }

        private void btnMenToHome_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.MenToHomeControlVisable();
        }

        bool validFindRequest = true;

        private void btnFindMen_Click(object sender, EventArgs e)
        {

            var formInstance1 = Form.ActiveForm as Form1;

            string sqlMenStatementReady = FindTableSearchQueryMen();

            formInstance1.userControlMenSearchResultScreen1.BindDataGridMenFindResult(sqlMenStatementReady);

            if (validFindRequest == true)
            {
                formInstance1.MenToMenResultControlVisable();
            }

            validFindRequest = true;
        }

        public string FindTableSearchQueryMen()
        {

            string menProductTypeSearch = cmbxProductTypeMen.Text;

            string menSizeSearch = cmbxSizeMen.Text;

            string menColourSearch = cmbxColourMen.Text;

            string menBrandSearch = cmbxBrandMen.Text;

            int menPriceMin = 0;

            int menPriceMax = 0;

            try
            {
                menPriceMin = (int)Int64.Parse(txtbPriceMinMen.Text);
            }

            catch
            {
                MessageBox.Show("Please enter a number for price min");

                validFindRequest = false;
            }

            try
            {
                menPriceMax = (int)Int64.Parse(txtbPriceMaxMen.Text);
            }

            catch
            {
                MessageBox.Show("Please enter a number for price max");

                validFindRequest = false;
            }

            if (menPriceMin > menPriceMax)
            {
                MessageBox.Show("Please enter a valid price range");

                validFindRequest = false;
            }

            return "SELECT [Product Discription], Brands , Quantity, Location FROM OurProducts WHERE [Product Type] ='" + menProductTypeSearch + "' AND [Mens Sizes]='" + menSizeSearch + "' AND Colour = '" + menColourSearch + "' AND Price BETWEEN '" + menPriceMin + "' AND '" + menPriceMax + "' AND Brands = '" + menBrandSearch + "'";
        }

        public void SmartItenmSelectionProductTypeMen()
        {
            if (cmbxProductTypeMen.Text != null)
            {
                if (cmbxProductTypeMen.Text == "Fleeces")
                {
                    cmbxSizeMen.Text = "M";

                    cmbxColourMen.Text = "Beige";

                    cmbxBrandMen.Text = "Brand A";
                }

                if (cmbxProductTypeMen.Text == "Hoodies")
                {
                    cmbxSizeMen.Text = "L";

                    cmbxColourMen.Text = "Red";

                    cmbxBrandMen.Text = "Brand A";
                }

                if (cmbxProductTypeMen.Text == "Polo Shirts")
                {
                    cmbxSizeMen.Text = "M";

                    cmbxColourMen.Text = "Multi";

                    cmbxBrandMen.Text = "Brand A";
                }

                if (cmbxProductTypeMen.Text == "Shoes")
                {
                    cmbxSizeMen.Text = "9.5";

                    cmbxColourMen.Text = "Black";

                    cmbxBrandMen.Text = "Brand C";
                }

                if (cmbxProductTypeMen.Text == "Shorts")
                {
                    cmbxBrandMen.Text = "Not in stock";
                }

                if (cmbxProductTypeMen.Text == "Sweatshirts")
                {
                    cmbxBrandMen.Text = "Not in stock";
                }

                if (cmbxProductTypeMen.Text == "Tracksuit Bottoms")
                {
                    cmbxBrandMen.Text = "Not in stock";
                }
            }
        }

        public void SmartItenmSelectionColourMen()
        {
            if (cmbxColourMen.Text != null)
            {
                if (cmbxColourMen.Text == "Black")
                {
                    cmbxProductTypeMen.Text = "Shoes";

                    cmbxSizeMen.Text = "9.5";

                    cmbxBrandMen.Text = "Brand C";
                }

                if (cmbxColourMen.Text == "Biege")
                {
                    cmbxProductTypeMen.Text = "Fleeces";

                    cmbxSizeMen.Text = "M";

                    cmbxBrandMen.Text = "Brand A";
                }

                if (cmbxColourMen.Text == "Red")
                {
                    cmbxProductTypeMen.Text = "Hoodie";

                    cmbxSizeMen.Text = "L";

                    cmbxBrandMen.Text = "Brand A";
                }

                if (cmbxColourMen.Text == "Multi")
                {
                    cmbxProductTypeMen.Text = "Polo Shirts";

                    cmbxSizeMen.Text = "L";

                    cmbxBrandMen.Text = "Brand A";
                }
            }
        }

        public void SmartItenmSelectionBrandMen()
        {
            if (cmbxBrandMen.Text != null)
            {
                if (cmbxBrandMen.Text == "Brand A")
                {
                    cmbxProductTypeMen.Text = "Fleeces";

                    cmbxSizeMen.Text = "M";

                    cmbxColourMen.Text = "Beige";
                }

                if (cmbxProductTypeMen.Text == "Brand C")
                {
                    cmbxProductTypeMen.Text = "Shoes";

                    cmbxSizeMen.Text = "M";

                    cmbxColourMen.Text = "Black";
                }

                if (cmbxProductTypeMen.Text == "Brand C")
                {
                    cmbxProductTypeMen.Text = "Not in stock";
                }

                if (cmbxProductTypeMen.Text == "Brand D")
                {
                    cmbxProductTypeMen.Text = "Not in stock";
                }

            }
        }


        private void cmbxProductTypeMen_SelectedIndexChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionProductTypeMen();
        }

        private void cmbxSizeMen_SelectedIndexChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionColourMen();
        }

        private void cmbxSizeMen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SmartItenmSelectionColourMen();
        }

        private void cmbxProductTypeMen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SmartItenmSelectionProductTypeMen();
        }

        private void cmbxColourMen_SelectedIndexChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionColourMen();
        }

        private void cmbxColourMen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SmartItenmSelectionColourMen();
        }

        private void cmbxBrandMen_SelectedIndexChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionBrandMen();
        }

        private void cmbxBrandMen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SmartItenmSelectionBrandMen();
        }
    }
}