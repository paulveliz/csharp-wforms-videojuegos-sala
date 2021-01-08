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
    public partial class ClientesForm : Form
    {
        clienteController clCtrl = new clienteController();
        bool toUpdate = false;
        public clientes Cliente { get; set; }
        public ClientesForm()
        {
            InitializeComponent();
        }

        private async void ClientesForm_Load(object sender, EventArgs e)
        {
            await cargarClientes();
        }

        private async Task cargarClientes()
        {
            this.dgvbase.DataSource = await clCtrl.obtenerTodos();
            this.dgvbase.Columns[0].Visible = false;
            this.dgvbase.Columns[1].HeaderText = "Nombre del cliente";
            this.dgvbase.Columns[2].Visible = false;
            this.dgvbase.Columns[3].Visible = false;
        }

        private async void txtcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                if(txtcliente.Text.Length < 4)
                {
                    MessageBox.Show(
                            "El cliente debe tener al menos 4 caracteres de longitud.",
                            "Datos incorrectos",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    return;
                }

                // Verificar si el cliente ya existe
                var cliente = await clCtrl.verificarNombre(txtcliente.Text.Trim());
                if(cliente != null)
                {
                    var c = MessageBox.Show(
                                "El cliente introducido ya existe en el sistema, desea actualizar su informacion?",
                                "Cliente existente",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question
                            );
                    if (c == DialogResult.No) return;
                    toUpdate = true;
                    this.button1.Enabled = true;
                    this.button1.Text = "Actualizar";
                    this.txtcliente.Focus();
                    this.Cliente = cliente;
                }
                else
                {
                    toUpdate = false;
                    this.button1.Enabled = true;
                    this.txtcliente.Enabled = false;
                    this.button1.Focus();
                    this.button1.Text = "Agregar";
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (toUpdate)
            {
                var updatedCliente = await clCtrl.actualizar(new clientes
                {
                    id = Cliente.id,
                    estatus = 1,
                    nombre = this.txtcliente.Text.Trim()
                });

                if (updatedCliente != null)
                {
                    MessageBox.Show(
                        "El cliente fue actualizado con exito.",
                        "Exito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    this.txtcliente.Clear();
                    this.txtcliente.Focus();
                    this.txtcliente.Enabled = true;
                    this.button1.Enabled = false;
                    await cargarClientes();
                }
                else
                {
                    MessageBox.Show(
                        "Ocurrio un error intentando actualizar el cliente,",
                        "Error base de datos.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            else
            {
                var c = MessageBox.Show(
                    $"Desea agregar al cliente {this.txtcliente.Text.ToUpper()} al sistema?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (c == DialogResult.No) return;
                var newCl = await clCtrl.crearNuevo(new clientes
                {
                    nombre = this.txtcliente.Text.Trim().ToUpper(),
                    estatus = 1
                });

                if (newCl != null)
                {
                    MessageBox.Show(
                        "El cliente fue agregado con exito.",
                        "Exito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    this.txtcliente.Clear();
                    this.txtcliente.Focus();
                    this.button1.Enabled = false;
                    this.txtcliente.Enabled = true;
                    await cargarClientes();
                }
                else
                {
                    MessageBox.Show(
                        "Ocurrio un error intentando actualizar el cliente,",
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
                int clienteId = Convert.ToInt32( this.dgvbase.SelectedRows[0].Cells[0].Value.ToString() );
                string clienteNombre = this.dgvbase.SelectedRows[0].Cells[1].Value.ToString();
                var c = MessageBox.Show(
                    $"Desea dar de baja al cliente {clienteNombre} del sistema?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (c == DialogResult.No) return;
                var deleted = await clCtrl.darDeBaja(clienteId);
                if (deleted != null)
                {
                    MessageBox.Show(
                        "El cliente fue dado de baja con exito.",
                        "Exito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    await cargarClientes();
                }
                else
                {
                    MessageBox.Show(
                        "Ocurrio un error intentando dar de baja el cliente,",
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

        private async void ClientesForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                var c = MessageBox.Show(
                    $"Restablecer formulario?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (c == DialogResult.No) return;
                this.txtcliente.Clear();
                this.button1.Enabled = false;
                this.txtcliente.Enabled = true;
                await cargarClientes();
                this.txtcliente.Focus();
            }
        }
    }
}
