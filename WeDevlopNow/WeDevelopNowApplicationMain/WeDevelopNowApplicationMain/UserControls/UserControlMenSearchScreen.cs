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

namespace WeDevelopNowApplicationMain
{
    public partial class UserControlMenSearchScreen : UserControl
    {
        public UserControlMenSearchScreen()
        {
            InitializeComponent();

            PopulateProductTypeDropdownBox();
        }



        List<string> columnProductTypelist = new List<string>();

        public void PopulateProductTypeDropdownBox()
        {
            string conString = "Data Source=(localdb)\\Local;Initial Catalog=DatabaseWeDevlopNow;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                string sqlStatement = "Select [Product Type] FROM OurProducts";

                using (SqlCommand cmd = new SqlCommand(sqlStatement, con))
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            columnProductTypelist.Add(reader.GetString(0));
                        }
                    }
                }
            }

            for (int i = 0; i < (columnProductTypelist.Count - 1); i++)
            {
                cmbxProductTypeMen.Items.Add(columnProductTypelist[i]);
            }
        }

        private void btnMenToHome_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.MenToHomeControlVisable();
        }

        private void btnFindMen_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            string menProductTypeSearch = "";

            formInstance.MenToMenResultControlVisable();
        }
    }
}
