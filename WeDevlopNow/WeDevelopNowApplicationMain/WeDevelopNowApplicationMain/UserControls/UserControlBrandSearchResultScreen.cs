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
    public partial class UserControlBrandSearchResultScreen : UserControl
    {
        string conString = "Data Source=(localdb)\\Local;Initial Catalog=DatabaseWeDevlopNow;Integrated Security=True";

        public UserControlBrandSearchResultScreen()
        {
            InitializeComponent();
        }

        public void BindDataGridBrandResult(string sqlBrandFindStatement)
        {

            lblNoMatchesBrand.Visible = false;

            using (SqlConnection con = new SqlConnection(conString))
            {
                string starterQuery = "SELECT * FROM OurProducts";

                using (SqlCommand cmd = new SqlCommand(sqlBrandFindStatement, con))
                {
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dgvwBrandResults.DataSource = dt;
                        }
                    }
                }
            }
        }

        public void BindDataGridBrandFindResult(string sqlBrandFindStatement)
        {

            lblNoMatchesBrand.Visible = false;

            using (SqlConnection con = new SqlConnection(conString))
            {

                using (SqlCommand cmd = new SqlCommand(sqlBrandFindStatement, con))
                {
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dgvwBrandResults.DataSource = dt;
                            dgvwBrandResults.Refresh();
                            dgvwBrandResults.Update();

                            if (dgvwBrandResults.Rows.Count == 1)
                            {
                                lblNoMatchesBrand.Visible = true;
                            }
                        }
                    }
                }
            }
        }


        private void btnBrandResultBack_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.BackToBrandControlVisable();
        }

        private void btnBrandResultToHome_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.BrandResultToHomeControlVisable();
        }
    }
}
