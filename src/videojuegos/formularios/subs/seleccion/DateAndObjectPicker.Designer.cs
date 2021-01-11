namespace videojuegos.formularios.subs.seleccion
{
    partial class DateAndObjectPicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateAndObjectPicker));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha2 = new System.Windows.Forms.DateTimePicker();
            this.fecha1 = new System.Windows.Forms.DateTimePicker();
            this.cbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btngenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "A la fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "De la fecha";
            // 
            // fecha2
            // 
            this.fecha2.Location = new System.Drawing.Point(12, 88);
            this.fecha2.Name = "fecha2";
            this.fecha2.Size = new System.Drawing.Size(273, 22);
            this.fecha2.TabIndex = 6;
            // 
            // fecha1
            // 
            this.fecha1.Location = new System.Drawing.Point(12, 33);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(273, 22);
            this.fecha1.TabIndex = 5;
            // 
            // cbox
            // 
            this.cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox.FormattingEnabled = true;
            this.cbox.Location = new System.Drawing.Point(15, 139);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(270, 24);
            this.cbox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seleccione empleado";
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(187, 169);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(98, 30);
            this.btngenerar.TabIndex = 12;
            this.btngenerar.Text = "Generar";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // DateAndObjectPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 213);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fecha2);
            this.Controls.Add(this.fecha1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DateAndObjectPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione los datos correctos";
            this.Load += new System.EventHandler(this.DateAndObjectPicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fecha2;
        private System.Windows.Forms.DateTimePicker fecha1;
        private System.Windows.Forms.ComboBox cbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btngenerar;
    }
}