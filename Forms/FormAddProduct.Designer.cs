namespace Salam_Database.Forms
{
    partial class FormAddProduct
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
            this.panelAddProduct = new System.Windows.Forms.Panel();
            this.labelProductInfo = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonAddUnit = new System.Windows.Forms.Button();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.labelUnit = new System.Windows.Forms.Label();
            this.textBoxCapacity = new System.Windows.Forms.TextBox();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.buttonAddBrand = new System.Windows.Forms.Button();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.textBoxMaterial = new System.Windows.Forms.TextBox();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonAddSubcategory = new System.Windows.Forms.Button();
            this.labelSubcategory = new System.Windows.Forms.Label();
            this.comboBoxSubcategory = new System.Windows.Forms.ComboBox();
            this.textBoxCodeReference = new System.Windows.Forms.TextBox();
            this.labelCodeReference = new System.Windows.Forms.Label();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.panelAddProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddProduct
            // 
            this.panelAddProduct.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelAddProduct.Controls.Add(this.labelProductInfo);
            this.panelAddProduct.Controls.Add(this.textBoxDescription);
            this.panelAddProduct.Controls.Add(this.labelDescription);
            this.panelAddProduct.Controls.Add(this.buttonAddItem);
            this.panelAddProduct.Controls.Add(this.buttonAddUnit);
            this.panelAddProduct.Controls.Add(this.comboBoxUnit);
            this.panelAddProduct.Controls.Add(this.labelUnit);
            this.panelAddProduct.Controls.Add(this.textBoxCapacity);
            this.panelAddProduct.Controls.Add(this.labelCapacity);
            this.panelAddProduct.Controls.Add(this.buttonAddBrand);
            this.panelAddProduct.Controls.Add(this.comboBoxBrand);
            this.panelAddProduct.Controls.Add(this.textBoxMaterial);
            this.panelAddProduct.Controls.Add(this.labelMaterial);
            this.panelAddProduct.Controls.Add(this.textBoxColor);
            this.panelAddProduct.Controls.Add(this.labelColor);
            this.panelAddProduct.Controls.Add(this.labelBrand);
            this.panelAddProduct.Controls.Add(this.textBoxName);
            this.panelAddProduct.Controls.Add(this.labelName);
            this.panelAddProduct.Controls.Add(this.buttonAddSubcategory);
            this.panelAddProduct.Controls.Add(this.labelSubcategory);
            this.panelAddProduct.Controls.Add(this.comboBoxSubcategory);
            this.panelAddProduct.Controls.Add(this.textBoxCodeReference);
            this.panelAddProduct.Controls.Add(this.labelCodeReference);
            this.panelAddProduct.Controls.Add(this.buttonAddCategory);
            this.panelAddProduct.Controls.Add(this.labelCategory);
            this.panelAddProduct.Controls.Add(this.comboBoxCategory);
            this.panelAddProduct.Location = new System.Drawing.Point(12, 12);
            this.panelAddProduct.Name = "panelAddProduct";
            this.panelAddProduct.Size = new System.Drawing.Size(479, 351);
            this.panelAddProduct.TabIndex = 1;
            // 
            // labelProductInfo
            // 
            this.labelProductInfo.AutoSize = true;
            this.labelProductInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductInfo.Location = new System.Drawing.Point(17, 323);
            this.labelProductInfo.Name = "labelProductInfo";
            this.labelProductInfo.Size = new System.Drawing.Size(19, 16);
            this.labelProductInfo.TabIndex = 25;
            this.labelProductInfo.Text = "...";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(20, 194);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(430, 62);
            this.textBoxDescription.TabIndex = 14;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(17, 176);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 24;
            this.labelDescription.Text = "Descripcion";
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(371, 318);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(85, 23);
            this.buttonAddItem.TabIndex = 15;
            this.buttonAddItem.Text = "Agregar";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // buttonAddUnit
            // 
            this.buttonAddUnit.Location = new System.Drawing.Point(421, 92);
            this.buttonAddUnit.Name = "buttonAddUnit";
            this.buttonAddUnit.Size = new System.Drawing.Size(29, 23);
            this.buttonAddUnit.TabIndex = 13;
            this.buttonAddUnit.Text = "＋";
            this.buttonAddUnit.UseVisualStyleBackColor = true;
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Location = new System.Drawing.Point(351, 93);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(64, 21);
            this.comboBoxUnit.TabIndex = 12;
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(352, 76);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(52, 13);
            this.labelUnit.TabIndex = 20;
            this.labelUnit.Text = "Unidades";
            // 
            // textBoxCapacity
            // 
            this.textBoxCapacity.Location = new System.Drawing.Point(270, 92);
            this.textBoxCapacity.Name = "textBoxCapacity";
            this.textBoxCapacity.Size = new System.Drawing.Size(73, 20);
            this.textBoxCapacity.TabIndex = 11;
            this.textBoxCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCapacity_KeyPress);
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Location = new System.Drawing.Point(267, 76);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(58, 13);
            this.labelCapacity.TabIndex = 18;
            this.labelCapacity.Text = "Capacidad";
            // 
            // buttonAddBrand
            // 
            this.buttonAddBrand.Location = new System.Drawing.Point(120, 150);
            this.buttonAddBrand.Name = "buttonAddBrand";
            this.buttonAddBrand.Size = new System.Drawing.Size(30, 23);
            this.buttonAddBrand.TabIndex = 8;
            this.buttonAddBrand.Text = "＋";
            this.buttonAddBrand.UseVisualStyleBackColor = true;
            this.buttonAddBrand.Click += new System.EventHandler(this.buttonAddBrand_Click);
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(16, 152);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(98, 21);
            this.comboBoxBrand.TabIndex = 7;
            // 
            // textBoxMaterial
            // 
            this.textBoxMaterial.Location = new System.Drawing.Point(247, 151);
            this.textBoxMaterial.Name = "textBoxMaterial";
            this.textBoxMaterial.Size = new System.Drawing.Size(73, 20);
            this.textBoxMaterial.TabIndex = 10;
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(244, 135);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(44, 13);
            this.labelMaterial.TabIndex = 14;
            this.labelMaterial.Text = "Material";
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(161, 151);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(73, 20);
            this.textBoxColor.TabIndex = 9;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(158, 135);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(31, 13);
            this.labelColor.TabIndex = 12;
            this.labelColor.Text = "Color";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(17, 135);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(37, 13);
            this.labelBrand.TabIndex = 10;
            this.labelBrand.Text = "Marca";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(17, 92);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(247, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(14, 76);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(89, 13);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Nombre producto";
            // 
            // buttonAddSubcategory
            // 
            this.buttonAddSubcategory.Location = new System.Drawing.Point(422, 39);
            this.buttonAddSubcategory.Name = "buttonAddSubcategory";
            this.buttonAddSubcategory.Size = new System.Drawing.Size(30, 23);
            this.buttonAddSubcategory.TabIndex = 5;
            this.buttonAddSubcategory.Text = "＋";
            this.buttonAddSubcategory.UseVisualStyleBackColor = true;
            this.buttonAddSubcategory.Click += new System.EventHandler(this.buttonAddSubcategory_Click);
            // 
            // labelSubcategory
            // 
            this.labelSubcategory.AutoSize = true;
            this.labelSubcategory.Location = new System.Drawing.Point(315, 25);
            this.labelSubcategory.Name = "labelSubcategory";
            this.labelSubcategory.Size = new System.Drawing.Size(70, 13);
            this.labelSubcategory.TabIndex = 6;
            this.labelSubcategory.Text = "Subcategoria";
            // 
            // comboBoxSubcategory
            // 
            this.comboBoxSubcategory.FormattingEnabled = true;
            this.comboBoxSubcategory.Location = new System.Drawing.Point(318, 41);
            this.comboBoxSubcategory.Name = "comboBoxSubcategory";
            this.comboBoxSubcategory.Size = new System.Drawing.Size(101, 21);
            this.comboBoxSubcategory.TabIndex = 4;
            // 
            // textBoxCodeReference
            // 
            this.textBoxCodeReference.Location = new System.Drawing.Point(17, 41);
            this.textBoxCodeReference.Name = "textBoxCodeReference";
            this.textBoxCodeReference.Size = new System.Drawing.Size(130, 20);
            this.textBoxCodeReference.TabIndex = 1;
            // 
            // labelCodeReference
            // 
            this.labelCodeReference.AutoSize = true;
            this.labelCodeReference.Location = new System.Drawing.Point(14, 25);
            this.labelCodeReference.Name = "labelCodeReference";
            this.labelCodeReference.Size = new System.Drawing.Size(40, 13);
            this.labelCodeReference.TabIndex = 3;
            this.labelCodeReference.Text = "Codigo";
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(282, 39);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(30, 23);
            this.buttonAddCategory.TabIndex = 3;
            this.buttonAddCategory.Text = "＋";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(158, 25);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(52, 13);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Text = "Categoria";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(161, 41);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(115, 21);
            this.comboBoxCategory.TabIndex = 2;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 375);
            this.Controls.Add(this.panelAddProduct);
            this.Name = "FormAddProduct";
            this.Text = "Agregar producto";
            this.panelAddProduct.ResumeLayout(false);
            this.panelAddProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddProduct;
        private System.Windows.Forms.Label labelProductInfo;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button buttonAddUnit;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.TextBox textBoxCapacity;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Button buttonAddBrand;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.TextBox textBoxMaterial;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonAddSubcategory;
        private System.Windows.Forms.Label labelSubcategory;
        private System.Windows.Forms.ComboBox comboBoxSubcategory;
        private System.Windows.Forms.TextBox textBoxCodeReference;
        private System.Windows.Forms.Label labelCodeReference;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
    }
}