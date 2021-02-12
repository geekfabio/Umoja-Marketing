using System;
using Vissoka_Marketing.Models;
using Vissoka_Marketing.Repositories;

namespace Vissoka_Marketing.Controllers
{

    class UserController
    {
        readonly UserRepository userRepository = new UserRepository();
        private UserModel userData;
        public async void LoginUser(String user, String pwd, bool checkKeepSession)
        {
            try {
                userData = await userRepository.LoginUserAsync(user, pwd);
                SaveCurrentUser(checkKeepSession);
            }
            catch
            {
                return;
            }
         
        }
        private bool SaveCurrentUser(bool keepSession = false)
        {
            if (userData != null)
            {
                Vissoka_Marketing.Properties.Settings.Default.userID = userData.ID;
                Vissoka_Marketing.Properties.Settings.Default.userName = userData.Name;
                Vissoka_Marketing.Properties.Settings.Default.userUsername = userData.User;
                Vissoka_Marketing.Properties.Settings.Default.userContacts = userData.Contacts;
                Vissoka_Marketing.Properties.Settings.Default.userState = userData.State;
                Vissoka_Marketing.Properties.Settings.Default.userPermissions_ID = userData.Permissions_ID;
                Vissoka_Marketing.Properties.Settings.Default.userCompany_ID = userData.Company_ID;
                Vissoka_Marketing.Properties.Settings.Default.userDate = userData.RegistrationDate;
                if(keepSession) Vissoka_Marketing.Properties.Settings.Default.Save();
                Console.WriteLine("User Save");
                return true;
            }
            else return false;        
        }
        public bool LogoutUser()
        {
            if (userData != null)
            {
                Properties.Settings.Default.Reset();
                return true;
            }
            else return false;    

        }
    }
}
