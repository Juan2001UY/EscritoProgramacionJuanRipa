namespace CapaVisual
{
    partial class AdministracionVisitantes
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
            this.btnGuardarVisitantes = new System.Windows.Forms.Button();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnModificarVisitantes = new System.Windows.Forms.Button();
            this.btnEliminarVisitantes = new System.Windows.Forms.Button();
            this.btnListarVisitantes = new System.Windows.Forms.Button();
            this.dgvVisitantes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitantes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarVisitantes
            // 
            this.btnGuardarVisitantes.Location = new System.Drawing.Point(15, 89);
            this.btnGuardarVisitantes.Name = "btnGuardarVisitantes";
            this.btnGuardarVisitantes.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarVisitantes.TabIndex = 0;
            this.btnGuardarVisitantes.Text = "Guardar";
            this.btnGuardarVisitantes.UseVisualStyleBackColor = true;
            this.btnGuardarVisitantes.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(12, 24);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(80, 13);
            this.lblCedula.TabIndex = 1;
            this.lblCedula.Text = "Cedula (Sin \"-\")";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(58, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(100, 21);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 4;
            // 
            // btnModificarVisitantes
            // 
            this.btnModificarVisitantes.Location = new System.Drawing.Point(125, 88);
            this.btnModificarVisitantes.Name = "btnModificarVisitantes";
            this.btnModificarVisitantes.Size = new System.Drawing.Size(75, 23);
            this.btnModificarVisitantes.TabIndex = 5;
            this.btnModificarVisitantes.Text = "Modificar";
            this.btnModificarVisitantes.UseVisualStyleBackColor = true;
            this.btnModificarVisitantes.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarVisitantes
            // 
            this.btnEliminarVisitantes.Location = new System.Drawing.Point(15, 131);
            this.btnEliminarVisitantes.Name = "btnEliminarVisitantes";
            this.btnEliminarVisitantes.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarVisitantes.TabIndex = 6;
            this.btnEliminarVisitantes.Text = "Eliminar";
            this.btnEliminarVisitantes.UseVisualStyleBackColor = true;
            this.btnEliminarVisitantes.Click += new System.EventHandler(this.btnEliminarVisitantes_Click);
            // 
            // btnListarVisitantes
            // 
            this.btnListarVisitantes.Location = new System.Drawing.Point(125, 130);
            this.btnListarVisitantes.Name = "btnListarVisitantes";
            this.btnListarVisitantes.Size = new System.Drawing.Size(75, 23);
            this.btnListarVisitantes.TabIndex = 8;
            this.btnListarVisitantes.Text = "Listar";
            this.btnListarVisitantes.UseVisualStyleBackColor = true;
            this.btnListarVisitantes.Click += new System.EventHandler(this.btnListarVisitantes_Click);
            // 
            // dgvVisitantes
            // 
            this.dgvVisitantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitantes.Location = new System.Drawing.Point(232, 24);
            this.dgvVisitantes.Name = "dgvVisitantes";
            this.dgvVisitantes.Size = new System.Drawing.Size(271, 184);
            this.dgvVisitantes.TabIndex = 7;
            // 
            // AdministracionVisitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 214);
            this.Controls.Add(this.btnListarVisitantes);
            this.Controls.Add(this.dgvVisitantes);
            this.Controls.Add(this.btnEliminarVisitantes);
            this.Controls.Add(this.btnModificarVisitantes);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.btnGuardarVisitantes);
            this.Name = "AdministracionVisitantes";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarVisitantes;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btnModificarVisitantes;
        private System.Windows.Forms.Button btnEliminarVisitantes;
        private System.Windows.Forms.Button btnListarVisitantes;
        private System.Windows.Forms.DataGridView dgvVisitantes;
    }
}

