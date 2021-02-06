using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vissoka_Marketing.Views
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabView);
        }

        private void viFlatButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabAdd);
        }
    }
}
