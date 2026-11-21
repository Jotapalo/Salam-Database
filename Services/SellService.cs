using Salam_Database.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salam_Database.Services
{
    public class SellService
    {

        public static string CreateSell(int clientId, DataGridViewRowCollection rows, decimal total, string paymentMethod)
        {
            // Registrar ventas y detalles de venta en la base de datos junto con el inventory movement
            DateTime date = DateTime.Now;

            // Insertar datos en la tabla venta
            int id_venta = SellRepository.CreateSell(clientId, rows, date, total, paymentMethod);

            // Insertar datos en la tabla detalle_venta
            SellRepository.CreateSellDetails(id_venta, rows);


            // Movimiento de inventario
            foreach (DataGridViewRow row in rows)
            {
                if (row.IsNewRow) { continue; }
                int id_presentacion = Convert.ToInt32(row.Cells["ColumnID_Presentation"].Value);
                int cantidad = Convert.ToInt32(row.Cells["ColumnQuantity"].Value);

                // Comprobar si la presentacion existe en el inventario
                if (InventoryService.IsExist(id_presentacion))
                {
                    InventoryService.ActualizarCantidad_Presentacion(id_presentacion, -cantidad);
                }
                // Si no existe entonces lanzar error
                else
                {
                    throw new Exception("La presentacion no existe.");
                }

                // REGISTRAR el movimiento en la tabla movimiento inventario
                InventoryService.AddInventoryMovement(id_presentacion, "VENTA", -cantidad, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "COMPRA", " ");


            }
            return "Venta registrada exitosamente.";

        }

    }
}
