using Vissoka_Marketing.Controllers;
using Vissoka_Marketing.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diteck_Sky.Views.Customer
{
    public partial class frmCustomer : Form
    {
        //variables
        readonly CustomerController Controller = new CustomerController();
        List<CustomerModel> customers = new List<CustomerModel>();
        bool isUpdateCustomer;
        int customerID = 0;
        //methods
        async Task GetCustumers(bool updateData = true)
        {
            try
            {
                //cacheDataUser
                if(updateData) customers = await Controller.GetCustomersAsync();
                if (customers != null) { 
                    dgvClientes.Rows.Clear();
                    foreach (CustomerModel model in customers)
                    {
                        if (dgvClientes.Columns.Count > 0)
                            dgvClientes.Rows.Add(customers.Capacity, model.Name, model.Contacts, model.Address, model.Email, model.Data_Nascimento.ToShortDateString());
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Controller Excepetion, verify your DB");
            }
            finally
            {
                if (customers != null) vissokaCardLoading.Dispose();
                else { 
                new Task(() => {
                    Thread.Sleep(3000);
                    if(this.IsHandleCreated)
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
                    else if(viSearchByAddress.Checked) {
                        if(model.Address.ToLower().Contains(txtSearch.Text.ToLower()))
                            dgvClientes.Rows.Add(model.ID, model.Name, model.Contacts, model.Address, model.Email, model.Data_Nascimento.ToShortDateString());
                    }
                    //Search By Contact
                    else if (viSearchByContact.Checked) {
                        if(model.Contacts.Contains(txtSearch.Text))
                            dgvClientes.Rows.Add(model.ID, model.Name, model.Contacts, model.Address, model.Email, model.Data_Nascimento.ToShortDateString());
                    }
                    //Search By Contact
                    else if (viSearchByEmail.Checked)
                    {
                        if (model.Email.Contains(txtSearch.Text))
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
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void cxFlatGroupBox1_Enter(object sender, EventArgs e)
        {
            cxFlatGroupBox1.Height =67;
        }

        private void cxFlatGroupBox1_Leave(object sender, EventArgs e)
        {
            cxFlatGroupBox1.Height = 38;
        }


   
        private async void frmCustomer_Load(object sender, EventArgs e)
        {
            await GetCustumers();
 
        }

        private void viFlatButton2_Click(object sender, EventArgs e)
        {
         
            ClearData();
            isUpdateCustomer = false;
            labelTitle.Text = "Cliente";
            txtNome.Focus();
            tabControl1.SelectTab(tabView);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (isUpdateCustomer) isUpdateCustomer = false;
            txtSearch.Clear();
            labelTitle.Text = "Cadastrar Cliente";
            tabControl1.SelectTab(tabAdd);
            txtNome.Focus();
        }


        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //  List<CustomerModel> search = new List<CustomerModel>();
            if (customers != null) {
                //txtsearch empty show all customers
                if (String.IsNullOrWhiteSpace(txtSearch.Text))
                {
                   if (dgvClientes.Rows.Count > 0) dgvClientes.Rows.Clear();
                   await GetCustumers(false);
                }
                //else Search by TypeSearch
                else
                {
                    GetSearch();
                }
            }
        }

        private void viFlatRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (viSearchByName.Checked) GetSearch();            
        }

        private void viSearchByContact_CheckedChanged(object sender, EventArgs e)
        {
            if (viSearchByContact.Checked) GetSearch();
        }

        private void viSearchByAll_CheckedChanged(object sender, EventArgs e)
        {
            if (viSearchByAll.Checked) GetSearch();
        }

        private void viSearchByEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (viSearchByEmail.Checked) GetSearch();
        }

        private void viImgResult_Click(object sender, EventArgs e)
        {

        }

        void addAnimation(bool _value = false, bool e = true)
        {
            viLoading1.Visible = !_value;
            if (e)
            {
                txtNome.Enabled = _value;
                txtContacto.Enabled = _value;
                txtEndereco.Enabled = _value;
                txtEmail.Enabled = _value;
            }
        }
        private async void viFlatButton1_Click(object sender, EventArgs e)
        {
            //btnAdd.Enabled = false;
            //btnBack.Enabled = false;
            //addAnimation(false);
            //if (ValidateData())
            //{
            //  CustomerModel customer = new CustomerModel(customerID,
            //        txtNome.Text, txtContacto.Text, txtEndereco.Text, txtEmail.Text, DateTime.Now);
            //    if (isUpdateCustomer == true)
            //    {

            //        if (await Controller.UpdateCustomerModels(customer))
            //        {
            //            ClearData();
            //            MessageBox.Show("Cliente " + customer.Name + " Atualizado com sucesso", "Vissoka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            dgvClientes.CurrentRow.Cells[1].Value = customer.Name;
            //            dgvClientes.CurrentRow.Cells[2].Value = customer.Contacts;
            //            dgvClientes.CurrentRow.Cells[3].Value = customer.Email;
            //            dgvClientes.CurrentRow.Cells[4].Value = customer.Address;
                       
            //            labelTitle.Text = "Cliente";
            //            tabControl1.SelectTab(tabAdd);
            //            isUpdateCustomer = false;
            //            customerID = 0;
            //        }
            //        else
            //            MessageBox.Show("O cliente não pode ser Atualizado, tente novamente mais tarde", "Vissoka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //    }
            //    else {

                 
            //        int new_customer = await Controller.SetCustomerModels(customer);
            //        if (new_customer > 0 )
            //        {
            //            customer = new CustomerModel(new_customer,
            //         txtNome.Text, txtContacto.Text, txtEndereco.Text, txtEmail.Text, DateTime.Now);
                      

                        
            //            if (dgvClientes.Rows.Count == 0) await GetCustumers();

            //            else { customers.Add(customer); dgvClientes.Rows.Add(customer.ID, customer.Name, customer.Contacts, customer.Address, customer.Email, customer.Data);
            //            }

            //            ClearData();
                     
            //         MessageBox.Show("Cliente Cadastrado com sucesso", "Vissoka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
            //        }
                   
            //         else
            //         {
            //           MessageBox.Show("O cliente não pode ser cadastrado, tente novamente mais tarde", "Vissoka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //         }
            //    }
            //}
            //btnBack.Enabled = true;
            //btnAdd.Enabled = true;
            //addAnimation(true);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dgvClientes.Rows.Count > 0) {
                btnUpdate.Enabled = false;
                if (customerID > 0)
                {
                    isUpdateCustomer = true;
                    labelTitle.Text = "Atualizar Cliente";
                    
                    GetInfo();
                    tabControl1.SelectTab(tabAdd);
                    txtNome.Focus();
                }
                else
                    MessageBox.Show("Nenhum cliente Selecionado!", "Vissoka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btnUpdate.Enabled = true;
            }
            else            
                MessageBox.Show("Nenhum cliente encontrado, Cadastre o primeiro Cliente!", "Vissoka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            //implement delete
            if(customerID > 0)
            {
                btnDelete.Enabled = false;

                DialogResult dialogResult = MessageBox.Show("Deseja realmente eliminar o Cliente?", "Vissoka", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    if (await Controller.DeleteCustomerById(customerID))
                    {
                        MessageBox.Show("O Cliente foi eliminado com sucesso!", "Vissoka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvClientes.Rows.Remove(dgvClientes.CurrentRow);
                        customers.RemoveAll(r => r.ID == customerID);
                        customerID = 0;
                    }
                    else
                    {
                        MessageBox.Show("O Cliente não pode ser eliminado, tente novamente mais tarde!", "Vissoka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
              
                btnDelete.Enabled = true;
            }
            else MessageBox.Show("Nenhum cliente foi selecionado", "Vissoka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.Rows.Count >0) customerID = int.Parse(dgvClientes.CurrentRow.Cells[0].Value.ToString());

        }

        private void labelTitle_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Text = labelTitle.Text;
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {

        }
    }
}
