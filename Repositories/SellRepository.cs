using Salam_Database.Data;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salam_Database.Repositories
{
    public class SellRepository
    {
        public static void CreateSellDetails(int id_venta, DataGridViewRowCollection rows)
        {
            // Create sell details records in the database
            using (var connection = Database.GetConnection())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (DataGridViewRow row in rows)
                        {
                            if (row.IsNewRow) continue; // Skip the new row placeholder

                            int cantidad = Convert.ToInt32(row.Cells["ColumnQuantity"].Value);
                            cantidad = cantidad < 0 ? cantidad * -1 : cantidad;
                            decimal cost_unit = Convert.ToDecimal(row.Cells["ColumnCostUnit"].Value);
                            decimal descuento = Convert.ToDecimal(row.Cells["ColumnDiscount"].Value.ToString().Replace("%", ""));
                            decimal subtotal = Convert.ToDecimal(row.Cells["ColumnSubtotal"].Value);

                            var detailCommand = new SQLiteCommand("INSERT INTO detalle_venta (id_venta, id_presentacion, cantidad, precio_unitario, descuento, subtotal) " +
                                "VALUES (@id_venta, @id_presentacion, @cantidad, @precio_unitario, @descuento, @subtotal);", connection, transaction);
                            detailCommand.Parameters.AddWithValue("@id_venta", id_venta);
                            detailCommand.Parameters.AddWithValue("@id_presentacion", row.Cells["ColumnID_Presentation"].Value);
                            detailCommand.Parameters.AddWithValue("@cantidad", cantidad);
                            detailCommand.Parameters.AddWithValue("@precio_unitario", cost_unit);
                            detailCommand.Parameters.AddWithValue("@descuento", descuento);
                            detailCommand.Parameters.AddWithValue("@subtotal", subtotal);
                            
                            detailCommand.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error creating sell details: {ex.Message} {ex.StackTrace}");
                        throw ex;
                    }
                }
            }
        }

        public static int CreateSell(int clientId, DataGridViewRowCollection rows, DateTime date, decimal total, string paymentMethod)
        {
            // Create a new sell record in the database

            using (var connection = Database.GetConnection())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var purchaseCommand = new SQLiteCommand("INSERT INTO venta (id_cliente, fecha, subtotal, total, metodo_pago) " +
                            "VALUES (@id_cliente, @fecha, @subtotal, @total, @metodo_pago); " +
                            "SELECT last_insert_rowid();", connection, transaction);
                        purchaseCommand.Parameters.AddWithValue("@id_cliente", clientId);
                        purchaseCommand.Parameters.AddWithValue("@fecha", date.ToString("yyyy-MM-dd HH:mm:ss"));
                        purchaseCommand.Parameters.AddWithValue("@subtotal", total);
                        purchaseCommand.Parameters.AddWithValue("@total", total);
                        purchaseCommand.Parameters.AddWithValue("@metodo_pago", paymentMethod);
                        int id_venta = Convert.ToInt32(purchaseCommand.ExecuteScalar());


                        transaction.Commit();
                        return id_venta;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error creating sell: {ex.Message}");
                        return -1;
                    }
                }
            }
        }
    }
}
