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
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMostrarPrecio = new System.Windows.Forms.Label();
            this.LbTickets = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(15, 143);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(115, 55);
            this.btnComprar.TabIndex = 0;
            this.btnComprar.Text = "Reaizar Compra";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lblCedulaComprador
            // 
            this.lblCedulaComprador.AutoSize = true;
            this.lblCedulaComprador.Location = new System.Drawing.Point(12, 111);
            this.lblCedulaComprador.Name = "lblCedulaComprador";
            this.lblCedulaComprador.Size = new System.Drawing.Size(163, 13);
            this.lblCedulaComprador.TabIndex = 1;
            this.lblCedulaComprador.Text = "Ingrese la Cedula del Comprador:";
            this.lblCedulaComprador.Click += new System.EventHandler(this.lblCedulaComprador_Click);
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Location = new System.Drawing.Point(46, 23);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(45, 13);
            this.lblTickets.TabIndex = 2;
            this.lblTickets.Text = "Tickets:";
            // 
            // txtCedulaComprador
            // 
            this.txtCedulaComprador.Location = new System.Drawing.Point(181, 108);
            this.txtCedulaComprador.Name = "txtCedulaComprador";
            this.txtCedulaComprador.Size = new System.Drawing.Size(100, 20);
            this.txtCedulaComprador.TabIndex = 3;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(141, 82);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblMostrarPrecio
            // 
            this.lblMostrarPrecio.AutoSize = true;
            this.lblMostrarPrecio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMostrarPrecio.Location = new System.Drawing.Point(187, 82);
            this.lblMostrarPrecio.Name = "lblMostrarPrecio";
            this.lblMostrarPrecio.Size = new System.Drawing.Size(0, 13);
            this.lblMostrarPrecio.TabIndex = 6;
            // 
            // LbTickets
            // 
            this.LbTickets.FormattingEnabled = true;
            this.LbTickets.Items.AddRange(new object[] {
            "4 Espacios",
            "6 Espacios",
            "10 Espacios",
            "Todos los Espacios"});
            this.LbTickets.Location = new System.Drawing.Point(15, 39);
            this.LbTickets.Name = "LbTickets";
            this.LbTickets.Size = new System.Drawing.Size(120, 56);
            this.LbTickets.TabIndex = 7;
            this.LbTickets.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MenuVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 206);
            this.Controls.Add(this.LbTickets);
            this.Controls.Add(this.lblMostrarPrecio);
            this.Controls.Add(this.lblPrecio);
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
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMostrarPrecio;
        private System.Windows.Forms.ListBox LbTickets;
    }
}