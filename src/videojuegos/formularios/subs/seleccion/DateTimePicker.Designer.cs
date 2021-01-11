namespace videojuegos.formularios.subs.seleccion
{
    partial class DateTimePicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateTimePicker));
            this.fecha1 = new System.Windows.Forms.DateTimePicker();
            this.fecha2 = new System.Windows.Forms.DateTimePicker();
            this.btngenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fecha1
            // 
            this.fecha1.Location = new System.Drawing.Point(12, 49);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(273, 22);
            this.fecha1.TabIndex = 0;
            // 
            // fecha2
            // 
            this.fecha2.Location = new System.Drawing.Point(12, 104);
            this.fecha2.Name = "fecha2";
            this.fecha2.Size = new System.Drawing.Size(273, 22);
            this.fecha2.TabIndex = 1;
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(187, 136);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(98, 30);
            this.btngenerar.TabIndex = 2;
            this.btngenerar.Text = "Generar";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "De la fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "A la fecha";
            // 
            // DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 176);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.fecha2);
            this.Controls.Add(this.fecha1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DateTimePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione fechas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fecha1;
        private System.Windows.Forms.DateTimePicker fecha2;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}