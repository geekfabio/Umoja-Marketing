using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vissoka_Marketing
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            labelWelcome.Text = " Olá, {0} seja bem vindo" + Properties.Settings.Default.userName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Views.UserControl1 controlCliente = new Views.UserControl1();
            panelUserControl.Controls.Add(controlCliente);
            panelUserControl.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelUserControl.Visible = false;
        }
    }
}
