namespace Vista
{
    partial class ClienteForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.CodigoCliTextBox = new System.Windows.Forms.TextBox();
            this.NombreCliTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DomicilioTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CorreoClieTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TelefonoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.NevoButton = new System.Windows.Forms.Button();
            this.ClientesDataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // CodigoCliTextBox
            // 
            this.CodigoCliTextBox.Location = new System.Drawing.Point(112, 57);
            this.CodigoCliTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CodigoCliTextBox.Name = "CodigoCliTextBox";
            this.CodigoCliTextBox.Size = new System.Drawing.Size(307, 24);
            this.CodigoCliTextBox.TabIndex = 1;
            // 
            // NombreCliTextBox
            // 
            this.NombreCliTextBox.Location = new System.Drawing.Point(112, 100);
            this.NombreCliTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NombreCliTextBox.Name = "NombreCliTextBox";
            this.NombreCliTextBox.Size = new System.Drawing.Size(307, 24);
            this.NombreCliTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // DomicilioTextBox
            // 
            this.DomicilioTextBox.Location = new System.Drawing.Point(112, 143);
            this.DomicilioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DomicilioTextBox.Name = "DomicilioTextBox";
            this.DomicilioTextBox.Size = new System.Drawing.Size(307, 24);
            this.DomicilioTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Domicilio:";
            // 
            // CorreoClieTextBox
            // 
            this.CorreoClieTextBox.Location = new System.Drawing.Point(112, 186);
            this.CorreoClieTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CorreoClieTextBox.Name = "CorreoClieTextBox";
            this.CorreoClieTextBox.Size = new System.Drawing.Size(307, 24);
            this.CorreoClieTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correo:";
            // 
            // TelefonoTextBox
            // 
            this.TelefonoTextBox.Location = new System.Drawing.Point(112, 218);
            this.TelefonoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TelefonoTextBox.Name = "TelefonoTextBox";
            this.TelefonoTextBox.Size = new System.Drawing.Size(307, 24);
            this.TelefonoTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefono:";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Image = global::Vista.Properties.Resources.cancelar;
            this.CancelarButton.Location = new System.Drawing.Point(348, 265);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(71, 38);
            this.CancelarButton.TabIndex = 23;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Enabled = false;
            this.EliminarButton.Image = global::Vista.Properties.Resources.eliminar;
            this.EliminarButton.Location = new System.Drawing.Point(271, 265);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(71, 39);
            this.EliminarButton.TabIndex = 22;
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Enabled = false;
            this.GuardarButton.Image = global::Vista.Properties.Resources.disco_flexible;
            this.GuardarButton.Location = new System.Drawing.Point(194, 265);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(71, 39);
            this.GuardarButton.TabIndex = 21;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Enabled = false;
            this.ModificarButton.Image = global::Vista.Properties.Resources.editar;
            this.ModificarButton.Location = new System.Drawing.Point(107, 265);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(71, 39);
            this.ModificarButton.TabIndex = 20;
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // NevoButton
            // 
            this.NevoButton.Image = global::Vista.Properties.Resources.agregar_archivo;
            this.NevoButton.Location = new System.Drawing.Point(20, 264);
            this.NevoButton.Name = "NevoButton";
            this.NevoButton.Size = new System.Drawing.Size(71, 39);
            this.NevoButton.TabIndex = 19;
            this.NevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NevoButton.UseVisualStyleBackColor = true;
            this.NevoButton.Click += new System.EventHandler(this.NevoButton_Click);
            // 
            // ClientesDataGridView
            // 
            this.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDataGridView.Location = new System.Drawing.Point(0, 368);
            this.ClientesDataGridView.Name = "ClientesDataGridView";
            this.ClientesDataGridView.Size = new System.Drawing.Size(483, 168);
            this.ClientesDataGridView.TabIndex = 24;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 535);
            this.Controls.Add(this.ClientesDataGridView);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.NevoButton);
            this.Controls.Add(this.TelefonoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CorreoClieTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DomicilioTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreCliTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodigoCliTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Small Semibold", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClienteForm";
            this.Text = "ClienteForm";
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodigoCliTextBox;
        private System.Windows.Forms.TextBox NombreCliTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DomicilioTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CorreoClieTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TelefonoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button NevoButton;
        private System.Windows.Forms.DataGridView ClientesDataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}