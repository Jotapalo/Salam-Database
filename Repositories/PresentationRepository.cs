using Salam_Database.Data;
using Salam_Database.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salam_Database.Repositories
{
    public class PresentationRepository
    {

        public static PresentationDTO BuscarPresentacion(int id_presentation)
        {
            string sqlquery = @"SELECT * FROM presentacion WHERE id_presentacion = @id_presentation";
            PresentationDTO presentacion;

            using (SQLiteConnection conection = Database.GetConnection())
            {
                using (SQLiteCommand command = new SQLiteCommand(sqlquery, conection))
                {
                    command.Parameters.AddWithValue("@id_presentation", id_presentation);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            presentacion = new PresentationDTO
                            {
                                IdPresentacion = Convert.ToInt32(reader["id_presentacion"]),
                                Nombre = reader["presentacion"].ToString(),
                                Tipo = reader["tipo"].ToString(),
                                CantidadUnidades = Convert.ToInt32(reader["cantidad_unidades"]),
                                Costo = Convert.ToSingle(reader["costo"]),
                                Precio = Convert.ToSingle(reader["precio_venta"]),
                                ProductoNombre = reader["producto"].ToString() + " - " + reader["marca"].ToString() + " - " + reader["presentacion"].ToString()
                            };
                            return presentacion;
                        }


                    }
                }
            }
            return new PresentationDTO();

        }

        public static int UpdatePricePresentation(int presentationtId, decimal costPresentation)
        {
            string sqlcommand = @"UPDATE presentacion SET costo = @costo WHERE id_presentacion = @presentationId";

            using (SQLiteConnection connection = Database.GetConnection())
            {
                using (SQLiteCommand command = new SQLiteCommand(sqlcommand, connection))
                {
                    command.Parameters.AddWithValue("@costo", costPresentation);
                    command.Parameters.AddWithValue("@presentationId", presentationtId);

                    return command.ExecuteNonQuery();
                }
            }
        }
        public static List<PresentationDTO> ObtenerPresentaciones()
        {
            List<PresentationDTO> presentaciones = new List<PresentationDTO>();
            string sql = @"
                SELECT p.id_presentacion, p.nombre AS presentacion, p.tipo, p.cantidad_unidades, p.costo, p.precio_venta, pr.nombre AS producto, m.nombre AS marca
                FROM presentacion p
                INNER JOIN producto pr ON p.id_producto = pr.id_producto
                INNER JOIN marca m ON pr.id_marca = m.id_marca
                ORDER BY pr.nombre, p.nombre;
            ";
            using (SQLiteConnection connection = Database.GetConnection())
            {
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PresentationDTO presentacion = new PresentationDTO
                            {
                                IdPresentacion = Convert.ToInt32(reader["id_presentacion"]),
                                Nombre = reader["presentacion"].ToString(),
                                Tipo = reader["tipo"].ToString(),
                                CantidadUnidades = Convert.ToInt32(reader["cantidad_unidades"]),
                                Costo = Convert.ToSingle(reader["costo"]),
                                Precio = Convert.ToSingle(reader["precio_venta"]),
                                ProductoNombre = reader["producto"].ToString() + " - " + reader["marca"].ToString() + " - " + reader["presentacion"].ToString()
                            };
                            presentaciones.Add(presentacion);
                        }
                    }
                }
            }
            return presentaciones;
        }

        public static int InsertPresentation(int id_producto, string nombre, string tipo, int cantidad_unidades, float costo, float precio)
        {

            string sqlInsertPresentacion = @"
                INSERT INTO presentacion
                (
                    id_producto,
                    nombre,
                    tipo,
                    cantidad_unidades,
                    costo,
                    precio_venta
                )
                VALUES
                (
                    @id_producto,
                    @nombre,
                    @tipo,
                    @cantidad_unidades,
                    @costo,
                    @precio_venta
                );
                SELECT last_insert_rowid();";

            using (SQLiteConnection connection = Database.GetConnection())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SQLiteCommand cmdInsPres = new SQLiteCommand(sqlInsertPresentacion, connection, transaction))
                        {
                            cmdInsPres.Parameters.AddWithValue("@id_producto", id_producto);
                            cmdInsPres.Parameters.AddWithValue("@nombre", string.IsNullOrEmpty(nombre) ? (object)DBNull.Value : nombre);
                            cmdInsPres.Parameters.AddWithValue("@tipo", string.IsNullOrEmpty(tipo) ? (object)DBNull.Value : tipo);
                            cmdInsPres.Parameters.AddWithValue("@cantidad_unidades", cantidad_unidades);
                            cmdInsPres.Parameters.AddWithValue("@costo", costo);
                            cmdInsPres.Parameters.AddWithValue("@precio_venta", precio);
                            int nuevoId = Convert.ToInt32(cmdInsPres.ExecuteScalar());
                            transaction.Commit();
                            return nuevoId; // Retornar el ID de la presentación insertada
                        }
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw; 
                    }
                }
            }
        }
    }
}
