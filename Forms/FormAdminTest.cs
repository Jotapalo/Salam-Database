using Salam_Database.Forms;
using Salam_Database.Models;
using Salam_Database.Repositories;
using Salam_Database.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salam_Database.Utils;

namespace Salam_Database
{
    public partial class MainView : Form
    {
        FormPurchases formPurchasesSells;
        FormSells formSells;

        List<ProductoDTO> productos;
        List<CategoryDTO> categorias;
        List<SubcategoryDTO> subcategorias;
        List<PresentationDTO> presentaciones;
        List<BrandDTO> marcas;

        public MainView()
        {
            InitializeComponent();

            productos = StockService.ObtenerProductos();
            categorias = DataBaseOperationsService.ObtenerCategorias();
            subcategorias = DataBaseOperationsService.ObtenerSubcategorias();
            marcas = DataBaseOperationsService.ObtenerMarcas();
            presentaciones = StockService.ObtenerPresentaciones();

            comboBoxBrand.DataSource = marcas;
            comboBoxBrand.DisplayMember = "Name";

            comboBoxCategory.DataSource = categorias;
            comboBoxCategory.DisplayMember = "Nombre";

            comboBoxSubcategory.DataSource = subcategorias;
            comboBoxSubcategory.DisplayMember = "Nombre";

            comboBoxPresentationProductName.DataSource = productos;
            comboBoxPresentationProductName.DisplayMember = "InfoParcial";

            comboBoxInventoryPresentationName.DataSource = presentaciones;
            comboBoxInventoryPresentationName.DisplayMember = "ProductoNombre";

            string[] movementTypes = { "COMPRA", "VENTA", "AJUSTE_ENTRADA", "AJUSTE_SALIDA", "DEVOLUCION", "APERTURA_PAQUETE" };
            comboBoxMovementType.DataSource = movementTypes;


        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            try { 

                int res = StockService.InsertarProducto(
                    textBoxCodeReference.Text,
                    textBoxName.Text,
                    $"{comboBoxCategory.Text}>{comboBoxSubcategory.Text}",
                    comboBoxBrand.Text,
                    textBoxDescription.Text,
                    textBoxColor.Text,
                    textBoxMaterial.Text,
                    decimal.Parse(textBoxCapacity.Text),
                    comboBoxUnit.Text
                );
                labelProductInfo.Text = res > 0 ? $"Producto agregado con ID: {res}" : "Error al agregar producto, revise la informacion.";
            }
            catch (FormatException)
            {
                labelProductInfo.Text = "Error: La capacidad debe ser un número decimal válido.";
                return;
            }
            productos = StockService.ObtenerProductos();
            comboBoxPresentationProductName.DataSource = productos;

            // Limpiar entradas
            GenericTools.ClearEntriesByPanel(panelAddProduct);
        }

        private void buttonAddProvider_Click(object sender, EventArgs e)
        {
            try
            {
                int res = DataBaseOperationsService.AgregarProveedor(
                    nombre: textBoxProviderName.Text,
                    document: textBoxProviderID.Text,
                    document_type: "NIT",
                    telefono: textBoxProviderNumber.Text,
                    direccion: textBoxProviderAddress.Text,
                    email: textBoxProviderEmail.Text,
                    contacto: textBoxProviderContact.Text);
                labelProviderInfo.Text = res > 0 ? $"Proveedor agregado con ID: {res}" : "Error al agregar proveedor, revise la informacion.";

            }
            catch (FormatException)
            {

                labelProviderInfo.Text = "Error al agregar el proveedor, corrobore los campos";
            }

            // Limpiar entradas
            GenericTools.ClearEntriesByPanel(panelAddProvider);
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                int res = DataBaseOperationsService.AgregarCliente(
                     nombre: textBoxClientName.Text,
                     documento: textBoxClientID.Text,
                     telefono: textBoxClientNumber.Text,
                     direccion: textBoxClientAddress.Text,
                     email: textBoxClientEmail.Text,
                     tipo_cliente: comboBoxClientType.SelectedItem.ToString());
                labelClientInfo.Text = res > 0 ? $"Cliente agregado con ID: {res}" : "Error al agregar cliente, revise la informacion.";

            }
            catch (FormatException)
            {
                labelClientInfo.Text = "Error al agregar el proveedor, corrobore los campos";
            }
            // Limpiar entradas
            GenericTools.ClearEntriesByPanel(panelAddClient);
        }

        private void buttonSwitchPurchasesAndSells_Click(object sender, EventArgs e)
        {
            formPurchasesSells = new FormPurchases();
            formPurchasesSells.Show();
        }

        private void buttonAddPresentation_Click(object sender, EventArgs e)
        {
            try
            {
                int res = StockService.AddPresentation(
                    productoId: ((ProductoDTO)comboBoxPresentationProductName.SelectedItem).IdProducto,
                    nombre: textBoxPresentationName.Text,
                    tipo: comboBoxPresentationType.SelectedItem.ToString(),
                    cantidadUnidades: int.Parse(textBoxPresentationQuantity.Text),
                    costo: float.Parse(textBoxPresentationCost.Text),
                    precio: float.Parse(textBoxPresentationPrice.Text)
                );
                labelPresentationInfo.Text = res > 0 ? $"Presentacion agregada con ID: {res}" : "Error al agregar presentacion, revise la informacion.";
            }
            catch (Exception ex)
            {
                labelPresentationInfo.Text = ex.Message;
                return;
            }
            // Limpiar entradas
            GenericTools.ClearEntriesByPanel(panelAddPresentation);
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryDTO selectedCategory = comboBoxCategory.SelectedItem as CategoryDTO;
            if (selectedCategory == null)
            {
                comboBoxSubcategory.DataSource = null;
                return;
            }

            // Filtrar subcategorias por IdCategoria
            var filtradas = subcategorias
                .Where(s => s.IdCategoria == selectedCategory.IdCategoria)
                .OrderBy(s => s.Nombre)
                .ToList();

            // Asignar una lista nueva para evitar problemas con el mismo objeto de DataSource
            comboBoxSubcategory.DataSource = filtradas;
            comboBoxSubcategory.DisplayMember = "Nombre";
            comboBoxSubcategory.ValueMember = "IdSubcategoria";
        }

        private void buttonAddToInventory_Click(object sender, EventArgs e)
        {
            InventoryService.AddToInventoryAndRegisterInventoryMovement(
                IdPresentacion: ((ProductoDTO)comboBoxPresentationProductName.SelectedItem).IdProducto,
                tipoMovimiento: comboBoxMovementType.SelectedItem.ToString(),
                cantidad: int.Parse(textBoxInventoryQuantity.Text),
                motivo: textBoxReason.Text,
                observacion: textBoxObservation.Text,
                stockMinimo: int.Parse(textBoxMinStock.Text),
                stockMaximo: int.Parse(textBoxMaxStock.Text)
            );

            // Limpiar entradas
            GenericTools.ClearEntriesByPanel(panelAddInventory);
        }

        private void buttonSwitchSells_Click(object sender, EventArgs e)
        {
            formSells = new FormSells();
            formSells.Show();
        }


        private void MainView_Load(object sender, EventArgs e)
        {

            
        }
    }
}
