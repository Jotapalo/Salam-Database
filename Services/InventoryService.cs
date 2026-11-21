using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salam_Database.Models;
using Salam_Database.Repositories;

namespace Salam_Database.Services
{
    public class InventoryService
    {
        public InventoryService() {
        }


        public static void AddToInventoryAndRegisterInventoryMovement(
            int IdPresentacion,
            string tipoMovimiento,
            int cantidad,
            string motivo,
            string observacion,
            int stockMinimo,
            int stockMaximo)
        {
            AddPresentation(IdPresentacion, cantidad, stockMinimo, stockMaximo);
            AddInventoryMovement(IdPresentacion, tipoMovimiento, cantidad, DateTime.Now.ToString("YYYY-MM-DD HH:MM:SS"), motivo, observacion);
        }

        public static int AddPresentation(
            int idPresentacion, 
            int cantidad, 
            int stockMinimo, 
            int stockMaximo)
        {
            {
                return InventoryRepository.AgregarPresentacion(idPresentacion, cantidad, stockMinimo, stockMaximo);
                
            }
        }

        public static void AddInventoryMovement(
            int id_presentation, 
            string movement_type, 
            int quantity,
            string date, 
            string reason, 
            string observation)
        {
            InventoryMovementDTO movimiento = new InventoryMovementDTO();
            movimiento.id_presentation = id_presentation;
            movimiento.movement_type = movement_type;
            movimiento.quantity = quantity;
            movimiento.reason = reason;
            movimiento.observation = observation;
            movimiento.date = date;
            InventoryRepository.AddInventoryMovement(movimiento);
        }

        public static int ActualizarCantidad_Presentacion(int id_presentacion, int cantidad)
            // Permite actualizar la cantidad restante en stock para el inventario
        {
            return InventoryRepository.ActualizarCantidad_Presentacion(id_presentacion, cantidad);
        }

        public static PresentationDTO BuscarPresentacion(int id_presentation)
        {

            return PresentationRepository.BuscarPresentacion(id_presentation);
        }


        public static bool IsExist(int id_presentation)
        {
            return InventoryRepository.IsExist(id_presentation);
        }

        public static int QueryStockPresentation(int id_presentacion)
        {
            return InventoryRepository.QueryStockPresentation(id_presentacion);
        }
    }
}
