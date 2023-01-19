using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeDevelopNowApplicationMain
{
    public partial class UserControlMenSearchResultScreen : UserControl
    {

        string conString = "Data Source=(localdb)\\Local;Initial Catalog=DatabaseWeDevlopNow;Integrated Security=True";

        public UserControlMenSearchResultScreen()
        {
            InitializeComponent();
        }

        public void BindDataGridMenResult(string sqlMenFindStatement)
        {

            using (SqlConnection con = new SqlConnection(conString))
            {
                string starterQuery = "SELECT * FROM OurProducts";

                using (SqlCommand cmd = new SqlCommand(sqlMenFindStatement, con))
                {
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dgvwMenResults.DataSource = dt;
                        }
                    }
                }
            }
        }


        public void BindDataGridMenFindResult(string sqlMenFindStatement)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {

                using (SqlCommand cmd = new SqlCommand(sqlMenFindStatement, con))
                {
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dgvwMenResults.DataSource = dt;
                            dgvwMenResults.Refresh();
                            dgvwMenResults.Update();
                        }
                    }
                }
            }
        }


        private void btnBackToMen_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.BackToMenControlVisable();
        }

        private void btnMenResultToHome_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.MenResultToHomeControlVisable();
        }
    }
}
