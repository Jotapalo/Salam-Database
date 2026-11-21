using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salam_Database.Repositories;

namespace Salam_Database.Services
{
    internal class LoginService
    {
        LoginRepository loginRepository;
        private static string ActualUser;
        private static string Rol;

        static public int Login(string username, string password)
        {
            // <sumary>
            // This method is responsible for handling the login process.  
            // </sumary>

            List<object> res = LoginRepository.Login(username, password);

            if (res.Count == 0)
            {
                return -1; // User not found
            }
            else
            {
                SetActualUser((string)res[1], (string)res[2]);
                return (int)res[0];

            }

        }

        static public int RegisterUser(string name, string user, string password)
        {
            // <sumary>
            // This method is responsible for registering a new user.  
            // </sumary>
            int res = LoginRepository.RegisterUser(name, user, password, "VENDEDOR");

            if (res == 0)
            {
                return -1;
                // Registration failed
            }
            else
            {
                return res;
            }
        }

        static private void SetActualUser(string username, string rol)
        {
            // <sumary>
            // This method is responsible for setting the actual user.  
            // </sumary>
            ActualUser = username;
            Rol = rol;
        }

        static public string GetActualUser()
        {
            // <sumary>
            // This method is responsible for getting the actual user.  
            // </sumary>
            return ActualUser;
        }
        static public string GetRol()
        {
            // <sumary>
            // This method is responsible for getting the actual user role.  
            // </sumary>
            return Rol;
        }
    }
}
