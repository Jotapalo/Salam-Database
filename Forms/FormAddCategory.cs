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
    public partial class FormAddCategory : Form
    {
        public FormAddCategory()
        {
            InitializeComponent();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {

            // Validadores
            if (GenericTools.IsNullOrEmpty(textBoxName))
            {
                labelCategoryInfo.Text = "El campo 'nombre' es obligatorio.";
                return;
            }

            int response = DataBaseOperationsService.InsertCategory(
                textBoxName.Text,
                textBoxDescription.Text
                );

            if (response > 0)
            {
                labelCategoryInfo.Text = $"Categoria agregada con ID: {response}";
                GenericTools.ClearEntriesByPanel(panelAddCategory);
            }
        }

    }
}
