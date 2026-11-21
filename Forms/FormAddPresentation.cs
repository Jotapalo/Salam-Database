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
    public partial class FormAddPresentation : Form
    {
        public FormAddPresentation()
        {
            InitializeComponent();
            comboBoxProductName.DataSource = CollectionService.products_collection;
            comboBoxProductName.DisplayMember = "Nombre";
        }

        private void buttonAddPresentation_Click(object sender, EventArgs e)
        {
            // Validadores

            if (GenericTools.IsNullOrEmpty(comboBoxProductName, textBoxPresentationName, comboBoxPresentationType, 
                textBoxPresentationQuantity, textBoxPresentationCost, textBoxPresentationPrice))
            {
                labelPresentationInfo.Text = "Todos los campos son obligatorios.";
                return;
            }
            
            int response = StockService.AddPresentation(
                productoId: ((ProductoDTO)comboBoxProductName.SelectedItem).IdProducto,
                nombre: textBoxPresentationName.Text,
                tipo: comboBoxPresentationType.SelectedItem.ToString(),
                cantidadUnidades: int.Parse(textBoxPresentationQuantity.Text),
                costo: float.Parse(textBoxPresentationCost.Text),
                precio: float.Parse(textBoxPresentationPrice.Text)
            );

            if (response > 0)
            {
                labelPresentationInfo.Text = $"Presentacion agregada con ID: {response}";

                GenericTools.ClearEntriesByPanel(panelAddPresentation);
            }    
        }

    }
}
