using Salam_Database.Data;
using Salam_Database.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;


namespace Salam_Database.Repositories
{
    public class PurchaseRepository
    {

        public static void CreatePurchaseDetails(int id_compra, DataGridViewRowCollection rows)
        {
            // Create purchase details records in the database
            using (var connection = Database.GetConnection())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (DataGridViewRow row in rows)
                        {
                            if (row.IsNewRow) continue; // Skip the new row placeholder
                            var detailCommand = new SQLiteCommand("INSERT INTO detalle_compra (id_compra, id_presentacion, cantidad, costo_unitario, subtotal) " +
                                "VALUES (@id_compra, @id_presentacion, @cantidad, @costo_unitario, @subtotal);", connection, transaction);
                            // Formatear tipos de datos
                            int cantidad = Convert.ToInt32(row.Cells["ColumnQuantity"].Value);
                            decimal costoUnitario = Convert.ToDecimal(row.Cells["ColumnCostUnit"].Value);
                            decimal subtotal = Convert.ToDecimal(row.Cells["ColumnSubtotal"].Value);

                            detailCommand.Parameters.AddWithValue("@id_compra", id_compra);
                            detailCommand.Parameters.AddWithValue("@id_presentacion", row.Cells["ColumnID_Presentation"].Value);
                            detailCommand.Parameters.AddWithValue("@cantidad", cantidad);
                            detailCommand.Parameters.AddWithValue("@costo_unitario", costoUnitario);
                            detailCommand.Parameters.AddWithValue("@subtotal", subtotal);
                            detailCommand.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error creating purchase details: {ex.Message}");
                    }
                }
            }
        }
        public static int CreatePurchase(int providerID, DataGridViewRowCollection rows, DateTime date, decimal total)
        {
            // Create a new purchase record in the database

            using (var connection = Database.GetConnection())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var purchaseCommand = new SQLiteCommand("INSERT INTO compra (id_proveedor, fecha, subtotal, total) " +
                            "VALUES (@id_proveedor, @fecha, @subtotal, @total); " +
                            "SELECT last_insert_rowid();", connection, transaction);


                        purchaseCommand.Parameters.AddWithValue("@id_proveedor", providerID);
                        purchaseCommand.Parameters.AddWithValue("@fecha", date.ToString("yyyy-MM-dd HH:mm:ss"));
                        purchaseCommand.Parameters.AddWithValue("@subtotal", total);
                        purchaseCommand.Parameters.AddWithValue("@total", total); 
                        int id_compra = Convert.ToInt32(purchaseCommand.ExecuteScalar());

                        
                        transaction.Commit();
                        return id_compra;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error creating purchase: {ex.Message}");
                        return -1;
                    }
                }
            }
        }
    }
}
