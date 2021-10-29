namespace CapaVisual
{
    partial class AgregarVisitanteDesdeCompra
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
            this.btnGuardarDesdeCompra = new System.Windows.Forms.Button();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCedulaDesdeCompra = new System.Windows.Forms.TextBox();
            this.txtNombreDesdeCompra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuardarDesdeCompra
            // 
            this.btnGuardarDesdeCompra.Location = new System.Drawing.Point(53, 92);
            this.btnGuardarDesdeCompra.Name = "btnGuardarDesdeCompra";
            this.btnGuardarDesdeCompra.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarDesdeCompra.TabIndex = 0;
            this.btnGuardarDesdeCompra.Text = "Guardar";
            this.btnGuardarDesdeCompra.UseVisualStyleBackColor = true;
            this.btnGuardarDesdeCompra.Click += new System.EventHandler(this.btnGuardarDesdeCompra_Click);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(8, 27);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(43, 13);
            this.lblCedula.TabIndex = 1;
            this.lblCedula.Text = "Cedula:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(8, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtCedulaDesdeCompra
            // 
            this.txtCedulaDesdeCompra.Location = new System.Drawing.Point(53, 24);
            this.txtCedulaDesdeCompra.Name = "txtCedulaDesdeCompra";
            this.txtCedulaDesdeCompra.Size = new System.Drawing.Size(100, 20);
            this.txtCedulaDesdeCompra.TabIndex = 3;
            // 
            // txtNombreDesdeCompra
            // 
            this.txtNombreDesdeCompra.Location = new System.Drawing.Point(53, 59);
            this.txtNombreDesdeCompra.Name = "txtNombreDesdeCompra";
            this.txtNombreDesdeCompra.Size = new System.Drawing.Size(100, 20);
            this.txtNombreDesdeCompra.TabIndex = 4;
            // 
            // AgregarVisitanteDesdeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 127);
            this.Controls.Add(this.txtNombreDesdeCompra);
            this.Controls.Add(this.txtCedulaDesdeCompra);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.btnGuardarDesdeCompra);
            this.Name = "AgregarVisitanteDesdeCompra";
            this.Text = "AgregarVisitanteDesdeCompra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarDesdeCompra;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCedulaDesdeCompra;
        private System.Windows.Forms.TextBox txtNombreDesdeCompra;
    }
}