using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salam_Database.Models;
using Salam_Database.Repositories;
using Salam_Database.Services;
using Salam_Database.Utils;

namespace Salam_Database.Forms
{
    public partial class FormSells : Form
    {
        public FormAddClients formAddClients { get; private set; }

        public FormSells()
        {
            InitializeComponent();

            // Cargar presentaciones y clientes en los comboboxes
            comboBoxPresentationName.DataSource = CollectionService.presentations_collection;
            comboBoxPresentationName.DisplayMember = "ProductoNombre";
            comboBoxPresentationName.SelectedIndex = -1;

            comboBoxClientName.DataSource = CollectionService.clients_collection;
            comboBoxClientName.DisplayMember = "nombre";
            comboBoxClientName.SelectedIndex = -1;


            // Configurar las opciones de comboboxPayMethod
            comboBoxPayMethod.Items.Add("Efectivo");
            comboBoxPayMethod.Items.Add("Transferencia");
        }

        // Metodos de operaciones

        public void UpdateTotal ()
        {
            decimal total_mod = 0;
            foreach (DataGridViewRow row in dataGridViewItems.Rows)
            {
                if (
                    row.Cells["ColumnSubtotal"].Value != null)
                {
                    total_mod += Convert.ToDecimal(
                        row.Cells["ColumnSubtotal"].Value
                    );
                }
            }
            // Actualizar el labelTotal con el nuevo total
            labelTotal.Text = total_mod.ToString("N0");
        }

        // Metodos de Formulario

        private void buttonInsertPresentation_Click(object sender, EventArgs e)
        {
            // Insertar detalles de presentacion en la lista de facturacion

            bool discard = false;

            textBoxInfo.Text = "";

            try
            {
                if (labelItemStock.Text == "0")
                {
                    textBoxInfo.Text += "No hay stock disponible para la presentacion seleccionada." + Environment.NewLine;
                    return;
                }
                else if (labelItemStock.Text == "-1")
                {
                    textBoxInfo.Text += "No se pudo obtener el stock de la presentacion seleccionada." + Environment.NewLine;
                    return;
                }

                if (string.IsNullOrEmpty(textBoxQuantity.Text))
                {
                    textBoxInfo.Text += "Debe ingresar una cantidad." + Environment.NewLine;
                    return;
                }

                if (string.IsNullOrEmpty(textBoxCostUnit.Text))
                {
                    textBoxInfo.Text += "Debe ingresar un costo unitario." + Environment.NewLine;
                    return;
                }


                if (int.Parse(labelItemStock.Text) < int.Parse(textBoxQuantity.Text))
                {
                    textBoxInfo.Text += "No hay suficiente stock disponible para la presentacion seleccionada." + Environment.NewLine;
                    return;
                }

                if (int.TryParse(textBoxQuantity.Text, out int quantity) && quantity <= 0)
                {
                    textBoxInfo.Text += "La cantidad debe ser mayor a 0." + Environment.NewLine;
                    discard = true;
                }

                if (decimal.TryParse(textBoxCostUnit.Text, out decimal costUnit) && costUnit <= 0)
                {
                    textBoxInfo.Text += "El costo unitario debe ser mayor a 0." + Environment.NewLine;
                    discard = true;
                }

                if (decimal.TryParse(textBoxDiscount.Text, out decimal discount) && (discount < 0 || discount > 100))
                {
                    textBoxInfo.Text += "El descuento debe estar entre 0 y 100." + Environment.NewLine;
                    discard = true;
                }


                if (comboBoxPresentationName.SelectedItem == null)
                {
                    textBoxInfo.Text += "Debe seleccionar una presentacion." + Environment.NewLine;
                    discard = true;
                }
            }
            catch (Exception ex)
            {
                textBoxInfo.Text += "Error al procesar los datos: " + ex.Message + Environment.NewLine;
            }

            if (discard)
            {
                return;
            }


            // Si la presentacion ya existe en la lista de facturacion, actualizar la cantidad y el subtotal

            GenericTools.GetRowByColumn(dataGridViewItems, ((PresentationDTO)comboBoxPresentationName.SelectedItem).IdPresentacion.ToString(), "ColumnID_Presentation", out DataGridViewRow existingRow);

            if (existingRow != null)
            {
                int existingQuantity = int.Parse(existingRow.Cells["ColumnQuantity"].Value.ToString());
                decimal existingCostUnit = decimal.Parse(existingRow.Cells["ColumnCostUnit"].Value.ToString());
                decimal existingDiscount = string.IsNullOrEmpty(existingRow.Cells["ColumnDiscount"].Value?.ToString()) ? 0 : decimal.Parse(existingRow.Cells["ColumnDiscount"].Value.ToString().TrimEnd('%'));

                decimal newDiscount = string.IsNullOrEmpty(textBoxDiscount.Text) ? 0 : decimal.Parse(textBoxDiscount.Text);
                int newQuantity = existingQuantity + int.Parse(textBoxQuantity.Text);
                decimal newCostUnit = existingCostUnit; // Mantener el costo unitario existente
                decimal newSubtotal = newQuantity * newCostUnit;
                decimal newTotal = newQuantity * newCostUnit * (1 - (newDiscount / 100));

                existingRow.Cells["ColumnQuantity"].Value = newQuantity.ToString("N0");
                existingRow.Cells["ColumnCostUnit"].Value = newCostUnit.ToString("N0");
                existingRow.Cells["ColumnDiscount"].Value = newDiscount.ToString() + "%";
                existingRow.Cells["ColumnSubtotal"].Value = newSubtotal.ToString("N0");
                existingRow.Cells["ColumnTotal"].Value = newTotal.ToString("N0");
            }
            else
            {
                // Parametros para crear la nueva fila en el DataGridView
                int indice = dataGridViewItems.Rows.Add();

                int cantidad = int.Parse(textBoxQuantity.Text);
                decimal costo_unitario = decimal.Parse(textBoxCostUnit.Text);
                decimal descuento = string.IsNullOrEmpty(textBoxDiscount.Text) ? 0 : decimal.Parse(textBoxDiscount.Text);
                decimal subtotal = cantidad * costo_unitario;
                decimal total = cantidad * costo_unitario * (1 - (descuento / 100));

                // Crear el nuevo objeto fila en el DataGridView
                DataGridViewRow fila = dataGridViewItems.Rows[indice];
                fila.Cells["ColumnID_Presentation"].Value = ((PresentationDTO)comboBoxPresentationName.SelectedItem).IdPresentacion;
                fila.Cells["ColumnProduct"].Value = comboBoxPresentationName.Text;
                fila.Cells["ColumnQuantity"].Value = cantidad.ToString("N0");
                fila.Cells["ColumnCostUnit"].Value = costo_unitario.ToString("N0");
                fila.Cells["ColumnDiscount"].Value = descuento.ToString() + "%";
                fila.Cells["ColumnSubtotal"].Value = subtotal.ToString("N0");
                fila.Cells["ColumnTotal"].Value = total.ToString("N0");
            }

            // Limpiar los campos de entrada 
            textBoxCostUnit.Clear();
            textBoxQuantity.Clear();
            textBoxDiscount.Clear();
            comboBoxPresentationName.SelectedIndex = -1;

            UpdateTotal();

            return;
        }

