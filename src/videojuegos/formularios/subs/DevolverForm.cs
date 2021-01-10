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

namespace videojuegos.formularios.subs
{
    public partial class DevolverForm : Form
    {
        rentaController rCtrl = new rentaController();
        public DevolverForm()
        {
            InitializeComponent();
        }

        private async void btnrecibir_Click(object sender, EventArgs e)
        {
            try
            {
                var renta = await rCtrl.obtenerPorId(Convert.ToInt32(txtfolio.Text));
                if(renta.Renta == null)
                {
                    var r = MessageBox.Show(
                       "La renta introducida no existe",
                       "Renta invalida",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Hand
                       );
                    return;
                }

                if(renta.Renta.Estatus == 0)
                {
                    var r = MessageBox.Show(
                       "La renta introducida ya fue recibida.",
                       "Alerta",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Hand
                       );
                    return;
                }

                var result = MessageBox.Show(
                                    $"La renta pertenece al cliente:\n{renta.Renta.Cliente}\n" +
                                    $"Fecha:\n {renta.Renta.Fecha.ToString("d")}\n" +
                                    $"Desea recibirla?",
                                    "Recibir renta",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question
                                );
                if (result == DialogResult.No) return;

                var devolverRenta = await rCtrl.recibirRenta(renta.Renta.Id);
                if(devolverRenta.Renta != null)
                {
                    var r = MessageBox.Show(
                            "Renta recibida con exito\nDesea imprimir el comprobante?",
                            "Imprimir comprobante",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                            );
                    if(r == DialogResult.No )
                    {
                        this.DialogResult = DialogResult.No;
                        // this.close
                        return;
                    }

                    // Imprimir comprobante
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    MessageBox.Show(
                        "Error al intentar recibir la renta verifique los datos.",
                        "Error de base de datos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Hand
                    );
                    this.DialogResult = DialogResult.No;
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
