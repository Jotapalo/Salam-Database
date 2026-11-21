using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salam_Database.Models;
using System.Data.SQLite;
using Salam_Database.Data;

namespace Salam_Database.Repositories
{
    public class PersonsRepository
    {
        public PersonsRepository() { }

        public static int InsertarProveedor(string nombre, string document, string document_type, string telefono, string direccion, string email, string contacto)
        {
            string sqlInsertProveedor = @"
                INSERT INTO proveedor
                (
                    nombre,
                    nit,
                    telefono,
                    direccion,
                    email,
                    contacto,
                    tipo_documento
                )
                VALUES
                (
                    @nombre,
                    @nit,
                    @telefono,
                    @direccion,
                    @email,
                    @contacto,
                    @tipo_documento
                );
                SELECT last_insert_rowid();";

            using (SQLiteConnection connection = Database.GetConnection())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SQLiteCommand cmdInsProv = new SQLiteCommand(sqlInsertProveedor, connection, transaction))
                        {
                            cmdInsProv.Parameters.AddWithValue("@nombre", string.IsNullOrEmpty(nombre) ? (object)DBNull.Value : nombre);
                            cmdInsProv.Parameters.AddWithValue("@nit", string.IsNullOrEmpty(document) ? (object)DBNull.Value : document);
                            cmdInsProv.Parameters.AddWithValue("@telefono", string.IsNullOrEmpty(telefono) ? (object)DBNull.Value : telefono);
                            cmdInsProv.Parameters.AddWithValue("@direccion", string.IsNullOrEmpty(direccion) ? (object)DBNull.Value : direccion);
                            cmdInsProv.Parameters.AddWithValue("@email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                            cmdInsProv.Parameters.AddWithValue("@contacto", string.IsNullOrEmpty(contacto) ? (object)DBNull.Value : contacto);
                            cmdInsProv.Parameters.AddWithValue("@tipo_documento", string.IsNullOrEmpty(document_type) ? "NIT" : document_type);


                            int nuevoId = Convert.ToInt32(cmdInsProv.ExecuteScalar());
                            transaction.Commit();
                            return nuevoId; // Retornar el ID del proveedor insertado
                        }

                    }
                    catch (SQLiteException ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static int InsertarCliente(string nombre, string documento, string telefono, string direccion, string email, string tipo_cliente)
        {

            // <sumary>
            // This method can be insert clients on the clients table
            // Este metodo permite insertar clientes en la tabla clientes
            // </sumary>
            string sqlInsertCliente = @"
                INSERT INTO cliente
                (
                    nombre,
                    documento,
                    telefono,
                    direccion,
                    email,
                    tipo_cliente
                )
                VALUES
                (
                    @nombre,
                    @documento,
                    @telefono,
                    @direccion,
                    @email,
                    @tipo_cliente
                );
                SELECT last_insert_rowid();";

            using (SQLiteConnection connection = Database.GetConnection())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SQLiteCommand cmdInsCli = new SQLiteCommand(sqlInsertCliente, connection, transaction))
                        {
                            cmdInsCli.Parameters.AddWithValue("@nombre", string.IsNullOrEmpty(nombre) ? (object)DBNull.Value : nombre);
                            cmdInsCli.Parameters.AddWithValue("@documento", string.IsNullOrEmpty(documento) ? (object)DBNull.Value : documento);
                            cmdInsCli.Parameters.AddWithValue("@telefono", string.IsNullOrEmpty(telefono) ? (object)DBNull.Value : telefono);
                            cmdInsCli.Parameters.AddWithValue("@direccion", string.IsNullOrEmpty(direccion) ? (object)DBNull.Value : direccion);
                            cmdInsCli.Parameters.AddWithValue("@email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                            cmdInsCli.Parameters.AddWithValue("@tipo_cliente", string.IsNullOrEmpty(tipo_cliente) ? (object)DBNull.Value : tipo_cliente);

                            int nuevoId = Convert.ToInt32(cmdInsCli.ExecuteScalar());
                            transaction.Commit();
                            return nuevoId; // Retornar el ID del cliente insertado
                        }

                    }
                    catch (SQLiteException ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static List<ProviderDTO> ObtenerProveedores()
        {
            // Implement the logic to retrieve providers from the database
            List<ProviderDTO> proveedores = new List<ProviderDTO>();
            try
            {
                using (var connection = Database.GetConnection())
                {


                    using (var command = new SQLiteCommand("SELECT * FROM proveedor", connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Create a ProviderDTO object for each record
                                var proveedor = new ProviderDTO
                                {
                                    IdProveedor = reader["id_proveedor"] != DBNull.Value ? Convert.ToInt32(reader["id_proveedor"]) : 0,
                                    Nombre = reader["nombre"].ToString(),
                                    Nit = reader["nit"].ToString(),
                                    Telefono = reader["telefono"].ToString(),
                                    Direccion = reader["direccion"].ToString(),
                                    Email = reader["email"].ToString(),
                                    Contacto = reader["contacto"].ToString()
                                };
                                proveedores.Add(proveedor);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return proveedores;
        }
        public static List<ClientDTO> ObtenerClientes()
        {
            // Implement the logic to retrieve providers from the database
            List<ClientDTO> clientes = new List<ClientDTO>();
            try
            {
                using (var connection = Database.GetConnection())
                {


                    using (var command = new SQLiteCommand("SELECT * FROM cliente", connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Create a ProviderDTO object for each record
                                var cliente = new ClientDTO
                                {
                                    id_cliente = reader["id_cliente"] != DBNull.Value ? Convert.ToInt32(reader["id_cliente"]) : 0,
                                    nombre = reader["nombre"].ToString(),
                                    documento = reader["documento"].ToString(),
                                    telefono = reader["telefono"].ToString(),
                                    direccion = reader["direccion"].ToString(),
                                    email = reader["email"].ToString(),
                                    tipo_cliente = reader["tipo_cliente"].ToString()
                                };
                                clientes.Add(cliente);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return clientes;
        }

    }
}
