namespace videojuegos.formularios
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depurarAuditoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informePorFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informePorEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentarVideojuegosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeRentasPorFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeRentasPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeRentasPorEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeAgotadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informePorAgotarseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracionToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.rentasToolStripMenuItem,
            this.inventariosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(536, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.auditoriasToolStripMenuItem});
            this.administracionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("administracionToolStripMenuItem.Image")));
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // auditoriasToolStripMenuItem
            // 
            this.auditoriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depurarAuditoriasToolStripMenuItem,
            this.informePorFechasToolStripMenuItem,
            this.informePorEmpleadoToolStripMenuItem});
            this.auditoriasToolStripMenuItem.Name = "auditoriasToolStripMenuItem";
            this.auditoriasToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.auditoriasToolStripMenuItem.Text = "Auditorias";
            // 
            // depurarAuditoriasToolStripMenuItem
            // 
            this.depurarAuditoriasToolStripMenuItem.Name = "depurarAuditoriasToolStripMenuItem";
            this.depurarAuditoriasToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.depurarAuditoriasToolStripMenuItem.Text = "Depurar auditorias";
            // 
            // informePorFechasToolStripMenuItem
            // 
            this.informePorFechasToolStripMenuItem.Name = "informePorFechasToolStripMenuItem";
            this.informePorFechasToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.informePorFechasToolStripMenuItem.Text = "Informe por fechas";
            // 
            // informePorEmpleadoToolStripMenuItem
            // 
            this.informePorEmpleadoToolStripMenuItem.Name = "informePorEmpleadoToolStripMenuItem";
            this.informePorEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.informePorEmpleadoToolStripMenuItem.Text = "Informe por empleado";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarClientesToolStripMenuItem,
            this.informeDeClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // gestionarClientesToolStripMenuItem
            // 
            this.gestionarClientesToolStripMenuItem.Name = "gestionarClientesToolStripMenuItem";
            this.gestionarClientesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gestionarClientesToolStripMenuItem.Text = "Gestionar clientes";
            this.gestionarClientesToolStripMenuItem.Click += new System.EventHandler(this.gestionarClientesToolStripMenuItem_Click);
            // 
            // informeDeClientesToolStripMenuItem
            // 
            this.informeDeClientesToolStripMenuItem.Name = "informeDeClientesToolStripMenuItem";
            this.informeDeClientesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.informeDeClientesToolStripMenuItem.Text = "Informe de clientes";
            // 
            // rentasToolStripMenuItem
            // 
            this.rentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentarVideojuegosToolStripMenuItem,
            this.informeDeRentasPorFechasToolStripMenuItem,
            this.informeDeRentasPorClienteToolStripMenuItem,
            this.informeDeRentasPorEmpleadoToolStripMenuItem});
            this.rentasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rentasToolStripMenuItem.Image")));
            this.rentasToolStripMenuItem.Name = "rentasToolStripMenuItem";
            this.rentasToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.rentasToolStripMenuItem.Text = "Rentas";
            // 
            // rentarVideojuegosToolStripMenuItem
            // 
            this.rentarVideojuegosToolStripMenuItem.Name = "rentarVideojuegosToolStripMenuItem";
            this.rentarVideojuegosToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.rentarVideojuegosToolStripMenuItem.Text = "Rentar videojuegos";
            this.rentarVideojuegosToolStripMenuItem.Click += new System.EventHandler(this.rentarVideojuegosToolStripMenuItem_Click);
            // 
            // informeDeRentasPorFechasToolStripMenuItem
            // 
            this.informeDeRentasPorFechasToolStripMenuItem.Name = "informeDeRentasPorFechasToolStripMenuItem";
            this.informeDeRentasPorFechasToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.informeDeRentasPorFechasToolStripMenuItem.Text = "Informe de rentas por fechas";
            // 
            // informeDeRentasPorClienteToolStripMenuItem
            // 
            this.informeDeRentasPorClienteToolStripMenuItem.Name = "informeDeRentasPorClienteToolStripMenuItem";
            this.informeDeRentasPorClienteToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.informeDeRentasPorClienteToolStripMenuItem.Text = "Informe de rentas por cliente";
            // 
            // informeDeRentasPorEmpleadoToolStripMenuItem
            // 
            this.informeDeRentasPorEmpleadoToolStripMenuItem.Name = "informeDeRentasPorEmpleadoToolStripMenuItem";
            this.informeDeRentasPorEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(308, 26);
            this.informeDeRentasPorEmpleadoToolStripMenuItem.Text = "Informe de rentas por empleado";
            // 
            // inventariosToolStripMenuItem
            // 
            this.inventariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarInventarioToolStripMenuItem,
            this.imprimirInventarioToolStripMenuItem,
            this.informeDeAgotadosToolStripMenuItem,
            this.informePorAgotarseToolStripMenuItem});
            this.inventariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inventariosToolStripMenuItem.Image")));
            this.inventariosToolStripMenuItem.Name = "inventariosToolStripMenuItem";
            this.inventariosToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.inventariosToolStripMenuItem.Text = "Inventarios";
            // 
            // imprimirInventarioToolStripMenuItem
            // 
            this.imprimirInventarioToolStripMenuItem.Name = "imprimirInventarioToolStripMenuItem";
            this.imprimirInventarioToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.imprimirInventarioToolStripMenuItem.Text = "Imprimir inventario";
            // 
            // gestionarInventarioToolStripMenuItem
            // 
            this.gestionarInventarioToolStripMenuItem.Name = "gestionarInventarioToolStripMenuItem";
            this.gestionarInventarioToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.gestionarInventarioToolStripMenuItem.Text = "Gestionar inventario";
            this.gestionarInventarioToolStripMenuItem.Click += new System.EventHandler(this.gestionarInventarioToolStripMenuItem_Click);
            // 
            // informeDeAgotadosToolStripMenuItem
            // 
            this.informeDeAgotadosToolStripMenuItem.Name = "informeDeAgotadosToolStripMenuItem";
            this.informeDeAgotadosToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.informeDeAgotadosToolStripMenuItem.Text = "Informe de agotados";
            // 
            // informePorAgotarseToolStripMenuItem
            // 
            this.informePorAgotarseToolStripMenuItem.Name = "informePorAgotarseToolStripMenuItem";
            this.informePorAgotarseToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.informePorAgotarseToolStripMenuItem.Text = "Informe por agotarse";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 627);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 590);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de videojuegos";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 655);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depurarAuditoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informePorFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informePorEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentarVideojuegosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeDeRentasPorFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeDeRentasPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeDeRentasPorEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeDeAgotadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informePorAgotarseToolStripMenuItem;
    }
}