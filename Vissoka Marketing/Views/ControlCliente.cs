using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vissoka_Marketing.Controllers;
using Vissoka_Marketing.Models;

namespace Vissoka_Marketing.Views
{
    public partial class ControlCliente : UserControl
    {
        public ControlCliente()
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
                            dgvClientes.Rows.Add(model.ID, model.Name, model.Contacts, model.Address, model.Email, model.Data_Nascimento.ToShortDateString(), model.Categoria);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Logger.AddToLog("Control Cliente Excepetion", "Method GetCostumers: " + ex.Message);
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
                                labelTotal.Text = dgvClientes.Rows.Count + " Clientes";
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
                            dgvClientes.Rows.Add(model.ID, model.Name, model.Contacts, model.Address, model.Email, model.Data_Nascimento.ToShortDateString(), model.Categoria);


                    }
                    //Search By Adress
                    else if (viSearchByAddress.Checked)
                    {
                        if (model.Address.ToLower().Contains(txtSearch.Text.ToLower()))
                            dgvClientes.Rows.Add(model.ID, model.Name, model.Contacts, model.Address, model.Email, model.Data_Nascimento.ToShortDateString(), model.Categoria);

                    }
                    //Search By Contact
                    else if (viSearchByContact.Checked)
                    {
                        if (model.Contacts.Contains(txtSearch.Text))
                            dgvClientes.Rows.Add(model.ID, model.Name, model.Contacts, model.Address, model.Email, model.Data_Nascimento.ToShortDateString(), model.Categoria);

                    }

                    //Search All
                    else
                    {
                        if (model.Name.ToLower().Contains(txtSearch.Text.ToLower()) || model.Contacts.Contains(txtSearch.Text) || model.Address.ToLower().Contains(txtSearch.Text.ToLower()) || model.Email.ToLower().Contains(txtSearch.Text.ToLower()))
                            dgvClientes.Rows.Add(model.ID, model.Name, model.Contacts, model.Address, model.Email, model.Data_Nascimento.ToShortDateString(), model.Categoria);

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
            txtNascimento.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();    
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabView);
            isUpdateCustomer = false;
            customerID = 0;
            viSearchByAll.Checked = true;

        }

        private void viFlatButton1_Click(object sender, EventArgs e)
        {
            if (!isUpdateCustomer)
            {
                tabControl1.SelectTab(tabAdd);
                btnAdd.ButtonType = Vissoka.Enums.ButtonType.Success;
                btnAdd.Text = "Cadastrar";
                txtNome.Focus();
                isUpdateCustomer = false;
            }
            else
            {               
                DialogResult dialogResult = MessageBox.Show("Deseja cancelar a operação e Cadastrar um novo cliente?", "Vissoka", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    ClearData();
                    customerID = 0;
                    isUpdateCustomer = false;
                    btnAdd.ButtonType = Vissoka.Enums.ButtonType.Success;
                    btnAdd.Text = "Cadastrar";
                    txtNome.Focus();
                }
            }
           
        }

        private async void ControlCliente_Load(object sender, EventArgs e)
        {
            await GetCustumers();
           
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
                        dgvClientes.CurrentRow.Cells[1].Value = customer.Name;
                        dgvClientes.CurrentRow.Cells[2].Value = customer.Contacts;
                        dgvClientes.CurrentRow.Cells[3].Value = customer.Address;
                        dgvClientes.CurrentRow.Cells[4].Value = customer.Email;
                        dgvClientes.CurrentRow.Cells[5].Value = customer.Data_Nascimento;
                        dgvClientes.CurrentRow.Cells[6].Value = customer.Categoria;
                        MessageBox.Show("Cliente " + customer.Name + " Atualizado com sucesso", "Vissoka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tabControl1.SelectTab(tabView);
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
                        labelTotal.Text = dgvClientes.Rows.Count + " Clientes";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvClientes.Rows.Count > 0)
            {
                btnUpdate.Enabled = false;
                if (customerID > 0)
                {
                    isUpdateCustomer = true;
                    GetInfo();
                    btnAdd.ButtonType = Vissoka.Enums.ButtonType.Info;
                    btnAdd.Text = "Atualizar";
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

        #region Search Methods
        private void cxFlatGroupBox1_Enter(object sender, EventArgs e)
        {
            cxFlatGroupBox1.Height = 68;
        }

        private void cxFlatGroupBox1_Leave(object sender, EventArgs e)
        {
            cxFlatGroupBox1.Height = 36;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //  List<CustomerModel> search = new List<CustomerModel>();
            if (customers != null)
            {
                GetSearch();       
            }
        }

        private void viSearchByAll_CheckedChanged(object sender, EventArgs e)
        {
            GetSearch();
        }

        private void viSearchByName_CheckedChanged(object sender, EventArgs e)
        {
            GetSearch();
        }

        private void viSearchByContact_CheckedChanged(object sender, EventArgs e)
        {
            GetSearch();
        }

        private void viSearchByAddress_CheckedChanged(object sender, EventArgs e)
        {
            GetSearch();
        }

        private void viSearchByEmail_CheckedChanged(object sender, EventArgs e)
        {
            GetSearch();
        }
        #endregion

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.Rows.Count > 0) customerID = int.Parse(dgvClientes.CurrentRow.Cells[0].Value.ToString());
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            //implement delete
            if (customerID > 0)
            {
                btnDelete.Enabled = false;

                DialogResult dialogResult = MessageBox.Show("Deseja realmente eliminar o Cliente?", "Vissoka", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    if (await Controller.DeleteCustomerById(customerID))
                    {
                        MessageBox.Show("O Cliente foi eliminado com sucesso!", "Vissoka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvClientes.Rows.Remove(dgvClientes.CurrentRow);
                        customers.RemoveAll(r => r.ID == customerID);
                        customerID = 0;
                        labelTotal.Text = dgvClientes.Rows.Count + " Clientes";
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
    }
}
