using Vissoka_Marketing.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Vissoka_Marketing.Repositories
{
    class CustomerRepository
    {
        readonly Database db = new Database();
        private readonly List<CustomerModel> CustomerModel = new List<CustomerModel>();
        public  async Task<List<CustomerModel>> ListClientAsync()
        {
            //for (int i = 0; i < 50; i++)
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
                    Console.WriteLine(db.dr.GetDateTime("dataCadastro"));
                   CustomerModel.Add(new CustomerModel(
                       db.dr.GetInt32(0),
                       db.dr.GetString("nomeCliente"),
                       db.dr.GetString("contactos"),
                       db.dr.GetString("endereco"),
                       db.dr.GetString("email"),
                       Convert.ToDateTime(db.dr.GetDateTime("dataAniversario")),
                       db.dr.GetString("categoria"),
                       Convert.ToDateTime(db.dr.GetDateTime("dataCadastro")),
                       db.dr.GetString("cadastradoPor"),
                       db.dr.GetInt32("empresa_id")                    
                       ));
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
                db.Cmd("INSERT INTO `clientes`(`nomeCliente`, `contactos`, `endereco`, `email`, `dataAniversario`, `categoria`, `dataCadastro`, `cadastradoPor`, `empresa_id`) VALUES (@nome, @contacto, @endereco, @email, @dataAniversario, @categoria, @data, @cadastrado, @company)");
                db._cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = model.Name;
                db._cmd.Parameters.Add("@contacto", MySqlDbType.VarChar).Value = model.Contacts;
                db._cmd.Parameters.Add("@endereco", MySqlDbType.VarChar).Value = model.Address;
                db._cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = model.Email;
                db._cmd.Parameters.Add("@dataAniversario", MySqlDbType.DateTime).Value = model.Data_Nascimento;
                db._cmd.Parameters.Add("@categoria", MySqlDbType.VarChar).Value = model.Categoria;
                db._cmd.Parameters.Add("@data", MySqlDbType.DateTime).Value = model.Data_Cadastrado;
                db._cmd.Parameters.Add("@cadastrado", MySqlDbType.VarChar).Value = model.CadastradoPor;
                db._cmd.Parameters.Add("@company", MySqlDbType.Int32).Value =  model.Company_id;
                if (await db._cmd.ExecuteNonQueryAsync() > 0 ) return Convert.ToInt32(db._cmd.LastInsertedId);
                Logger.AddToLog("Repository", "Add Customer Async");
            }
            return 0;
        }
  

        public async Task<bool> UpdateCustomerAsync(CustomerModel model)
        {
        
            using (db)
            {
                await db.Connection.OpenAsync();
                if (db.Connection.State != System.Data.ConnectionState.Open) return false;
                db.Cmd("UPDATE `clientes` SET `nomeCliente`=@nome, `contactos`=@contacto,`endereco`=@endereco,`email`=@email,`dataAniversario`=@dataAniversario,`categoria`=@categoria Where clienteID=@id");
                db._cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = model.ID;
                db._cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = model.Name;
                db._cmd.Parameters.Add("@contacto", MySqlDbType.VarChar).Value = model.Contacts;
                db._cmd.Parameters.Add("@endereco", MySqlDbType.VarChar).Value = model.Address;
                db._cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = model.Email;
                db._cmd.Parameters.Add("@dataAniversario", MySqlDbType.DateTime).Value = model.Data_Nascimento;
                db._cmd.Parameters.Add("@categoria", MySqlDbType.VarChar).Value = model.Categoria;
                if (await db._cmd.ExecuteNonQueryAsync() > 0) return true;
                Logger.AddToLog("Repository", "Update Cliente Error");
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
                Logger.AddToLog("Repository ", "DeleteCustomerAsync");
            }
            return false;
        }
    }
}
