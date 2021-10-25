namespace CapaVisual
{
    partial class AdministracionAnimales
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
            this.dgvAnimales = new System.Windows.Forms.DataGridView();
            this.btnGuardarAnimales = new System.Windows.Forms.Button();
            this.btnEliminarAnimales = new System.Windows.Forms.Button();
            this.btnModificarAnimales = new System.Windows.Forms.Button();
            this.btnlistarAnimales = new System.Windows.Forms.Button();
            this.lblNombreAnimal = new System.Windows.Forms.Label();
            this.lblDescripcionAnimal = new System.Windows.Forms.Label();
            this.lblIdJ = new System.Windows.Forms.Label();
            this.lblIdAnimal = new System.Windows.Forms.Label();
            this.txtIdJ = new System.Windows.Forms.TextBox();
            this.txtIdAnimal = new System.Windows.Forms.TextBox();
            this.txtNombreAnimal = new System.Windows.Forms.TextBox();
            this.txtDescripcionAnimal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAnimales
            // 
            this.dgvAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimales.Location = new System.Drawing.Point(313, 12);
            this.dgvAnimales.Name = "dgvAnimales";
            this.dgvAnimales.Size = new System.Drawing.Size(240, 150);
            this.dgvAnimales.TabIndex = 0;
            // 
            // btnGuardarAnimales
            // 
            this.btnGuardarAnimales.Location = new System.Drawing.Point(15, 145);
            this.btnGuardarAnimales.Name = "btnGuardarAnimales";
            this.btnGuardarAnimales.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarAnimales.TabIndex = 1;
            this.btnGuardarAnimales.Text = "Guardar";
            this.btnGuardarAnimales.UseVisualStyleBackColor = true;
            this.btnGuardarAnimales.Click += new System.EventHandler(this.btnGuardarAnimales_Click);
            // 
            // btnEliminarAnimales
            // 
            this.btnEliminarAnimales.Location = new System.Drawing.Point(105, 145);
            this.btnEliminarAnimales.Name = "btnEliminarAnimales";
            this.btnEliminarAnimales.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarAnimales.TabIndex = 2;
            this.btnEliminarAnimales.Text = "Eliminar";
            this.btnEliminarAnimales.UseVisualStyleBackColor = true;
            this.btnEliminarAnimales.Click += new System.EventHandler(this.btnEliminarAnimales_Click);
            // 
            // btnModificarAnimales
            // 
            this.btnModificarAnimales.Location = new System.Drawing.Point(15, 177);
            this.btnModificarAnimales.Name = "btnModificarAnimales";
            this.btnModificarAnimales.Size = new System.Drawing.Size(75, 23);
            this.btnModificarAnimales.TabIndex = 3;
            this.btnModificarAnimales.Text = "Modificar";
            this.btnModificarAnimales.UseVisualStyleBackColor = true;
            this.btnModificarAnimales.Click += new System.EventHandler(this.btnModificarAnimales_Click);
            // 
            // btnlistarAnimales
            // 
            this.btnlistarAnimales.Location = new System.Drawing.Point(105, 177);
            this.btnlistarAnimales.Name = "btnlistarAnimales";
            this.btnlistarAnimales.Size = new System.Drawing.Size(75, 23);
            this.btnlistarAnimales.TabIndex = 4;
            this.btnlistarAnimales.Text = "Listar";
            this.btnlistarAnimales.UseVisualStyleBackColor = true;
            // 
            // lblNombreAnimal
            // 
            this.lblNombreAnimal.AutoSize = true;
            this.lblNombreAnimal.Location = new System.Drawing.Point(12, 21);
            this.lblNombreAnimal.Name = "lblNombreAnimal";
            this.lblNombreAnimal.Size = new System.Drawing.Size(98, 13);
            this.lblNombreAnimal.TabIndex = 5;
            this.lblNombreAnimal.Text = "Nombre del Animal:";
            // 
            // lblDescripcionAnimal
            // 
            this.lblDescripcionAnimal.AutoSize = true;
            this.lblDescripcionAnimal.Location = new System.Drawing.Point(12, 50);
            this.lblDescripcionAnimal.Name = "lblDescripcionAnimal";
            this.lblDescripcionAnimal.Size = new System.Drawing.Size(117, 13);
            this.lblDescripcionAnimal.TabIndex = 6;
            this.lblDescripcionAnimal.Text = "Descripción del Animal:";
            // 
            // lblIdJ
            // 
            this.lblIdJ.AutoSize = true;
            this.lblIdJ.Location = new System.Drawing.Point(12, 82);
            this.lblIdJ.Name = "lblIdJ";
            this.lblIdJ.Size = new System.Drawing.Size(189, 13);
            this.lblIdJ.TabIndex = 7;
            this.lblIdJ.Text = "Jaula en la que se encuentra el Animal";
            // 
            // lblIdAnimal
            // 
            this.lblIdAnimal.AutoSize = true;
            this.lblIdAnimal.Location = new System.Drawing.Point(12, 111);
            this.lblIdAnimal.Name = "lblIdAnimal";
            this.lblIdAnimal.Size = new System.Drawing.Size(70, 13);
            this.lblIdAnimal.TabIndex = 8;
            this.lblIdAnimal.Text = "Id del Animal:";
            // 
            // txtIdJ
            // 
            this.txtIdJ.Location = new System.Drawing.Point(207, 79);
            this.txtIdJ.Name = "txtIdJ";
            this.txtIdJ.Size = new System.Drawing.Size(100, 20);
            this.txtIdJ.TabIndex = 9;
            // 
            // txtIdAnimal
            // 
            this.txtIdAnimal.Location = new System.Drawing.Point(88, 108);
            this.txtIdAnimal.Name = "txtIdAnimal";
            this.txtIdAnimal.Size = new System.Drawing.Size(100, 20);
            this.txtIdAnimal.TabIndex = 10;
            // 
            // txtNombreAnimal
            // 
            this.txtNombreAnimal.Location = new System.Drawing.Point(114, 18);
            this.txtNombreAnimal.Name = "txtNombreAnimal";
            this.txtNombreAnimal.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAnimal.TabIndex = 11;
            // 
            // txtDescripcionAnimal
            // 
            this.txtDescripcionAnimal.Location = new System.Drawing.Point(133, 47);
            this.txtDescripcionAnimal.Name = "txtDescripcionAnimal";
            this.txtDescripcionAnimal.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionAnimal.TabIndex = 12;
            // 
            // AdministracionAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 212);
            this.Controls.Add(this.txtDescripcionAnimal);
            this.Controls.Add(this.txtNombreAnimal);
            this.Controls.Add(this.txtIdAnimal);
            this.Controls.Add(this.txtIdJ);
            this.Controls.Add(this.lblIdAnimal);
            this.Controls.Add(this.lblIdJ);
            this.Controls.Add(this.lblDescripcionAnimal);
            this.Controls.Add(this.lblNombreAnimal);
            this.Controls.Add(this.btnlistarAnimales);
            this.Controls.Add(this.btnModificarAnimales);
            this.Controls.Add(this.btnEliminarAnimales);
            this.Controls.Add(this.btnGuardarAnimales);
            this.Controls.Add(this.dgvAnimales);
            this.Name = "AdministracionAnimales";
            this.Text = "AdministracionAnimales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnimales;
        private System.Windows.Forms.Button btnGuardarAnimales;
        private System.Windows.Forms.Button btnEliminarAnimales;
        private System.Windows.Forms.Button btnModificarAnimales;
        private System.Windows.Forms.Button btnlistarAnimales;
        private System.Windows.Forms.Label lblNombreAnimal;
        private System.Windows.Forms.Label lblDescripcionAnimal;
        private System.Windows.Forms.Label lblIdJ;
        private System.Windows.Forms.Label lblIdAnimal;
        private System.Windows.Forms.TextBox txtIdJ;
        private System.Windows.Forms.TextBox txtIdAnimal;
        private System.Windows.Forms.TextBox txtNombreAnimal;
        private System.Windows.Forms.TextBox txtDescripcionAnimal;
    }
}