using controllers;
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
            globals.usuario = usuario;
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
            var rentasForm = new formularios.subs.RentasForm(this.Usuario);
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

        private void videojuegosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var videojuegosForm = new formularios.subs.VideojuegosForm();
            videojuegosForm.ShowDialog();
        }

        private async void informePorFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new formularios.subs.seleccion.DateTimePicker())
            {
                var r = frm.ShowDialog();
                if (r != DialogResult.Yes) return;

                var auditorias = await new auditoriaController().obtenerAuditoriasPorFecha(frm.Fecha1, frm.Fecha2);
                var rpt = new reportes.forms.ReporteAuditorias(auditorias, frm.Fecha1, frm.Fecha2);
                rpt.ShowDialog();
            }
        }

        private async void informePorEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new formularios.subs.seleccion.DateAndObjectPicker())
            {
                var r = frm.ShowDialog();
                if (r != DialogResult.Yes) return;
                var auditorias = await new auditoriaController().obtenerAuditoriasPorFecha(frm.Fecha1, frm.Fecha2);
                var rpt = new reportes.forms.ReporteAuditorias(auditorias, frm.Fecha1, frm.Fecha2);
                rpt.ShowDialog();
            }
        }

        private async void depurarAuditoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Esta seguro de depurar las auditorias?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) return;

            var aCtrl = await new auditoriaController().depurar();
            if (aCtrl)
            {
                MessageBox.Show("Auditorias depuradas con exito", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void informeDeRentasPorFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new formularios.subs.seleccion.DateTimePicker())
            {
                var r = frm.ShowDialog();
                if (r != DialogResult.Yes) return;

                var rentas = await new rentaController().obtenerRentas(frm.Fecha1, frm.Fecha2);
                var result = rentas.Select( fr =>
                    fr.Renta
                ).ToList();
                var rpt = new reportes.forms.ReporteRentas(result, frm.Fecha1, frm.Fecha2);
                rpt.ShowDialog();
            }
        }

        private async void informeDeRentasPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new formularios.subs.seleccion.DateAndClienteSelection())
            {
                var r = frm.ShowDialog();
                if (r != DialogResult.Yes) return;
                var rentas = await new rentaController().obtenerRentasPorCliente(frm.Fecha1, frm.Fecha2, frm.Cliente.id);
                var result = rentas.Select(fr =>
                                       fr.Renta
                                    ).ToList();
                var rpt = new reportes.forms.ReporteRentas(result, frm.Fecha1, frm.Fecha2);
                rpt.ShowDialog();
            }
        }

        private async void informeDeRentasPorEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new formularios.subs.seleccion.DateAndObjectPicker())
            {
                var r = frm.ShowDialog();
                if (r != DialogResult.Yes) return;
                var rentas = await new rentaController().obtenerRentasPorUsuario(frm.Fecha1, frm.Fecha2, frm.Empleado.id);
                var result = rentas.Select(fr =>
                                       fr.Renta
                                    ).ToList();
                var rpt = new reportes.forms.ReporteRentas(result, frm.Fecha1, frm.Fecha2);
                rpt.ShowDialog();
            }
        }

        private async void imprimirInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Imprimir inventario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) return;

            var inventarios = await new inventarioController().obtenerTodos();
            var rpt = new reportes.forms.ReporteInventario(inventarios);
            rpt.ShowDialog();

        }

        private async void informeDeAgotadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Imprimir inventario que esta agotado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) return;

            var inventarios = await new inventarioController().obtenerAgotados();
            var rpt = new reportes.forms.ReporteInventario(inventarios);
            rpt.ShowDialog();
        }

        private async void informePorAgotarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Imprimir inventario que esta por agotarse?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) return;

            var inventarios = await new inventarioController().obtenerPorAgotar();
            var rpt = new reportes.forms.ReporteInventario(inventarios);
            rpt.ShowDialog();
        }
    }
}
