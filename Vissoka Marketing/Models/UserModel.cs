// Vissoka_Marketing.Models.UserModel
using System;

internal class UserModel
{
	public int ID
	{
		get;
		set;
	}

	public string User
	{
		get;
		set;
	}

	public string Password
	{
		get;
		set;
	}

	public string Name
	{
		get;
		set;
	}

	public string Contacts
	{
		get;
		set;
	}

	public int State
	{
		get;
		set;
	}

	public DateTime RegistrationDate
	{
		get;
		set;
	}

	public int Company_ID
	{
		get;
		set;
	}

	public int Permissions_ID
	{
		get;
		set;
	}

	public UserModel(int id, string name, string user, string password, string contacts, int state, DateTime registrationDate, int company_id = 1, int permissoes_id = 1)
	{
		ID = id;
		User = user ?? throw new ArgumentNullException("user");
		Password = password ?? throw new ArgumentNullException("password");
		Name = name ?? throw new ArgumentNullException("name");
		Contacts = contacts ?? throw new ArgumentNullException("contacts");
		State = state;
		RegistrationDate = registrationDate;
		Company_ID = company_id;
		Permissions_ID = permissoes_id;
	}
}
