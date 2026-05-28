using System;
using System.Drawing;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace Presentacion {
    public partial class PacientesView:BaseCRUDView {
        private readonly PacientesNegocio negocioPaciente = new PacientesNegocio();
        private bool esEdicion = false;

        public PacientesView() {
            InitializeComponent();
            ConfigurarVista();
            CargarGrid("");
        }

        private void ConfigurarVista() {

            // Aplicar el mismo patron de colores de Sara_UI_Design
            this.EstilizarGrid(dgvDatos);

            cmbGenero.Items.AddRange(new string[] { "Masculino", "Femenino" });
            cmbGenero.SelectedIndex = 0;

            txtCodigo.Enabled = false;
            txtEdad.Enabled = false;

            // INYECTAR COLUMNA ACCIONES
            DataGridViewButtonColumn colEditar = new DataGridViewButtonColumn();
            colEditar.Name = "ColEditar";
            colEditar.HeaderText = "Acciones";
            colEditar.Text = "Editar ✏️";
            colEditar.UseColumnTextForButtonValue = true;
            colEditar.FlatStyle = FlatStyle.Flat;
            colEditar.DefaultCellStyle.BackColor = Color.FromArgb(0, 28, 84);
            colEditar.DefaultCellStyle.ForeColor = Color.White;
            colEditar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 140, 128);
            colEditar.Width = 90;

            dgvDatos.Columns.Insert(0, colEditar);
            dgvDatos.CellClick += dgvDatos_CellClick;
            dgvDatos.CellFormatting += dgvDatos_CellFormatting;

            AplicarSeguridadPorRol();
        }

        private void AplicarSeguridadPorRol() {
            if(Sesion.CodigoRol != 1) {
                dgvDatos.Columns["ColEditar"].Visible = false;
                btnNuevo.Visible = false;
                btnGuardar.Visible = false;
                btnEditar.Visible = false;
                btnEliminar.Visible = false;
                btnCancelar.Visible = false;
                sarauI_TabControl1.TabPages.Remove(tabPage2);
            } else {
                EstadoBotonesYCampos(operacionActiva: false, registroNuevo: false);
            }
        }

        private void dgvDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if(dgvDatos.Columns[e.ColumnIndex].Name == "Estado" && e.Value != null) {
                if(!Convert.ToBoolean(e.Value)) {
                    dgvDatos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(225, 228, 232);
                    dgvDatos.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(140, 150, 165);
                    dgvDatos.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Strikeout | FontStyle.Italic);
                }
            }
        }

        private void EstadoBotonesYCampos(bool operacionActiva, bool registroNuevo) {
            if(Sesion.CodigoRol != 1)
                return;

            txtNombre.Enabled = operacionActiva;
            txtApellido.Enabled = operacionActiva;
            txtDpi.Enabled = operacionActiva;
            dtpFechaNacimiento.Enabled = operacionActiva;
            cmbGenero.Enabled = operacionActiva;
            txtTelefono.Enabled = operacionActiva;
            txtDireccion.Enabled = operacionActiva;
            chkEstado.Enabled = operacionActiva;

            if(!operacionActiva) {
                btnNuevo.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = false;
            } else {
                btnNuevo.Enabled = false;
                btnCancelar.Enabled = true;

                if(registroNuevo) {
                    btnGuardar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                } else {
                    btnGuardar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                }
            }
        }

        private void CargarGrid(string filtro) {
            try {
                dgvDatos.DataSource = negocioPaciente.BuscarPacientes(filtro);
                lblTotalRegistros.Text = $"Total registros: {dgvDatos.Rows.Count}";
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if(Sesion.CodigoRol != 1)
                return;

            if(dgvDatos.Columns[e.ColumnIndex].Name == "ColEditar") {
                esEdicion = true;
                DataGridViewRow filaActual = dgvDatos.Rows[e.RowIndex];

                txtCodigo.Text = filaActual.Cells["CodigoPaciente"].Value.ToString();
                txtNombre.Text = filaActual.Cells["Nombre"].Value.ToString();
                txtApellido.Text = filaActual.Cells["Apellido"].Value.ToString();
                txtDpi.Text = filaActual.Cells["Dpi"].Value.ToString();
                dtpFechaNacimiento.Value = Convert.ToDateTime(filaActual.Cells["FechaNacimiento"].Value);
                cmbGenero.Text = filaActual.Cells["Genero"].Value.ToString();
                txtTelefono.Text = filaActual.Cells["Telefono"].Value.ToString();
                txtDireccion.Text = filaActual.Cells["Direccion"].Value.ToString();
                txtEdad.Text = filaActual.Cells["Edad"].Value.ToString();
                chkEstado.Checked = Convert.ToBoolean(filaActual.Cells["Estado"].Value);

                EstadoBotonesYCampos(operacionActiva: true, registroNuevo: false);
                this.CambiarPestaña(1);
            }
        }

        private void LimpiarFormulario() {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDpi.Text = "";
            dtpFechaNacimiento.Value = DateTime.Today;
            cmbGenero.SelectedIndex = 0;
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEdad.Text = "";
            chkEstado.Checked = true;
        }

        protected override void btnBuscar_Click(object sender, EventArgs e) { CargarGrid(txtBuscar.Text); }
        protected override void btnLimpiar_Click(object sender, EventArgs e) { txtBuscar.Text = ""; CargarGrid(""); }
        protected override void btnNuevo_Click(object sender, EventArgs e) { esEdicion = false; LimpiarFormulario(); EstadoBotonesYCampos(operacionActiva: true, registroNuevo: true); this.CambiarPestaña(1); }
        protected override void btnCancelar_Click(object sender, EventArgs e) { esEdicion = false; LimpiarFormulario(); EstadoBotonesYCampos(operacionActiva: false, registroNuevo: false); this.CambiarPestaña(0); }
        protected override void btnGuardar_Click(object sender, EventArgs e) { ProcesarTransaccion(esCambioEdicion: false); }
        protected override void btnEditar_Click(object sender, EventArgs e) { ProcesarTransaccion(esCambioEdicion: true); }

        private void ProcesarTransaccion(bool esCambioEdicion) {
            var paciente = new PacientesEntity {
                CodigoPaciente = string.IsNullOrEmpty(txtCodigo.Text) ? 0 : Convert.ToInt32(txtCodigo.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Dpi = string.IsNullOrEmpty(txtDpi.Text) ? 0 : Convert.ToInt64(txtDpi.Text),
                FechaNacimiento = dtpFechaNacimiento.Value,
                Genero = cmbGenero.Texts,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                Estado = chkEstado.Checked
            };

            string resultado = negocioPaciente.GuardarPaciente(paciente, esCambioEdicion);

            if(resultado == "OK") {
                MessageBox.Show("¡Paciente registrado/actualizado con éxito!", "Sistema Hospitalario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                EstadoBotonesYCampos(operacionActiva: false, registroNuevo: false);
                CargarGrid("");
                this.CambiarPestaña(0);
            } else {
                MessageBox.Show(resultado, "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected override void btnEliminar_Click(object sender, EventArgs e) {
            if(dgvDatos.CurrentRow != null) {
                int id = Convert.ToInt32(dgvDatos.CurrentRow.Cells["CodigoPaciente"].Value);
                string nombreCompleto = $"{dgvDatos.CurrentRow.Cells["Nombre"].Value} {dgvDatos.CurrentRow.Cells["Apellido"].Value}";

                DialogResult result = MessageBox.Show($"¿Desea dar de baja al paciente '{nombreCompleto}'?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes) {
                    if(negocioPaciente.DarBajaPaciente(id)) {
                        MessageBox.Show("Paciente desactivado correctamente.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                        EstadoBotonesYCampos(operacionActiva: false, registroNuevo: false);
                        CargarGrid("");
                        this.CambiarPestaña(0);
                    }
                }
            }
        }
    }
}