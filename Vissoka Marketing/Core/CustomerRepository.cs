using Diteck_Sky.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Diteck_Sky.Repositories
{
    class CustomerRepository
    {
        readonly Database db = new Database();
        private readonly List<CustomerModel> CustomerModel = new List<CustomerModel>();
        public  async Task<List<CustomerModel>> ListClientAsync()
        {
            //for (int i = 0; i < 500; i++)
            using (db)
            {
                
               await db.Connection.OpenAsync();
                Console.WriteLine("----OPEN------");
                if (db.Connection.State != System.Data.ConnectionState.Open) return null;
               db.Cmd("SELECT * FROM clientes");         
               db.dr = await db._cmd.ExecuteReaderAsync();
               // CustomerModel customers;
                while (await db.dr.ReadAsync())
                {
                    //  customers = new CustomerModel(db.dr.GetInt32(0), db.dr.GetString(1),
                    //   db.dr.GetString(2), db.dr.GetString(3), db.dr.GetString(3), Convert.ToDateTime(db.dr.GetDateTime(4)));
                    //Console.WriteLine("----------" + db.dr.GetInt32(0));
                    //Console.WriteLine("----------" + db.dr.GetString(1));
                    //Console.WriteLine("----------" + db.dr.GetString(2));
                    //Console.WriteLine("----------" + db.dr.GetString(3));
                    //Console.WriteLine("----------" + db.dr.GetString(4));
                    //Console.WriteLine("----------" + Convert.ToDateTime(db.dr.GetDateTime(5).ToShortDateString()));
                    CustomerModel.Add(new CustomerModel
                      (db.dr.GetInt32(0),
                      db.dr.GetString(1),
                      db.dr.GetString(2),
                      db.dr.GetString(3),
                      db.dr.GetString(4),
                      Convert.ToDateTime(db.dr.GetDateTime(5))));
                }
            }
            return CustomerModel; 
        }
        public async Task<int> AddCustomerAsync(CustomerModel model)
        {
          
            using (db)
            {
                
                await db.Connection.OpenAsync();
                if (db.Connection.State != System.Data.ConnectionState.Open) return 0;
                db.Cmd("INSERT INTO `clientes`(`nomeCliente`, `contactos`, `endereco`, `email`, `dataCadastro`)" +
                    " VALUES (@nome, @contacto, @endereco, @email, @data)");
                db._cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = model.Name;
                db._cmd.Parameters.Add("@contacto", MySqlDbType.VarChar).Value = model.Contacts;
                db._cmd.Parameters.Add("@endereco", MySqlDbType.VarChar).Value = model.Address;
                db._cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = model.Email;
                db._cmd.Parameters.Add("@data", MySqlDbType.DateTime).Value = model.Data;
                if (await db._cmd.ExecuteNonQueryAsync() > 0 ) return Convert.ToInt32(db._cmd.LastInsertedId);
                Console.Write("****** ERROR");
            }
            return 0;
        }
        public async Task<bool> UpdateCustomerAsync(CustomerModel model)
        {

            using (db)
            {
                await db.Connection.OpenAsync();
                if (db.Connection.State != System.Data.ConnectionState.Open) return false;
                db.Cmd("UPDATE `clientes` SET `nomeCliente`=@nome,`contactos`=@contacto,`endereco`=@endereco,`email`=@email WHERE clienteID=@id");
                db._cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = model.ID;
                db._cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = model.Name;
                db._cmd.Parameters.Add("@contacto", MySqlDbType.VarChar).Value = model.Contacts;
                db._cmd.Parameters.Add("@endereco", MySqlDbType.VarChar).Value = model.Address;
                db._cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = model.Email;
                if (await db._cmd.ExecuteNonQueryAsync() > 0) return true;
                Console.WriteLine("****** ERROR");
            }
            
            return false;
        }
        public async Task<bool> DeleteCustomerAsync(int model)
        {
            using (db)
            {
                await db.Connection.OpenAsync();
                db.Cmd("DELETE FROM `clientes` WHERE clienteID=@id");
                db._cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = model;
                if (await db._cmd.ExecuteNonQueryAsync() > 0) return true;
                Console.Write("****** ERROR");
            }
            return false;
        }
    }
}
