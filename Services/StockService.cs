using Salam_Database.Models;
using Salam_Database.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salam_Database.Services
{
    public class StockService
    {
        public StockService()
        { 
        }
        public static int InsertarProducto(
            string codigo,
            string nombre,
            string categoria,
            string marca,
            string descripcion,
            string color,
            string material,
            decimal capacidad,
            string unidadMedida)
        {
            return ProductRepository.InsertarProducto(codigo, nombre, categoria, marca, descripcion, color, material, capacidad, unidadMedida);
        }
        public static List<ProductoDTO> ObtenerProductos()
        {
            return ProductRepository.ObtenerTodos();
        }
        public static List<PresentationDTO> ObtenerPresentaciones()
        {
            return PresentationRepository.ObtenerPresentaciones();
        }
        public static int UpdatePricePresentation(int id_presentation, decimal price)
        {
            return PresentationRepository.UpdatePricePresentation(id_presentation, price);
        }

        public static int AddPresentation(int productoId, string nombre, string tipo, int cantidadUnidades, float costo, float precio)
        {
            try
            {
                return PresentationRepository.InsertPresentation(productoId, nombre, tipo, cantidadUnidades, costo, precio);

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Error al agrega nueva presentacion: {ex.Message}");
                return -1;
            }
        }
    }
}
