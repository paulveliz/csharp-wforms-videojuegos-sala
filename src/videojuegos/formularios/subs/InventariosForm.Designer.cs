namespace videojuegos.formularios.subs
{
    partial class InventariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventariosForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnquit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnaddcant = new System.Windows.Forms.Button();
            this.btnquitcant = new System.Windows.Forms.Button();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.swnombre = new System.Windows.Forms.RadioButton();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.swtodos = new System.Windows.Forms.RadioButton();
            this.swagotarse = new System.Windows.Forms.RadioButton();
            this.swagotados = new System.Windows.Forms.RadioButton();
            this.txtsearchbyname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtvideojuego = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvbase = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbase)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(867, 529);
            this.splitContainer1.SplitterDistance = 289;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnquit);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnaddcant);
            this.groupBox1.Controls.Add(this.btnquitcant);
            this.groupBox1.Controls.Add(this.txtcant);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtvideojuego);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 529);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar existencias";
            // 
            // btnquit
            // 
            this.btnquit.Enabled = false;
            this.btnquit.Location = new System.Drawing.Point(9, 197);
            this.btnquit.Name = "btnquit";
            this.btnquit.Size = new System.Drawing.Size(247, 30);
            this.btnquit.TabIndex = 9;
            this.btnquit.Text = "Disminuir existencias -";
            this.btnquit.UseVisualStyleBackColor = true;
            this.btnquit.Click += new System.EventHandler(this.btnquit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Enabled = false;
            this.btnadd.Location = new System.Drawing.Point(9, 161);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(247, 30);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "Agregar existencias +";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cantidad";
            // 
            // btnaddcant
            // 
            this.btnaddcant.Location = new System.Drawing.Point(118, 122);
            this.btnaddcant.Name = "btnaddcant";
            this.btnaddcant.Size = new System.Drawing.Size(41, 26);
            this.btnaddcant.TabIndex = 6;
            this.btnaddcant.Text = "+";
            this.btnaddcant.UseVisualStyleBackColor = true;
            this.btnaddcant.Click += new System.EventHandler(this.btnaddcant_Click);
            // 
            // btnquitcant
            // 
            this.btnquitcant.Location = new System.Drawing.Point(71, 122);
            this.btnquitcant.Name = "btnquitcant";
            this.btnquitcant.Size = new System.Drawing.Size(41, 26);
            this.btnquitcant.TabIndex = 5;
            this.btnquitcant.Text = "-";
            this.btnquitcant.UseVisualStyleBackColor = true;
            this.btnquitcant.Click += new System.EventHandler(this.btnquitcant_Click);
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(7, 123);
            this.txtcant.Name = "txtcant";
            this.txtcant.ReadOnly = true;
            this.txtcant.Size = new System.Drawing.Size(58, 22);
            this.txtcant.TabIndex = 4;
            this.txtcant.Text = "1";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(232, 62);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(51, 30);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "?";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.swnombre);
            this.groupBox3.Controls.Add(this.btnbuscar);
            this.groupBox3.Controls.Add(this.swtodos);
            this.groupBox3.Controls.Add(this.swagotarse);
            this.groupBox3.Controls.Add(this.swagotados);
            this.groupBox3.Controls.Add(this.txtsearchbyname);
            this.groupBox3.Location = new System.Drawing.Point(3, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 276);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ordenar inventario";
            // 
            // swnombre
            // 
            this.swnombre.AutoSize = true;
            this.swnombre.Location = new System.Drawing.Point(8, 55);
            this.swnombre.Name = "swnombre";
            this.swnombre.Size = new System.Drawing.Size(150, 21);
            this.swnombre.TabIndex = 13;
            this.swnombre.Text = "Buscar por nombre";
            this.swnombre.UseVisualStyleBackColor = true;
            this.swnombre.CheckedChanged += new System.EventHandler(this.swnombre_CheckedChanged);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(138, 235);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(112, 30);
            this.btnbuscar.TabIndex = 9;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // swtodos
            // 
            this.swtodos.AutoSize = true;
            this.swtodos.Checked = true;
            this.swtodos.Location = new System.Drawing.Point(6, 115);
            this.swtodos.Name = "swtodos";
            this.swtodos.Size = new System.Drawing.Size(69, 21);
            this.swtodos.TabIndex = 12;
            this.swtodos.TabStop = true;
            this.swtodos.Text = "Todos";
            this.swtodos.UseVisualStyleBackColor = true;
            // 
            // swagotarse
            // 
            this.swagotarse.AutoSize = true;
            this.swagotarse.Location = new System.Drawing.Point(5, 169);
            this.swagotarse.Name = "swagotarse";
            this.swagotarse.Size = new System.Drawing.Size(162, 21);
            this.swagotarse.TabIndex = 11;
            this.swagotarse.Text = "Mostrar por agotarse";
            this.swagotarse.UseVisualStyleBackColor = true;
            // 
            // swagotados
            // 
            this.swagotados.AutoSize = true;
            this.swagotados.Location = new System.Drawing.Point(5, 142);
            this.swagotados.Name = "swagotados";
            this.swagotados.Size = new System.Drawing.Size(140, 21);
            this.swagotados.TabIndex = 10;
            this.swagotados.Text = "Mostrar agotados";
            this.swagotados.UseVisualStyleBackColor = true;
            // 
            // txtsearchbyname
            // 
            this.txtsearchbyname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsearchbyname.Enabled = false;
            this.txtsearchbyname.Location = new System.Drawing.Point(6, 82);
            this.txtsearchbyname.Name = "txtsearchbyname";
            this.txtsearchbyname.Size = new System.Drawing.Size(210, 22);
            this.txtsearchbyname.TabIndex = 9;
            this.txtsearchbyname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsearchbyname_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregar existencias del producto:";
            // 
            // txtvideojuego
            // 
            this.txtvideojuego.Location = new System.Drawing.Point(6, 66);
            this.txtvideojuego.Name = "txtvideojuego";
            this.txtvideojuego.ReadOnly = true;
            this.txtvideojuego.Size = new System.Drawing.Size(220, 22);
            this.txtvideojuego.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvbase);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 529);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inventario de videojuegos";
            // 
            // dgvbase
            // 
            this.dgvbase.AllowUserToAddRows = false;
            this.dgvbase.AllowUserToDeleteRows = false;
            this.dgvbase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvbase.Location = new System.Drawing.Point(3, 18);
            this.dgvbase.Name = "dgvbase";
            this.dgvbase.ReadOnly = true;
            this.dgvbase.RowHeadersVisible = false;
            this.dgvbase.RowHeadersWidth = 51;
            this.dgvbase.RowTemplate.Height = 24;
            this.dgvbase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbase.Size = new System.Drawing.Size(568, 508);
            this.dgvbase.TabIndex = 1;
            // 
            // InventariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 529);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventariosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de inventario";
            this.Load += new System.EventHandler(this.InventariosForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvbase;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnaddcant;
        private System.Windows.Forms.Button btnquitcant;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtvideojuego;
        private System.Windows.Forms.TextBox txtsearchbyname;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.RadioButton swtodos;
        private System.Windows.Forms.RadioButton swagotarse;
        private System.Windows.Forms.RadioButton swagotados;
        private System.Windows.Forms.RadioButton swnombre;
        private System.Windows.Forms.Button btnquit;
    }
}