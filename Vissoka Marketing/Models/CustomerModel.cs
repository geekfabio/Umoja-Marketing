using System;

namespace Vissoka_Marketing.Models
{
    class CustomerModel
    {
      
        public int ID { get; set; }
        public string Name { get; set; }
        public string Contacts { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string Categoria { get; set; }
        public DateTime Data_Cadastrado { get; set; }      
        public int Company_id { get; set; }
        public string CadastradoPor { get; set; }

        public CustomerModel(int _id, string name, string contacts, string address, string email, DateTime data_Nascimento, string categoria, DateTime data_Cadastrado, string cadastradoPor, int company_id)
        {
            ID = _id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Contacts = contacts ?? throw new ArgumentNullException(nameof(contacts));
            Address = address ?? throw new ArgumentNullException(nameof(address));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Data_Nascimento = data_Nascimento;
            Categoria = categoria ?? throw new ArgumentNullException(nameof(categoria));
            Data_Cadastrado = data_Cadastrado;
            Company_id = company_id;
            CadastradoPor = cadastradoPor ?? throw new ArgumentNullException(nameof(cadastradoPor));
        }
    }

}
