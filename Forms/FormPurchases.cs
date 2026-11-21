using Salam_Database.Models;
using Salam_Database.Repositories;
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
    public partial class FormPurchases : Form
    {
        FormAddProvider formAddProvider;


        public FormPurchases()
        {
            InitializeComponent();

            
            comboBoxPresentationName.DataSource = CollectionService.presentations_collection;
            comboBoxPresentationName.DisplayMember = "ProductoNombre";
            comboBoxPresentationName.SelectedIndex = -1;

            
            comboBoxProviderName.DataSource = CollectionService.providers_collection;
            comboBoxProviderName.DisplayMember = "Nombre";
            comboBoxProviderName.SelectedIndex = -1;

            // Configurar ComboboxPaymentMethod
            comboBoxPaymentMehtod.Items.Add("Efectivo");
            comboBoxPaymentMehtod.Items.Add("Transferencia");

        }

        // Metodos de operaciones

        public void UpdateTotal()
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
            // Validadores 

            if (string.IsNullOrEmpty(textBoxQuantity.Text) || string.IsNullOrEmpty(textBoxCostUnit.Text))
            {
                textBoxInfo.Text = "Debe ingresar cantidad y costo unitario para la presentacion seleccionada.";
                return;
            }
            else if (comboBoxPresentationName.SelectedItem == null)
            {
                textBoxInfo.Text = "Debe seleccionar una presentacion para agregar a la lista de facturacion.";
                return;
            }
            if (int.Parse(textBoxQuantity.Text) <= 0 || decimal.Parse(textBoxCostUnit.Text) <= 0)
            {
                textBoxInfo.Text = "La cantidad y el costo unitario deben ser mayores a cero.";
                return;
            }
            if (comboBoxPaymentMehtod.SelectedItem == null)
            {
                textBoxInfo.Text = "Debe seleccionar un método de pago.";
                return;
            }
            if (comboBoxProviderName.SelectedItem == null)
            {
                textBoxInfo.Text = "Debe seleccionar un proveedor.";
                return;
            }


            // Si la presentacion ya existe en la lista de facturacion, actualizar la cantidad y el subtotal

            GenericTools.GetRowByColumn(dataGridViewItems, ((PresentationDTO)comboBoxPresentationName.SelectedItem).IdPresentacion.ToString(), "ColumnID_Presentation", out DataGridViewRow existingRow);

            if (existingRow != null)
            {
                int existingQuantity = int.Parse(existingRow.Cells["ColumnQuantity"].Value.ToString());
                decimal existingCostUnit = decimal.Parse(existingRow.Cells["ColumnCostUnit"].Value.ToString());


                int newQuantity = existingQuantity + int.Parse(textBoxQuantity.Text);
                decimal newCostUnit = existingCostUnit; // Mantener el costo unitario existente
                decimal newSubtotal = newQuantity * newCostUnit;

                existingRow.Cells["ColumnQuantity"].Value = newQuantity.ToString("N0");
                existingRow.Cells["ColumnCostUnit"].Value = newCostUnit.ToString("N0");
                existingRow.Cells["ColumnSubtotal"].Value = newSubtotal.ToString("N0");
            }
            else
            {
                labelItemStock.Text = 0.ToString("N0");

                int indice = dataGridViewItems.Rows.Add();

                DataGridViewRow fila =
                    dataGridViewItems.Rows[indice];
                fila.Cells["ColumnID_Presentation"].Value = ((PresentationDTO)comboBoxPresentationName.SelectedItem).IdPresentacion;
                fila.Cells["ColumnProduct"].Value = comboBoxPresentationName.Text;
                fila.Cells["ColumnQuantity"].Value = int.Parse(textBoxQuantity.Text).ToString("N0");
                fila.Cells["ColumnCostUnit"].Value = decimal.Parse(textBoxCostUnit.Text).ToString("N0");
                fila.Cells["ColumnSubtotal"].Value = (float.Parse(textBoxQuantity.Text) * float.Parse(textBoxCostUnit.Text)).ToString("N0");

                
            }
            // Limpiar los campos de entrada
            textBoxCostUnit.Clear();
            textBoxQuantity.Clear();
            comboBoxPresentationName.SelectedIndex = -1;

            decimal total = 0;

            // Limpiar las filas
            foreach (DataGridViewRow row in dataGridViewItems.Rows)
            {
                if (
                    row.Cells["ColumnSubtotal"].Value != null)
                {
                    total += Convert.ToDecimal(
                        row.Cells["ColumnSubtotal"].Value
                    );
                }
            }
            // Actualizar el labelTotal con el total calculado
            labelTotal.Text = total.ToString("N0");
            return;
        }

        private void buttonInvoice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxProviderName.Text) == false &&
                dataGridViewItems.Rows.Count > 0)
            {
                string res = PurchaseService.CreatePurchase(((ProviderDTO)comboBoxProviderName.SelectedItem).IdProveedor, 
                    dataGridViewItems.Rows, 
                    decimal.Parse(labelTotal.Text));

                foreach (DataGridViewRow row in dataGridViewItems.Rows)
                {
                    dataGridViewItems.Rows.Remove(row);
                }
                labelTotal.Text = "";
            }
        }

        private void comboBoxPresentationName_SelectedIndexChanged(object sender, EventArgs e)
        {
            PresentationDTO presentation_act = (PresentationDTO)comboBoxPresentationName.SelectedItem;
            if (presentation_act != null)
            {
                textBoxCostUnit.Text = presentation_act.Costo.ToString("N0");
            }
            if (presentation_act != null)
            {
                labelItemStock.Text = InventoryService.QueryStockPresentation(presentation_act.IdPresentacion).ToString("N0");
            }
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void buttonCleanRows_Click(object sender, EventArgs e)
        {
            dataGridViewItems.Rows.Clear();
            UpdateTotal();
        }

        private void buttonRemoveRecord_Click(object sender, EventArgs e)
        {
            if (dataGridViewItems.CurrentRow != null)
            {
                dataGridViewItems.Rows.Remove(dataGridViewItems.CurrentRow);
                UpdateTotal();
            }
        }

        private void buttonReloadCostUnit_Click(object sender, EventArgs e)
        {
            if (comboBoxPresentationName.SelectedItem != null)
            {
                textBoxCostUnit.Text = ((PresentationDTO)comboBoxPresentationName.SelectedItem).Costo.ToString("N0");
            }
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            formAddProvider = new FormAddProvider();
            formAddProvider.ShowDialog();   
        }
    }
}
