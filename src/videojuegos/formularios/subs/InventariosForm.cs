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

        bool toUpdate = false;
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
                
            }
        }
    }
}
