using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIclubdeportivo
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
            this.KeyPreview = true; // Permite al formulario capturar eventos de teclas
            this.KeyPress += new KeyPressEventHandler(frmLogin_KeyPress);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private void picCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pnlCentro.Location = new Point(
                this.ClientSize.Width / 2 - pnlCentro.Size.Width / 2,
                this.ClientSize.Height / 2 - pnlCentro.Size.Height / 2);
            pnlCentro.Anchor = AnchorStyles.None;

            pnlCentro.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlCentro.Width, pnlCentro.Height, 30, 30));
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            // Este evento se ejecuta al llegar el foco, "on focus", al textbox
            if (txtUsuario.Text == "USUARIO") {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            // Este evento se ejecuta al irse el foco del textbox
            if (txtUsuario.Text == "") {
                txtUsuario.Text = "USUARIO";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA") {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "") {
                txtPass.Text = "CONTRASEÑA";
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            Datos.Usuarios dato = new Datos.Usuarios(); // variable que contiene todas las caracteristicas de la clase
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);
            if (tablaLogin.Rows.Count > 0) {
                // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
                MessageBox.Show("Ingreso exitoso", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // La siguiente línea permite tomar el dominio de la primera columna
                // de la primera fila del resultado de la ejecucion de la query

                Datos.Sesion.Rol = Convert.ToString(tablaLogin.Rows[0][0]);
                Datos.Sesion.Usuario = Convert.ToString(txtUsuario.Text);

                /*
                 Una vez que tenemos la conexion establecida PASAMOS al formulario PRINCIPAL
                 Se debe "Instanciar" un objeto de la clase formulario principal
                 */
                frmPrincipal principal = new frmPrincipal();
                principal.Show(); // se llama al formulario principal
                this.Hide(); // se oculta el formulario del login

            }
            else {
                MessageBox.Show("Usuario y/o password incorrecto", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) {
                btnIngresar.PerformClick(); // Ejecuta el clic del botón
                e.Handled = true; // Evita que el evento se propague
            }
        }
    }

}
