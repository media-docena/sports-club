using PIclubdeportivo.Entidades;
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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
            cboTipoC.Items.Add("Socio");
            cboTipoC.Items.Add("No Socio");
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            if (txtNombreC.Text == "" || txtApellidoC.Text == "" || txtTelC.Text == ""
                || txtCorreoC.Text == "" || cboTipoC.Text == "" || txtDNIC.Text == "") {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                string respuesta;
                E_Cliente cliente;

                string nombre = txtNombreC.Text;
                string apellido = txtApellidoC.Text;
                int tel = Convert.ToInt32(txtTelC.Text);
                string correo = txtCorreoC.Text;
                string tipoCliente = cboTipoC.Text;
                string DNI = txtDNIC.Text;

                if (tipoCliente.ToLower() == "socio") {
                    cliente = new E_Socio(nombre, apellido, DNI, tel, correo, tipoCliente, true);
                } else {
                    cliente = new E_No_Socio(nombre, apellido, DNI, tel, correo, tipoCliente, true);
                }

                //E_Cliente cliente = new E_Cliente(nombre, apellido, DNI, tel, correo, tipoCliente, true);

                // instanciamos para usar el metodo dentro de clientes
                Datos.Clientes clientes = new Datos.Clientes();
                respuesta = clientes.Nuevo_Cliente(cliente);

                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero) {
                    if (codigo == 1) {
                        MessageBox.Show("CLIENTE YA EXISTE", "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    else {
                        MessageBox.Show("Se almacenó con éxito con el codigo Nro  " + respuesta, "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnVolverRegC_Click(object sender, EventArgs e)
        {
            // Permite retornar al formulario principal
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreC.Text = "";
            txtApellidoC.Text = "";
            txtTelC.Text = "";
            txtCorreoC.Text = "";
            txtDNIC.Text = "";
            cboTipoC.Text = "";
            txtNombreC.Focus();
        }
    }
}
