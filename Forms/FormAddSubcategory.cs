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
    public partial class FormAddSubcategory : Form
    {
        

        public FormAddSubcategory()
        {
            InitializeComponent();

            comboBoxCategory.DataSource = CollectionService.categories_collection;
            comboBoxCategory.DisplayMember = "Nombre";


        }

        private void buttonAddSubcategory_Click(object sender, EventArgs e)
        {
            // Validadores
            if (GenericTools.IsNullOrEmpty(comboBoxCategory, textBoxName))
            {
                labelSubcategoryInfo.Text = "Los campos 'categoria' y 'nombre' son obligatorios";
                return;
            }

            int response = DataBaseOperationsService.InsertSubcategory(
                ((CategoryDTO)comboBoxCategory.SelectedItem).IdCategoria, 
                textBoxName.Text, 
                textBoxDescription.Text);

            if (response > 0)
            {
                labelSubcategoryInfo.Text = $"Subcategoria agregada exitosamente con ID: {response}";

                GenericTools.ClearEntriesByPanel(panelAddSubcategory);
            }
        }
    }
}
