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
        string conString = "Data Source=(localdb)\\Local;Initial Catalog=DatabaseWeDevlopNow;Integrated Security=True";

        public UserControlMenSearchScreen()
        {
            InitializeComponent();

            PopulateProductTypeDropdownBox();

            PopulateSizeDropdownBox();

            PopulateColourDropdownBox();

            PopulateBrandDropdownBox();
        }



        List<string> columnProductTypelist = new List<string>();

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
            Form1 formInstance = new Form1();

            UserControlMenSearchResultScreen menResultInstance = new UserControlMenSearchResultScreen();

            string sqlMenStatementReady = FindTableSearchQueryMen();

            if (validFindRequest == true)
            {

                menResultInstance.BindDataGridMenFindResult(sqlMenStatementReady);


                formInstance.MenToMenResultControlVisable();
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

            return "SELECT [Product Type], [Mens Sizes], Colour, Price, Brands FROM OurProducts WHERE [Product Type] ='" + menProductTypeSearch + "' AND [Mens Sizes]='" + menSizeSearch + "' AND Colour = '" + menColourSearch + "' AND Price BETWEEN '" + menPriceMin + "' AND '" + menPriceMax + "' AND Brands = '" + menBrandSearch + "'";
        }

    }
}