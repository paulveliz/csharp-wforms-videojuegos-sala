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

namespace videojuegos.formularios.subs.seleccion
{
    public partial class ClienteSelection : Form
    {
        clienteController cCtrl = new clienteController();
        public clientes Cliente { get; set; }
        public ClienteSelection()
        {
            InitializeComponent();
        }

        private async void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            var vj = await cCtrl.obtenerTodos();
            this.dgvbase.DataSource = vj.Where(v =>
               v.nombre.Contains(txtsearch.Text)
            ).ToList();
            encuadrarDgv();
        }

        private void encuadrarDgv()
        {
            this.dgvbase.Columns[0].Visible = false;
            this.dgvbase.Columns[1].HeaderText = "Nombre del cliente";
            this.dgvbase.Columns[2].Visible = false;
            this.dgvbase.Columns[3].Visible = false;
        }

        private async void ClienteSelection_Load(object sender, EventArgs e)
        {
            this.dgvbase.DataSource = await cCtrl.obtenerTodos();
            encuadrarDgv();
        }

        private void dgvbase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var cliente = (clientes)this.dgvbase.SelectedRows[0].DataBoundItem;
                var r = MessageBox.Show(
                    $"Desea seleccionar el cliente {cliente.nombre}",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (r == DialogResult.No) return;
                this.Cliente = cliente;
                this.DialogResult = DialogResult.Yes;
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
