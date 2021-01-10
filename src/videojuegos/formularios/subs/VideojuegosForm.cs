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

namespace videojuegos.formularios.subs
{
    public partial class VideojuegosForm : Form
    {
        videojuegoController vCtrl = new videojuegoController();
        bool toUpdate = false;
        public models.db.videojuegos Videojuego { get; set; }
        public VideojuegosForm()
        {
            InitializeComponent();
        }

        private async void VideojuegosForm_Load(object sender, EventArgs e)
        {
            await cargarVideojuegos();
        }

        private async Task cargarVideojuegos()
        {
            this.dgvbase.DataSource = await vCtrl.obtenerTodos();
            this.dgvbase.Columns[0].Visible = false;
            this.dgvbase.Columns[1].HeaderText = "Nombre del videojuego";
            this.dgvbase.Columns[2].Visible = false;
            this.dgvbase.Columns[3].Visible = true;
            this.dgvbase.Columns[5].Visible = false;
            this.dgvbase.Columns[6].Visible = false;
        }

        private async void txtvideojuego_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtvideojuego.Text.Length < 4)
                {
                    MessageBox.Show(
                            "El videojuego debe tener al menos 4 caracteres de longitud.",
                            "Datos incorrectos",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    return;
                }

                var videojuego = await vCtrl.verificarNombre(txtvideojuego.Text.Trim());
                if (videojuego != null)
                {
                    var c = MessageBox.Show(
                                "El videojuego introducido ya existe en el sistema, desea actualizar su informacion?",
                                "Videojuego existente",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question
                            );
                    if (c == DialogResult.No) return;
                    toUpdate = true;
                    this.btnadd.Enabled = true;
                    this.btnadd.Text = "Actualizar";
                    this.txtvideojuego.Focus();
                    this.Videojuego = videojuego;
                }
                else
                {
                    toUpdate = false;
                    this.btnadd.Enabled = true;
                    this.txtvideojuego.Enabled = false;
                    this.btnadd.Focus();
                    this.btnadd.Text = "Agregar";
                }
            }
        }

        private async void btnadd_Click(object sender, EventArgs e)
        {
            if (toUpdate)
            {
                var updatedJuego = await vCtrl.editarJuego(new models.db.videojuegos
                {
                    id = Videojuego.id,
                    estatus = 1,
                    nombre = this.txtvideojuego.Text.Trim()
                });

                if (updatedJuego != null)
                {
                    MessageBox.Show(
                        "El Videojuego fue actualizado con exito.",
                        "Exito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    this.txtvideojuego.Clear();
                    this.txtvideojuego.Focus();
                    this.txtvideojuego.Enabled = true;
                    this.btnadd.Enabled = false;
                    await cargarVideojuegos();
                }
                else
                {
                    MessageBox.Show(
                        "Ocurrio un error intentando actualizar el videojuego,",
                        "Error base de datos.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            else
            {
                var c = MessageBox.Show(
                    $"Desea agregar el videojuego {this.txtvideojuego.Text.ToUpper()} al sistema?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (c == DialogResult.No) return;
                var newCl = await vCtrl.crearNuevo(new models.db.videojuegos
                {
                    nombre = this.txtvideojuego.Text.Trim().ToUpper(),
                    estatus = 1
                });

                if (newCl != null)
                {
                    var newInventario = await new inventarioController().crearNuevo(new inventarios
                    {
                        estatus = 1,
                        existencias = 0,
                        videojuego_id = newCl.id
                    });

                    MessageBox.Show(
                        "El videojuego fue agregado con exito.",
                        "Exito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    this.txtvideojuego.Clear();
                    this.txtvideojuego.Focus();
                    this.btnadd.Enabled = false;
                    this.txtvideojuego.Enabled = true;
                    await cargarVideojuegos();
                }
                else
                {
                    MessageBox.Show(
                        "Ocurrio un error intentando actualizar el videojuego,",
                        "Error base de datos.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }

        private async void dgvbase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int videoJuegoId = Convert.ToInt32(this.dgvbase.SelectedRows[0].Cells[0].Value.ToString());
                string videoJuegoNombre = this.dgvbase.SelectedRows[0].Cells[1].Value.ToString();
                var c = MessageBox.Show(
                    $"Desea dar de baja al videojuego {videoJuegoNombre} del sistema?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (c == DialogResult.No) return;
                var deleted = await vCtrl.darDeBaja(videoJuegoId);
                if (deleted != null)
                {
                    MessageBox.Show(
                        "El videojuego fue dado de baja con exito.",
                        "Exito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    await cargarVideojuegos();
                }
                else
                {
                    MessageBox.Show(
                        "Ocurrio un error intentando dar de baja el videojuego,",
                        "Error base de datos.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private async void VideojuegosForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                var c = MessageBox.Show(
                    $"Restablecer formulario?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (c == DialogResult.No) return;
                this.txtvideojuego.Clear();
                this.btnadd.Enabled = false;
                this.txtvideojuego.Enabled = true;
                await cargarVideojuegos();
                this.txtvideojuego.Focus();
            }
        }
    }
}
