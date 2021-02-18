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
    public partial class frmCliente : Form
    {
        public frmCliente()
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
                        vissokaCardLoading.Dispose();
                        new Task(() => {
                        Thread.Sleep(3000);
                        if (this.IsHandleCreated)
                            this.Invoke((EventHandler)delegate {
                                progressIndicator1.Dispose();
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
                    if (viSearchByName.Checked)
                    {
                        if (model.Name.ToLower().Contains(txtSearch.Text.ToLower()))
                            dgvClientes.Rows.Add(model.ID, model.Name, model.Contacts, model.Address, model.Email, model.Data_Nascimento.ToShortDateString());
                    }
                    //Search By Adress
                    else if (viSearchByAddress.Checked)
                    {
                        if (model.Address.ToLower().Contains(txtSearch.Text.ToLower()))
                            dgvClientes.Rows.Add(model.ID, model.Name, model.Contacts, model.Address, model.Email, model.Data_Nascimento.ToShortDateString());
                    }
                    //Search By Contact
                    else if (viSearchByContact.Checked)
                    {
                        if (model.Contacts.Contains(txtSearch.Text))
                            dgvClientes.Rows.Add(model.ID, model.Name, model.Contacts, model.Address, model.Email, model.Data_Nascimento.ToShortDateString());
                    }
                 
                    //Search All
                    else
                    {
                        if (model.Name.ToLower().Contains(txtSearch.Text.ToLower()) || model.Contacts.Contains(txtSearch.Text) || model.Address.ToLower().Contains(txtSearch.Text.ToLower()) || model.Email.ToLower().Contains(txtSearch.Text.ToLower()))
                            dgvClientes.Rows.Add(model.ID, model.Name, model.Contacts, model.Address, model.Email, model.Data_Nascimento.ToShortDateString());
                    }
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
            else if ((txtEmail.Text.Length > 1) && (!txtEmail.Text.Contains("@")) && (!txtEmail.Text.Contains(".")))
            {
                MessageBox.Show("O email não parece estar correcto", "Vissoka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Focus();
                return false;
            }
            //else if (string.IsNullOrWhiteSpace(txtContacto.Text))
            //{
            //    txtContacto.Focus();
            //    return false;
            //}
            else { return true; }

        }
        void ClearData()
        {
            txtContacto.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNome.Clear();
        }
        void GetInfo()
        {
            txtNome.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            txtContacto.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            txtEndereco.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();

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
                vissokaCardLoading.Dispose();
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
            
            if (ValidateData())
            {
                CustomerModel customer = new CustomerModel(customerID,
                      txtNome.Text, txtContacto.Text, txtEndereco.Text, txtEmail.Text, txtNascimento.Value, txtCategoria.Text, DateTime.Now, "userROOT", 1);
                if (isUpdateCustomer)
                {
                    if (await Controller.UpdateCustomerModels(customer))
                    {
                        ClearData();
                        MessageBox.Show("Cliente " + customer.Name + " Atualizado com sucesso", "Vissoka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvClientes.CurrentRow.Cells[1].Value = customer.Name;
                        dgvClientes.CurrentRow.Cells[2].Value = customer.Contacts;
                        dgvClientes.CurrentRow.Cells[3].Value = customer.Email;
                        dgvClientes.CurrentRow.Cells[4].Value = customer.Address;
                        tabControl1.SelectTab(tabAdd);
                        isUpdateCustomer = false;
                        customerID = 0;
                    }
                    else
                        MessageBox.Show("O cliente não pode ser Atualizado, tente novamente mais tarde", "Vissoka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    int new_customer = await Controller.AddCustomer(customer);
                    if (new_customer > 0)
                    {
                        customer = new CustomerModel(new_customer,
                      txtNome.Text, txtContacto.Text, txtEndereco.Text, txtEmail.Text, txtNascimento.Value, txtCategoria.Text, DateTime.Now, "userROOT", 1);
                       
                        if (dgvClientes.Rows.Count == 0) await GetCustumers();
                        else
                        {
                            customers.Add(customer);                            
                            dgvClientes.Rows.Add(customer.ID, customer.Name, customer.Contacts, customer.Address, customer.Email, customer.Data_Nascimento);
                        }
                        ClearData();
                        MessageBox.Show("Cliente Cadastrado com sucesso", "Vissoka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show("O cliente não pode ser cadastrado, tente novamente mais tarde", "Vissoka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
            }
            btnAdd.Enabled = true;
            btnBack.Enabled = true;
        }

        private void cxFlatGroupBox1_Enter(object sender, EventArgs e)
        {
            cxFlatGroupBox1.Height = 67;
        }

        private void cxFlatGroupBox1_Leave(object sender, EventArgs e)
        {
            cxFlatGroupBox1.Height = 36;
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
