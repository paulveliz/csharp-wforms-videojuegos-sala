﻿namespace videojuegos.formularios.subs
{
    partial class DevolverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevolverForm));
            this.txtfolio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnrecibir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.folioOlvidadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtfolio
            // 
            this.txtfolio.Location = new System.Drawing.Point(15, 86);
            this.txtfolio.Name = "txtfolio";
            this.txtfolio.Size = new System.Drawing.Size(188, 22);
            this.txtfolio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduzca el folio de la renta";
            // 
            // btnrecibir
            // 
            this.btnrecibir.Location = new System.Drawing.Point(118, 124);
            this.btnrecibir.Name = "btnrecibir";
            this.btnrecibir.Size = new System.Drawing.Size(85, 36);
            this.btnrecibir.TabIndex = 2;
            this.btnrecibir.Text = "Recibir";
            this.btnrecibir.UseVisualStyleBackColor = true;
            this.btnrecibir.Click += new System.EventHandler(this.btnrecibir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folioOlvidadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(236, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // folioOlvidadoToolStripMenuItem
            // 
            this.folioOlvidadoToolStripMenuItem.BackColor = System.Drawing.Color.Wheat;
            this.folioOlvidadoToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.folioOlvidadoToolStripMenuItem.Name = "folioOlvidadoToolStripMenuItem";
            this.folioOlvidadoToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.folioOlvidadoToolStripMenuItem.Text = "Folio olvidado";
            // 
            // DevolverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 173);
            this.Controls.Add(this.btnrecibir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfolio);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DevolverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recibir una renta";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfolio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnrecibir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem folioOlvidadoToolStripMenuItem;
    }
}