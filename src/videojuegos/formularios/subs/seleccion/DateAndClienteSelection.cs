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
    public partial class DateAndClienteSelection : Form
    {
        clienteController usr = new clienteController();
        public clientes Cliente { get; set; }
        public DateTime Fecha1 { get; set; }
        public DateTime Fecha2 { get; set; }
        public DateAndClienteSelection()
        {
            InitializeComponent();
        }

        private async void DateAndClienteSelection_Load(object sender, EventArgs e)
        {
            this.cbox.DataSource = await usr.obtenerTodos();
            this.cbox.DisplayMember = "nombre";
            this.cbox.ValueMember = "id";
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show(
                "Generar reporte con el cliente seleccionado?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (r == DialogResult.No) return;

            this.Cliente = (clientes)this.cbox.SelectedItem;
            this.DialogResult = DialogResult.Yes;
            this.Fecha1 = this.fecha1.Value;
            this.Fecha2 = this.fecha2.Value;
        }
    }
}
