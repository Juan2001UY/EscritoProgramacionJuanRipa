namespace CapaVisual
{
    partial class MenuVendedor
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
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblCedulaComprador = new System.Windows.Forms.Label();
            this.lblTickets = new System.Windows.Forms.Label();
            this.txtCedulaComprador = new System.Windows.Forms.TextBox();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(87, 114);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(115, 23);
            this.btnComprar.TabIndex = 0;
            this.btnComprar.Text = "Reaizar Compra";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lblCedulaComprador
            // 
            this.lblCedulaComprador.AutoSize = true;
            this.lblCedulaComprador.Location = new System.Drawing.Point(12, 78);
            this.lblCedulaComprador.Name = "lblCedulaComprador";
            this.lblCedulaComprador.Size = new System.Drawing.Size(163, 13);
            this.lblCedulaComprador.TabIndex = 1;
            this.lblCedulaComprador.Text = "Ingrese la Cedula del Comprador:";
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Location = new System.Drawing.Point(12, 34);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(45, 13);
            this.lblTickets.TabIndex = 2;
            this.lblTickets.Text = "Tickets:";
            // 
            // txtCedulaComprador
            // 
            this.txtCedulaComprador.Location = new System.Drawing.Point(181, 75);
            this.txtCedulaComprador.Name = "txtCedulaComprador";
            this.txtCedulaComprador.Size = new System.Drawing.Size(100, 20);
            this.txtCedulaComprador.TabIndex = 3;
            // 
            // cbProductos
            // 
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Items.AddRange(new object[] {
            "4 espacios (30$)",
            "6 espacios ($40)",
            "10 espacios ($100)",
            "Todos los espacios ($250)"});
            this.cbProductos.Location = new System.Drawing.Point(71, 31);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(144, 21);
            this.cbProductos.TabIndex = 4;
            this.cbProductos.Text = "Seleccione un Ticket";
            this.cbProductos.SelectedIndexChanged += new System.EventHandler(this.cbProductos_SelectedIndexChanged);
            // 
            // MenuVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 149);
            this.Controls.Add(this.cbProductos);
            this.Controls.Add(this.txtCedulaComprador);
            this.Controls.Add(this.lblTickets);
            this.Controls.Add(this.lblCedulaComprador);
            this.Controls.Add(this.btnComprar);
            this.Name = "MenuVendedor";
            this.Text = "MenuVendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lblCedulaComprador;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.TextBox txtCedulaComprador;
        private System.Windows.Forms.ComboBox cbProductos;
    }
}