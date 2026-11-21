using Salam_Database.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salam_Database.Services;
using Salam_Database.Models;

namespace Salam_Database.Services
{
    public class PurchaseService
    {


        public static string CreatePurchase(int providerID, DataGridViewRowCollection rows, decimal total)
        {
            // registrar la compra en la tabla compras

            DateTime date = DateTime.Now;
            int id_compra = PurchaseRepository.CreatePurchase(providerID, rows, date, total);

            // registrar los detalles de la compra en la tabla detalle_compra
            PurchaseRepository.CreatePurchaseDetails(id_compra, rows);

            // Se tiene que crear una funcion en el InventoryService para agregar el movimiento de inventario
            // esta recorre las rows que reciba y va a insertar en la tabla inventario el movimiento de entrada de cada presentacion que se compro
            // como requiere stock minimo y maximo, primero consulta si existe la presentacion en el inventario, de ser asi agrega las unidades que
            // entraron y actualiza el precio unitario de la presentacion de no existir crea un nuevo registro con un stock minimo de 1 y un stock
            // maximo igual a las unidades agregadas, ademas en todo caso se actualiza el precio de las presentaciones con el nuevo.


            foreach (DataGridViewRow row in rows)
            {
                if (row.IsNewRow) { continue; }
                int id_presentacion = Convert.ToInt32(row.Cells["ColumnID_Presentation"].Value);
                int cantidad = Convert.ToInt32(row.Cells["ColumnQuantity"].Value);
                


                // Comprobar si la presentacion existe en el inventario
                if (InventoryService.IsExist(id_presentacion))
                {
                    InventoryService.ActualizarCantidad_Presentacion(id_presentacion, cantidad);
                }
                // Si no existe entonces registrarla
                else
                {
                    InventoryService.AddPresentation(id_presentacion,
                        cantidad,
                        1,
                        cantidad
                        );
                }
                // REGISTRAR el movimiento en la tabla movimiento inventario
                InventoryService.AddInventoryMovement(id_presentacion, "COMPRA", cantidad, DateTime.Now.ToString("YYYY-MM-DD HH:MM:SS"), "COMPRA", " ");

                // UPDATE al precio de la presentacion
                int res = StockService.UpdatePricePresentation(id_presentacion, Convert.ToDecimal(row.Cells["ColumnCostUnit"].Value) );
                
            }
            return "Compra registrada exitosamente.";
        }
    }
}