        private void buttonInvoice_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "";

            if (comboBoxClientName.SelectedItem == null)
            {
                textBoxInfo.Text += "Debe seleccionar un cliente." + Environment.NewLine;
                return;
            }
            if (dataGridViewItems.Rows.Count == 0)
            {
                textBoxInfo.Text += "Debe agregar al menos un item a la venta." + Environment.NewLine;
                return;
            }
            if (comboBoxPayMethod.SelectedItem == null)
            {
                textBoxInfo.Text += "Debe seleccionar un método de pago." + Environment.NewLine;
                return;
            }

            // Facturar la venta
            if (string.IsNullOrEmpty(comboBoxClientName.Text) == false &&
                dataGridViewItems.Rows.Count > 0)
            { // Comprobar que existe un nombre de cliente y que hay items en la venta

                // Llamar al servicio para crear la venta
                SellService.CreateSell(
                    ((ClientDTO)comboBoxClientName.SelectedItem).id_cliente,
                    dataGridViewItems.Rows,
                    decimal.Parse(labelTotal.Text),
                    comboBoxPayMethod.SelectedItem.ToString());

                // Limpieza de datos despues de la venta
                dataGridViewItems.Rows.Clear();
                labelTotal.Text = "";

            }
        }

        private void comboBoxPresentationName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Crear objeto PresentationDTO a partir del item seleccionado en el combobox
            PresentationDTO presentation_act = (PresentationDTO)comboBoxPresentationName.SelectedItem;

            if (presentation_act != null)
            {
                textBoxCostUnit.Text = presentation_act.Costo.ToString("N0");
            }


            // Mostrar el stock de la presentacion seleccionada en el labelItemStock menos las presentaciones que ya se han agregado a la venta
            if (presentation_act != null)
            {
                int stock_actual = InventoryService.QueryStockPresentation(presentation_act.IdPresentacion);

                labelItemStock.ForeColor = Color.Black;

                foreach (DataGridViewRow row in dataGridViewItems.Rows)
                {
                    if (row.Cells["ColumnID_Presentation"].Value != null &&
                        (int)row.Cells["ColumnID_Presentation"].Value == presentation_act.IdPresentacion)
                    {
                        stock_actual -= int.Parse(row.Cells["ColumnQuantity"].Value.ToString());
                        labelItemStock.ForeColor = Color.Red;
                    }
                }
                labelItemStock.Text = stock_actual.ToString("N0");
            }
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar que solo se ingresen numeros en la cantidad
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCostUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonClearRows_Click(object sender, EventArgs e)
        {
            dataGridViewItems.Rows.Clear();
            UpdateTotal();
        }

        private void buttonDeleteRecord_Click(object sender, EventArgs e)
        {
            if (dataGridViewItems.CurrentRow != null)
            {
                dataGridViewItems.Rows.Remove(dataGridViewItems.CurrentRow);
                UpdateTotal();
            }
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            formAddClients = new FormAddClients();
            formAddClients.ShowDialog();
        }

        private void buttonReloadUnitPrice_Click(object sender, EventArgs e)
        {
            if (comboBoxPresentationName.SelectedItem != null)
            {
                textBoxCostUnit.Text = ((PresentationDTO)comboBoxPresentationName.SelectedItem).Costo.ToString("N0");
            }
        }


    }
}
