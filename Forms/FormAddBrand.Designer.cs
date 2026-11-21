namespace Salam_Database.Forms
{
    partial class FormAddBrand
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
            this.panelAddBrand = new System.Windows.Forms.Panel();
            this.labelBranInfo = new System.Windows.Forms.Label();
            this.buttonAddBrand = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAddBrand.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddBrand
            // 
            this.panelAddBrand.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelAddBrand.Controls.Add(this.labelBranInfo);
            this.panelAddBrand.Controls.Add(this.buttonAddBrand);
            this.panelAddBrand.Controls.Add(this.textBoxDescription);
            this.panelAddBrand.Controls.Add(this.label2);
            this.panelAddBrand.Controls.Add(this.textBoxName);
            this.panelAddBrand.Controls.Add(this.label1);
            this.panelAddBrand.Location = new System.Drawing.Point(10, 12);
            this.panelAddBrand.Name = "panelAddBrand";
            this.panelAddBrand.Size = new System.Drawing.Size(359, 218);
            this.panelAddBrand.TabIndex = 0;
            // 
            // labelBranInfo
            // 
            this.labelBranInfo.AutoSize = true;
            this.labelBranInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBranInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBranInfo.Location = new System.Drawing.Point(18, 187);
            this.labelBranInfo.Name = "labelBranInfo";
            this.labelBranInfo.Size = new System.Drawing.Size(19, 16);
            this.labelBranInfo.TabIndex = 5;
            this.labelBranInfo.Text = "...";
            // 
            // buttonAddBrand
            // 
            this.buttonAddBrand.Location = new System.Drawing.Point(267, 180);
            this.buttonAddBrand.Name = "buttonAddBrand";
            this.buttonAddBrand.Size = new System.Drawing.Size(75, 23);
            this.buttonAddBrand.TabIndex = 4;
            this.buttonAddBrand.Text = "Agregar";
            this.buttonAddBrand.UseVisualStyleBackColor = true;
            this.buttonAddBrand.Click += new System.EventHandler(this.buttonAddBrand_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(21, 73);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(238, 40);
            this.textBoxDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(21, 27);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(238, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // FormAddBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 248);
            this.Controls.Add(this.panelAddBrand);
            this.Name = "FormAddBrand";
            this.Text = "Agregar marca";
            this.panelAddBrand.ResumeLayout(false);
            this.panelAddBrand.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAddBrand;
        private System.Windows.Forms.Label labelBranInfo;
    }
}