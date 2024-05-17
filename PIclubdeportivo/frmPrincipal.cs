using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIclubdeportivo
{
    public partial class frmPrincipal : Form
    {
        internal string rol = Datos.Sesion.Rol;
        internal string usuario = Datos.Sesion.Usuario;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
        }

        private void btnSalirNav_Click(object sender, EventArgs e)
        {
            // Cierra la ventana de la aplicación
            Application.Exit();
        }

        private void btnRegistrarC_Click(object sender, EventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            registro.Show();
            this.Hide();
        }
    }
}
