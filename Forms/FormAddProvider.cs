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
    public partial class FormAddProvider : Form
    {
        public FormAddProvider()
        {
            InitializeComponent();
            comboBoxDocumentType.Items.Add("CC");
            comboBoxDocumentType.Items.Add("NIT");
        }


        private void buttonAddProvider_Click(object sender, EventArgs e)
        {
            // Validadores
            if (string.IsNullOrEmpty(textBoxProviderID.Text) ||
                string.IsNullOrEmpty(textBoxProviderName.Text) ||
                comboBoxDocumentType.SelectedItem == null)
            {
                labelProviderInfo.Text = "Los campos: 'Nombre proveedor', 'Documento' y 'Tipo de documento' son obligatorios.";
            }


            // Consulta
            try
            {
                int res = DataBaseOperationsService.AgregarProveedor(
                    nombre: textBoxProviderName.Text,
                    document: textBoxProviderID.Text,
                    document_type: comboBoxDocumentType.Text,
                    telefono: textBoxProviderNumber.Text,
                    direccion: textBoxProviderAddress.Text,
                    email: textBoxProviderEmail.Text,
                    contacto: textBoxProviderContact.Text);
                labelProviderInfo.Text = res > 0 ? $"Proveedor agregado con ID: {res}" : "Error al agregar proveedor, revise la informacion.";

            }

            catch (SQLiteException ex)
            {
                MessageBox.Show("Error en la consulta de insercion de nuevo Proveedor: " + ex.Message);
            }



            // Limpiar entradas
            GenericTools.ClearEntriesByPanel(panelAddProvider);
        }

        private void textBoxProviderID_KeyPress(object sender, KeyPressEventArgs e)
        {
            GenericTools.OnlyNumericTextBox_keypress(sender, e);
        }
    }
}
