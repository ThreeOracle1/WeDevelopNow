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
    public partial class UserControlMenSearchResultScreen : UserControl
    {
        public UserControlMenSearchResultScreen()
        {
            InitializeComponent();

            BindDataGridMenResult();
        }

        public void BindDataGridMenResult()
        {

            string conString = "Data Source=(localdb)\\Local;Initial Catalog=DatabaseWeDevlopNow;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(conString))
            {
                string sqlCommandStringSelectData = "SELECT * FROM OurProducts";


                using (SqlCommand cmd = new SqlCommand(sqlCommandStringSelectData, con))
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
