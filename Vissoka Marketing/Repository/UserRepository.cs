// Vissoka_Marketing.Repositories.UserRepository
using System.Threading.Tasks;
using Vissoka_Marketing;
using Vissoka_Marketing.Models;

internal class UserRepository
{
	private Database db = new Database();

	private UserModel userModel;

	public async Task<UserModel> LoginUserAsync(string user, string pwd)
	{
		if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pwd))
		{
			return null;
		}
		using (db)
		{
			await db.Connection.OpenAsync();
			db.Cmd("SELECT * FROM usuarios WHERE email=@emailuser AND senha=@senhauser");
			db._cmd.Parameters.AddWithValue("@emailuser", user);
			db._cmd.Parameters.AddWithValue("@senhauser", pwd);
			Database database = db;
			database.dr = await db._cmd.ExecuteReaderAsync();
			if (await db.dr.ReadAsync())
			{
				userModel = new UserModel(db.dr.GetInt32(0), db.dr.GetString(1), db.dr.GetString(2), db.dr.GetString(3), db.dr.GetString(4), db.dr.GetSByte(5), db.dr.GetDateTime(6), db.dr.GetInt32(7), db.dr.GetInt32(8));
			}
			else
			{
				userModel = null;
			}
		}
		return userModel;
	}
}
