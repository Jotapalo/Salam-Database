using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salam_Database.Repositories;
using Salam_Database.Models;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Salam_Database.Services
{
    public class DataBaseOperationsService
    {
        public DataBaseOperationsService() { }

        public static List<BrandDTO> ObtenerMarcas()
        {
            return GenericDataBaseOperationsRepository.GetAllBrand();
        }

        public static List<CategoryDTO> ObtenerCategorias() {
            return GenericDataBaseOperationsRepository.ObtenerCategorias();
        }

        public static int InsertCategory(string name, string description)
        {
            try
            { 
                return GenericDataBaseOperationsRepository.InsertCategory(name, description);
            } 
            catch (SQLiteException exception_sql)
            {
                MessageBox.Show("Error al Insertar nueva categoria: " + exception_sql.Message);
                return -1;
            }
        }

        public static int InsertSubcategory(int category_id, string name, string description)
        {
            try
            {
                return GenericDataBaseOperationsRepository.InsertSubcategory(category_id, name, description);
            }
            catch (SQLiteException exception_sql)
            {
                MessageBox.Show("Error al Insertar nueva subcategoria: " + exception_sql.Message);
                return -1;
            }
        }


        public static List<ProviderDTO> ObtenerProveedores()
        {
            return PersonsRepository.ObtenerProveedores();
        }
        public static List<ClientDTO> ObtenerClientes()
        {
            return PersonsRepository.ObtenerClientes();
        }

        public static List<SubcategoryDTO> ObtenerSubcategorias()
        {
            return GenericDataBaseOperationsRepository.ObtenerSubcategorias();
        }

        public static int AgregarProveedor(
            string nombre, 
            string document, 
            string document_type, 
            string telefono, 
            string direccion, 
            string email, 
            string contacto)
        {

            return PersonsRepository.InsertarProveedor(nombre, document, document_type, telefono, direccion, email, contacto);
        }

        public static int AgregarCliente(
            string nombre, 
            string documento, 
            string telefono, 
            string direccion, 
            string email, 
            string tipo_cliente)
        {
            return PersonsRepository.InsertarCliente(nombre, documento, telefono, direccion, email, tipo_cliente);
        }

        public static int AddBrand(
            string nombre,
            string descripcion)
        {
            return GenericDataBaseOperationsRepository.InsertBrand(nombre, descripcion);
        }
    }
}
