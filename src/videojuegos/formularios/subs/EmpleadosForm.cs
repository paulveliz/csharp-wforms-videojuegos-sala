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
    public partial class EmpleadosForm : Form
    {
        usuarioController usrCtrl = new usuarioController();
        public bool toUpdate = false;
        usuarios Usuario { get; set; }
        public EmpleadosForm()
        {
            InitializeComponent();
        }

        private async void btnadd_Click(object sender, EventArgs e)
        {
            /// Validaciones

            if (txtnombrereal.Text.Length < 5)
            {
                MessageBox.Show(
                    "Debe introducir un nombre real de almenos 5 caracteres de longitud.",
                    "Datos incorrectos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }

            if (txtnombre.Text.Length < 5)
            {
                MessageBox.Show(
                    "Debe introducir un nombre de usuario de almenos 4 caracteres de longitud.",
                    "Datos incorrectos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }

            if (txtpass1.Text.Length < 3)
            {
                MessageBox.Show(
                    "Debe introducir una contraseña de almenos 3 caracteres de longitud.",
                    "Datos incorrectos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }

            if (txtpass2.Text.Length < 3)
            {
                MessageBox.Show(
                    "Debe introducir una contraseña de almenos 3 caracteres de longitud y su repeticion.",
                    "Datos incorrectos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }

            if (txtpass1.Text != txtpass2.Text)
            {
                MessageBox.Show(
                    "Las contraseñas introducidas no coinciden.",
                    "Datos incorrectos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }

            var r = MessageBox.Show(
                      "Todos los datos introducidos son correctos, desea continuar?",
                      "Confirmar",
                      MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question
                      );
            if (r == DialogResult.No) return;

            // Registrar nuevo usuario

            if(toUpdate == false)
            {
                var newUser = await usrCtrl.crearNuevo(new usuarios
                {
                    estatus = 1,
                    nombre = txtnombre.Text.Trim(),
                    nombre_real = txtnombrereal.Text.Trim(),
                    pass = txtpass1.Text,
                });

                if(newUser != null)
                {
                    MessageBox.Show(
                        $"El usuario {newUser.nombre} fue registrado con exito.",
                        "Exito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
                else
                {
                    MessageBox.Show(
                        "Ocurrio un problema intentando agregar el usuario al sistema.",
                        "Problema con el servidor",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Hand
                        );
                }
            }
            else
            {
                // Actualizar usuario
                var updatedUped = await usrCtrl.actualizar(new usuarios 
                {
                    id = this.Usuario.id,
                    estatus = 1,
                    nombre = this.txtnombre.Text.Trim(),
                    nombre_real = this.txtnombrereal.Text.Trim(),
                    pass = this.txtpass1.Text
                });
                if (updatedUped != null)
                {
                    MessageBox.Show(
                        $"El usuario {updatedUped.nombre} fue actualizado con exito.",
                        "Exito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
                else
                {
                    MessageBox.Show(
                        "Ocurrio un problema intentando actualizar el usuario en el sistema.",
                        "Problema con el servidor",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Hand
                        );
                }
            }
            await cargarusuarios();
            enableControls(false);
            txtnombre.Enabled = true;
            txtnombre.Focus();
        }

        private async void EmpleadosForm_Load(object sender, EventArgs e)
        {
            await cargarusuarios();
        }

        private async Task cargarusuarios()
        {
            this.dgvbase.DataSource = await usrCtrl.obtenerTodos();
            this.dgvbase.Columns[0].Visible = false;
            this.dgvbase.Columns[1].HeaderText = "Nombre de usuario";
            this.dgvbase.Columns[2].HeaderText = "Nombre real";
            this.dgvbase.Columns[3].Visible = false;
            this.dgvbase.Columns[4].Visible = false;
            this.dgvbase.Columns[5].Visible = false;
            this.dgvbase.Columns[6].Visible = false;
        }

        private async void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                if (txtnombre.Text.Length < 5)
                {
                    MessageBox.Show(
                        "Debe introducir un nombre de usuario de almenos 4 caracteres de longitud.",
                        "Datos incorrectos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                    return;
                }
                // Verificar nombre de usuario
                var username = await usrCtrl.verificarNombre(txtnombre.Text.Trim());
                if (username != null)
                {
                   var r = MessageBox.Show(
                                "El nombre de usuario introducido ya existe en el sistema, desea actualizar sus datos?",
                                "Usuario existente",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question
                                );
                    if (r == DialogResult.No) return;
                    this.Usuario = username;
                    toUpdate = true;
                    this.txtnombre.Enabled = false;
                    enableControls(true);
                    this.txtnombrereal.Focus();
                }
                else
                {
                    toUpdate = false;
                    this.txtnombre.Enabled = false;
                    enableControls(true);
                    this.txtnombrereal.Focus();
                }
            }
        }

        private void enableControls(bool t)
        {
            this.txtnombrereal.Enabled = t;
            this.txtpass1.Enabled = t;
            this.txtpass2.Enabled = t;
            this.btnadd.Enabled = t;
            if(t == false)
            {
                txtnombre.Clear();
                txtnombrereal.Clear();
                txtpass1.Clear();
                txtpass2.Clear();
            }
        }

        private async void dgvbase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string userId = this.dgvbase.SelectedRows[0].Cells[0].Value.ToString();
                string userName = this.dgvbase.SelectedRows[0].Cells[1].Value.ToString();
                var r = MessageBox.Show(
                         $"Desea dar de baja al usuario {userName} ?",
                         "Confirmar",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question
                         );
                if (r == DialogResult.No) return;
                var baha = await usrCtrl.darDeBaja( Convert.ToInt32( userId ) );
                MessageBox.Show(
                    $"El usuario {userName} fue dado de baja con exito.",
                    "Exito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                await cargarusuarios();
                enableControls(false);
                txtnombre.Enabled = true;
                txtnombre.Focus();
            }
            catch (Exception)
            {
                return;
            }
        }

        private async void EmpleadosForm_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode == Keys.Escape)
            {
                var r = MessageBox.Show(
                         $"Reestablecer formulario ?",
                         "Confirmar",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question
                         );
                if (r == DialogResult.No) return;
                await cargarusuarios();
                enableControls(false);
                txtnombre.Enabled = true;
                txtnombre.Focus();
            }
        }
    }
}
