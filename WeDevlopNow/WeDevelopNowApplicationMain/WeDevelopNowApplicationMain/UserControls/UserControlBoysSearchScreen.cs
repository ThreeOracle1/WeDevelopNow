﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeDevelopNowApplicationMain
{
    public partial class UserControlBoysSearchScreen : UserControl
    {
        public UserControlBoysSearchScreen()
        {
            InitializeComponent();
        }

        private void btnBoysToHome_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.BoysToHomeControlVisable();
        }

        private void btnFindBoys_Click(object sender, EventArgs e)
        {
            Form1 formInstance = new Form1();

            formInstance.BoysToBoysResultControlVisable();
        }
    }
}
