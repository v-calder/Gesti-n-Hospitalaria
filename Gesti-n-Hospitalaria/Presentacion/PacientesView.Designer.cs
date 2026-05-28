namespace Presentacion {
    partial class PacientesView {
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
            txtApellido = new Sara_UI_Design.SaraControls.SaraUI_TextBox();
            label3 = new Label();
            panel5 = new Panel();
            txtDpi = new Sara_UI_Design.SaraControls.SaraUI_TextBox();
            label4 = new Label();
            panel6 = new Panel();
            dtpFechaNacimiento = new Sara_UI_Design.SaraControls.SaraUI_DatePicker();
            label5 = new Label();
            panel7 = new Panel();
            cmbGenero = new Sara_UI_Design.SaraControls.SaraUI_ComboBox();
            label6 = new Label();
            panel8 = new Panel();
            txtTelefono = new Sara_UI_Design.SaraControls.SaraUI_TextBox();
            label7 = new Label();
            panel9 = new Panel();
            txtDireccion = new Sara_UI_Design.SaraControls.SaraUI_TextBox();
            label8 = new Label();
            panel10 = new Panel();
            txtEdad = new Sara_UI_Design.SaraControls.SaraUI_TextBox();
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
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Size = new Size(772, 32);
            lblSubtitulo.Text = "Registro maestro, datos de contacto e identificación de pacientes inscritos";
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(303, 7);
            lblTitulo.Size = new Size(393, 54);
            lblTitulo.Text = "Control de Pacientes";
            // 
            // panelGestionIzq
            // 
            panelGestionIzq.ChildSpacing = 8;
            panelGestionIzq.Controls.Add(panel11);
            panelGestionIzq.Controls.Add(panel10);
            panelGestionIzq.Controls.Add(panel9);
            panelGestionIzq.Controls.Add(panel8);
            panelGestionIzq.Controls.Add(panel7);
            panelGestionIzq.Direction = Sara_UI_Design.SaraControls.SaraUI_FlexPanel.FlexDirection.Column;
            panelGestionIzq.Padding = new Padding(10, 10, 0, 0);
            // 
            // panelGestionDer
            // 
            panelGestionDer.ChildSpacing = 8;
            panelGestionDer.Controls.Add(panel6);
            panelGestionDer.Controls.Add(panel5);
            panelGestionDer.Controls.Add(panel4);
            panelGestionDer.Controls.Add(panel3);
            panelGestionDer.Controls.Add(panel2);
            panelGestionDer.Direction = Sara_UI_Design.SaraControls.SaraUI_FlexPanel.FlexDirection.Column;
            panelGestionDer.Padding = new Padding(10, 10, 10, 0);
            // 
            // txtBuscar
            // 
            txtBuscar.BorderFocusColor = Color.FromArgb(90, 114, 138);
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
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtCodigo);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(456, 58);
            panel2.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(198, 211, 222);
            txtCodigo.BorderColor = Color.FromArgb(90, 114, 138);
            txtCodigo.BorderFocusColor = Color.FromArgb(0, 28, 84);
            txtCodigo.BorderRadius = 8;
            txtCodigo.BorderSize = 2;
            txtCodigo.Enabled = false;
            txtCodigo.IconColor = Color.Gray;
            txtCodigo.IconLocation = Sara_UI_Design.SaraControls.SaraUI_TextBox.SaraIconLocation.Left;
            txtCodigo.IconName = "None";
            txtCodigo.IconSize = 20;
            txtCodigo.Location = new Point(0, 18);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Padding = new Padding(8, 7, 8, 7);
            txtCodigo.PlaceholderColor = Color.Gray;
            txtCodigo.PlaceholderText = "";
            txtCodigo.Size = new Size(456, 30);
            txtCodigo.TabIndex = 7;
            txtCodigo.Type = Sara_UI_Design.SaraControls.SaraUI_TextBox.InputType.Text;
            txtCodigo.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 6;
            label1.Text = "Codigo:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtNombre);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(10, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(456, 58);
            panel3.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(12, 50, 132);
            txtNombre.BorderColor = Color.FromArgb(90, 114, 138);
            txtNombre.BorderFocusColor = Color.FromArgb(90, 114, 138);
            txtNombre.BorderRadius = 8;
            txtNombre.BorderSize = 2;
            txtNombre.Enabled = false;
            txtNombre.ForeColor = Color.White;
            txtNombre.IconColor = Color.Gray;
            txtNombre.IconLocation = Sara_UI_Design.SaraControls.SaraUI_TextBox.SaraIconLocation.Left;
            txtNombre.IconName = "None";
            txtNombre.IconSize = 20;
            txtNombre.Location = new Point(0, 18);
            txtNombre.Name = "txtNombre";
            txtNombre.Padding = new Padding(8, 7, 8, 7);
            txtNombre.PlaceholderColor = Color.Gray;
            txtNombre.PlaceholderText = "";
            txtNombre.Size = new Size(456, 30);
            txtNombre.TabIndex = 7;
            txtNombre.Type = Sara_UI_Design.SaraControls.SaraUI_TextBox.InputType.Text;
            txtNombre.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 6;
            label2.Text = "Nombre:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtApellido);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(10, 142);
            panel4.Name = "panel4";
            panel4.Size = new Size(456, 58);
            panel4.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.FromArgb(12, 50, 132);
            txtApellido.BorderColor = Color.FromArgb(90, 114, 138);
            txtApellido.BorderFocusColor = Color.FromArgb(90, 114, 138);
            txtApellido.BorderRadius = 8;
            txtApellido.BorderSize = 2;
            txtApellido.Enabled = false;
            txtApellido.ForeColor = Color.White;
            txtApellido.IconColor = Color.Gray;
            txtApellido.IconLocation = Sara_UI_Design.SaraControls.SaraUI_TextBox.SaraIconLocation.Left;
            txtApellido.IconName = "None";
            txtApellido.IconSize = 20;
            txtApellido.Location = new Point(0, 18);
            txtApellido.Name = "txtApellido";
            txtApellido.Padding = new Padding(8, 7, 8, 7);
            txtApellido.PlaceholderColor = Color.Gray;
            txtApellido.PlaceholderText = "";
            txtApellido.Size = new Size(456, 30);
            txtApellido.TabIndex = 7;
            txtApellido.Type = Sara_UI_Design.SaraControls.SaraUI_TextBox.InputType.Text;
            txtApellido.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 6;
            label3.Text = "Apellido:";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtDpi);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(10, 208);
            panel5.Name = "panel5";
            panel5.Size = new Size(456, 58);
            panel5.TabIndex = 4;
            // 
            // txtDpi
            // 
            txtDpi.BackColor = Color.FromArgb(12, 50, 132);
            txtDpi.BorderColor = Color.FromArgb(90, 114, 138);
            txtDpi.BorderFocusColor = Color.FromArgb(90, 114, 138);
            txtDpi.BorderRadius = 8;
            txtDpi.BorderSize = 2;
            txtDpi.Enabled = false;
            txtDpi.ForeColor = Color.White;
            txtDpi.IconColor = Color.Gray;
            txtDpi.IconLocation = Sara_UI_Design.SaraControls.SaraUI_TextBox.SaraIconLocation.Left;
            txtDpi.IconName = "None";
            txtDpi.IconSize = 20;
            txtDpi.Location = new Point(0, 18);
            txtDpi.Name = "txtDpi";
            txtDpi.Padding = new Padding(8, 7, 8, 7);
            txtDpi.PlaceholderColor = Color.Gray;
            txtDpi.PlaceholderText = "";
            txtDpi.Size = new Size(456, 30);
            txtDpi.TabIndex = 7;
            txtDpi.Type = Sara_UI_Design.SaraControls.SaraUI_TextBox.InputType.Text;
            txtDpi.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 6;
            label4.Text = "DPI:";
            // 
            // panel6
            // 
            panel6.Controls.Add(dtpFechaNacimiento);
            panel6.Controls.Add(label5);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(10, 274);
            panel6.Name = "panel6";
            panel6.Size = new Size(456, 58);
            panel6.TabIndex = 5;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.BorderColor = Color.FromArgb(90, 114, 138);
            dtpFechaNacimiento.BorderRadius = 8;
            dtpFechaNacimiento.BorderSize = 0;
            dtpFechaNacimiento.Font = new Font("Segoe UI", 9.5F);
            dtpFechaNacimiento.Location = new Point(0, 18);
            dtpFechaNacimiento.MinimumSize = new Size(0, 35);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(450, 35);
            dtpFechaNacimiento.SkinColor = Color.FromArgb(12, 50, 132);
            dtpFechaNacimiento.TabIndex = 7;
            dtpFechaNacimiento.TextColor = Color.White;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 6;
            label5.Text = "Fecha Nacimiento";
            // 
            // panel7
            // 
            panel7.Controls.Add(cmbGenero);
            panel7.Controls.Add(label6);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(10, 10);
            panel7.Name = "panel7";
            panel7.Size = new Size(466, 58);
            panel7.TabIndex = 3;
            // 
            // cmbGenero
            // 
            cmbGenero.BackColor = Color.FromArgb(12, 50, 132);
            cmbGenero.BorderColor = Color.FromArgb(90, 114, 138);
            cmbGenero.BorderFocusColor = Color.FromArgb(93, 118, 173);
            cmbGenero.BorderSize = 2;
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.Font = new Font("Segoe UI", 10F);
            cmbGenero.ForeColor = Color.White;
            cmbGenero.IconColor = Color.White;
            cmbGenero.ListBackColor = Color.FromArgb(90, 114, 138);
            cmbGenero.ListTextColor = Color.White;
            cmbGenero.Location = new Point(3, 18);
            cmbGenero.MinimumSize = new Size(200, 30);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Padding = new Padding(2);
            cmbGenero.Size = new Size(470, 30);
            cmbGenero.TabIndex = 7;
            cmbGenero.Texts = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 6;
            label6.Text = "Genero:";
            // 
            // panel8
            // 
            panel8.Controls.Add(txtTelefono);
            panel8.Controls.Add(label7);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(10, 76);
            panel8.Name = "panel8";
            panel8.Size = new Size(466, 58);
            panel8.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(12, 50, 132);
            txtTelefono.BorderColor = Color.FromArgb(90, 114, 138);
            txtTelefono.BorderFocusColor = Color.FromArgb(90, 114, 138);
            txtTelefono.BorderRadius = 8;
            txtTelefono.BorderSize = 2;
            txtTelefono.Enabled = false;
            txtTelefono.ForeColor = Color.White;
            txtTelefono.IconColor = Color.Gray;
            txtTelefono.IconLocation = Sara_UI_Design.SaraControls.SaraUI_TextBox.SaraIconLocation.Left;
            txtTelefono.IconName = "None";
            txtTelefono.IconSize = 20;
            txtTelefono.Location = new Point(0, 18);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Padding = new Padding(8, 7, 8, 7);
            txtTelefono.PlaceholderColor = Color.Gray;
            txtTelefono.PlaceholderText = "";
            txtTelefono.Size = new Size(456, 30);
            txtTelefono.TabIndex = 7;
            txtTelefono.Type = Sara_UI_Design.SaraControls.SaraUI_TextBox.InputType.Text;
            txtTelefono.UnderlinedStyle = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 6;
            label7.Text = "Telefono";
            // 
            // panel9
            // 
            panel9.Controls.Add(txtDireccion);
            panel9.Controls.Add(label8);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(10, 142);
            panel9.Name = "panel9";
            panel9.Size = new Size(466, 58);
            panel9.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.FromArgb(12, 50, 132);
            txtDireccion.BorderColor = Color.FromArgb(90, 114, 138);
            txtDireccion.BorderFocusColor = Color.FromArgb(90, 114, 138);
            txtDireccion.BorderRadius = 8;
            txtDireccion.BorderSize = 2;
            txtDireccion.Enabled = false;
            txtDireccion.ForeColor = Color.White;
            txtDireccion.IconColor = Color.Gray;
            txtDireccion.IconLocation = Sara_UI_Design.SaraControls.SaraUI_TextBox.SaraIconLocation.Left;
            txtDireccion.IconName = "None";
            txtDireccion.IconSize = 20;
            txtDireccion.Location = new Point(0, 18);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Padding = new Padding(8, 7, 8, 7);
            txtDireccion.PlaceholderColor = Color.Gray;
            txtDireccion.PlaceholderText = "";
            txtDireccion.Size = new Size(456, 30);
            txtDireccion.TabIndex = 7;
            txtDireccion.Type = Sara_UI_Design.SaraControls.SaraUI_TextBox.InputType.Text;
            txtDireccion.UnderlinedStyle = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 6;
            label8.Text = "Direccion:";
            // 
            // panel10
            // 
            panel10.Controls.Add(txtEdad);
            panel10.Controls.Add(label9);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(10, 208);
            panel10.Name = "panel10";
            panel10.Size = new Size(466, 58);
            panel10.TabIndex = 6;
            // 
            // txtEdad
            // 
            txtEdad.BackColor = Color.FromArgb(222, 230, 238);
            txtEdad.BorderColor = Color.FromArgb(90, 114, 138);
            txtEdad.BorderFocusColor = Color.FromArgb(90, 114, 138);
            txtEdad.BorderRadius = 8;
            txtEdad.BorderSize = 2;
            txtEdad.Enabled = false;
            txtEdad.ForeColor = Color.White;
            txtEdad.IconColor = Color.Gray;
            txtEdad.IconLocation = Sara_UI_Design.SaraControls.SaraUI_TextBox.SaraIconLocation.Left;
            txtEdad.IconName = "None";
            txtEdad.IconSize = 20;
            txtEdad.Location = new Point(0, 18);
            txtEdad.Name = "txtEdad";
            txtEdad.Padding = new Padding(8, 7, 8, 7);
            txtEdad.PlaceholderColor = Color.Gray;
            txtEdad.PlaceholderText = "";
            txtEdad.Size = new Size(456, 30);
            txtEdad.TabIndex = 7;
            txtEdad.Type = Sara_UI_Design.SaraControls.SaraUI_TextBox.InputType.Text;
            txtEdad.UnderlinedStyle = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 6;
            label9.Text = "Edad:";
            // 
            // panel11
            // 
            panel11.Controls.Add(chkEstado);
            panel11.Controls.Add(label10);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(10, 274);
            panel11.Name = "panel11";
            panel11.Size = new Size(466, 58);
            panel11.TabIndex = 7;
            // 
            // chkEstado
            // 
            chkEstado.Location = new Point(0, 18);
            chkEstado.MinimumSize = new Size(45, 22);
            chkEstado.Name = "chkEstado";
            chkEstado.OffBackColor = Color.FromArgb(90, 114, 138);
            chkEstado.OffToggleColor = Color.Gainsboro;
            chkEstado.OnBackColor = Color.FromArgb(0, 28, 84);
            chkEstado.OnToggleColor = Color.WhiteSmoke;
            chkEstado.Size = new Size(53, 24);
            chkEstado.TabIndex = 7;
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 6;
            label10.Text = "Estado:";
            // 
            // PacientesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "PacientesView";
            Subtitulo = "Registro maestro, datos de contacto e identificación de pacientes inscritos";
            Titulo = "Control de Pacientes";
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
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
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
        private Panel panel5;
        private Sara_UI_Design.SaraControls.SaraUI_TextBox txtDpi;
        private Label label4;
        private Panel panel4;
        private Sara_UI_Design.SaraControls.SaraUI_TextBox txtApellido;
        private Label label3;
        private Panel panel3;
        private Sara_UI_Design.SaraControls.SaraUI_TextBox txtNombre;
        private Label label2;
        private Panel panel6;
        private Sara_UI_Design.SaraControls.SaraUI_DatePicker dtpFechaNacimiento;
        private Label label5;
        private Panel panel7;
        private Sara_UI_Design.SaraControls.SaraUI_ComboBox cmbGenero;
        private Label label6;
        private Panel panel11;
        private Label label10;
        private Panel panel10;
        private Sara_UI_Design.SaraControls.SaraUI_TextBox txtEdad;
        private Label label9;
        private Panel panel9;
        private Sara_UI_Design.SaraControls.SaraUI_TextBox txtDireccion;
        private Label label8;
        private Panel panel8;
        private Sara_UI_Design.SaraControls.SaraUI_TextBox txtTelefono;
        private Label label7;
        private Sara_UI_Design.SaraControls.SaraUI_ToggleButton chkEstado;
    }
}
