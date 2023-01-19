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
    public partial class UserControlBrandTypeSearchScreen : UserControl
    {
        string conString = "Data Source=(localdb)\\Local;Initial Catalog=DatabaseWeDevlopNow;Integrated Security=True";

        public UserControlBrandTypeSearchScreen()
        {
            InitializeComponent();

            PopulateBrandDropdownBox();

            PopulateSizeDropdownBox();

            PopulateColourDropdownBox();

            PopulateGenderDropdownBox();
        }

        public void PopulateBrandDropdownBox()
        {
            string defaultBrand = "Brand A/Brand B/Brand C/Brand D";

            string[] individualBrand = defaultBrand.Split('/');

            for (int i = 0; i < individualBrand.Length; i++)
            {
                cmbxBrandBrandType.Items.Add(individualBrand[i]);
            }
        }

        public void PopulateSizeDropdownBox()
        {
            string defaultSizes = "S/M/L/XL/XXL";

            string[] individualSizes = defaultSizes.Split('/');

            for (int s = 0; s < individualSizes.Length; s++)
            {
                cmbxSizeBrandType.Items.Add(individualSizes[s]);
            }
        }

        public void PopulateColourDropdownBox()
        {
            string defaultColours = "Black/Blue/Beige/Multi/Pink/Purple/Tan/Red";

            string[] individualColours = defaultColours.Split('/');

            for (int s = 0; s < individualColours.Length; s++)
            {
                cmbxColourBrandType.Items.Add(individualColours[s]);
            }
        }

        public void PopulateGenderDropdownBox()
        {
            string defaultGender = "Mens/Womens/Boys/Girls";

            string[] individualBrands = defaultGender.Split('/');

            for (int s = 0; s < individualBrands.Length; s++)
            {
                cmbxGenderBrandType.Items.Add(individualBrands[s]);
            }

        }

        bool validFindRequest = true;

        public string FindTableSearchQueryBrandType()
        {

            string brandBrandTypeSearch = cmbxBrandBrandType.Text;

            string brandTypeSizeSearch = cmbxSizeBrandType.Text;

            string brandTypeColourSearch = cmbxColourBrandType.Text;

            string brandTypeGenderSearch = cmbxGenderBrandType.Text;

            if (brandTypeGenderSearch == "")
            {
                brandTypeGenderSearch = "Mens";

                validFindRequest = false;

                MessageBox.Show("Please enter a gender");
            }

            int brandTypePriceMin = 0;

            int brandTypePriceMax = 0;

            try
            {
                brandTypePriceMin = (int)Int64.Parse(txtbPriceMinBrandType.Text);
            }

            catch
            {
                MessageBox.Show("Please enter a number for price min");

                validFindRequest = false;
            }

            try
            {
                brandTypePriceMax = (int)Int64.Parse(txtbPriceMaxBrandType.Text);
            }

            catch
            {
                MessageBox.Show("Please enter a number for price max");

                validFindRequest = false;
            }

            if (brandTypePriceMin > brandTypePriceMax)
            {
                MessageBox.Show("Please enter a valid price range");

                validFindRequest = false;
            }
            return "SELECT [Product Discription], Brands, Quantity, Location FROM OurProducts WHERE ["+brandTypeGenderSearch+" Sizes] like '%"+ brandTypeSizeSearch + "%' AND Colour = '" + brandTypeColourSearch + "' AND Price BETWEEN '" + brandTypePriceMin + "' AND '" + brandTypePriceMax + "' AND Brands = '" + brandBrandTypeSearch + "'";
        }

        public void SmartItenmSelectionGenderBrandType()
        {
            if (cmbxGenderBrandType.Text != null)
            {
                if (cmbxGenderBrandType.Text == "Mens")
                {
                    cmbxBrandBrandType.Text = "Brand A";

                    cmbxSizeBrandType.Text = "M";

                    cmbxColourBrandType.Text = "Beige";
                }

                if (cmbxGenderBrandType.Text == "Womens")
                {
                    cmbxBrandBrandType.Text = "Brand C";

                    cmbxSizeBrandType.Text = "M";

                    cmbxColourBrandType.Text = "Blue";
                }

                if (cmbxGenderBrandType.Text == "Boys")
                {
                    cmbxBrandBrandType.Text = "Brand A";

                    cmbxSizeBrandType.Text = "M";

                    cmbxColourBrandType.Text = "Multi";
                }

                if (cmbxGenderBrandType.Text == "Girls")
                {
                    cmbxBrandBrandType.Text = "Brand C";

                    cmbxSizeBrandType.Text = "M";

                    cmbxColourBrandType.Text = "Pink";
                }
            }
        }

        public void SmartItenmSelectionBrandBrandType()
        {
            if (cmbxGenderBrandType.Text != null)
            {
                if (cmbxBrandBrandType.Text == "Brand A")
                {
                    cmbxSizeBrandType.Text = "L";

                    cmbxGenderBrandType.Text = "Mens";

                    cmbxColourBrandType.Text = "Red";
                }

                if (cmbxBrandBrandType.Text == "Brand B")
                {
                    cmbxGenderBrandType.Text = "Womens";

                    cmbxColourBrandType.Text = "Tan";
                }

                if (cmbxBrandBrandType.Text == "Brand C")
                {

                    cmbxGenderBrandType.Text = "Boys";

                    cmbxColourBrandType.Text = "Multi";
                }

                if (cmbxBrandBrandType.Text == "Brand D")
                {
                    cmbxGenderBrandType.Text = "Womens";

                    cmbxColourBrandType.Text = "Pink";
                }
            }
        }

        public void SmartItenmSelectionColourBrandType()
        {
            if (cmbxColourBrandType.Text != null)
            {
                if (cmbxColourBrandType.Text == "Black")
                {
                    cmbxSizeBrandType.Text = "9.5";

                    cmbxGenderBrandType.Text = "Mens";

                    cmbxBrandBrandType.Text = "Brand C";
                }

                if (cmbxColourBrandType.Text == "Blue")
                {
                    cmbxSizeBrandType.Text = "M";

                    cmbxGenderBrandType.Text = "Womens";

                    cmbxBrandBrandType.Text = "Brand C";
                }

                if (cmbxColourBrandType.Text == "Biege")
                {
                    cmbxSizeBrandType.Text = "M";

                    cmbxGenderBrandType.Text = "Mens";

                    cmbxBrandBrandType.Text = "Brand A";
                }

                if (cmbxColourBrandType.Text == "Red")
                {
                    cmbxSizeBrandType.Text = "L";

                    cmbxGenderBrandType.Text = "Mens";

                    cmbxBrandBrandType.Text = "Brand A";
                }

                if (cmbxColourBrandType.Text == "Multi")
                {
                    cmbxSizeBrandType.Text = "L";

                    cmbxGenderBrandType.Text = "Mens";

                    cmbxBrandBrandType.Text = "Brand A";
                }

                if (cmbxColourBrandType.Text == "Purple")
                {
                    cmbxSizeBrandType.Text = "M";

                    cmbxGenderBrandType.Text = "Womens";

                    cmbxBrandBrandType.Text = "Brand C";
                }

                if (cmbxColourBrandType.Text == "Pink")
                {
                    cmbxSizeBrandType.Text = "M";

                    cmbxGenderBrandType.Text = "Womens";

                    cmbxBrandBrandType.Text = "Brand B";
                }

                if (cmbxColourBrandType.Text == "Tan")
                {
                    cmbxGenderBrandType.Text = "Womens";

                    cmbxSizeBrandType.Text = "";

                    cmbxBrandBrandType.Text = "Brand B";
                }

            }
        }


        private void btnBrandTypeToHome_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.BrandTypeToHomeControlVisable();
        }

        private void btnFindBrandType_Click(object sender, EventArgs e)
        {
            var formInstance1 = Form.ActiveForm as Form1;

            string sqlBrandTypeStatementReady = FindTableSearchQueryBrandType();

            formInstance1.userControlBrandTypeSearchResultScreen1.BindDataGridBrandTypeFindResult(sqlBrandTypeStatementReady);

            if (validFindRequest == true)
            {
                formInstance1.BrandTypeToBrandTypeResultControlVisable();
            }

            validFindRequest = true;
        }

        private void cmbxGenderBrandType_TextChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionGenderBrandType();
        }

        private void cmbxBrandBrandType_TextChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionBrandBrandType();
        }

        private void cmbxColourBrandType_TextChanged(object sender, EventArgs e)
        {
            SmartItenmSelectionColourBrandType();
        }
    }
}
