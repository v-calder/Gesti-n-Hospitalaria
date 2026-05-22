using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Entidad;
using Sara_UI_Design.SaraControls;

namespace Presentacion
{
    public partial class DashboardForm : Form
    {

        // DLLs nativas de Windows para permitir el arrastre de un formulario sin bordes (Borderless)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Variables de diseño para el control de botones
        private Color colorFondoBotonNormal = Color.FromArgb(12, 50, 132);
        private Color colorFondoBotonActivo = Color.FromArgb(2, 30, 87);

        public DashboardForm()
        {
            InitializeComponent();
            ConfiguracionInicial();
        }

        private void ConfiguracionInicial()
        {

            // Evita tapar la barra de tareas de Windows al maximizar
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            lblNombreUsuario.Text = Sesion.NombreUsuario;
            lblRol.Text = Sesion.NombreRol;

            lblFecha.Text = DateTime.Now.ToString("dd - MMMM - yyyy");

            // Ocultar el rectángulo indicador de 4px al arrancar
            panelIndicador.Height = 0;
        }

        #region Movimiento de Ventana
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            // Permite arrastrar el formulario desde tu barra de títulos azul superior
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region --- LÓGICA Y HOVER: BOTÓN CERRAR ---

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btn_BotonCerrar.Image = Properties.Resources.btn_cerrar_hover;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btn_BotonCerrar.Image = Properties.Resources.btn_cerrar;
        }

        #endregion

        #region --- LÓGICA Y HOVER: BOTÓN MINIMIZAR ---

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            btn_BotonMinimizar.Image = Properties.Resources.btn_minimizar_hover;
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btn_BotonMinimizar.Image = Properties.Resources.btn_minimizar;
        }

        #endregion

        #region --- LÓGICA Y HOVER: BOTÓN MAXIMIZAR / RESTAURAR ---

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                // Al maximizarse, el puntero sigue encima, por lo que asignamos el hover de restaurar inmediatamente
                btn_BotonRestaurar.Image = Properties.Resources.btn_restaurar_hover;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                // Al restaurarse, el puntero sigue encima, asignamos el hover de maximizar de una vez
                btn_BotonRestaurar.Image = Properties.Resources.btn_maximizar_hover;
            }
        }

        private void btnMaximizar_MouseEnter(object sender, EventArgs e)
        {
            // Validamos el estado de la ventana para saber qué imagen "hover" mostrar
            if (this.WindowState == FormWindowState.Maximized)
            {
                btn_BotonRestaurar.Image = Properties.Resources.btn_restaurar_hover;
            }
            else
            {
                btn_BotonRestaurar.Image = Properties.Resources.btn_maximizar_hover;
            }
        }

        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            // Validamos el estado de la ventana al salir el mouse para regresar a la imagen base correcta
            if (this.WindowState == FormWindowState.Maximized)
            {
                btn_BotonRestaurar.Image = Properties.Resources.btn_restaurar;
            }
            else
            {
                btn_BotonRestaurar.Image = Properties.Resources.btn_maximizar;
            }
        }

        #endregion

        #region Motor de Navegación del Menú Lateral (Sidebar)
        private void AbrirVistaEnContenedor(UserControl vistaControl)
        {
            if (panelContenedor.Controls.Count > 0)
                panelContenedor.Controls.RemoveAt(0);

            vistaControl.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(vistaControl);
            panelContenedor.Tag = vistaControl;
            vistaControl.Show();
        }

        private void ActivarBotonMenu(object botonSender)
        {
            if (botonSender != null)
            {
                // Resetear todos los botones dentro del panel del menú lateral
                foreach (Control item in panelMenuLateral.Controls)
                {
                    if (item is Button)
                    {
                        item.BackColor = colorFondoBotonNormal;
                    }
                }

                // Aplicar estilo activo al seleccionado
                Button btnSeleccionado = (Button)botonSender;
                btnSeleccionado.BackColor = colorFondoBotonActivo;

                // Mover y ajustar el rectángulo de 4px (panelIndicador) al botón activo
                panelIndicador.Height = btnSeleccionado.Height;
                panelIndicador.Top = btnSeleccionado.Top;
                panelIndicador.Visible = true;
            }
        }

        // --- EVENTOS CLICK DEL MENÚ ---
        private void btnPacientes_Click(object sender, EventArgs e)
        {
            ActivarBotonMenu(sender);
            // Reemplaza 'PacientesView' por el nombre del UserControl que creará el Integrante 1
            // AbrirVistaEnContenedor(new PacientesView()); 
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            ActivarBotonMenu(sender);
            // AbrirVistaEnContenedor(new MedicosView());
        }

        private void btnAtenciones_Click(object sender, EventArgs e)
        {
            ActivarBotonMenu(sender);
        }

        private void btnSanatorios_Click(object sender, EventArgs e)
        {
            ActivarBotonMenu(sender);
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            ActivarBotonMenu(sender);
        }
        #endregion

        #region Lógica de Cierre de Sesión
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cerrar la sesión?",
                "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Buscar el formulario de Login que dejamos oculto en memoria
                LoginForm login = (LoginForm)Application.OpenForms["LoginForm"];

                if (login != null)
                {
                    // La limpieza de campos
                    login.limpiarCampos();
                    login.Show();
                }

                this.Dispose(); // Libera los recursos del Dashboard de inmediato
            }
        }
        #endregion

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
