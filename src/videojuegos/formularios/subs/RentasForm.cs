using controllers;
using models;
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
    public partial class RentasForm : Form
    {
        rentaController rCtrl = new rentaController();
        public usuarios Usuario { get; set; }
        public clientes Cliente { get; set; }
        public models.db.videojuegos Videogame { get; set; }
        public Inventario VideojuegoInventario { get; set; }
        bool ExisteVideojuego = false;
        public RentasForm(usuarios usuario)
        {
            this.Usuario = usuario;
            InitializeComponent();
        }

        public void resetForm()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            this.txtempleado.Text = this.Usuario.nombre_real;
            ExisteVideojuego = false;
        }

        private void RentasForm_Load(object sender, EventArgs e)
        {
            this.txtempleado.Text = this.Usuario.nombre_real;
        }

        private void btnquit_Click(object sender, EventArgs e)
        {
            int cant = Convert.ToInt32(this.txtcant.Text);
            this.txtcant.Text = (cant + 1).ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int cant = Convert.ToInt32(this.txtcant.Text);
            this.txtcant.Text = cant == 1 ? cant.ToString() : (cant - 1).ToString();
        }

        private async void btnsearchvideojuego_Click(object sender, EventArgs e)
        {
            using (var frm = new seleccion.VideoJuegosSelection())
            {
                var result = frm.ShowDialog();
                if (result != DialogResult.Yes) return;

                var videojuegos = await new inventarioController().obtenerTodos();
                VideojuegoInventario = videojuegos.Where( v =>
                    v.Videojuego == frm.Videojuego.nombre
                ).FirstOrDefault();

                if(VideojuegoInventario.Existencias == 0)
                {
                    MessageBox.Show(
                        "El videojuego que desea rentar se encuentra agotado.",
                        "Agotado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                this.Videogame = frm.Videojuego;
                this.txtvideojuego.Text = this.Videogame.nombre;
                this.btnadd.Enabled = true;
                this.btnquit.Enabled = true;
            }
        }

        private void btnaddtocart_Click(object sender, EventArgs e)
        {
            if(txtvideojuego.Text.Length < 4)
            {
                MessageBox.Show(
                    "Debe seleccionar un videojuego para agregar ala cesta",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand
                );
                return;
            }

            if(Convert.ToInt32(this.txtcant.Text) > this.VideojuegoInventario.Existencias)
            {
                MessageBox.Show(
                    $"Solo se encuentran {this.VideojuegoInventario.Existencias} existencias de este videojuego en el inventario, por lo tanto no puede rentar mas de las existentes.",
                    "Sin existencias",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            foreach (DataGridViewRow row in this.dgvbase.Rows)
            {
                if(row.Cells[0].Value.ToString() == this.Videogame.id.ToString())
                {
                    ExisteVideojuego = true;
                    break;
                }
                else
                {
                    ExisteVideojuego = false;
                }
            }

            if (ExisteVideojuego)
            {
                MessageBox.Show(
                    $"El videojuego ya se encuentra en la cesta.",
                    "Producto no disponible",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            double importePorProducto = ( Convert.ToDouble(this.txtcant.Text) * (double)this.Videogame.precio );
            double total = Convert.ToDouble(this.txttotal.Text) + importePorProducto;
            this.dgvbase.Rows.Add($"{this.Videogame.id}", $"{this.Videogame.nombre}", $"{this.txtcant.Text}", $"{importePorProducto}");

            this.txttotal.Text = total.ToString();
        }

        private void dgvbase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.dgvbase.Rows.Remove(this.dgvbase.SelectedRows[0]);
            }
            catch (Exception)
            {
                return;
            }
        }

        private async void btnfinalizar_Click(object sender, EventArgs e)
        {
            if(dgvbase.Rows.Count < 1)
            {
                MessageBox.Show(
                    "No hay videojuegos en la cesta",
                    "Sin elementos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand
                );
                return;
            }

            if (txtcliente.Text.Length < 4)
            {
                MessageBox.Show(
                    "No ha seleccionado un cliente",
                    "Sin cliente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand
                );
                return;
            }

            var r = MessageBox.Show(
                        "Desea realizar la renta?",
                        "Confirmar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
            if (r == DialogResult.No) return;

            var renta = new rentas
            {
               cliente_id = this.Cliente.id,
               usuario_id = this.Usuario.id,
               fecha = Convert.ToDateTime( DateTime.Now.ToString("d") ),
               estatus = 1,
               total = (decimal)Convert.ToDouble(this.txttotal.Text)
            };

            List<rentas_detalles> detalles = new List<rentas_detalles>();
            foreach (DataGridViewRow row in this.dgvbase.Rows)
            {
                detalles.Add(new rentas_detalles 
                {
                    videojuego_id = Convert.ToInt32( row.Cells[0].Value.ToString() ),
                    cantidad = Convert.ToInt32( row.Cells[2].Value.ToString() ),
                    importe =  (decimal)Convert.ToDouble( row.Cells[3].Value.ToString() ),
                    estatus = 1,
                });
            }

            var newRenta = await rCtrl.crearNueva(renta, detalles);
            if(newRenta != null)
            {
                MessageBox.Show(
                        "La renta fue exitosa\nImprimir ticket?",
                        "Operacion exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                resetForm();
            }
            else
            {
                MessageBox.Show(
                    "La renta no se pudo realizar",
                    "Error de base de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand
                );
            }

        }

        private void btnsearchclient_Click(object sender, EventArgs e)
        {
            using (var frm = new seleccion.ClienteSelection())
            {
                var result = frm.ShowDialog();
                if (result != DialogResult.Yes) return;
                this.Cliente = frm.Cliente;
                this.txtcliente.Text = this.Cliente.nombre;
                this.btnadd.Enabled = true;
                this.btnquit.Enabled = true;
            }
        }
    }
}
