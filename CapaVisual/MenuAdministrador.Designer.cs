namespace CapaVisual
{
    partial class MenuAdministrador
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
            this.btnMenuVisitantes = new System.Windows.Forms.Button();
            this.BtnMenuJaulas = new System.Windows.Forms.Button();
            this.btnMenuEspacios = new System.Windows.Forms.Button();
            this.btnMenuAnimales = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuVisitantes
            // 
            this.btnMenuVisitantes.Location = new System.Drawing.Point(23, 12);
            this.btnMenuVisitantes.Name = "btnMenuVisitantes";
            this.btnMenuVisitantes.Size = new System.Drawing.Size(223, 23);
            this.btnMenuVisitantes.TabIndex = 1;
            this.btnMenuVisitantes.Text = "Ir al menu de administración de visitantes";
            this.btnMenuVisitantes.UseVisualStyleBackColor = true;
            this.btnMenuVisitantes.Click += new System.EventHandler(this.btnMenuVisitantes_Click);
            // 
            // BtnMenuJaulas
            // 
            this.BtnMenuJaulas.Location = new System.Drawing.Point(23, 70);
            this.BtnMenuJaulas.Name = "BtnMenuJaulas";
            this.BtnMenuJaulas.Size = new System.Drawing.Size(223, 23);
            this.BtnMenuJaulas.TabIndex = 2;
            this.BtnMenuJaulas.Text = "Ir al menu de administración de Jaulas";
            this.BtnMenuJaulas.UseVisualStyleBackColor = true;
            this.BtnMenuJaulas.Click += new System.EventHandler(this.BtnMenuJaulas_Click);
            // 
            // btnMenuEspacios
            // 
            this.btnMenuEspacios.Location = new System.Drawing.Point(23, 41);
            this.btnMenuEspacios.Name = "btnMenuEspacios";
            this.btnMenuEspacios.Size = new System.Drawing.Size(223, 23);
            this.btnMenuEspacios.TabIndex = 3;
            this.btnMenuEspacios.Text = "Ir al menu de administración de espacios";
            this.btnMenuEspacios.UseVisualStyleBackColor = true;
            this.btnMenuEspacios.Click += new System.EventHandler(this.btnMenuEspacios_Click);
            // 
            // btnMenuAnimales
            // 
            this.btnMenuAnimales.Location = new System.Drawing.Point(23, 99);
            this.btnMenuAnimales.Name = "btnMenuAnimales";
            this.btnMenuAnimales.Size = new System.Drawing.Size(223, 23);
            this.btnMenuAnimales.TabIndex = 4;
            this.btnMenuAnimales.Text = "Ir al menu de administración de Animales";
            this.btnMenuAnimales.UseVisualStyleBackColor = true;
            this.btnMenuAnimales.Click += new System.EventHandler(this.btnMenuAnimales_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(181, 161);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 198);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMenuAnimales);
            this.Controls.Add(this.btnMenuEspacios);
            this.Controls.Add(this.BtnMenuJaulas);
            this.Controls.Add(this.btnMenuVisitantes);
            this.Name = "MenuAdministrador";
            this.Text = "MenuAdministrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuVisitantes;
        private System.Windows.Forms.Button BtnMenuJaulas;
        private System.Windows.Forms.Button btnMenuEspacios;
        private System.Windows.Forms.Button btnMenuAnimales;
        private System.Windows.Forms.Button btnSalir;
    }
}