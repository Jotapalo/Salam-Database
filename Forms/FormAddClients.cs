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
    public partial class FormAddClients : Form
    {
        public FormAddClients()
        {
            InitializeComponent();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            // <sumary>
            // </sumary>


            // Validadores
            if (string.IsNullOrEmpty(textBoxClientName.Text) || string.IsNullOrEmpty(textBoxClientID.Text) || comboBoxClientType.SelectedItem == null)
            {
                labelClientInfo.Text = "Los campos 'Nombre', 'Documento' y 'Tipo cliente' son obligatorios";
                return;
            }

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
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error en la consulta de insercion de nuevo Cliente: " + ex.Message);
            }

            // Limpiar entradas
            GenericTools.ClearEntriesByPanel(panelAddClient);
        }
    }
}
