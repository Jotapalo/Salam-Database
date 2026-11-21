using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Salam_Database.Models
{
    public class ClientDTO
    {
		public int id_cliente { get; set; }
		public string nombre { get; set; }
		public string documento { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public string tipo_cliente { get; set; } // 'CONSUMIDOR_FINAL', 'NEGOCIO', 'RESTAURANTE', 'REVENDEDOR'
    }
}
