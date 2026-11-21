namespace Salam_Database.Forms
{
    partial class FormPurchases
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
            this.buttonReloadCostUnit = new System.Windows.Forms.Button();
            this.buttonSearchPresentation = new System.Windows.Forms.Button();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.comboBoxPaymentMehtod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonRemoveRecord = new System.Windows.Forms.Button();
            this.buttonCleanRows = new System.Windows.Forms.Button();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.labelItemStock = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxProviderName = new System.Windows.Forms.ComboBox();
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
            this.labelProvider = new System.Windows.Forms.Label();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.ColumnID_Presentation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCostUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPurchase = new System.Windows.Forms.Label();
            this.panelPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPurchase
            // 
            this.panelPurchase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelPurchase.Controls.Add(this.buttonReloadCostUnit);
            this.panelPurchase.Controls.Add(this.buttonSearchPresentation);
            this.panelPurchase.Controls.Add(this.buttonAddClient);
            this.panelPurchase.Controls.Add(this.comboBoxPaymentMehtod);
            this.panelPurchase.Controls.Add(this.label6);
            this.panelPurchase.Controls.Add(this.buttonRemoveRecord);
            this.panelPurchase.Controls.Add(this.buttonCleanRows);
            this.panelPurchase.Controls.Add(this.textBoxInfo);
            this.panelPurchase.Controls.Add(this.labelItemStock);
            this.panelPurchase.Controls.Add(this.label5);
            this.panelPurchase.Controls.Add(this.comboBoxProviderName);
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
            this.panelPurchase.Controls.Add(this.labelProvider);
            this.panelPurchase.Controls.Add(this.dataGridViewItems);
            this.panelPurchase.Location = new System.Drawing.Point(12, 12);
            this.panelPurchase.Name = "panelPurchase";
            this.panelPurchase.Size = new System.Drawing.Size(960, 437);
            this.panelPurchase.TabIndex = 0;
            // 
            // buttonReloadCostUnit
            // 
            this.buttonReloadCostUnit.AutoSize = true;
            this.buttonReloadCostUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReloadCostUnit.Location = new System.Drawing.Point(164, 70);
            this.buttonReloadCostUnit.Name = "buttonReloadCostUnit";
            this.buttonReloadCostUnit.Size = new System.Drawing.Size(26, 23);
            this.buttonReloadCostUnit.TabIndex = 28;
            this.buttonReloadCostUnit.Text = "↻";
            this.buttonReloadCostUnit.UseVisualStyleBackColor = true;
            this.buttonReloadCostUnit.Click += new System.EventHandler(this.buttonReloadCostUnit_Click);
            // 
            // buttonSearchPresentation
            // 
            this.buttonSearchPresentation.AutoSize = true;
            this.buttonSearchPresentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSearchPresentation.Location = new System.Drawing.Point(472, 21);
            this.buttonSearchPresentation.Name = "buttonSearchPresentation";
            this.buttonSearchPresentation.Size = new System.Drawing.Size(29, 26);
            this.buttonSearchPresentation.TabIndex = 27;
            this.buttonSearchPresentation.Text = "🔍";
            this.buttonSearchPresentation.UseVisualStyleBackColor = true;
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddClient.AutoSize = true;
            this.buttonAddClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddClient.Location = new System.Drawing.Point(158, 21);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(32, 26);
            this.buttonAddClient.TabIndex = 26;
            this.buttonAddClient.Text = "＋";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // comboBoxPaymentMehtod
            // 
            this.comboBoxPaymentMehtod.FormattingEnabled = true;
            this.comboBoxPaymentMehtod.Location = new System.Drawing.Point(205, 72);
            this.comboBoxPaymentMehtod.Name = "comboBoxPaymentMehtod";
            this.comboBoxPaymentMehtod.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPaymentMehtod.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Metodo de pago";
            // 
            // buttonRemoveRecord
            // 
            this.buttonRemoveRecord.Location = new System.Drawing.Point(428, 88);
            this.buttonRemoveRecord.Name = "buttonRemoveRecord";
            this.buttonRemoveRecord.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveRecord.TabIndex = 23;
            this.buttonRemoveRecord.Text = "Borrar";
            this.buttonRemoveRecord.UseVisualStyleBackColor = true;
            this.buttonRemoveRecord.Click += new System.EventHandler(this.buttonRemoveRecord_Click);
            // 
            // buttonCleanRows
            // 
            this.buttonCleanRows.Location = new System.Drawing.Point(428, 57);
            this.buttonCleanRows.Name = "buttonCleanRows";
            this.buttonCleanRows.Size = new System.Drawing.Size(75, 23);
            this.buttonCleanRows.TabIndex = 22;
            this.buttonCleanRows.Text = "Limpiar";
            this.buttonCleanRows.UseVisualStyleBackColor = true;
            this.buttonCleanRows.Click += new System.EventHandler(this.buttonCleanRows_Click);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfo.ForeColor = System.Drawing.Color.Red;
            this.textBoxInfo.Location = new System.Drawing.Point(514, 25);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(429, 89);
            this.textBoxInfo.TabIndex = 21;
            // 
            // labelItemStock
            // 
            this.labelItemStock.AutoSize = true;
            this.labelItemStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemStock.Location = new System.Drawing.Point(56, 96);
            this.labelItemStock.Name = "labelItemStock";
            this.labelItemStock.Size = new System.Drawing.Size(15, 15);
            this.labelItemStock.TabIndex = 17;
            this.labelItemStock.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Stock: ";
            // 
            // comboBoxProviderName
            // 
            this.comboBoxProviderName.FormattingEnabled = true;
            this.comboBoxProviderName.Location = new System.Drawing.Point(15, 25);
            this.comboBoxProviderName.Name = "comboBoxProviderName";
            this.comboBoxProviderName.Size = new System.Drawing.Size(137, 21);
            this.comboBoxProviderName.TabIndex = 14;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(677, 417);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(19, 16);
            this.labelTotal.TabIndex = 13;
            this.labelTotal.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(623, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total: $";
            // 
            // buttonInvoice
            // 
            this.buttonInvoice.Location = new System.Drawing.Point(347, 86);
            this.buttonInvoice.Name = "buttonInvoice";
            this.buttonInvoice.Size = new System.Drawing.Size(75, 23);
            this.buttonInvoice.TabIndex = 11;
            this.buttonInvoice.Text = "Facturar";
            this.buttonInvoice.UseVisualStyleBackColor = true;
            this.buttonInvoice.Click += new System.EventHandler(this.buttonInvoice_Click);
            // 
            // buttonInsertPresentation
            // 
            this.buttonInsertPresentation.Location = new System.Drawing.Point(347, 57);
            this.buttonInsertPresentation.Name = "buttonInsertPresentation";
            this.buttonInsertPresentation.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertPresentation.TabIndex = 10;
            this.buttonInsertPresentation.Text = "Insertar Presentacion";
            this.buttonInsertPresentation.UseVisualStyleBackColor = true;
            this.buttonInsertPresentation.Click += new System.EventHandler(this.buttonInsertPresentation_Click);
            // 
            // textBoxCostUnit
            // 
            this.textBoxCostUnit.Location = new System.Drawing.Point(90, 73);
            this.textBoxCostUnit.Name = "textBoxCostUnit";
            this.textBoxCostUnit.Size = new System.Drawing.Size(68, 20);
            this.textBoxCostUnit.TabIndex = 9;
            this.textBoxCostUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCostUnit_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Costo unitario";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(15, 73);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(56, 20);
            this.textBoxQuantity.TabIndex = 7;
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantity_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad";
            // 
            // comboBoxPresentationName
            // 
            this.comboBoxPresentationName.FormattingEnabled = true;
            this.comboBoxPresentationName.Location = new System.Drawing.Point(207, 25);
            this.comboBoxPresentationName.Name = "comboBoxPresentationName";
            this.comboBoxPresentationName.Size = new System.Drawing.Size(259, 21);
            this.comboBoxPresentationName.TabIndex = 5;
            this.comboBoxPresentationName.SelectedIndexChanged += new System.EventHandler(this.comboBoxPresentationName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Presentacion";
            // 
            // labelProvider
            // 
            this.labelProvider.AutoSize = true;
            this.labelProvider.Location = new System.Drawing.Point(12, 9);
            this.labelProvider.Name = "labelProvider";
            this.labelProvider.Size = new System.Drawing.Size(95, 13);
            this.labelProvider.TabIndex = 2;
            this.labelProvider.Text = "Nombre proveedor";
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
            this.ColumnSubtotal});
            this.dataGridViewItems.Location = new System.Drawing.Point(15, 123);
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
            // labelPurchase
            // 
            this.labelPurchase.AutoSize = true;
            this.labelPurchase.Location = new System.Drawing.Point(12, 9);
            this.labelPurchase.Name = "labelPurchase";
            this.labelPurchase.Size = new System.Drawing.Size(99, 13);
            this.labelPurchase.TabIndex = 1;
            this.labelPurchase.Text = "Registro de compra";
            // 
            // FormPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.labelPurchase);
            this.Controls.Add(this.panelPurchase);
            this.Name = "FormPurchases";
            this.Text = "Registar Compras";
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
        private System.Windows.Forms.Label labelProvider;
        private System.Windows.Forms.ComboBox comboBoxPresentationName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonInsertPresentation;
        private System.Windows.Forms.TextBox textBoxCostUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID_Presentation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCostUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubtotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonInvoice;
        private System.Windows.Forms.ComboBox comboBoxProviderName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelItemStock;
        private System.Windows.Forms.Button buttonRemoveRecord;
        private System.Windows.Forms.Button buttonCleanRows;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxPaymentMehtod;
        private System.Windows.Forms.Button buttonSearchPresentation;
        private System.Windows.Forms.Button buttonReloadCostUnit;
        private System.Windows.Forms.Button buttonAddClient;
    }
}