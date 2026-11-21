using Salam_Database.Data;
using Salam_Database.Models;
using Salam_Database.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Salam_Database.Repositories
{
    public class GenericDataBaseOperationsRepository
    {
        public static List<BrandDTO> GetAllBrand()
        {
            // <sumary>
            // Get all brands from database
            // </sumary>

            var brandList = new List<BrandDTO>();
            string sqlcommand = @"SELECT * FROM marca WHERE estado = 1";

            using (SQLiteConnection connection = Database.GetConnection())
            {
                using (SQLiteCommand command = new SQLiteCommand(sqlcommand, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BrandDTO marca = new BrandDTO
                            {
                                Id = Convert.ToInt32(reader["id_marca"]),
                                Name = reader["nombre"].ToString(),
                                Description = reader["descripcion"].ToString()
                            };
                            brandList.Add(marca);
                        }
                    }
                }
            }
            return brandList;
        }

        public static int InsertBrand(string name, string description)
        {
            // <sumary>
            // Add new brand to DataBase
            // </sumary>
            int res;
            string sqlcommand = "INSERT INTO marca (nombre, descripcion)" +
                "VALUES (@name, @description)";

            using (SQLiteConnection connection = Database.GetConnection())
            {
                using (SQLiteCommand command = new SQLiteCommand(sqlcommand, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@description", description);

                    res = command.ExecuteNonQuery();
                }
            }

            return res;
            
        }

        public static int InsertCategory(string name, string description)
        {
            // <sumary>
            // Add new category to DataBase
            // </sumary>
            int res;
            string sqlcommand = @"
                INSERT INTO categoria (nombre, descripcion)
                VALUES (@name, @description);
                SELECT last_insert_rowid();";

            
            using (SQLiteConnection connection = Database.GetConnection())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SQLiteCommand command = new SQLiteCommand(sqlcommand, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@name", name);
                            command.Parameters.AddWithValue("@description", description);

                            res = Convert.ToInt32(command.ExecuteScalar());
                            transaction.Commit();
                        }
                    }
                    catch (SQLiteException ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine(ex.Message);
                        throw;
                    }
                }
            }
            return res;
        }

        public static int InsertSubcategory(int category_id, string name, string description)
        {
            // <sumary>
            // Add new category to DataBase
            // </sumary>
            int res;
            string sqlcommand = @"
                INSERT INTO subcategoria (id_categoria, nombre, descripcion)
                VALUES (@category_id, @name, @description);
                SELECT last_insert_rowid();";


            using (SQLiteConnection connection = Database.GetConnection())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SQLiteCommand command = new SQLiteCommand(sqlcommand, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@category_id", category_id);
                            command.Parameters.AddWithValue("@name", name);
                            command.Parameters.AddWithValue("@description", description);

                            res = Convert.ToInt32(command.ExecuteScalar());
                            transaction.Commit();
                        }
                    }
                    catch (SQLiteException ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine(ex.Message);
                        throw;
                    }
                }
            }
            return res;
        }


        public static DataTable GetPurchaseDetailsById(string id)
        {
            DataTable tabla = new DataTable();
            string sqlcommand =
                "SELECT pr.nombre, dc.cantidad, dc.costo_unitario, dc.subtotal " +
                "FROM detalle_compra AS dc " +
                "JOIN presentacion AS p ON dc.id_presentacion = p.id_presentacion " +
                "JOIN producto AS pr ON p.id_producto = pr.id_producto " +
                "WHERE dc.id_compra = @id";

            using (SQLiteConnection connection = Database.GetConnection())
            {
                using (SQLiteCommand command = new SQLiteCommand(sqlcommand, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        public static DataTable GetSellDetailsById(string id)
        {
            DataTable tabla = new DataTable();
            string sqlcommand =
                "SELECT pr.nombre, dv.cantidad, dv.precio_unitario, dv.subtotal " +
                "FROM detalle_venta AS dv " +
                "JOIN presentacion AS p ON dv.id_presentacion = p.id_presentacion " +
                "JOIN producto AS pr ON p.id_producto = pr.id_producto " +
                "WHERE dv.id_venta = @id";
            using (SQLiteConnection connection = Database.GetConnection())
            {
                using (SQLiteCommand command = new SQLiteCommand(sqlcommand, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(tabla);
                    }
                }
            }
            return tabla;
        }


        public static List<SubcategoryDTO> ObtenerSubcategorias()
        {
            List<SubcategoryDTO> subcategorias = new List<SubcategoryDTO>();
            string sql = @"
                SELECT s.id_subcategoria, s.nombre AS subcategoria, s.id_categoria, c.nombre AS categoria
                FROM subcategoria s
                INNER JOIN categoria c ON s.id_categoria = c.id_categoria
                ORDER BY c.nombre, s.nombre;
            ";
            using (SQLiteConnection connection = Database.GetConnection())
            {
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SubcategoryDTO subcategoria = new SubcategoryDTO
                            {
                                IdSubcategoria = Convert.ToInt32(reader["id_subcategoria"]),
                                Nombre = reader["subcategoria"].ToString(),
                                IdCategoria = Convert.ToInt32(reader["id_categoria"])
                            };
                            subcategorias.Add(subcategoria);
                        }
                    }
                }
            }
            return subcategorias;
        }

        public static List<CategoryDTO> ObtenerCategorias()
        {
            List<CategoryDTO> categorias = new List<CategoryDTO>();
            string sql = "SELECT id_categoria, nombre FROM categoria ORDER BY nombre;";
            using (SQLiteConnection connection = Database.GetConnection())
            {
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CategoryDTO categoria = new CategoryDTO
                            {
                                IdCategoria = Convert.ToInt32(reader["id_categoria"]),
                                Nombre = reader["nombre"].ToString()
                            };
                            categorias.Add(categoria);
                        }
                    }
                }
            }
            return categorias;
        }

        public static string SearchValueById(string columnName, string table, string namePK, int idPK)
        {
            string sqlcommand = $"SELECT \"{columnName}\" FROM \"{table}\" WHERE \"{namePK}\" = @idPK";

            using (SQLiteConnection connection = Database.GetConnection())
            {
                using (SQLiteCommand command = new SQLiteCommand(sqlcommand, connection))
                {
                    command.Parameters.AddWithValue("@idPK", idPK);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader.IsDBNull(0))
                                return null;

                            return reader.GetValue(0).ToString();
                        }
                    }
                }
            }

            return null;
        }

        public static DataTable GetPurchaseAndSellsResume()
        {
            DataTable tabla = new DataTable();

            string sqlcommand = "SELECT * " +
                "FROM" +
                "(SELECT id_venta AS id, fecha, 'VENTA' AS tipo, total, c.nombre AS persona FROM venta v JOIN cliente c ON v.id_cliente = c.id_cliente " +
                "UNION ALL " +
                "SELECT id_compra AS id, fecha, 'COMPRA' AS tipo, total, p.nombre AS persona FROM compra c JOIN proveedor p ON c.id_proveedor = p.id_proveedor) " +
                "ORDER BY fecha DESC LIMIT 10";

            using (SQLiteConnection connection = Database.GetConnection())
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlcommand, connection))
                {
                    adapter.Fill(tabla);
                }
            }
            return tabla;
        }


    }
}
