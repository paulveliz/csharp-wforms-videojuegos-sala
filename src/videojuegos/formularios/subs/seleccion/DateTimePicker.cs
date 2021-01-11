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
    public partial class DateTimePicker : Form
    {
        public DateTime Fecha1 { get; set; }
        public DateTime Fecha2 { get; set; }
        public DateTimePicker()
        {
            InitializeComponent();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                    "Generar con las fechas seleccionadas?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
            if (result == DialogResult.No) return;

            this.Fecha1 = fecha1.Value;
            this.Fecha2 = fecha2.Value;
            this.DialogResult = DialogResult.Yes;
        }
    }
}
