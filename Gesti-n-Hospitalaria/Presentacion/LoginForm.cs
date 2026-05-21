using Entidad;
using Negocio;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Presentacion
{
    public partial class LoginForm : Form
    {

        private readonly UsuarioNegocio negocioUsuario = new UsuarioNegocio();


        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                string txtUser = txtUsuario.Text;
                string txtPass = txtContrasena.Text;

                UsuarioEntity usuarioLogueado = negocioUsuario.AutenticarUsuario(txtUser, txtPass);

                if (usuarioLogueado != null)
                {
                    MessageBox.Show($"¡Bienvenido {usuarioLogueado.NombreUsuario}! Acceso concedido.",
                        "Sistema Hospitalario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Sesion.CodigoUsuario = usuarioLogueado.CodigoUsuario;
                    Sesion.NombreUsuario = usuarioLogueado.NombreUsuario;
                    // Mapeo básico del rol según su código
                    Sesion.CodigoRol = usuarioLogueado.CodigoRol;
                    Sesion.NombreRol = usuarioLogueado.CodigoRol == 1 ? "Administrador" :
                                       usuarioLogueado.CodigoRol == 2 ? "Médico" : "Recepcionista";

                

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas o usuario inactivo.",
                        "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void limpiarCampos()
        {
            txtContrasena.Text = "";
            if (!chkRecordarme.Checked) txtUsuario.Text = "";
        }
    }
}

