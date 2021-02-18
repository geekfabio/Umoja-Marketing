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

        Color _selected = Color.FromArgb(64, 64, 64);
        Color _normal = Color.FromArgb(49, 50, 54);
        void GiveColor(Button button, string Title = "")
        {
            button1.BackColor = _normal;
            button2.BackColor = _normal;
            button3.BackColor = _normal;
            button4.BackColor = _normal;
            button5.BackColor = _normal;           
            button.BackColor = _selected;
            this.Text = "Umoja Marketing || " + Title;
            panelUserControl.Controls.Clear();
        }
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            labelWelcome.Text = string.Format(" Olá, {0} seja bem vindo", Properties.Settings.Default.userName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Views.ControlCliente controlCliente = new Views.ControlCliente();
            panelUserControl.Controls.Add(controlCliente);
            panelUserControl.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelUserControl.Visible = false;
            GiveColor(button1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            Cursor.Current = Cursors.WaitCursor;
            GiveColor(button2, "Clientes");
            Views.ControlCliente controlCliente = new Views.ControlCliente();

            panelUserControl.Controls.Add(controlCliente);
            panelUserControl.Visible = true;
            Cursor.Current = Cursors.Default;
        
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Cath all Excpection 
            Logger.WriteLog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            new Views.frmCategoria().Show();
        }
    }
}
