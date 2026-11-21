using Salam_Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salam_Database.Services
{
    public class CollectionService
    {
        public static List<CategoryDTO> categories_collection { get; private set; }
        public static List<SubcategoryDTO> subcategories_collection { get; private set; }
        public static List<ProductoDTO> products_collection { get; private set; }
        public static List<PresentationDTO> presentations_collection { get; private set; }
        public static List<ClientDTO> clients_collection { get; private set; }
        public static List<PresentationDTO> providers_collection { get; private set; }
        public static List<BrandDTO> brands_collection { get; private set; }

        public CollectionService() {
            categories_collection = DataBaseOperationsService.ObtenerCategorias();
            subcategories_collection = DataBaseOperationsService.ObtenerSubcategorias();

            products_collection = StockService.ObtenerProductos();
            presentations_collection = StockService.ObtenerPresentaciones();

            clients_collection = DataBaseOperationsService.ObtenerClientes();
            providers_collection = StockService.ObtenerPresentaciones();
            brands_collection = DataBaseOperationsService.ObtenerMarcas();
        }
    }
}
