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
    public partial class UserControlWomenSearchResultScreen : UserControl
    {

        string conString = "Data Source=(localdb)\\Local;Initial Catalog=DatabaseWeDevlopNow;Integrated Security=True";

        public UserControlWomenSearchResultScreen()
        {
            InitializeComponent();
        }


        public void BindDataGridWomenResult(string sqlWomenFindStatement)
        {

            using (SqlConnection con = new SqlConnection(conString))
            {
                string starterQuery = "SELECT * FROM OurProducts";

                using (SqlCommand cmd = new SqlCommand(sqlWomenFindStatement, con))
                {
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dgvwWomenResults.DataSource = dt;
                        }
                    }
                }
            }
        }

        public void BindDataGridWomenFindResult(string sqlWomenFindStatement)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {

                using (SqlCommand cmd = new SqlCommand(sqlWomenFindStatement, con))
                {
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dgvwWomenResults.DataSource = dt;
                            dgvwWomenResults.Refresh();
                            dgvwWomenResults.Update();
                        }
                    }
                }
            }
        }


        private void btnBackToWomen_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.BackToWomenControlVisable();
        }

        private void btnWomenResultToHome_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.WomenResultToHomeControlVisable();
        }
    }
}
