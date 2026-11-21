using Salam_Database.Models;
using Salam_Database.Services;
using Salam_Database.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salam_Database.Forms
{
    public partial class FormAddProduct : Form
    {

        public FormAddBrand formAddBrand { get; private set; }
        public FormAddCategory formAddCategory { get; private set; }
        public FormAddSubcategory formAddSubcategory { get; private set; }

        public FormAddProduct()
        {
            InitializeComponent();

            comboBoxCategory.DataSource = CollectionService.categories_collection;
            comboBoxCategory.DisplayMember = "Nombre";
            comboBoxCategory.SelectedIndex = -1;

            comboBoxSubcategory.DataSource = CollectionService.subcategories_collection;
            comboBoxSubcategory.DisplayMember = "Nombre";
            comboBoxSubcategory.SelectedIndex = -1;

            comboBoxBrand.DataSource = CollectionService.brands_collection;
            comboBoxBrand.DisplayMember = "Name";
            comboBoxBrand.SelectedIndex = -1;
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            // VALIDADORES

            
            if (GenericTools.IsNullOrEmpty(comboBoxSubcategory, textBoxName, textBoxCodeReference, comboBoxBrand, textBoxCapacity, comboBoxUnit))
            {
                labelProductInfo.Text = "Los campos no pueden estar vacios.";
                return;
            }


            try
            {

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

            // Limpiar entradas
            GenericTools.ClearEntriesByPanel(panelAddProduct);
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
            var filtradas = CollectionService.subcategories_collection
                .Where(s => s.IdCategoria == selectedCategory.IdCategoria)
                .OrderBy(s => s.Nombre)
                .ToList();

            // Asignar una lista nueva para evitar problemas con el mismo objeto de DataSource
            comboBoxSubcategory.DataSource = filtradas;
            comboBoxSubcategory.DisplayMember = "Nombre";
            comboBoxSubcategory.ValueMember = "IdSubcategoria";
        }

        private void textBoxCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            GenericTools.OnlyNumericTextBox_keypress(sender, e);
        }

        private void buttonAddBrand_Click(object sender, EventArgs e)
        {
            formAddBrand = new FormAddBrand();
            formAddBrand.ShowDialog();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            formAddCategory = new FormAddCategory();
            formAddCategory.ShowDialog();
        }

        private void buttonAddSubcategory_Click(object sender, EventArgs e)
        {
            formAddSubcategory = new FormAddSubcategory();
            formAddSubcategory.ShowDialog();
        }
    }
}
