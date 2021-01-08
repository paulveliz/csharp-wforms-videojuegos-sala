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
    }
}
