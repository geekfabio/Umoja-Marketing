using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoka_Marketing.Models;
using Vissoka_Marketing.Repositories;

public class TestUnit
    {

    readonly CustomerRepository customerRepository = new CustomerRepository();
    private List<CustomerModel> CustomerModel;
    /// <summary>
    /// Test Unit to Save Costumer
    /// </summary>
    /// <returns></returns>
    public async Task<int> SaveModelsAsyncTest()
    {

        
        try
        {

            CustomerModel model = new CustomerModel(
                1,
                "Moises",
                "92972566",
                "Luanda",
                "moises@gmil.com",
                DateTime.Now,
                "computador",
                DateTime.Now,
                "Root",
                1);
            int i = await customerRepository.AddCustomerAsync(model);
            if (i != 0) return i;
            return 0;
        }
        catch
        {
            return 0;
        }
    }

}

