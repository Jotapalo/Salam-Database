namespace Salam_Database.Forms
{
    partial class FormMainView
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
            this.panelRegister = new System.Windows.Forms.Panel();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.buttonAddPresentation = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonAddBrand = new System.Windows.Forms.Button();
            this.buttonAddProvider = new System.Windows.Forms.Button();
            this.buttonAddClients = new System.Windows.Forms.Button();
            this.buttonRegisterPurchases = new System.Windows.Forms.Button();
            this.buttonRegisterSells = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelInformation = new System.Windows.Forms.Panel();
            this.labelUserRole = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panelShowLog = new System.Windows.Forms.Panel();
            this.buttonUpdateRecentMovements = new System.Windows.Forms.Button();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnitValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewRecentMovements = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.panelView = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddSubcategory = new System.Windows.Forms.Button();
            this.buttonAddInventory = new System.Windows.Forms.Button();
            this.panelRegister.SuspendLayout();
            this.panelInformation.SuspendLayout();
            this.panelShowLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecentMovements)).BeginInit();
            this.panelView.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRegister
            // 
            this.panelRegister.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelRegister.Controls.Add(this.buttonAddInventory);
            this.panelRegister.Controls.Add(this.buttonAddSubcategory);
            this.panelRegister.Controls.Add(this.buttonAddCategory);
            this.panelRegister.Controls.Add(this.buttonAddPresentation);
            this.panelRegister.Controls.Add(this.buttonAddProduct);
            this.panelRegister.Controls.Add(this.buttonAddBrand);
            this.panelRegister.Controls.Add(this.buttonAddProvider);
            this.panelRegister.Controls.Add(this.buttonAddClients);
            this.panelRegister.Controls.Add(this.buttonRegisterPurchases);
            this.panelRegister.Controls.Add(this.buttonRegisterSells);
            this.panelRegister.Controls.Add(this.label1);
            this.panelRegister.Location = new System.Drawing.Point(12, 12);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(666, 79);
            this.panelRegister.TabIndex = 0;
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(573, 13);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(78, 23);
            this.buttonAddCategory.TabIndex = 9;
            this.buttonAddCategory.Text = "Categoria";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // buttonAddPresentation
            // 
            this.buttonAddPresentation.Location = new System.Drawing.Point(489, 13);
            this.buttonAddPresentation.Name = "buttonAddPresentation";
            this.buttonAddPresentation.Size = new System.Drawing.Size(78, 23);
            this.buttonAddPresentation.TabIndex = 8;
            this.buttonAddPresentation.Text = "Presentacion";
            this.buttonAddPresentation.UseVisualStyleBackColor = true;
            this.buttonAddPresentation.Click += new System.EventHandler(this.buttonAddPresentation_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(408, 13);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonAddProduct.TabIndex = 7;
            this.buttonAddProduct.Text = "Producto";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonAddBrand
            // 
            this.buttonAddBrand.Location = new System.Drawing.Point(327, 13);
            this.buttonAddBrand.Name = "buttonAddBrand";
            this.buttonAddBrand.Size = new System.Drawing.Size(75, 23);
            this.buttonAddBrand.TabIndex = 6;
            this.buttonAddBrand.Text = "Marcas";
            this.buttonAddBrand.UseVisualStyleBackColor = true;
            this.buttonAddBrand.Click += new System.EventHandler(this.buttonAddBrand_Click);
            // 
            // buttonAddProvider
            // 
            this.buttonAddProvider.Location = new System.Drawing.Point(246, 13);
            this.buttonAddProvider.Name = "buttonAddProvider";
            this.buttonAddProvider.Size = new System.Drawing.Size(75, 23);
            this.buttonAddProvider.TabIndex = 5;
            this.buttonAddProvider.Text = "Proveedores";
            this.buttonAddProvider.UseVisualStyleBackColor = true;
            this.buttonAddProvider.Click += new System.EventHandler(this.buttonAddProvider_Click);
            // 
            // buttonAddClients
            // 
            this.buttonAddClients.Location = new System.Drawing.Point(165, 13);
            this.buttonAddClients.Name = "buttonAddClients";
            this.buttonAddClients.Size = new System.Drawing.Size(75, 23);
            this.buttonAddClients.TabIndex = 4;
            this.buttonAddClients.Text = "Clientes";
            this.buttonAddClients.UseVisualStyleBackColor = true;
            this.buttonAddClients.Click += new System.EventHandler(this.buttonAddClients_Click);
            // 
            // buttonRegisterPurchases
            // 
            this.buttonRegisterPurchases.Location = new System.Drawing.Point(84, 13);
            this.buttonRegisterPurchases.Name = "buttonRegisterPurchases";
            this.buttonRegisterPurchases.Size = new System.Drawing.Size(75, 23);
            this.buttonRegisterPurchases.TabIndex = 3;
            this.buttonRegisterPurchases.Text = "Compras";
            this.buttonRegisterPurchases.UseVisualStyleBackColor = true;
            this.buttonRegisterPurchases.Click += new System.EventHandler(this.buttonRegisterPurchases_Click);
            // 
            // buttonRegisterSells
            // 
            this.buttonRegisterSells.Location = new System.Drawing.Point(3, 13);
            this.buttonRegisterSells.Name = "buttonRegisterSells";
            this.buttonRegisterSells.Size = new System.Drawing.Size(75, 23);
            this.buttonRegisterSells.TabIndex = 2;
            this.buttonRegisterSells.Text = "Ventas";
            this.buttonRegisterSells.UseVisualStyleBackColor = true;
            this.buttonRegisterSells.Click += new System.EventHandler(this.buttonRegisterSells_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ventanas registro";
            // 
            // panelInformation
            // 
            this.panelInformation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelInformation.Controls.Add(this.labelUserRole);
            this.panelInformation.Controls.Add(this.button10);
            this.panelInformation.Controls.Add(this.button9);
            this.panelInformation.Controls.Add(this.labelUserName);
            this.panelInformation.Location = new System.Drawing.Point(684, 12);
            this.panelInformation.Name = "panelInformation";
            this.panelInformation.Size = new System.Drawing.Size(433, 132);
            this.panelInformation.TabIndex = 0;
            // 
            // labelUserRole
            // 
            this.labelUserRole.AutoSize = true;
            this.labelUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserRole.Location = new System.Drawing.Point(3, 26);
            this.labelUserRole.Name = "labelUserRole";
            this.labelUserRole.Size = new System.Drawing.Size(95, 13);
            this.labelUserRole.TabIndex = 12;
            this.labelUserRole.Text = "ROL_USUARIO";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 42);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(96, 23);
            this.button10.TabIndex = 11;
            this.button10.Text = "Agregar Usuario";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 69);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(96, 23);
            this.button9.TabIndex = 10;
            this.button9.Text = "Configuracion";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(3, 13);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(123, 13);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "NOMBRE_USUARIO";
            // 
            // panelShowLog
            // 
            this.panelShowLog.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelShowLog.Controls.Add(this.buttonUpdateRecentMovements);
            this.panelShowLog.Controls.Add(this.dataGridViewDetails);
            this.panelShowLog.Controls.Add(this.label4);
            this.panelShowLog.Controls.Add(this.dataGridViewRecentMovements);
            this.panelShowLog.Location = new System.Drawing.Point(12, 150);
            this.panelShowLog.Name = "panelShowLog";
            this.panelShowLog.Size = new System.Drawing.Size(1105, 446);
            this.panelShowLog.TabIndex = 1;
            // 
            // buttonUpdateRecentMovements
            // 
            this.buttonUpdateRecentMovements.AutoSize = true;
            this.buttonUpdateRecentMovements.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateRecentMovements.Location = new System.Drawing.Point(276, 15);
            this.buttonUpdateRecentMovements.Name = "buttonUpdateRecentMovements";
            this.buttonUpdateRecentMovements.Size = new System.Drawing.Size(26, 23);
            this.buttonUpdateRecentMovements.TabIndex = 27;
            this.buttonUpdateRecentMovements.Text = "↻";
            this.buttonUpdateRecentMovements.UseVisualStyleBackColor = true;
            this.buttonUpdateRecentMovements.Click += new System.EventHandler(this.buttonUpdateRecentMovements_Click);
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.AllowUserToAddRows = false;
            this.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnQuantity,
            this.ColumnUnitValue,
            this.ColumnSubtotal});
            this.dataGridViewDetails.Location = new System.Drawing.Point(589, 41);
            this.dataGridViewDetails.Name = "dataGridViewDetails";
            this.dataGridViewDetails.Size = new System.Drawing.Size(513, 426);
            this.dataGridViewDetails.TabIndex = 2;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "nombre";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.HeaderText = "cantidad";
            this.ColumnQuantity.Name = "ColumnQuantity";
            // 
            // ColumnUnitValue
            // 
            this.ColumnUnitValue.HeaderText = "precio unitario";
            this.ColumnUnitValue.Name = "ColumnUnitValue";
            // 
            // ColumnSubtotal
            // 
            this.ColumnSubtotal.HeaderText = "subtotal";
            this.ColumnSubtotal.Name = "ColumnSubtotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Compras y ventas recientes";
            // 
            // dataGridViewRecentMovements
            // 
            this.dataGridViewRecentMovements.AllowUserToAddRows = false;
            this.dataGridViewRecentMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecentMovements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnPerson,
            this.ColumnDate,
            this.ColumnType,
            this.ColumnTotal});
            this.dataGridViewRecentMovements.Location = new System.Drawing.Point(7, 41);
            this.dataGridViewRecentMovements.Name = "dataGridViewRecentMovements";
            this.dataGridViewRecentMovements.Size = new System.Drawing.Size(560, 426);
            this.dataGridViewRecentMovements.TabIndex = 0;
            this.dataGridViewRecentMovements.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecentMovements_CellClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 50;
            // 
            // ColumnPerson
            // 
            this.ColumnPerson.HeaderText = "persona";
            this.ColumnPerson.Name = "ColumnPerson";
            this.ColumnPerson.ReadOnly = true;
            this.ColumnPerson.Width = 140;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "fecha";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            this.ColumnDate.Width = 150;
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "tipo";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            this.ColumnType.Width = 80;
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.HeaderText = "total";
            this.ColumnTotal.Name = "ColumnTotal";
            this.ColumnTotal.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(687, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Informacion";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(84, 13);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(105, 23);
            this.button11.TabIndex = 2;
            this.button11.Text = "Estadisticas";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelView.Controls.Add(this.button15);
            this.panelView.Controls.Add(this.button14);
            this.panelView.Controls.Add(this.button13);
            this.panelView.Controls.Add(this.button11);
            this.panelView.Controls.Add(this.button12);
            this.panelView.Controls.Add(this.label5);
            this.panelView.Location = new System.Drawing.Point(12, 97);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(666, 47);
            this.panelView.TabIndex = 2;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(382, 13);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(90, 23);
            this.button15.TabIndex = 5;
            this.button15.Text = "Presentaciones";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(290, 13);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(86, 23);
            this.button14.TabIndex = 4;
            this.button14.Text = "Personas";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(195, 13);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(86, 23);
            this.button13.TabIndex = 3;
            this.button13.Text = "Movimientos";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(3, 13);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 1;
            this.button12.Text = "Inventario";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, -3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Visualizacion";
            // 
            // buttonAddSubcategory
            // 
            this.buttonAddSubcategory.Location = new System.Drawing.Point(3, 42);
            this.buttonAddSubcategory.Name = "buttonAddSubcategory";
            this.buttonAddSubcategory.Size = new System.Drawing.Size(78, 23);
            this.buttonAddSubcategory.TabIndex = 10;
            this.buttonAddSubcategory.Text = "Subcategoria";
            this.buttonAddSubcategory.UseVisualStyleBackColor = true;
            this.buttonAddSubcategory.Click += new System.EventHandler(this.buttonAddSubcategory_Click);
            // 
            // buttonAddInventory
            // 
            this.buttonAddInventory.Location = new System.Drawing.Point(87, 42);
            this.buttonAddInventory.Name = "buttonAddInventory";
            this.buttonAddInventory.Size = new System.Drawing.Size(78, 23);
            this.buttonAddInventory.TabIndex = 11;
            this.buttonAddInventory.Text = "Inventario";
            this.buttonAddInventory.UseVisualStyleBackColor = true;
            // 
            // FormMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 608);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelShowLog);
            this.Controls.Add(this.panelInformation);
            this.Controls.Add(this.panelRegister);
            this.Name = "FormMainView";
            this.Text = "Menu principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMainView_FormClosed);
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.panelInformation.ResumeLayout(false);
            this.panelInformation.PerformLayout();
            this.panelShowLog.ResumeLayout(false);
            this.panelShowLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecentMovements)).EndInit();
            this.panelView.ResumeLayout(false);
            this.panelView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Panel panelInformation;
        private System.Windows.Forms.Panel panelShowLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRegisterSells;
        private System.Windows.Forms.Button buttonRegisterPurchases;
        private System.Windows.Forms.Button buttonAddBrand;
        private System.Windows.Forms.Button buttonAddProvider;
        private System.Windows.Forms.Button buttonAddClients;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Button buttonAddPresentation;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelUserRole;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewRecentMovements;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.DataGridView dataGridViewDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnitValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubtotal;
        private System.Windows.Forms.Button buttonUpdateRecentMovements;
        private System.Windows.Forms.Button buttonAddSubcategory;
        private System.Windows.Forms.Button buttonAddInventory;
    }
}