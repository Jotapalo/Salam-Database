using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salam_Database.Data;

namespace Salam_Database.Repositories
{
    internal class LoginRepository
    {

        static public List<object> Login(string username, string password)
        {

            // <sumary>
            // This method is responsible for handling the login process.
            // </sumary>

            using (var connection = Database.GetConnection())
            {
                var command = new System.Data.SQLite.SQLiteCommand("SELECT id_usuario, usuario, rol FROM usuarios_sistema WHERE usuario = @usuario AND contrasena = @contrasena", connection);
                command.Parameters.AddWithValue("@usuario", username);
                command.Parameters.AddWithValue("@contrasena", password);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // User found, login successful
                        // You can retrieve user information from the reader if needed
                        return new List<object> { reader.GetInt32(0), reader.GetString(1), reader.GetString(2) }; // Return the user ID
                    }
                    else
                    {
                        // User not found, login failed
                        // throw new Exception("Invalid username or password.");
                        return new List<object>(); // Return -1 to indicate login failure
                    }
                }
            }
        }

        static public int RegisterUser(string name, string user, string password, string role)
        {
            // <sumary>
            // This method is responsible for registering a new user.
            // </sumary>

            using (var connection = Database.GetConnection())
            {
                var command = new System.Data.SQLite.SQLiteCommand("INSERT INTO usuarios_sistema (nombre, usuario, contrasena, rol) VALUES (@nombre, @usuario, @contrasena, 'VENDEDOR')", connection);
                command.Parameters.AddWithValue("@nombre", name);
                command.Parameters.AddWithValue("@usuario", user);
                command.Parameters.AddWithValue("@contrasena", password);
                command.Parameters.AddWithValue("@rol", role); // Set the role to 'VENDEDOR' for new users
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected; // Return the number of rows affected (1 if successful)
            }

        }

    }
}
