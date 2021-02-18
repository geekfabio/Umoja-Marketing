using System.Collections.Generic;
using System.Threading.Tasks;
using Vissoka_Marketing.Models;
using Vissoka_Marketing.Repositories;

namespace Vissoka_Marketing.Controllers  
{
    class CustomerController 
    {
        readonly CustomerRepository customerRepository = new CustomerRepository();
        private List<CustomerModel> CustomerModel;
        public async Task<List<CustomerModel>> GetCustomersAsync()
        {
            try {
                CustomerModel = await customerRepository.ListClientAsync();
                if (CustomerModel != null) return CustomerModel;
            }
            catch
            {
                Logger.AddToLog("GetCustomersAsync Controller", "Mysql, error on Add Model to Repository");
                Logger.WriteLog();
                return null;
            }
            return CustomerModel;
        }
        public async Task<int> AddCustomer(CustomerModel model)
        {
            if (string.IsNullOrWhiteSpace(model.Name)) return 0;
            try
            {
                int i = await customerRepository.AddCustomerAsync(model);
                if (i != 0) return i;
                return 0;
            }
            catch
            {
                Logger.AddToLog("Add Costumer Controller", "Mysql, error on Add Model to Repository");
                Logger.WriteLog();
                return 0;
            }
           
        }
        public async Task<bool> UpdateCustomerModels(CustomerModel model)
        {
            if (model.ID < 1) return false;
            try
            {
                if (await customerRepository.UpdateCustomerAsync(model)) return true;
            }
            catch
            {
                return false;
            }
            return false;
        }
        public async Task<bool> DeleteCustomerById(int model)
        {
           if (await customerRepository.DeleteCustomerAsync(model)) return true;
           return false;     
        }
    }
}
