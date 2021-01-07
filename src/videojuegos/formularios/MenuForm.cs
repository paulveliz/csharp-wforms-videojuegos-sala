using models.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace videojuegos.formularios
{
    public partial class MenuForm : Form
    {
        public usuarios Usuario { get; set; }
        public MenuForm(usuarios usuario)
        {
            this.Usuario = usuario;
            this.Text = $"Sistema videojuegos v1 - Empleado actual: {usuario.nombre_real}";
            InitializeComponent();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var empleadosForm = new formularios.subs.EmpleadosForm();
            empleadosForm.ShowDialog();
        }

        private void gestionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clientesForm = new formularios.subs.ClientesForm();
            clientesForm.ShowDialog();
        }

        private void rentarVideojuegosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rentasForm = new formularios.subs.RentasForm();
            rentasForm.ShowDialog();
        }

        private void gestionarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inventariosForm = new formularios.subs.InventariosForm();
            inventariosForm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Esta seguro de cerrar el sistema?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) return;
            Application.Exit();
        }
    }
}
