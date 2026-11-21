using Salam_Database.Services;
using Salam_Database.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salam_Database.Forms
{
    public partial class FormAddBrand : Form
    {
        public FormAddBrand()
        {
            InitializeComponent();
        }

        private void buttonAddBrand_Click(object sender, EventArgs e)
        {
            // Validadores
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                labelBranInfo.Text = "El campo 'Nombre' es obligatorio.";
                return;
            }

            try
            {
                int response = DataBaseOperationsService.AddBrand(
                    nombre: textBoxName.Text,
                    descripcion: textBoxDescription.Text
                    );

                labelBranInfo.Text = $"Marca agregada con ID: {response}";

                GenericTools.ClearEntriesByPanel(panelAddBrand);


            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error en la consulta de insercion de nueva Marca: " + ex.Message);
            }

        }
    }
}
