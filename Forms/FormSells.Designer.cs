namespace Salam_Database.Forms
{
    partial class FormSells
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPurchase = new System.Windows.Forms.Panel();
            this.buttonReloadUnitPrice = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDeleteRecord = new System.Windows.Forms.Button();
            this.buttonClearRows = new System.Windows.Forms.Button();
            this.comboBoxPayMethod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.labelItemStock = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.comboBoxClientName = new System.Windows.Forms.ComboBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonInvoice = new System.Windows.Forms.Button();
            this.buttonInsertPresentation = new System.Windows.Forms.Button();
            this.textBoxCostUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPresentationName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.ColumnID_Presentation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCostUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPurchase = new System.Windows.Forms.Label();
            this.panelPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPurchase
            // 
            this.panelPurchase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelPurchase.Controls.Add(this.buttonReloadUnitPrice);
            this.panelPurchase.Controls.Add(this.button1);
            this.panelPurchase.Controls.Add(this.buttonDeleteRecord);
            this.panelPurchase.Controls.Add(this.buttonClearRows);
            this.panelPurchase.Controls.Add(this.comboBoxPayMethod);
            this.panelPurchase.Controls.Add(this.label6);
            this.panelPurchase.Controls.Add(this.textBoxInfo);
            this.panelPurchase.Controls.Add(this.labelItemStock);
            this.panelPurchase.Controls.Add(this.label9);
            this.panelPurchase.Controls.Add(this.textBoxDiscount);
            this.panelPurchase.Controls.Add(this.label5);
            this.panelPurchase.Controls.Add(this.buttonAddClient);
            this.panelPurchase.Controls.Add(this.comboBoxClientName);
            this.panelPurchase.Controls.Add(this.labelTotal);
            this.panelPurchase.Controls.Add(this.label4);
            this.panelPurchase.Controls.Add(this.buttonInvoice);
            this.panelPurchase.Controls.Add(this.buttonInsertPresentation);
            this.panelPurchase.Controls.Add(this.textBoxCostUnit);
            this.panelPurchase.Controls.Add(this.label3);
            this.panelPurchase.Controls.Add(this.textBoxQuantity);
            this.panelPurchase.Controls.Add(this.label2);
            this.panelPurchase.Controls.Add(this.comboBoxPresentationName);
            this.panelPurchase.Controls.Add(this.label1);
            this.panelPurchase.Controls.Add(this.labelClient);
            this.panelPurchase.Controls.Add(this.dataGridViewItems);
            this.panelPurchase.Location = new System.Drawing.Point(12, 8);
            this.panelPurchase.Name = "panelPurchase";
            this.panelPurchase.Size = new System.Drawing.Size(960, 441);
            this.panelPurchase.TabIndex = 0;
            // 
            // buttonReloadUnitPrice
            // 
            this.buttonReloadUnitPrice.AutoSize = true;
            this.buttonReloadUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReloadUnitPrice.Location = new System.Drawing.Point(174, 74);
            this.buttonReloadUnitPrice.Name = "buttonReloadUnitPrice";
            this.buttonReloadUnitPrice.Size = new System.Drawing.Size(26, 23);
            this.buttonReloadUnitPrice.TabIndex = 26;
            this.buttonReloadUnitPrice.Text = "↻";
            this.buttonReloadUnitPrice.UseVisualStyleBackColor = true;
            this.buttonReloadUnitPrice.Click += new System.EventHandler(this.buttonReloadUnitPrice_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(542, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 26);
            this.button1.TabIndex = 25;
            this.button1.Text = "🔍";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteRecord
            // 
            this.buttonDeleteRecord.Location = new System.Drawing.Point(495, 90);
            this.buttonDeleteRecord.Name = "buttonDeleteRecord";
            this.buttonDeleteRecord.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteRecord.TabIndex = 24;
            this.buttonDeleteRecord.Text = "Borrar";
            this.buttonDeleteRecord.UseVisualStyleBackColor = true;
            this.buttonDeleteRecord.Click += new System.EventHandler(this.buttonDeleteRecord_Click);
            // 
            // buttonClearRows
            // 
            this.buttonClearRows.Location = new System.Drawing.Point(495, 61);
            this.buttonClearRows.Name = "buttonClearRows";
            this.buttonClearRows.Size = new System.Drawing.Size(75, 23);
            this.buttonClearRows.TabIndex = 23;
            this.buttonClearRows.Text = "Limpiar";
            this.buttonClearRows.UseVisualStyleBackColor = true;
            this.buttonClearRows.Click += new System.EventHandler(this.buttonClearRows_Click);
            // 
            // comboBoxPayMethod
            // 
            this.comboBoxPayMethod.FormattingEnabled = true;
            this.comboBoxPayMethod.Location = new System.Drawing.Point(294, 76);
            this.comboBoxPayMethod.Name = "comboBoxPayMethod";
            this.comboBoxPayMethod.Size = new System.Drawing.Size(107, 21);
            this.comboBoxPayMethod.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Metodo de pago";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfo.ForeColor = System.Drawing.Color.Red;
            this.textBoxInfo.Location = new System.Drawing.Point(580, 14);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(362, 105);
            this.textBoxInfo.TabIndex = 20;
            // 
            // labelItemStock
            // 
            this.labelItemStock.AutoSize = true;
            this.labelItemStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemStock.Location = new System.Drawing.Point(52, 100);
            this.labelItemStock.Name = "labelItemStock";
            this.labelItemStock.Size = new System.Drawing.Size(15, 15);
            this.labelItemStock.TabIndex = 19;
            this.labelItemStock.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Stock: ";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Location = new System.Drawing.Point(209, 77);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(68, 20);
            this.textBoxDiscount.TabIndex = 17;
            this.textBoxDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDiscount_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Descuento";
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.AutoSize = true;
            this.buttonAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddClient.Location = new System.Drawing.Point(209, 28);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(29, 26);
            this.buttonAddClient.TabIndex = 15;
            this.buttonAddClient.Text = "＋";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // comboBoxClientName
            // 
            this.comboBoxClientName.FormattingEnabled = true;
            this.comboBoxClientName.Location = new System.Drawing.Point(19, 30);
            this.comboBoxClientName.Name = "comboBoxClientName";
            this.comboBoxClientName.Size = new System.Drawing.Size(184, 21);
            this.comboBoxClientName.TabIndex = 14;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(907, 419);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(19, 16);
            this.labelTotal.TabIndex = 13;
            this.labelTotal.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(848, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total: $";
            // 
            // buttonInvoice
            // 
            this.buttonInvoice.Location = new System.Drawing.Point(414, 90);
            this.buttonInvoice.Name = "buttonInvoice";
            this.buttonInvoice.Size = new System.Drawing.Size(75, 23);
            this.buttonInvoice.TabIndex = 11;
            this.buttonInvoice.Text = "Facturar";
            this.buttonInvoice.UseVisualStyleBackColor = true;
            this.buttonInvoice.Click += new System.EventHandler(this.buttonInvoice_Click);
            // 
            // buttonInsertPresentation
            // 
            this.buttonInsertPresentation.Location = new System.Drawing.Point(414, 61);
            this.buttonInsertPresentation.Name = "buttonInsertPresentation";
            this.buttonInsertPresentation.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertPresentation.TabIndex = 10;
            this.buttonInsertPresentation.Text = "Insertar Presentacion";
            this.buttonInsertPresentation.UseVisualStyleBackColor = true;
            this.buttonInsertPresentation.Click += new System.EventHandler(this.buttonInsertPresentation_Click);
            // 
            // textBoxCostUnit
            // 
            this.textBoxCostUnit.Location = new System.Drawing.Point(101, 77);
            this.textBoxCostUnit.Name = "textBoxCostUnit";
            this.textBoxCostUnit.ReadOnly = true;
            this.textBoxCostUnit.Size = new System.Drawing.Size(68, 20);
            this.textBoxCostUnit.TabIndex = 9;
            this.textBoxCostUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCostUnit_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio unitario";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(14, 77);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(65, 20);
            this.textBoxQuantity.TabIndex = 7;
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantity_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad";
            // 
            // comboBoxPresentationName
            // 
            this.comboBoxPresentationName.FormattingEnabled = true;
            this.comboBoxPresentationName.Location = new System.Drawing.Point(258, 30);
            this.comboBoxPresentationName.Name = "comboBoxPresentationName";
            this.comboBoxPresentationName.Size = new System.Drawing.Size(281, 21);
            this.comboBoxPresentationName.TabIndex = 5;
            this.comboBoxPresentationName.SelectedIndexChanged += new System.EventHandler(this.comboBoxPresentationName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Presentacion";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(16, 14);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(39, 13);
            this.labelClient.TabIndex = 2;
            this.labelClient.Text = "Cliente";
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID_Presentation,
            this.ColumnProduct,
            this.ColumnQuantity,
            this.ColumnCostUnit,
            this.ColumnSubtotal,
            this.ColumnDiscount,
            this.ColumnTotal});
            this.dataGridViewItems.Location = new System.Drawing.Point(14, 125);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.Size = new System.Drawing.Size(928, 291);
            this.dataGridViewItems.TabIndex = 1;
            // 
            // ColumnID_Presentation
            // 
            this.ColumnID_Presentation.HeaderText = "ID";
            this.ColumnID_Presentation.Name = "ColumnID_Presentation";
            this.ColumnID_Presentation.Width = 50;
            // 
            // ColumnProduct
            // 
            this.ColumnProduct.HeaderText = "Producto";
            this.ColumnProduct.Name = "ColumnProduct";
            this.ColumnProduct.Width = 300;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.HeaderText = "Cantidad";
            this.ColumnQuantity.Name = "ColumnQuantity";
            // 
            // ColumnCostUnit
            // 
            this.ColumnCostUnit.HeaderText = "Costo Unitario";
            this.ColumnCostUnit.Name = "ColumnCostUnit";
            // 
            // ColumnSubtotal
            // 
            this.ColumnSubtotal.HeaderText = "Subtotal";
            this.ColumnSubtotal.Name = "ColumnSubtotal";
            // 
            // ColumnDiscount
            // 
            this.ColumnDiscount.HeaderText = "Descuento";
            this.ColumnDiscount.Name = "ColumnDiscount";
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.HeaderText = "Total";
            this.ColumnTotal.Name = "ColumnTotal";
            // 
            // labelPurchase
            // 
            this.labelPurchase.AutoSize = true;
            this.labelPurchase.Location = new System.Drawing.Point(12, 8);
            this.labelPurchase.Name = "labelPurchase";
            this.labelPurchase.Size = new System.Drawing.Size(96, 13);
            this.labelPurchase.TabIndex = 1;
            this.labelPurchase.Text = "Registro de ventas";
            // 
            // FormSells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.labelPurchase);
            this.Controls.Add(this.panelPurchase);
            this.Name = "FormSells";
            this.Text = "Registar Ventas";
            this.panelPurchase.ResumeLayout(false);
            this.panelPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPurchase;
        private System.Windows.Forms.Label labelPurchase;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.ComboBox comboBoxPresentationName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonInsertPresentation;
        private System.Windows.Forms.TextBox textBoxCostUnit;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonInvoice;
        private System.Windows.Forms.ComboBox comboBoxClientName;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelItemStock;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.ComboBox comboBoxPayMethod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDeleteRecord;
        private System.Windows.Forms.Button buttonClearRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID_Presentation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCostUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonReloadUnitPrice;
    }
}