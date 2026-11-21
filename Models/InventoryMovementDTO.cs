using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salam_Database.Models
{

    public class InventoryMovementDTO
    {
        public int id_presentation { get; set; }
        public string movement_type { get; set; } // ('COMPRA', 'VENTA', 'AJUSTE_ENTRADA', 'AJUSTE_SALIDA', 'DEVOLUCION', 'APERTURA_PAQUETE')
        public int quantity { get; set; }
        public string date { get; set; } // 'YYYY-MM-DD HH:MM:SS'
        public string reason { get; set; } // 'Motivo del movimiento'
        public string observation { get; set; } // 'Observaciones adicionales'

    }
}
