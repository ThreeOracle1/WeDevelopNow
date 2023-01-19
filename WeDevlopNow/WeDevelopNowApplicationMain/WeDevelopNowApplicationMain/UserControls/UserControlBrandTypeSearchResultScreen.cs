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
    public partial class UserControlBrandTypeSearchResultScreen : UserControl
    {
        public UserControlBrandTypeSearchResultScreen()
        {
            InitializeComponent();
        }

        string conString = "Data Source=(localdb)\\Local;Initial Catalog=DatabaseWeDevlopNow;Integrated Security=True";

        public void BindDataGridBrandTypeResult(string sqlBrandTypeFindStatement)
        {

            using (SqlConnection con = new SqlConnection(conString))
            {
                string starterQuery = "SELECT * FROM OurProducts";

                using (SqlCommand cmd = new SqlCommand(sqlBrandTypeFindStatement, con))
                {
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dgvwBrandTypeResults.DataSource = dt;
                        }
                    }
                }
            }
        }

        public void BindDataGridBrandTypeFindResult(string sqlBrandTypeFindStatement)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {

                using (SqlCommand cmd = new SqlCommand(sqlBrandTypeFindStatement, con))
                {
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dgvwBrandTypeResults.DataSource = dt;
                            dgvwBrandTypeResults.Refresh();
                            dgvwBrandTypeResults.Update();
                        }
                    }
                }
            }
        }

        private void btnBrandTypeToHome_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.BrandTypeResultToHomeControlVisable();
        }

        private void btnBrandTypeResultBack_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.BackToBrandTypeControlVisable();
        }
    }
}
