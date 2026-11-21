namespace Salam_Database.Forms
{
    partial class FormAddClients
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
            this.panelAddClient = new System.Windows.Forms.Panel();
            this.labelClientInfo = new System.Windows.Forms.Label();
            this.comboBoxClientType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.textBoxClientEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxClientAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxClientNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.labelClientName = new System.Windows.Forms.Label();
            this.panelAddClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddClient
            // 
            this.panelAddClient.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelAddClient.Controls.Add(this.labelClientInfo);
            this.panelAddClient.Controls.Add(this.comboBoxClientType);
            this.panelAddClient.Controls.Add(this.label6);
            this.panelAddClient.Controls.Add(this.buttonAddClient);
            this.panelAddClient.Controls.Add(this.textBoxClientEmail);
            this.panelAddClient.Controls.Add(this.label1);
            this.panelAddClient.Controls.Add(this.textBoxClientAddress);
            this.panelAddClient.Controls.Add(this.label3);
            this.panelAddClient.Controls.Add(this.textBoxClientNumber);
            this.panelAddClient.Controls.Add(this.label4);
            this.panelAddClient.Controls.Add(this.textBoxClientID);
            this.panelAddClient.Controls.Add(this.label5);
            this.panelAddClient.Controls.Add(this.textBoxClientName);
            this.panelAddClient.Controls.Add(this.labelClientName);
            this.panelAddClient.Location = new System.Drawing.Point(12, 12);
            this.panelAddClient.Name = "panelAddClient";
            this.panelAddClient.Size = new System.Drawing.Size(386, 293);
            this.panelAddClient.TabIndex = 14;
            // 
            // labelClientInfo
            // 
            this.labelClientInfo.AutoSize = true;
            this.labelClientInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelClientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientInfo.Location = new System.Drawing.Point(15, 265);
            this.labelClientInfo.Name = "labelClientInfo";
            this.labelClientInfo.Size = new System.Drawing.Size(16, 16);
            this.labelClientInfo.TabIndex = 15;
            this.labelClientInfo.Text = "...";
            // 
            // comboBoxClientType
            // 
            this.comboBoxClientType.FormattingEnabled = true;
            this.comboBoxClientType.Items.AddRange(new object[] {
            "CONSUMIDOR_FINAL",
            "NEGOCIO",
            "RESTAURANTE",
            "REVENDEDOR"});
            this.comboBoxClientType.Location = new System.Drawing.Point(18, 89);
            this.comboBoxClientType.Name = "comboBoxClientType";
            this.comboBoxClientType.Size = new System.Drawing.Size(195, 21);
            this.comboBoxClientType.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tipo de cliente";
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(303, 258);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(69, 23);
            this.buttonAddClient.TabIndex = 12;
            this.buttonAddClient.Text = "Agregar";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // textBoxClientEmail
            // 
            this.textBoxClientEmail.Location = new System.Drawing.Point(18, 179);
            this.textBoxClientEmail.Name = "textBoxClientEmail";
            this.textBoxClientEmail.Size = new System.Drawing.Size(192, 20);
            this.textBoxClientEmail.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Email";
            // 
            // textBoxClientAddress
            // 
            this.textBoxClientAddress.Location = new System.Drawing.Point(18, 139);
            this.textBoxClientAddress.Name = "textBoxClientAddress";
            this.textBoxClientAddress.Size = new System.Drawing.Size(195, 20);
            this.textBoxClientAddress.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Direccion";
            // 
            // textBoxClientNumber
            // 
            this.textBoxClientNumber.Location = new System.Drawing.Point(233, 90);
            this.textBoxClientNumber.Name = "textBoxClientNumber";
            this.textBoxClientNumber.Size = new System.Drawing.Size(115, 20);
            this.textBoxClientNumber.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numero de telefono";
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Location = new System.Drawing.Point(233, 39);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(115, 20);
            this.textBoxClientID.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Documento";
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(18, 39);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(192, 20);
            this.textBoxClientName.TabIndex = 1;
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Location = new System.Drawing.Point(15, 22);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(78, 13);
            this.labelClientName.TabIndex = 0;
            this.labelClientName.Text = "Nombre cliente";
            // 
            // FormAddClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 319);
            this.Controls.Add(this.panelAddClient);
            this.Name = "FormAddClients";
            this.Text = "Agregar clientes";
            this.panelAddClient.ResumeLayout(false);
            this.panelAddClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddClient;
        private System.Windows.Forms.Label labelClientInfo;
        private System.Windows.Forms.ComboBox comboBoxClientType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.TextBox textBoxClientEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxClientAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxClientNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.Label labelClientName;
    }
}