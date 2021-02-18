using Vissoka_Marketing.Controllers;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vissoka.Core;
using Vissoka.UI;

namespace Vissoka_Marketing
{
    public partial class frmLogin : Form
    {
        readonly UserController Controller = new UserController();
        
        
        public frmLogin()
        {
          
            (new DropShadow()).ApplyShadows(this);

            InitializeComponent();
            this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // Thread.Sleep(100);
            if (Properties.Settings.Default.userID > 0)
            {
                new frmMain().ShowDialog();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void airForm1_Click(object sender, EventArgs e)
        {

        }

  


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btn_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUsername.Text)) {
                MessageBox.Show("Usúario não encontrado", "Vissoka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                btn.Enabled = false;
                Loading loading = Loading.ShowLoading(this);
                await Task.Run(() => Controller.LoginUser(txtUsername.Text, txtPassword.Text, checkKeepSession.Checked));
                Loading.StopLoading(loading);
                btn.Enabled = true;                
                if (string.IsNullOrEmpty(Properties.Settings.Default.userName))
                {
                    MessageBox.Show("Usúario ou Senha Incorrectos", "Vissoka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
                }
                else
                {
                    MessageBox.Show("Usúario ou Senha Incorrectos", "Vissoka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
              
            }          
        }


        #region animate
        void Animation()
        {
            Loading loading = Loading.ShowLoading(this);
            new Task(() => {
                Thread.Sleep(3000);
                this.Invoke((EventHandler)delegate {
                    Loading.StopLoading(loading);
                });

            }).Start();
        }
        #endregion
    }
}
