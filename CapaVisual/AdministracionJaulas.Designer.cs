namespace CapaVisual
{
    partial class AdministracionJaulas
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
            this.dgvJaula = new System.Windows.Forms.DataGridView();
            this.btnAltaJaula = new System.Windows.Forms.Button();
            this.btnBajaJaula = new System.Windows.Forms.Button();
            this.btnModificarJaula = new System.Windows.Forms.Button();
            this.btnListarJaula = new System.Windows.Forms.Button();
            this.lblDescripcionJaula = new System.Windows.Forms.Label();
            this.lblIdJaula = new System.Windows.Forms.Label();
            this.lblIdUbicacion = new System.Windows.Forms.Label();
            this.txtIdJaula = new System.Windows.Forms.TextBox();
            this.txtIdUbicacion = new System.Windows.Forms.TextBox();
            this.txtDescripcionJaula = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJaula)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJaula
            // 
            this.dgvJaula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJaula.Location = new System.Drawing.Point(340, 21);
            this.dgvJaula.Name = "dgvJaula";
            this.dgvJaula.Size = new System.Drawing.Size(240, 150);
            this.dgvJaula.TabIndex = 0;
            // 
            // btnAltaJaula
            // 
            this.btnAltaJaula.Location = new System.Drawing.Point(15, 119);
            this.btnAltaJaula.Name = "btnAltaJaula";
            this.btnAltaJaula.Size = new System.Drawing.Size(75, 23);
            this.btnAltaJaula.TabIndex = 1;
            this.btnAltaJaula.Text = "Guardar";
            this.btnAltaJaula.UseVisualStyleBackColor = true;
            this.btnAltaJaula.Click += new System.EventHandler(this.btnAltaJaula_Click);
            // 
            // btnBajaJaula
            // 
            this.btnBajaJaula.Location = new System.Drawing.Point(96, 119);
            this.btnBajaJaula.Name = "btnBajaJaula";
            this.btnBajaJaula.Size = new System.Drawing.Size(75, 23);
            this.btnBajaJaula.TabIndex = 2;
            this.btnBajaJaula.Text = "Eliminar";
            this.btnBajaJaula.UseVisualStyleBackColor = true;
            this.btnBajaJaula.Click += new System.EventHandler(this.btnBajaJaula_Click);
            // 
            // btnModificarJaula
            // 
            this.btnModificarJaula.Location = new System.Drawing.Point(15, 148);
            this.btnModificarJaula.Name = "btnModificarJaula";
            this.btnModificarJaula.Size = new System.Drawing.Size(75, 23);
            this.btnModificarJaula.TabIndex = 3;
            this.btnModificarJaula.Text = "Modificar";
            this.btnModificarJaula.UseVisualStyleBackColor = true;
            this.btnModificarJaula.Click += new System.EventHandler(this.btnModificarJaula_Click);
            // 
            // btnListarJaula
            // 
            this.btnListarJaula.Location = new System.Drawing.Point(96, 148);
            this.btnListarJaula.Name = "btnListarJaula";
            this.btnListarJaula.Size = new System.Drawing.Size(75, 23);
            this.btnListarJaula.TabIndex = 4;
            this.btnListarJaula.Text = "Listar";
            this.btnListarJaula.UseVisualStyleBackColor = true;
            this.btnListarJaula.Click += new System.EventHandler(this.btnListarJaula_Click);
            // 
            // lblDescripcionJaula
            // 
            this.lblDescripcionJaula.AutoSize = true;
            this.lblDescripcionJaula.Location = new System.Drawing.Point(12, 35);
            this.lblDescripcionJaula.Name = "lblDescripcionJaula";
            this.lblDescripcionJaula.Size = new System.Drawing.Size(120, 13);
            this.lblDescripcionJaula.TabIndex = 5;
            this.lblDescripcionJaula.Text = "Descripcion da la Jaula:";
            // 
            // lblIdJaula
            // 
            this.lblIdJaula.AutoSize = true;
            this.lblIdJaula.Location = new System.Drawing.Point(12, 87);
            this.lblIdJaula.Name = "lblIdJaula";
            this.lblIdJaula.Size = new System.Drawing.Size(73, 13);
            this.lblIdJaula.TabIndex = 6;
            this.lblIdJaula.Text = "Id de la Jaula:";
            // 
            // lblIdUbicacion
            // 
            this.lblIdUbicacion.AutoSize = true;
            this.lblIdUbicacion.Location = new System.Drawing.Point(12, 60);
            this.lblIdUbicacion.Name = "lblIdUbicacion";
            this.lblIdUbicacion.Size = new System.Drawing.Size(206, 13);
            this.lblIdUbicacion.TabIndex = 7;
            this.lblIdUbicacion.Text = "Id del Espacio en el que se ubica la Jaula:";
            // 
            // txtIdJaula
            // 
            this.txtIdJaula.Location = new System.Drawing.Point(91, 84);
            this.txtIdJaula.Name = "txtIdJaula";
            this.txtIdJaula.Size = new System.Drawing.Size(100, 20);
            this.txtIdJaula.TabIndex = 8;
            // 
            // txtIdUbicacion
            // 
            this.txtIdUbicacion.Location = new System.Drawing.Point(224, 57);
            this.txtIdUbicacion.Name = "txtIdUbicacion";
            this.txtIdUbicacion.Size = new System.Drawing.Size(100, 20);
            this.txtIdUbicacion.TabIndex = 9;
            // 
            // txtDescripcionJaula
            // 
            this.txtDescripcionJaula.Location = new System.Drawing.Point(138, 33);
            this.txtDescripcionJaula.Name = "txtDescripcionJaula";
            this.txtDescripcionJaula.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionJaula.TabIndex = 10;
            // 
            // AdministracionJaulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 196);
            this.Controls.Add(this.txtDescripcionJaula);
            this.Controls.Add(this.txtIdUbicacion);
            this.Controls.Add(this.txtIdJaula);
            this.Controls.Add(this.lblIdUbicacion);
            this.Controls.Add(this.lblIdJaula);
            this.Controls.Add(this.lblDescripcionJaula);
            this.Controls.Add(this.btnListarJaula);
            this.Controls.Add(this.btnModificarJaula);
            this.Controls.Add(this.btnBajaJaula);
            this.Controls.Add(this.btnAltaJaula);
            this.Controls.Add(this.dgvJaula);
            this.Name = "AdministracionJaulas";
            this.Text = "AdministracionJaulas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJaula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJaula;
        private System.Windows.Forms.Button btnAltaJaula;
        private System.Windows.Forms.Button btnBajaJaula;
        private System.Windows.Forms.Button btnModificarJaula;
        private System.Windows.Forms.Button btnListarJaula;
        private System.Windows.Forms.Label lblDescripcionJaula;
        private System.Windows.Forms.Label lblIdJaula;
        private System.Windows.Forms.Label lblIdUbicacion;
        private System.Windows.Forms.TextBox txtIdJaula;
        private System.Windows.Forms.TextBox txtIdUbicacion;
        private System.Windows.Forms.TextBox txtDescripcionJaula;
    }
}