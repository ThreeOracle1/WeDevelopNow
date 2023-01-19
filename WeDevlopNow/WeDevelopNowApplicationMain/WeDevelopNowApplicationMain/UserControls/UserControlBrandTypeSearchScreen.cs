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
            string defaultGender = "Mens/Womens";

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
                    cmbxSizeBrandType.Text = "M";

                    cmbxColourBrandType.Text = "Beige";
                }

                if (cmbxGenderBrandType.Text == "Womens")
                {
                    cmbxSizeBrandType.Text = "M";

                    cmbxColourBrandType.Text = "Blue";
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
    }
}
