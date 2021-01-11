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
    public partial class DateAndObjectPicker : Form
    {
        usuarioController usr = new usuarioController();
        public usuarios Empleado { get; set; }
        public DateTime Fecha1 { get; set; }
        public DateTime Fecha2 { get; set; }
        public DateAndObjectPicker()
        {
            InitializeComponent();
        }

        private async void DateAndObjectPicker_Load(object sender, EventArgs e)
        {
            this.cbox.DataSource = await usr.obtenerTodos();
            this.cbox.DisplayMember = "nombre_real";
            this.cbox.ValueMember = "id";
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show(
                    "Generar reporte con el empleado seleccionado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
            if (r == DialogResult.No) return;

            this.Empleado = (usuarios)this.cbox.SelectedItem;
            this.DialogResult = DialogResult.Yes;
            this.Fecha1 = this.fecha1.Value;
            this.Fecha2 = this.fecha2.Value;
        }
    }
}
