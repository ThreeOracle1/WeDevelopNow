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
    public partial class UserControlGirlsSearchResultScreen : UserControl
    {

        string conString = "Data Source=(localdb)\\Local;Initial Catalog=DatabaseWeDevlopNow;Integrated Security=True";

        public UserControlGirlsSearchResultScreen()
        {
            InitializeComponent();
        }

        public void BindDataGridGirlsResult(string sqlGirlsFindStatement)
        {

            lblNoMatchesGirls.Visible = false;

            using (SqlConnection con = new SqlConnection(conString))
            {
                string starterQuery = "SELECT * FROM OurProducts";

                using (SqlCommand cmd = new SqlCommand(sqlGirlsFindStatement, con))
                {
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dgvwGirlsResults.DataSource = dt;
                        }
                    }
                }
            }
        }

        public void BindDataGridGirlsFindResult(string sqlGirlsFindStatement)
        {

            lblNoMatchesGirls.Visible = false;

            using (SqlConnection con = new SqlConnection(conString))
            {

                using (SqlCommand cmd = new SqlCommand(sqlGirlsFindStatement, con))
                {
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dgvwGirlsResults.DataSource = dt;
                            dgvwGirlsResults.Refresh();
                            dgvwGirlsResults.Update();

                            if (dgvwGirlsResults.Rows.Count == 1)
                            {
                                lblNoMatchesGirls.Visible = true;
                            }
                        }
                    }
                }
            }
        }


        private void btnGirlsResultsToHome_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.GirlsResultToHomeControlVisable();
        }

        private void btnBackToGirls_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.BackToGirlsControlVisable();
        }
    }
}
