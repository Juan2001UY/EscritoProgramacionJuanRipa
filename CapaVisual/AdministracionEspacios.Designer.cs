namespace CapaVisual
{
    partial class AdministracionEspacios
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
            this.btnGuardarEspacio = new System.Windows.Forms.Button();
            this.btnEliminarEspacio = new System.Windows.Forms.Button();
            this.btnModificarEspacio = new System.Windows.Forms.Button();
            this.btnListarEspacio = new System.Windows.Forms.Button();
            this.dgvEspacio = new System.Windows.Forms.DataGridView();
            this.lblNombreEspacio = new System.Windows.Forms.Label();
            this.lblDescripcionEspacio = new System.Windows.Forms.Label();
            this.lblIdEspacio = new System.Windows.Forms.Label();
            this.txtNombreEspacio = new System.Windows.Forms.TextBox();
            this.txtIdEspacio = new System.Windows.Forms.TextBox();
            this.txtDescripcionEspacio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspacio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarEspacio
            // 
            this.btnGuardarEspacio.Location = new System.Drawing.Point(15, 113);
            this.btnGuardarEspacio.Name = "btnGuardarEspacio";
            this.btnGuardarEspacio.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarEspacio.TabIndex = 0;
            this.btnGuardarEspacio.Text = "Guardar";
            this.btnGuardarEspacio.UseVisualStyleBackColor = true;
            this.btnGuardarEspacio.Click += new System.EventHandler(this.btnGuardarEspacio_Click);
            // 
            // btnEliminarEspacio
            // 
            this.btnEliminarEspacio.Location = new System.Drawing.Point(108, 113);
            this.btnEliminarEspacio.Name = "btnEliminarEspacio";
            this.btnEliminarEspacio.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarEspacio.TabIndex = 1;
            this.btnEliminarEspacio.Text = "Eliminar";
            this.btnEliminarEspacio.UseVisualStyleBackColor = true;
            this.btnEliminarEspacio.Click += new System.EventHandler(this.btnEliminarEspacio_Click);
            // 
            // btnModificarEspacio
            // 
            this.btnModificarEspacio.Location = new System.Drawing.Point(15, 142);
            this.btnModificarEspacio.Name = "btnModificarEspacio";
            this.btnModificarEspacio.Size = new System.Drawing.Size(75, 23);
            this.btnModificarEspacio.TabIndex = 2;
            this.btnModificarEspacio.Text = "Modificar";
            this.btnModificarEspacio.UseVisualStyleBackColor = true;
            this.btnModificarEspacio.Click += new System.EventHandler(this.btnModificarEspacio_Click);
            // 
            // btnListarEspacio
            // 
            this.btnListarEspacio.Location = new System.Drawing.Point(108, 142);
            this.btnListarEspacio.Name = "btnListarEspacio";
            this.btnListarEspacio.Size = new System.Drawing.Size(75, 23);
            this.btnListarEspacio.TabIndex = 3;
            this.btnListarEspacio.Text = "Listar";
            this.btnListarEspacio.UseVisualStyleBackColor = true;
            this.btnListarEspacio.Click += new System.EventHandler(this.btnListarEspacio_Click);
            // 
            // dgvEspacio
            // 
            this.dgvEspacio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspacio.Location = new System.Drawing.Point(336, 12);
            this.dgvEspacio.Name = "dgvEspacio";
            this.dgvEspacio.Size = new System.Drawing.Size(240, 150);
            this.dgvEspacio.TabIndex = 4;
            // 
            // lblNombreEspacio
            // 
            this.lblNombreEspacio.AutoSize = true;
            this.lblNombreEspacio.Location = new System.Drawing.Point(12, 18);
            this.lblNombreEspacio.Name = "lblNombreEspacio";
            this.lblNombreEspacio.Size = new System.Drawing.Size(105, 13);
            this.lblNombreEspacio.TabIndex = 5;
            this.lblNombreEspacio.Text = "Nombre del Espacio:";
            // 
            // lblDescripcionEspacio
            // 
            this.lblDescripcionEspacio.AutoSize = true;
            this.lblDescripcionEspacio.Location = new System.Drawing.Point(12, 48);
            this.lblDescripcionEspacio.Name = "lblDescripcionEspacio";
            this.lblDescripcionEspacio.Size = new System.Drawing.Size(124, 13);
            this.lblDescripcionEspacio.TabIndex = 6;
            this.lblDescripcionEspacio.Text = "Descripción del Espacio:";
            // 
            // lblIdEspacio
            // 
            this.lblIdEspacio.AutoSize = true;
            this.lblIdEspacio.Location = new System.Drawing.Point(12, 76);
            this.lblIdEspacio.Name = "lblIdEspacio";
            this.lblIdEspacio.Size = new System.Drawing.Size(214, 13);
            this.lblIdEspacio.TabIndex = 7;
            this.lblIdEspacio.Text = "Id del Espacio (solo para modificar/eliminar):";
            // 
            // txtNombreEspacio
            // 
            this.txtNombreEspacio.Location = new System.Drawing.Point(119, 15);
            this.txtNombreEspacio.Name = "txtNombreEspacio";
            this.txtNombreEspacio.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEspacio.TabIndex = 8;
            // 
            // txtIdEspacio
            // 
            this.txtIdEspacio.Location = new System.Drawing.Point(226, 75);
            this.txtIdEspacio.Name = "txtIdEspacio";
            this.txtIdEspacio.Size = new System.Drawing.Size(100, 20);
            this.txtIdEspacio.TabIndex = 9;
            // 
            // txtDescripcionEspacio
            // 
            this.txtDescripcionEspacio.Location = new System.Drawing.Point(137, 45);
            this.txtDescripcionEspacio.Name = "txtDescripcionEspacio";
            this.txtDescripcionEspacio.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionEspacio.TabIndex = 10;
            // 
            // AdministracionEspacios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 192);
            this.Controls.Add(this.txtDescripcionEspacio);
            this.Controls.Add(this.txtIdEspacio);
            this.Controls.Add(this.txtNombreEspacio);
            this.Controls.Add(this.lblIdEspacio);
            this.Controls.Add(this.lblDescripcionEspacio);
            this.Controls.Add(this.lblNombreEspacio);
            this.Controls.Add(this.dgvEspacio);
            this.Controls.Add(this.btnListarEspacio);
            this.Controls.Add(this.btnModificarEspacio);
            this.Controls.Add(this.btnEliminarEspacio);
            this.Controls.Add(this.btnGuardarEspacio);
            this.Name = "AdministracionEspacios";
            this.Text = "AdministracionEspacios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspacio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarEspacio;
        private System.Windows.Forms.Button btnEliminarEspacio;
        private System.Windows.Forms.Button btnModificarEspacio;
        private System.Windows.Forms.Button btnListarEspacio;
        private System.Windows.Forms.DataGridView dgvEspacio;
        private System.Windows.Forms.Label lblNombreEspacio;
        private System.Windows.Forms.Label lblDescripcionEspacio;
        private System.Windows.Forms.Label lblIdEspacio;
        private System.Windows.Forms.TextBox txtNombreEspacio;
        private System.Windows.Forms.TextBox txtIdEspacio;
        private System.Windows.Forms.TextBox txtDescripcionEspacio;
    }
}