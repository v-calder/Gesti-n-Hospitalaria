namespace Presentacion {
    partial class SanatoriosView {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            panel2 = new Panel();
            txtCodigo = new Sara_UI_Design.SaraControls.SaraUI_TextBox();
            label1 = new Label();
            panel3 = new Panel();
            txtNombre = new Sara_UI_Design.SaraControls.SaraUI_TextBox();
            label2 = new Label();
            panel4 = new Panel();
            txtUbicacion = new Sara_UI_Design.SaraControls.SaraUI_TextBox();
            label3 = new Label();
            panel5 = new Panel();
            numCapacidad = new NumericUpDown();
            label4 = new Label();
            panel6 = new Panel();
            txtTelefono = new Sara_UI_Design.SaraControls.SaraUI_TextBox();
            label5 = new Label();
            panel7 = new Panel();
            txtDirector = new Sara_UI_Design.SaraControls.SaraUI_TextBox();
            label6 = new Label();
            panel8 = new Panel();
            cmbTipoSanatorio = new Sara_UI_Design.SaraControls.SaraUI_ComboBox();
            label7 = new Label();
            panel9 = new Panel();
            numCostoOperacion = new NumericUpDown();
            label8 = new Label();
            panel10 = new Panel();
            txtNivelServicio = new Sara_UI_Design.SaraControls.SaraUI_TextBox();
            label9 = new Label();
            panel11 = new Panel();
            chkEstado = new Sara_UI_Design.SaraControls.SaraUI_ToggleButton();
            label10 = new Label();
            panelGestionIzq.SuspendLayout();
            panelGestionDer.SuspendLayout();
            sarauI_TabControl1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacidad).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCostoOperacion).BeginInit();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Size = new Size(881, 32);
            lblSubtitulo.Text = "Administración de sedes regionales, capacidades físicas y costos operativos de la red";
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(292, 7);
            lblTitulo.Size = new Size(416, 54);
            lblTitulo.Text = "Control de Sanatorios";
            // 
            // panelGestionIzq
            // 
            panelGestionIzq.ChildSpacing = 3;
            panelGestionIzq.Controls.Add(panel11);
            panelGestionIzq.Controls.Add(panel10);
            panelGestionIzq.Controls.Add(panel9);
            panelGestionIzq.Controls.Add(panel8);
            panelGestionIzq.Controls.Add(panel7);
            panelGestionIzq.Direction = Sara_UI_Design.SaraControls.SaraUI_FlexPanel.FlexDirection.Column;
            panelGestionIzq.Padding = new Padding(10, 10, 10, 0);
            // 
            // panelGestionDer
            // 
            panelGestionDer.ChildSpacing = 3;
            panelGestionDer.Controls.Add(panel6);
            panelGestionDer.Controls.Add(panel5);
            panelGestionDer.Controls.Add(panel4);
            panelGestionDer.Controls.Add(panel3);
            panelGestionDer.Controls.Add(panel2);
            panelGestionDer.Direction = Sara_UI_Design.SaraControls.SaraUI_FlexPanel.FlexDirection.Column;
            panelGestionDer.Padding = new Padding(10, 10, 10, 0);
            // 
            // btnNuevo
            // 
            btnNuevo.FlatAppearance.BorderSize = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatAppearance.BorderSize = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderSize = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            // 
            // btnImprimir
            // 
            btnImprimir.FlatAppearance.BorderSize = 0;
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatAppearance.BorderSize = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.BorderSize = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtCodigo);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(456, 51);
            panel2.TabIndex = 0;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(222, 230, 238);
            txtCodigo.BorderColor = Color.FromArgb(90, 114, 138);
            txtCodigo.BorderFocusColor = Color.FromArgb(90, 114, 138);
            txtCodigo.BorderRadius = 8;
            txtCodigo.BorderSize = 2;
            txtCodigo.Enabled = false;
            txtCodigo.ForeColor = Color.White;
            txtCodigo.IconColor = Color.Gray;
            txtCodigo.IconLocation = Sara_UI_Design.SaraControls.SaraUI_TextBox.SaraIconLocation.Left;
            txtCodigo.IconName = "None";
            txtCodigo.IconSize = 20;
            txtCodigo.Location = new Point(0, 17);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Padding = new Padding(8, 7, 8, 7);
            txtCodigo.PlaceholderColor = Color.Gray;
            txtCodigo.PlaceholderText = "";
            txtCodigo.Size = new Size(453, 30);
            txtCodigo.TabIndex = 1;
            txtCodigo.Type = Sara_UI_Design.SaraControls.SaraUI_TextBox.InputType.Text;
            txtCodigo.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtNombre);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(10, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(456, 51);
            panel3.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(12, 50, 132);
            txtNombre.BorderColor = Color.FromArgb(90, 114, 138);
            txtNombre.BorderFocusColor = Color.FromArgb(90, 114, 138);
            txtNombre.BorderRadius = 8;
            txtNombre.BorderSize = 2;
            txtNombre.ForeColor = Color.White;
            txtNombre.IconColor = Color.Gray;
            txtNombre.IconLocation = Sara_UI_Design.SaraControls.SaraUI_TextBox.SaraIconLocation.Left;
            txtNombre.IconName = "None";
            txtNombre.IconSize = 20;
            txtNombre.Location = new Point(0, 17);
            txtNombre.Name = "txtNombre";
            txtNombre.Padding = new Padding(8, 7, 8, 7);
            txtNombre.PlaceholderColor = Color.Gray;
            txtNombre.PlaceholderText = "";
            txtNombre.Size = new Size(453, 30);
            txtNombre.TabIndex = 1;
            txtNombre.Type = Sara_UI_Design.SaraControls.SaraUI_TextBox.InputType.Text;
            txtNombre.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtUbicacion);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(10, 118);
            panel4.Name = "panel4";
            panel4.Size = new Size(456, 51);
            panel4.TabIndex = 2;
            // 
            // txtUbicacion
            // 
            txtUbicacion.BackColor = Color.FromArgb(12, 50, 132);
            txtUbicacion.BorderColor = Color.FromArgb(90, 114, 138);
            txtUbicacion.BorderFocusColor = Color.FromArgb(90, 114, 138);
            txtUbicacion.BorderRadius = 8;
            txtUbicacion.BorderSize = 2;
            txtUbicacion.ForeColor = Color.White;
            txtUbicacion.IconColor = Color.Gray;
            txtUbicacion.IconLocation = Sara_UI_Design.SaraControls.SaraUI_TextBox.SaraIconLocation.Left;
            txtUbicacion.IconName = "None";
            txtUbicacion.IconSize = 20;
            txtUbicacion.Location = new Point(0, 17);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Padding = new Padding(8, 7, 8, 7);
            txtUbicacion.PlaceholderColor = Color.Gray;
            txtUbicacion.PlaceholderText = "";
            txtUbicacion.Size = new Size(453, 30);
            txtUbicacion.TabIndex = 1;
            txtUbicacion.Type = Sara_UI_Design.SaraControls.SaraUI_TextBox.InputType.Text;
            txtUbicacion.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 0;
            label3.Text = "Ubicacion:";
            // 
            // panel5
            // 
            panel5.Controls.Add(numCapacidad);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(10, 172);
            panel5.Name = "panel5";
            panel5.Size = new Size(456, 51);
            panel5.TabIndex = 3;
            // 
            // numCapacidad
            // 
            numCapacidad.Location = new Point(3, 18);
            numCapacidad.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numCapacidad.Name = "numCapacidad";
            numCapacidad.Size = new Size(450, 23);
            numCapacidad.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 0;
            label4.Text = "Habitaciones:";
            // 
            // panel6
            // 
            panel6.Controls.Add(txtTelefono);
            panel6.Controls.Add(label5);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(10, 226);
            panel6.Name = "panel6";
            panel6.Size = new Size(456, 51);
            panel6.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(12, 50, 132);
            txtTelefono.BorderColor = Color.FromArgb(90, 114, 138);
            txtTelefono.BorderFocusColor = Color.FromArgb(90, 114, 138);
            txtTelefono.BorderRadius = 8;
            txtTelefono.BorderSize = 2;
            txtTelefono.ForeColor = Color.White;
            txtTelefono.IconColor = Color.Gray;
            txtTelefono.IconLocation = Sara_UI_Design.SaraControls.SaraUI_TextBox.SaraIconLocation.Left;
            txtTelefono.IconName = "None";
            txtTelefono.IconSize = 20;
            txtTelefono.Location = new Point(0, 17);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Padding = new Padding(8, 7, 8, 7);
            txtTelefono.PlaceholderColor = Color.Gray;
            txtTelefono.PlaceholderText = "";
            txtTelefono.Size = new Size(453, 30);
            txtTelefono.TabIndex = 1;
            txtTelefono.Type = Sara_UI_Design.SaraControls.SaraUI_TextBox.InputType.Text;
            txtTelefono.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 0;
            label5.Text = "Telefono:";
            // 
            // panel7
            // 
            panel7.Controls.Add(txtDirector);
            panel7.Controls.Add(label6);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(10, 10);
            panel7.Name = "panel7";
            panel7.Size = new Size(456, 51);
            panel7.TabIndex = 5;
            // 
            // txtDirector
            // 
            txtDirector.BackColor = Color.FromArgb(12, 50, 132);
            txtDirector.BorderColor = Color.FromArgb(90, 114, 138);
            txtDirector.BorderFocusColor = Color.FromArgb(90, 114, 138);
            txtDirector.BorderRadius = 8;
            txtDirector.BorderSize = 2;
            txtDirector.ForeColor = Color.White;
            txtDirector.IconColor = Color.Gray;
            txtDirector.IconLocation = Sara_UI_Design.SaraControls.SaraUI_TextBox.SaraIconLocation.Left;
            txtDirector.IconName = "None";
            txtDirector.IconSize = 20;
            txtDirector.Location = new Point(0, 17);
            txtDirector.Name = "txtDirector";
            txtDirector.Padding = new Padding(8, 7, 8, 7);
            txtDirector.PlaceholderColor = Color.Gray;
            txtDirector.PlaceholderText = "";
            txtDirector.Size = new Size(453, 30);
            txtDirector.TabIndex = 1;
            txtDirector.Type = Sara_UI_Design.SaraControls.SaraUI_TextBox.InputType.Text;
            txtDirector.UnderlinedStyle = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 0;
            label6.Text = "Medico Director:";
            // 
            // panel8
            // 
            panel8.Controls.Add(cmbTipoSanatorio);
            panel8.Controls.Add(label7);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(10, 64);
            panel8.Name = "panel8";
            panel8.Size = new Size(456, 51);
            panel8.TabIndex = 6;
            // 
            // cmbTipoSanatorio
            // 
            cmbTipoSanatorio.BackColor = Color.FromArgb(12, 50, 132);
            cmbTipoSanatorio.BorderColor = Color.FromArgb(90, 114, 138);
            cmbTipoSanatorio.BorderFocusColor = Color.FromArgb(90, 114, 138);
            cmbTipoSanatorio.BorderSize = 2;
            cmbTipoSanatorio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoSanatorio.Font = new Font("Segoe UI", 10F);
            cmbTipoSanatorio.ForeColor = Color.White;
            cmbTipoSanatorio.IconColor = Color.White;
            cmbTipoSanatorio.ListBackColor = Color.FromArgb(90, 114, 138);
            cmbTipoSanatorio.ListTextColor = Color.FromArgb(222, 230, 238);
            cmbTipoSanatorio.Location = new Point(3, 17);
            cmbTipoSanatorio.MinimumSize = new Size(200, 30);
            cmbTipoSanatorio.Name = "cmbTipoSanatorio";
            cmbTipoSanatorio.Padding = new Padding(2);
            cmbTipoSanatorio.Size = new Size(450, 30);
            cmbTipoSanatorio.TabIndex = 1;
            cmbTipoSanatorio.Texts = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 0;
            label7.Text = "Sanatorio:";
            // 
            // panel9
            // 
            panel9.Controls.Add(numCostoOperacion);
            panel9.Controls.Add(label8);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(10, 118);
            panel9.Name = "panel9";
            panel9.Size = new Size(456, 51);
            panel9.TabIndex = 7;
            // 
            // numCostoOperacion
            // 
            numCostoOperacion.DecimalPlaces = 2;
            numCostoOperacion.Location = new Point(3, 18);
            numCostoOperacion.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numCostoOperacion.Name = "numCostoOperacion";
            numCostoOperacion.Size = new Size(450, 23);
            numCostoOperacion.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(99, 15);
            label8.TabIndex = 0;
            label8.Text = "Costo Operacion:";
            // 
            // panel10
            // 
            panel10.Controls.Add(txtNivelServicio);
            panel10.Controls.Add(label9);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(10, 172);
            panel10.Name = "panel10";
            panel10.Size = new Size(456, 51);
            panel10.TabIndex = 8;
            // 
            // txtNivelServicio
            // 
            txtNivelServicio.BackColor = Color.FromArgb(222, 230, 238);
            txtNivelServicio.BorderColor = Color.FromArgb(90, 114, 138);
            txtNivelServicio.BorderFocusColor = Color.FromArgb(90, 114, 138);
            txtNivelServicio.BorderRadius = 8;
            txtNivelServicio.BorderSize = 2;
            txtNivelServicio.Enabled = false;
            txtNivelServicio.ForeColor = Color.White;
            txtNivelServicio.IconColor = Color.Gray;
            txtNivelServicio.IconLocation = Sara_UI_Design.SaraControls.SaraUI_TextBox.SaraIconLocation.Left;
            txtNivelServicio.IconName = "None";
            txtNivelServicio.IconSize = 20;
            txtNivelServicio.Location = new Point(0, 17);
            txtNivelServicio.Name = "txtNivelServicio";
            txtNivelServicio.Padding = new Padding(8, 7, 8, 7);
            txtNivelServicio.PlaceholderColor = Color.Gray;
            txtNivelServicio.PlaceholderText = "";
            txtNivelServicio.Size = new Size(453, 30);
            txtNivelServicio.TabIndex = 1;
            txtNivelServicio.Type = Sara_UI_Design.SaraControls.SaraUI_TextBox.InputType.Text;
            txtNivelServicio.UnderlinedStyle = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(81, 15);
            label9.TabIndex = 0;
            label9.Text = "Nivel Servicio:";
            // 
            // panel11
            // 
            panel11.Controls.Add(chkEstado);
            panel11.Controls.Add(label10);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(10, 226);
            panel11.Name = "panel11";
            panel11.Size = new Size(456, 51);
            panel11.TabIndex = 9;
            // 
            // chkEstado
            // 
            chkEstado.Checked = true;
            chkEstado.CheckState = CheckState.Checked;
            chkEstado.Location = new Point(3, 17);
            chkEstado.MinimumSize = new Size(45, 22);
            chkEstado.Name = "chkEstado";
            chkEstado.OffBackColor = Color.FromArgb(90, 114, 138);
            chkEstado.OffToggleColor = Color.Gainsboro;
            chkEstado.OnBackColor = Color.FromArgb(0, 28, 84);
            chkEstado.OnToggleColor = Color.WhiteSmoke;
            chkEstado.Size = new Size(57, 24);
            chkEstado.TabIndex = 1;
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 0;
            label10.Text = "Estado:";
            // 
            // SanatoriosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "SanatoriosView";
            Titulo = "Control de Sanatorios";
            panelGestionIzq.ResumeLayout(false);
            panelGestionDer.ResumeLayout(false);
            sarauI_TabControl1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacidad).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCostoOperacion).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Sara_UI_Design.SaraControls.SaraUI_TextBox txtCodigo;
        private Label label1;
        private Panel panel3;
        private Sara_UI_Design.SaraControls.SaraUI_TextBox txtNombre;
        private Label label2;
        private Panel panel5;
        private NumericUpDown numCapacidad;
        private Label label4;
        private Panel panel4;
        private Sara_UI_Design.SaraControls.SaraUI_TextBox txtUbicacion;
        private Label label3;
        private Panel panel8;
        private Sara_UI_Design.SaraControls.SaraUI_ComboBox cmbTipoSanatorio;
        private Label label7;
        private Panel panel7;
        private Sara_UI_Design.SaraControls.SaraUI_TextBox txtDirector;
        private Label label6;
        private Panel panel6;
        private Sara_UI_Design.SaraControls.SaraUI_TextBox txtTelefono;
        private Label label5;
        private Panel panel11;
        private Sara_UI_Design.SaraControls.SaraUI_ToggleButton chkEstado;
        private Label label10;
        private Panel panel10;
        private Sara_UI_Design.SaraControls.SaraUI_TextBox txtNivelServicio;
        private Label label9;
        private Panel panel9;
        private NumericUpDown numCostoOperacion;
        private Label label8;
    }
}
