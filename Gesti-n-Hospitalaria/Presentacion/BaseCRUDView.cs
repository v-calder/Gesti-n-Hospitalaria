using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class BaseCRUDView : UserControl
    {
        public BaseCRUDView()
        {
            InitializeComponent();
        }

        // ====================================================================
        // PROPIEDADES PARA CAMBIAR TÍTULOS DESDE LAS VISTAS HIJAS
        // ====================================================================
        public string Titulo
        {
            get => lblTitulo.Text;
            set => lblTitulo.Text = value;
        }

        public string Subtitulo
        {
            get => lblSubtitulo.Text;
            set => lblSubtitulo.Text = value;
        }

        public string TotalRegistros
        {
            get => lblTotalRegistros.Text;
            set => lblTotalRegistros.Text = value;
        }

        public DataGridView TablaDatos
        {
            get => dgvDatos;
        }

        public void CambiarPestaña(int index)
        {
            if (index >= 0 && index < sarauI_TabControl1.TabCount)
            {
                sarauI_TabControl1.SelectedIndex = index;
            }
        }

        // ====================================================================
        //  ESTILIZAR GRID (SARA UI DESIGN)
        // ====================================================================
        protected void EstilizarGrid(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(93, 118, 173);

            // Cabecera del Grid (Azul Oscuro Corporativo)
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 28, 84);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 35;

            // Configuración de Celdas Normales
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(198, 211, 222);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 28, 84);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgv.GridColor = Color.FromArgb(222, 230, 238);
        }

        // ====================================================================
        // MÉTODOS DE LA PESTAÑA 1: CONSULTA
        // ====================================================================
        protected virtual void btnBuscar_Click(object sender, EventArgs e) { }
        protected virtual void btnLimpiar_Click(object sender, EventArgs e) { }
        protected virtual void btnImprimir_Click(object sender, EventArgs e) { }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Control panelContenedorPrincipal = this.Parent;
            if (panelContenedorPrincipal != null)
            {
                panelContenedorPrincipal.Controls.Remove(this);
                this.Dispose();
            }
        }

        // ====================================================================
        // Métodos de la Pestaña 2: Gestión (CRUD)
        // ====================================================================
        protected virtual void btnNuevo_Click(object sender, EventArgs e) { }
        protected virtual void btnGuardar_Click(object sender, EventArgs e) { }
        protected virtual void btnCancelar_Click(object sender, EventArgs e) { }
        protected virtual void btnEditar_Click(object sender, EventArgs e) { }
        protected virtual void btnEliminar_Click(object sender, EventArgs e) { }
    }
}