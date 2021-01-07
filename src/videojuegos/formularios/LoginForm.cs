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

namespace videojuegos.formularios
{
    public partial class LoginForm : Form
    {
        usuarioController usrCtrl = new usuarioController();
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnacceder_Click(object sender, EventArgs e)
        {
            this.btnacceder.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            var validate = await usrCtrl.verificarLogin(txtusuario.Text.Trim(), txtpass.Text.Trim());
            if( validate != null )
            {
                this.Hide();
                var menuForm = new MenuForm(validate).ShowDialog();
            }
            else
            {
                MessageBox.Show(
                    "El nombre de usuario o pass son incorrectas.",
                    "Credenciales incorrectas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            this.Cursor = Cursors.Default;
            this.btnacceder.Enabled = true;
        }
    }
}
