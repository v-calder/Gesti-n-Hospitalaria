using System;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace Presentacion {
    public partial class SegurosMedicosView:BaseCRUDView {
        private readonly SegurosMedicosNegocio negocioSeguro = new SegurosMedicosNegocio();
        private bool esEdicion = false;

        public SegurosMedicosView() {
            InitializeComponent();
            ConfigurarVista();
            CargarGrid("");
        }

        private void ConfigurarVista() {
            this.Titulo = "Control de Seguros Médicos";
            this.Subtitulo = "Módulo financiero para la administración de pólizas y convenios de salud";

            cmbTipo.Items.AddRange(new string[] { "Básico", "Intermedio", "Premium" });
            cmbTipo.SelectedIndex = 0;
            txtCodigo.Enabled = false;

            // RANGOS NUMÉRICOS
            numMaximo.Minimum = 0;
            numMaximo.Maximum = 999999999;
            numMaximo.DecimalPlaces = 2;
            numMaximo.Increment = 100;

            numCobertura.Minimum = 0;
            numCobertura.Maximum = 100;
            numCobertura.DecimalPlaces = 2;

            // INYECTAR COLUMNA ACCIONES EN GRID
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

            // Arrancar en estado de reposo inicial
            EstadoBotonesYCampos(operacionActiva: false, registroNuevo: false);
        }

        // ====================================================================
        //  ESTADO DE LOS CONTROLES
        // ====================================================================
        private void EstadoBotonesYCampos(bool operacionActiva, bool registroNuevo) {
            // Control de Cajas de Texto y selectores
            txtNombre.Enabled = operacionActiva;
            cmbTipo.Enabled = operacionActiva;
            numCobertura.Enabled = operacionActiva;
            numMaximo.Enabled = operacionActiva;
            txtTelefono.Enabled = operacionActiva;
            txtDireccion.Enabled = operacionActiva;
            txtCorreo.Enabled = operacionActiva;
            chkEstado.Enabled = operacionActiva;

            // Control de Botones del CRUD
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
                    // Creando un registro desde cero
                    btnGuardar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                } else {
                    // Editando un registro existente cargado desde el Grid
                    btnGuardar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                }
            }
        }

        private void CargarGrid(string filtro) {
            try {
                dgvDatos.DataSource = negocioSeguro.BuscarSeguros(filtro);
                lblTotalRegistros.Text = $"Total registros: {dgvDatos.Rows.Count}";
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if(dgvDatos.Columns[e.ColumnIndex].Name == "ColEditar") {
                esEdicion = true;
                DataGridViewRow filaActual = dgvDatos.Rows[e.RowIndex];

                // PASAR CAMPOS DESDE EL GRID
                txtCodigo.Text = filaActual.Cells["CodigoSeguro"].Value.ToString();
                txtNombre.Text = filaActual.Cells["NombreSeguro"].Value.ToString();
                cmbTipo.Text = filaActual.Cells["TipoSeguro"].Value.ToString();
                numCobertura.Value = Convert.ToDecimal(filaActual.Cells["PorcentajeCobertura"].Value);
                numMaximo.Value = Convert.ToDecimal(filaActual.Cells["MontoMaximo"].Value);
                txtTelefono.Text = filaActual.Cells["Telefono"].Value.ToString();
                txtDireccion.Text = filaActual.Cells["Direccion"].Value.ToString();
                txtCorreo.Text = filaActual.Cells["CorreoContacto"].Value?.ToString() ?? "";
                chkEstado.Checked = Convert.ToBoolean(filaActual.Cells["Estado"].Value);

                // Activar modo edición sobre fila existente (Inhabilita guardar, habilita editar)
                EstadoBotonesYCampos(operacionActiva: true, registroNuevo: false);
                this.CambiarPestaña(1);
            }
        }

        private void LimpiarFormulario() {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            numCobertura.Value = 0;
            numMaximo.Value = 0;
            chkEstado.Checked = true;
        }

        // ====================================================================
        //  SOBRESCRITURA DE LOGICA DE BOTONES
        // ====================================================================

        protected override void btnBuscar_Click(object sender, EventArgs e) {
            CargarGrid(txtBuscar.Text);
        }

        protected override void btnLimpiar_Click(object sender, EventArgs e) {
            txtBuscar.Text = "";
            CargarGrid("");
        }

        protected override void btnNuevo_Click(object sender, EventArgs e) {
            esEdicion = false;
            LimpiarFormulario();
            // Pasa a modo activo para registro NUEVO (Habilita guardar, inhabilita editar)
            EstadoBotonesYCampos(operacionActiva: true, registroNuevo: true);
            this.CambiarPestaña(1);
        }

        protected override void btnCancelar_Click(object sender, EventArgs e) {
            esEdicion = false;
            LimpiarFormulario();
            // Regresa a estado de reposo
            EstadoBotonesYCampos(operacionActiva: false, registroNuevo: false);
            this.CambiarPestaña(0); // Devuelve al usuario a la pestaña de Consulta
        }

        protected override void btnGuardar_Click(object sender, EventArgs e) {
            ProcesarTransaccion(esCambioEdicion: false);
        }

        protected override void btnEditar_Click(object sender, EventArgs e) {
            ProcesarTransaccion(esCambioEdicion: true);
        }

        private void ProcesarTransaccion(bool esCambioEdicion) {
            var seguro = new SegurosMedicosEntity {
                CodigoSeguro = string.IsNullOrEmpty(txtCodigo.Text) ? 0 : Convert.ToInt32(txtCodigo.Text),
                NombreSeguro = txtNombre.Text,
                TipoSeguro = cmbTipo.Text,
                PorcentajeCobertura = numCobertura.Value,
                MontoMaximo = numMaximo.Value,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                CorreoContacto = txtCorreo.Text,
                Estado = chkEstado.Checked
            };

            string resultado = negocioSeguro.GuardarSeguro(seguro, esCambioEdicion);

            if(resultado == "OK") {
                MessageBox.Show("¡Información guardada exitosamente en el sistema!", "Sistema Hospitalario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                EstadoBotonesYCampos(operacionActiva: false, registroNuevo: false);
                CargarGrid("");
                this.CambiarPestaña(0);
            } else {
                MessageBox.Show(resultado, "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected override void btnEliminar_Click(object sender, EventArgs e) {
            // Validamos que haya una fila seleccionada en el DataGridView
            if(dgvDatos.CurrentRow != null) {
                int id = Convert.ToInt32(dgvDatos.CurrentRow.Cells["CodigoSeguro"].Value);
                string nombre = dgvDatos.CurrentRow.Cells["NombreSeguro"].Value.ToString();

                // Ventana de confirmación
                DialogResult result = MessageBox.Show($"¿Está seguro de que desea dar de baja el seguro '{nombre}'?",
                    "Confirmación de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes) {
                    if(negocioSeguro.DarBajaSeguro(id)) {
                        MessageBox.Show("El seguro ha sido desactivado correctamente del sistema.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // === LIMPIEZA Y RETORNO ===
                        LimpiarFormulario();
                        EstadoBotonesYCampos(operacionActiva: false, registroNuevo: false);
                        CargarGrid("");

                        this.CambiarPestaña(0);
                    } else {
                        MessageBox.Show("No se pudo realizar la eliminación en la base de datos.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } else {
                MessageBox.Show("Por favor, seleccione una fila de la tabla para poder eliminarla.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}