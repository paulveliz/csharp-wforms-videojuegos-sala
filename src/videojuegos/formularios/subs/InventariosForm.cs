using controllers;
using models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace videojuegos.formularios.subs
{
    public partial class InventariosForm : Form
    {
        inventarioController iCtrl = new inventarioController();
        models.db.videojuegos Videojuego {get; set;}
        public Inventario Inventario { get; set; }
        public InventariosForm()
        {
            InitializeComponent();
        }

        private void btnaddcant_Click(object sender, EventArgs e)
        {
            int cant = Convert.ToInt32( this.txtcant.Text );
            this.txtcant.Text = (cant + 1).ToString();
        }

        private void btnquitcant_Click(object sender, EventArgs e)
        {
            int cant = Convert.ToInt32(this.txtcant.Text);
            this.txtcant.Text = cant == 1 ? cant.ToString() : (cant - 1).ToString();
        }

        private async void InventariosForm_Load(object sender, EventArgs e)
        {
            await cargarInventario();
        }

        private async Task cargarInventario()
        {
            this.dgvbase.DataSource = await iCtrl.obtenerTodos();
            this.dgvbase.Columns[0].Visible = false;
            this.dgvbase.Columns[3].Visible = false;
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            using (var frm = new seleccion.VideoJuegosSelection())
            {
                var result = frm.ShowDialog();
                if (result != DialogResult.Yes) return;
                this.Videojuego = frm.Videojuego;
                this.txtvideojuego.Text = this.Videojuego.nombre;
                this.btnadd.Enabled = true;
                this.btnquit.Enabled = true;
            }
        }

        private async void btnadd_Click(object sender, EventArgs e)
        {
            int existencias = Convert.ToInt32(this.txtcant.Text);
            var response = MessageBox.Show(
                    "Desea agregar existencias ",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
            if (response == DialogResult.No) return;

            var newExis = await iCtrl.agregarExistencias(this.Videojuego.id, existencias);
            if (newExis != null)
            {
                await cargarInventario();
                MessageBox.Show(
                    $"Se agregaron las existencias con exito del videojuego {this.Videojuego.nombre}",
                    "Operacion exitosa"
                );
            }
            else
            {
                await cargarInventario();
                MessageBox.Show(
                    "Ocurrio un error al agregar existencias",
                    "Error de base de datos"
                );
            }
        }

        private async void btnquit_Click(object sender, EventArgs e)
        {
            int existencias = Convert.ToInt32(this.txtcant.Text);
            var response = MessageBox.Show(
                    "Desea quitar existencias ",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
            if (response == DialogResult.No) return;

            var inventarios = await iCtrl.obtenerTodos();
            var inventarioActual = inventarios.Where(i =>
               i.Videojuego == this.Videojuego.nombre
            ).FirstOrDefault();

            if(inventarioActual.Existencias == 0)
            {
                MessageBox.Show(
                    "No puede quitar existencias a este producto debido a que esta agotado.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand
                );
                return;
            }

            var newExis = await iCtrl.disminuirExistencias(this.Videojuego.id, existencias);
            if (newExis != null)
            {
                await cargarInventario();
                MessageBox.Show(
                    $"Se Disminuyeron las existencias con exito del videojuego {this.Videojuego.nombre}",
                    "Operacion exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                await cargarInventario();
                MessageBox.Show(
                    "Ocurrio un error al disminuir existencias",
                    "Error de base de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand
                );
            }
        }

        private void swnombre_CheckedChanged(object sender, EventArgs e)
        {
            if (this.swnombre.Checked)
            {
                this.txtsearchbyname.Enabled = true;
                this.btnbuscar.Enabled = false;
            }
            else
            {
                this.btnbuscar.Enabled = true;
                this.txtsearchbyname.Enabled = false;
            }
        }

        private async void txtsearchbyname_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                var inventarios = await iCtrl.obtenerTodos();
                this.dgvbase.DataSource = inventarios.Where(inv =>
                   inv.Videojuego.Contains(txtsearchbyname.Text)
                ).ToList();
                this.dgvbase.Columns[0].Visible = false;
                this.dgvbase.Columns[3].Visible = false;
            }
            catch (Exception)
            {
                return;
            }
        }

        private async void btnbuscar_Click(object sender, EventArgs e)
        {

            if (swtodos.Checked)
            {
                this.dgvbase.DataSource = await iCtrl.obtenerTodos();
            }

            if (swagotados.Checked)
            {
                this.dgvbase.DataSource = await iCtrl.obtenerAgotados();
            }

            if (swagotarse.Checked)
            {
                this.dgvbase.DataSource = await iCtrl.obtenerPorAgotar();
            }

            this.dgvbase.Columns[0].Visible = false;
            this.dgvbase.Columns[3].Visible = false;

        }
    }
}
