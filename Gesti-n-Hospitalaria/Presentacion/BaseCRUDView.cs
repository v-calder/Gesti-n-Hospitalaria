using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion {
    public partial class BaseCRUDView:UserControl {
        public BaseCRUDView() {
            InitializeComponent();
        }

        // ====================================================================
        // PROPIEDADES PARA CAMBIAR TÍTULOS DESDE LAS VISTAS HIJAS
        // ====================================================================
        public string Titulo {
            get => lblTitulo.Text;
            set => lblTitulo.Text = value;
        }

        public string Subtitulo {
            get => lblSubtitulo.Text;
            set => lblSubtitulo.Text = value;
        }

        public string TotalRegistros {
            get => lblTotalRegistros.Text;
            set => lblTotalRegistros.Text = value;
        }

        
        public DataGridView TablaDatos {
            get => dgvDatos;
        }

        public void CambiarPestaña(int index) {
            if(index >= 0 && index < sarauI_TabControl1.TabCount) {
                sarauI_TabControl1.SelectedIndex = index;
            }
        }

        // ====================================================================
        // MÉTODOS DE LA PESTAÑA 1: CONSULTA
        // ====================================================================
        protected virtual void btnBuscar_Click(object sender, EventArgs e) { }

        protected virtual void btnLimpiar_Click(object sender, EventArgs e) { }

        protected virtual void btnImprimir_Click(object sender, EventArgs e) { }

        //protected virtual void btnCerrar_Click(object sender, EventArgs e) { }
        private void btnCerrar_Click(object sender, EventArgs e) {
            // Remueve de forma dinámica este UserControl del panel contenedor del Dashboard
            Control panelContenedorPrincipal = this.Parent;
            if(panelContenedorPrincipal != null) {
                panelContenedorPrincipal.Controls.Remove(this);
                this.Dispose(); // Libera la memoria consumida por este control inmediatamente
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
