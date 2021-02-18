using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vissoka_Marketing.Controllers;
using Vissoka_Marketing.Models;

namespace Vissoka_Marketing.Views
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
     
        }


        //variables
        readonly TestUnit unit = new TestUnit();
        readonly CustomerController Controller = new CustomerController();
        List<CustomerModel> customers = new List<CustomerModel>();
        bool isUpdateCustomer;
        int customerID = 0;
        //methods
        async Task GetCustumers(bool updateData = true)
        {
            Console.WriteLine("Debbug");
            Logger.WriteLog();
            Logger.AddToLog("Test Log", "this is a Text");
            try
            {
                //cacheDataUser
                if (updateData) customers = await Controller.GetCustomersAsync();
                if (customers != null)
                {
                    dgvClientes.Rows.Clear();
                    foreach (CustomerModel model in customers)
                    {
                        if (dgvClientes.Columns.Count > 0)
                            dgvClientes.Rows.Add(model.ID, model.Name, model.Contacts, model.Address, model.Email, model.Data_Nascimento.ToShortDateString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Controller Excepetion, verify your DB");
            }
            finally
            {
                if (customers != null)
                {
                      
                        new Task(() => {
                        Thread.Sleep(3000);
                        if (this.IsHandleCreated)
                            this.Invoke((EventHandler)delegate {
                             
                                // viImgResult.Visible = true;
                                //create a img for not found customers
                            });

                    }).Start();
                }   
            }
        }
        void GetSearch()
        {
            if (customers == null) return; //verify if cache user is Null
            try
            {
                if (dgvClientes.Rows.Count > 0) dgvClientes.Rows.Clear();
                foreach (CustomerModel model in customers)
                {
                    //Search By Name
               
                 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception();
            }

        }
        bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O nome do cliente é um campo obirgatório", "Vissoka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
                return false;
            }
            //else if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            //{
            //    MessageBox.Show("O nome do cliente é um campo obirgatório", "Vissoka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtEndereco.Focus();
            //    return false;
            //}
           
            //else if (string.IsNullOrWhiteSpace(txtContacto.Text))
            //{
            //    txtContacto.Focus();
            //    return false;
            //}
            else { return true; }

        }
        void ClearData()
        {
         
            txtEndereco.Clear();
            txtNome.Clear();
        }
        void GetInfo()
        {
            txtNome.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
          
            txtEndereco.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();

        }
       
    
        
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void fmMain_Load(object sender, EventArgs e)
        {          
            var t = Task.Run(() => GetCustumers());
            t.Wait();      

        }

        private void vissokaCard1_SizeChanged(object sender, EventArgs e)
        {
          
            int my_width = 0;
            my_width = this.Size.Width - 200;
            labelLineDecoration.Size = new Size(my_width+ 2, labelLineDecoration.Height);
         
        }

        private void vissokaCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viFlatButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabAdd);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabView);
        }

        private async void bckLoad_DoWork(object sender, DoWorkEventArgs e)
        {
          
        }

        private void bckLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (customers != null) { 
              
                foreach (CustomerModel model in customers)
                {
                    //   MessageBox.Show(model.Name);
                    DataGridViewRow viewRow = new DataGridViewRow();
                    viewRow.SetValues("Nome", "Lakra", "ID");
                    dgvClientes.Rows.Add(viewRow);
                }
            }
            else
            {
              
            }
            foreach (CustomerModel model in customers)
            {
                MessageBox.Show(model.Name);
               
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnBack.Enabled = false;
            
      
            btnAdd.Enabled = true;
            btnBack.Enabled = true;
        }

        private void cxFlatGroupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void cxFlatGroupBox1_Leave(object sender, EventArgs e)
        {
          
        }
      
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
          await unit.SaveModelsAsyncTest();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
