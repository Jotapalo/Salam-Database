using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salam_Database.Models;
using Salam_Database.Services;
using Salam_Database.Data;
using System.Data.SQLite;

namespace Salam_Database.Repositories
{
    public class InventoryRepository
    {
        public InventoryRepository() { }

        public static int ActualizarCantidad_Presentacion (int id_presentation, int quantity)
        {

            string sqlquery = @"UPDATE inventario SET cantidad = cantidad + @quantity WHERE id_presentacion = @id_presentation";

            using (SQLiteConnection connection = Database.GetConnection())
            {
                using (SQLiteCommand command = new SQLiteCommand(sqlquery, connection))
                {

                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@id_presentation", id_presentation);
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public static bool IsExist(int id_presentation)
        {
            string sqlquery = @"SELECT * FROM inventario WHERE id_presentacion = @id_presentation";

            using (SQLiteConnection conection = Database.GetConnection())
            {
                using (SQLiteCommand command = new SQLiteCommand(sqlquery, conection))
                {
                    command.Parameters.AddWithValue("@id_presentation", id_presentation);
                    
                    object reader = command.ExecuteScalar();

                    return Convert.ToInt32(reader) > 0;    
                }
            }

        }

        public static int AgregarPresentacion(int id_presentation, int quantity, int stockMinimo, int stockMaximo)
        {
            // Insertar LA PRESENTACION en la tabla inventario
            using (var connection = Database.GetConnection())
            {
                string query = "INSERT INTO inventario (id_presentacion, cantidad, stock_minimo, stock_maximo) " +
                    "VALUES (@id_presentacion, @cantidad, @stock_minimo, @stock_maximo)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    // Aquí deberías asignar los valores a los parámetros del comando
                    command.Parameters.AddWithValue("@id_presentacion", id_presentation);
                    command.Parameters.AddWithValue("@cantidad", quantity);
                    command.Parameters.AddWithValue("@stock_minimo", stockMinimo);
                    command.Parameters.AddWithValue("@stock_maximo", stockMaximo);
                    command.ExecuteNonQuery();
                }
            }
            return 0;
        }

        public static int QueryStockPresentation(int id_presentation)
        {
            // Consultar la cantidad de stock de la presentacion
            using (var connection = Database.GetConnection())
            {
                string query = "SELECT cantidad FROM inventario WHERE id_presentacion = @id_presentacion";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_presentacion", id_presentation);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return -1; // o algún valor que indique que no se encontró la presentación
                    }
                }
            }
        }

        public static void AddInventoryMovement(InventoryMovementDTO movimiento)
        {
            // Insertar el movimiento en la tabla movimiento_inventario
            using (var connection = Database.GetConnection())
            {
                string query = "INSERT INTO movimiento_inventario (id_presentacion, tipo_movimiento, cantidad, fecha, motivo, observacion) " +
                    "VALUES (@id_presentacion, @tipo_movimiento, @cantidad, @fecha, @motivo, @observacion)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_presentacion", movimiento.id_presentation);
                    command.Parameters.AddWithValue("@tipo_movimiento", movimiento.movement_type);
                    command.Parameters.AddWithValue("@cantidad", movimiento.quantity);
                    command.Parameters.AddWithValue("@fecha", movimiento.date);
                    command.Parameters.AddWithValue("@motivo", movimiento.reason);
                    command.Parameters.AddWithValue("@observacion", movimiento.observation);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
