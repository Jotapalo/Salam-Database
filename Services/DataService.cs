using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salam_Database.Repositories;
using System.Data;

namespace Salam_Database.Services
{
    internal class DataService
    {
        public static DataTable GetRecentMovements()
        {
            return GenericDataBaseOperationsRepository.GetPurchaseAndSellsResume();
        }

        public static DataTable GetMovementDetailsById(string movementId, string movementType)
        {
            if (movementType.ToLower() == "compra")
            {
                return GenericDataBaseOperationsRepository.GetPurchaseDetailsById(movementId);
            }
            else if (movementType.ToLower() == "venta")
            {
                return GenericDataBaseOperationsRepository.GetSellDetailsById(movementId);
            }
            return new DataTable();
        }
    }
}
