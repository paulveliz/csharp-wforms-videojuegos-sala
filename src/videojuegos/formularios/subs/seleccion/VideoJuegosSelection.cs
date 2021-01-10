using controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using models.db;

namespace videojuegos.formularios.subs.seleccion
{
    public partial class VideoJuegosSelection : Form
    {
        videojuegoController vCtrl = new videojuegoController();
        public models.db.videojuegos Videojuego { get; set; }
        public VideoJuegosSelection()
        {
            InitializeComponent();
        }

        private async void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            var vj = await vCtrl.obtenerTodos();
            this.dgvbase.DataSource = null;
            this.dgvbase.Refresh();
            this.dgvbase.DataSource = vj.Where(v =>
               v.nombre.Contains(txtsearch.Text)
            ).ToList();
            this.dgvbase.Columns[0].Visible = false;
            this.dgvbase.Columns[1].HeaderText = "Nombre del videojuego";
            this.dgvbase.Columns[2].Visible = false;
            this.dgvbase.Columns[3].Visible = true;
            this.dgvbase.Columns[4].Visible = false;
            this.dgvbase.Columns[5].Visible = false;
        }

        private async void VideoJuegosSelection_Load(object sender, EventArgs e)
        {
            this.dgvbase.DataSource = await vCtrl.obtenerTodos();
            this.dgvbase.Columns[0].Visible = false;
            this.dgvbase.Columns[1].HeaderText = "Nombre del videojuego";
            this.dgvbase.Columns[2].Visible = false;
            this.dgvbase.Columns[3].Visible = true;
            this.dgvbase.Columns[4].Visible = false;
            this.dgvbase.Columns[5].Visible = false;
        }

        private async void dgvbase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var videojuego = (models.db.videojuegos)this.dgvbase.SelectedRows[0].DataBoundItem;

                var videojuegos = await new inventarioController().obtenerTodos();
                var invj = videojuegos.Where(v =>
                   v.Videojuego == videojuego.nombre
                ).FirstOrDefault();

                var r = MessageBox.Show(
                    $"Desea seleccionar el videojuego {videojuego.nombre}\n Existencias: {invj.Existencias}",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (r == DialogResult.No) return;
                this.Videojuego = videojuego;
                this.DialogResult = DialogResult.Yes;
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
