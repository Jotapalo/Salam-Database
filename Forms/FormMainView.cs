using Salam_Database.Models;
using Salam_Database.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Salam_Database.Forms
{
    public partial class FormMainView : Form
    {
        // Formularios de referencia
        public FormPurchases formPurchases { get; private set; }
        public FormSells formSells { get; private set; }
        public FormAddClients formAddClients { get; private set; }
        public FormAddProvider formAddProvider { get; private set; }
        public FormAddBrand formAddBrand { get; private set; }
        public FormAddProduct formAddProduct { get; private set; }
        public FormAddCategory formAddCategory { get; private set; }


        public static DataTable recentMovements { get; private set; }
        public FormAddSubcategory formAddSubcategory { get; private set; }
        public FormAddPresentation formAddPresentation { get; private set; }

        public FormMainView()
        {
            InitializeComponent();
            labelUserName.Text = LoginService.GetActualUser();
            labelUserRole.Text = LoginService.GetRol();

            dataGridViewRecentMovements.AutoGenerateColumns = false;
            dataGridViewDetails.AutoGenerateColumns = false;

            // Configurar las columnas del DataGridView de movimientos recientes
            ColumnId.DataPropertyName = "id";
            ColumnDate.DataPropertyName = "fecha";
            ColumnType.DataPropertyName = "tipo";
            ColumnTotal.DataPropertyName = "total";
            ColumnPerson.DataPropertyName = "persona";
            dataGridViewRecentMovements.Columns["ColumnTotal"].DefaultCellStyle.Format = "N0";

            recentMovements = DataService.GetRecentMovements();
            dataGridViewRecentMovements.DataSource = recentMovements;

            // Configurar las columnas del DataGridView de detalles 
            ColumnQuantity.DataPropertyName = "cantidad";
            ColumnName.DataPropertyName = "nombre";
            ColumnSubtotal.DataPropertyName = "subtotal";
        }

        private void buttonRegisterSells_Click(object sender, EventArgs e)
        {
            
            formSells = new FormSells();
            formSells.Show();
        }

        private void buttonRegisterPurchases_Click(object sender, EventArgs e)
        {
            formPurchases = new FormPurchases();
            formPurchases.Show();
        }

        private void FormMainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewRecentMovements_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridViewRecentMovements.Rows.Count)
            {
                return; // Salir si se hace clic en el encabezado o fuera de los límites
            }
            // Cambiar la columna dependiendo del tipo de movimiento
            string movementType = dataGridViewRecentMovements.Rows[e.RowIndex].Cells["ColumnType"].Value.ToString().ToLower();
            if (movementType == "venta")
            {
                ColumnUnitValue.DataPropertyName = "precio_unitario";
                ColumnUnitValue.HeaderText = "Precio Unitario";
            }
            else if (movementType == "compra")
            {
                ColumnUnitValue.DataPropertyName = "costo_unitario";
                ColumnUnitValue.HeaderText = "Costo Unitario";
            }
            else
            {
                // Manejar otros tipos de movimiento si es necesario
                ColumnUnitValue.DataPropertyName = "precio_unitario"; // Valor por defecto
                ColumnUnitValue.HeaderText = "Precio Unitario"; // Valor por defecto
            }

            DataTable movementDetails = DataService.GetMovementDetailsById(
                dataGridViewRecentMovements.Rows[e.RowIndex].Cells["ColumnId"].Value.ToString(),
                dataGridViewRecentMovements.Rows[e.RowIndex].Cells["ColumnType"].Value.ToString());


            dataGridViewDetails.DataSource = movementDetails;
        }

        private void buttonAddClients_Click(object sender, EventArgs e)
        {
            formAddClients = new FormAddClients();
            formAddClients.ShowDialog();
        }

        private void buttonUpdateRecentMovements_Click(object sender, EventArgs e)
        {
            recentMovements = DataService.GetRecentMovements();
            dataGridViewRecentMovements.DataSource = recentMovements;
        }

        private void buttonAddProvider_Click(object sender, EventArgs e)
        {
            formAddProvider = new FormAddProvider();
            formAddProvider.ShowDialog();
        }

        private void buttonAddBrand_Click(object sender, EventArgs e)
        {
            formAddBrand = new FormAddBrand();
            formAddBrand.ShowDialog();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            formAddProduct = new FormAddProduct();
            formAddProduct.ShowDialog();
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

        private void buttonAddPresentation_Click(object sender, EventArgs e)
        {
            formAddPresentation = new FormAddPresentation();
            formAddPresentation.ShowDialog();
        }
    }
}
