namespace videojuegos.formularios.subs
{
    partial class RentasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentasForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recibirProductosRentadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.btnaddtocart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnquit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsearchclient = new System.Windows.Forms.Button();
            this.btnsearchvideojuego = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtvideojuego = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtempleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvbase = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Videojuego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbase)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recibirProductosRentadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(987, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // recibirProductosRentadosToolStripMenuItem
            // 
            this.recibirProductosRentadosToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.recibirProductosRentadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recibirToolStripMenuItem});
            this.recibirProductosRentadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("recibirProductosRentadosToolStripMenuItem.Image")));
            this.recibirProductosRentadosToolStripMenuItem.Name = "recibirProductosRentadosToolStripMenuItem";
            this.recibirProductosRentadosToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.recibirProductosRentadosToolStripMenuItem.Text = "Recibir productos rentados";
            // 
            // recibirToolStripMenuItem
            // 
            this.recibirToolStripMenuItem.Name = "recibirToolStripMenuItem";
            this.recibirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.recibirToolStripMenuItem.Text = "Recibir";
            this.recibirToolStripMenuItem.Click += new System.EventHandler(this.recibirToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(987, 436);
            this.splitContainer1.SplitterDistance = 426;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnfinalizar);
            this.groupBox1.Controls.Add(this.btnaddtocart);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txttotal);
            this.groupBox1.Controls.Add(this.btnquit);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.btnsearchclient);
            this.groupBox1.Controls.Add(this.btnsearchvideojuego);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtcant);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtvideojuego);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtcliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtempleado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 436);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.Location = new System.Drawing.Point(144, 398);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(279, 29);
            this.btnfinalizar.TabIndex = 3;
            this.btnfinalizar.Text = "Concluir renta";
            this.btnfinalizar.UseVisualStyleBackColor = true;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // btnaddtocart
            // 
            this.btnaddtocart.Location = new System.Drawing.Point(16, 249);
            this.btnaddtocart.Name = "btnaddtocart";
            this.btnaddtocart.Size = new System.Drawing.Size(397, 29);
            this.btnaddtocart.TabIndex = 2;
            this.btnaddtocart.Text = "Agregar videojuego a la cesta";
            this.btnaddtocart.UseVisualStyleBackColor = true;
            this.btnaddtocart.Click += new System.EventHandler(this.btnaddtocart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Total a pagar";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(25, 402);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(110, 22);
            this.txttotal.TabIndex = 15;
            this.txttotal.Text = "0";
            // 
            // btnquit
            // 
            this.btnquit.Location = new System.Drawing.Point(372, 204);
            this.btnquit.Name = "btnquit";
            this.btnquit.Size = new System.Drawing.Size(41, 29);
            this.btnquit.TabIndex = 14;
            this.btnquit.Text = "+";
            this.btnquit.UseVisualStyleBackColor = true;
            this.btnquit.Click += new System.EventHandler(this.btnquit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(325, 204);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(41, 29);
            this.btnadd.TabIndex = 13;
            this.btnadd.Text = "-";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsearchclient
            // 
            this.btnsearchclient.Location = new System.Drawing.Point(372, 152);
            this.btnsearchclient.Name = "btnsearchclient";
            this.btnsearchclient.Size = new System.Drawing.Size(41, 29);
            this.btnsearchclient.TabIndex = 0;
            this.btnsearchclient.Text = "?";
            this.btnsearchclient.UseVisualStyleBackColor = true;
            this.btnsearchclient.Click += new System.EventHandler(this.btnsearchclient_Click);
            // 
            // btnsearchvideojuego
            // 
            this.btnsearchvideojuego.Location = new System.Drawing.Point(225, 204);
            this.btnsearchvideojuego.Name = "btnsearchvideojuego";
            this.btnsearchvideojuego.Size = new System.Drawing.Size(41, 29);
            this.btnsearchvideojuego.TabIndex = 1;
            this.btnsearchvideojuego.Text = "?";
            this.btnsearchvideojuego.UseVisualStyleBackColor = true;
            this.btnsearchvideojuego.Click += new System.EventHandler(this.btnsearchvideojuego_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cant.";
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(281, 207);
            this.txtcant.Name = "txtcant";
            this.txtcant.ReadOnly = true;
            this.txtcant.Size = new System.Drawing.Size(38, 22);
            this.txtcant.TabIndex = 9;
            this.txtcant.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Videojuego a rentar";
            // 
            // txtvideojuego
            // 
            this.txtvideojuego.Location = new System.Drawing.Point(16, 207);
            this.txtvideojuego.Name = "txtvideojuego";
            this.txtvideojuego.ReadOnly = true;
            this.txtvideojuego.Size = new System.Drawing.Size(203, 22);
            this.txtvideojuego.TabIndex = 7;
            this.txtvideojuego.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cliente";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(16, 156);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.ReadOnly = true;
            this.txtcliente.Size = new System.Drawing.Size(350, 22);
            this.txtcliente.TabIndex = 5;
            this.txtcliente.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Empleado actual";
            // 
            // txtempleado
            // 
            this.txtempleado.Location = new System.Drawing.Point(16, 104);
            this.txtempleado.Name = "txtempleado";
            this.txtempleado.ReadOnly = true;
            this.txtempleado.Size = new System.Drawing.Size(397, 22);
            this.txtempleado.TabIndex = 3;
            this.txtempleado.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nueva renta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvbase);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 436);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos en la renta (Doble click para eliminar videojuego de la cesta)";
            // 
            // dgvbase
            // 
            this.dgvbase.AllowUserToAddRows = false;
            this.dgvbase.AllowUserToDeleteRows = false;
            this.dgvbase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Videojuego,
            this.Cantidad,
            this.Importe});
            this.dgvbase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvbase.Location = new System.Drawing.Point(3, 18);
            this.dgvbase.Name = "dgvbase";
            this.dgvbase.ReadOnly = true;
            this.dgvbase.RowHeadersVisible = false;
            this.dgvbase.RowHeadersWidth = 51;
            this.dgvbase.RowTemplate.Height = 24;
            this.dgvbase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbase.Size = new System.Drawing.Size(551, 415);
            this.dgvbase.TabIndex = 0;
            this.dgvbase.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbase_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Videojuego
            // 
            this.Videojuego.HeaderText = "Videojuego";
            this.Videojuego.MinimumWidth = 6;
            this.Videojuego.Name = "Videojuego";
            this.Videojuego.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 6;
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // RentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 464);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RentasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de rentas";
            this.Load += new System.EventHandler(this.RentasForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recibirProductosRentadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recibirToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvbase;
        private System.Windows.Forms.Button btnsearchvideojuego;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtvideojuego;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtempleado;
        private System.Windows.Forms.Button btnquit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsearchclient;
        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.Button btnaddtocart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Videojuego;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    }
}