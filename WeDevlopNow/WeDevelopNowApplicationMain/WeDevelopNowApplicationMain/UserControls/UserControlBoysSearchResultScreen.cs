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
    public partial class UserControlBoysSearchResultScreen : UserControl
    {

        string conString = "Data Source=(localdb)\\Local;Initial Catalog=DatabaseWeDevlopNow;Integrated Security=True";

        public UserControlBoysSearchResultScreen()
        {
            InitializeComponent();
        }

        public void BindDataGridWomenResult(string sqlBoysFindStatement)
        {

            using (SqlConnection con = new SqlConnection(conString))
            {
                string starterQuery = "SELECT * FROM OurProducts";

                using (SqlCommand cmd = new SqlCommand(sqlBoysFindStatement, con))
                {
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dgvwBoysResults.DataSource = dt;
                        }
                    }
                }
            }
        }

        public void BindDataGridBoysFindResult(string sqlBoysFindStatement)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {

                using (SqlCommand cmd = new SqlCommand(sqlBoysFindStatement, con))
                {
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dgvwBoysResults.DataSource = dt;
                            dgvwBoysResults.Refresh();
                            dgvwBoysResults.Update();
                        }
                    }
                }
            }
        }



        private void btnBackToBoys_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.BackToBoysControlVisable();
        }

        private void btnBoysResultToHome_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.BoysResultToHomeControlVisable();
        }
    }
}
