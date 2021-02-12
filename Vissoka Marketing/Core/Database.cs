// Vissoka_Marketing.Database
using System;
using MySqlConnector;

public class Database : IDisposable
{
	public readonly MySqlConnection Connection;

	public MySqlCommand _cmd;

	public MySqlDataReader dr;

	public void Cmd(string Sql)
	{
		_cmd = new MySqlCommand(Sql, Connection);
	}

	public Database()
	{
		Connection = new MySqlConnection("host=127.0.0.1;port=3306;user id=flamestrindade;password=thecod3s;database=umoja_marketing;");
	}

	public void Dispose()
	{
		Console.WriteLine("Dispose Connection");
		if (_cmd != null)
		{
			_cmd.Dispose();
		}
		Connection.CloseAsync();
	}
}
