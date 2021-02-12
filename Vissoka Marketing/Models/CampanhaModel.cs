// Vissoka_Marketing.Models.CampanhaModel
using System;

internal class CampanhaModel
{
	public int ID
	{
		get;
		set;
	}

	public string Nome
	{
		get;
		set;
	}

	public string Detalhes
	{
		get;
		set;
	}

	public string template
	{
		get;
		set;
	}

	public DateTime DataInicio
	{
		get;
		set;
	}

	public DateTime DataFim
	{
		get;
		set;
	}

	public int User_id
	{
		get;
		set;
	}

	public int Company_id
	{
		get;
		set;
	}

	public CampanhaModel(int iD, string nome, string detalhes, string template, DateTime dataInicio, DateTime dataFim, int user_id, int company_id)
	{
		ID = iD;
		Nome = nome;
		Detalhes = detalhes;
		this.template = template;
		DataInicio = dataInicio;
		DataFim = dataFim;
		User_id = user_id;
		Company_id = company_id;
	}
}
