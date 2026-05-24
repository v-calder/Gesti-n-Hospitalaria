namespace Presentacion {
    partial class SegurosMedicosView {
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
            panel1 = new Panel();
            txtCodigo = new Sara_UI_Design.SaraControls.SaraUI_TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txtNombre = new Sara_UI_Design.SaraControls.SaraUI_TextBox();
            label2 = new Label();
            panel3 = new Panel();
            cmbTipo = new Sara_UI_Design.SaraControls.SaraUI_ComboBox();
            label3 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            panel6 = new Panel();
            txtTelefono = new Sara_UI_Design.SaraControls.SaraUI_TextBox();
            label6 = new Label();
            panel7 = new Panel();
            txtDireccion = new Sara_UI_Design.SaraControls.SaraUI_TextBox();
            label7 = new Label();
            panel8 = new Panel();
            txtCorreo = new Sara_UI_Design.SaraControls.SaraUI_TextBox();
            label8 = new Label();
            panel9 = new Panel();
            chkEstado = new Sara_UI_Design.SaraControls.SaraUI_ToggleButton();
            label9 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            numCobertura = new NumericUpDown();
            numMaximo = new NumericUpDown();
            panelGestionIzq.SuspendLayout();
            panelGestionDer.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCobertura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaximo).BeginInit();
            SuspendLayout();
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Size = new Size(587, 32);
            lblSubtitulo.Text = "Gestión de pólizas, coberturas y convenios hospitalarios";
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(233, 5);
            lblTitulo.Size = new Size(534, 54);
            lblTitulo.Text = "Control de Seguros Médicos";
            // 
            // panelGestionIzq
            // 
            panelGestionIzq.ChildSpacing = 0;
            panelGestionIzq.Controls.Add(panel9);
            panelGestionIzq.Controls.Add(panel8);
            panelGestionIzq.Controls.Add(panel7);
            panelGestionIzq.Controls.Add(panel6);
            panelGestionIzq.Direction = Sara_UI_Design.SaraControls.SaraUI_FlexPanel.FlexDirection.Column;
            // 
            // panelGestionDer
            // 
            panelGestionDer.ChildSpacing = 0;
            panelGestionDer.Controls.Add(panel5);
            panelGestionDer.Controls.Add(panel4);
            panelGestionDer.Controls.Add(panel3);
            panelGestionDer.Controls.Add(panel2);
            panelGestionDer.Controls.Add(panel1);
            panelGestionDer.Direction = Sara_UI_Design.SaraControls.SaraUI_FlexPanel.FlexDirection.Column;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtCodigo);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 65);
            panel1.TabIndex = 0;
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
            txtCodigo.Location = new Point(13, 29);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Padding = new Padding(8, 7, 8, 7);
            txtCodigo.PlaceholderColor = Color.Gray;
            txtCodigo.PlaceholderText = "";
            txtCodigo.Size = new Size(450, 30);
            txtCodigo.TabIndex = 1;
            txtCodigo.Type = Sara_UI_Design.SaraControls.SaraUI_TextBox.InputType.Text;
            txtCodigo.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(1, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(473, 65);
            panel2.TabIndex = 1;
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
            txtNombre.Location = new Point(13, 29);
            txtNombre.Name = "txtNombre";
            txtNombre.Padding = new Padding(8, 7, 8, 7);
            txtNombre.PlaceholderColor = Color.Gray;
            txtNombre.PlaceholderText = "";
            txtNombre.Size = new Size(450, 30);
            txtNombre.TabIndex = 1;
            txtNombre.Type = Sara_UI_Design.SaraControls.SaraUI_TextBox.InputType.Text;
            txtNombre.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 11);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // panel3
            // 
            panel3.Controls.Add(cmbTipo);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(1, 130);
            panel3.Name = "panel3";
            panel3.Size = new Size(473, 65);
            panel3.TabIndex = 2;
            // 
            // cmbTipo
            // 
            cmbTipo.BackColor = Color.FromArgb(0, 28, 84);
            cmbTipo.BorderColor = Color.FromArgb(90, 114, 138);
            cmbTipo.BorderFocusColor = Color.FromArgb(0, 140, 128);
            cmbTipo.BorderSize = 2;
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDown;
            cmbTipo.Font = new Font("Segoe UI", 10F);
            cmbTipo.ForeColor = Color.White;
            cmbTipo.IconColor = Color.White;
            cmbTipo.ListBackColor = Color.FromArgb(222, 230, 238);
            cmbTipo.ListTextColor = Color.Black;
            cmbTipo.Location = new Point(13, 29);
            cmbTipo.MinimumSize = new Size(200, 30);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Padding = new Padding(2);
            cmbTipo.Size = new Size(450, 30);
            cmbTipo.TabIndex = 1;
            cmbTipo.Texts = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 11);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 0;
            label3.Text = "Tipo:";
            // 
            // panel4
            // 
            panel4.Controls.Add(numCobertura);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(1, 195);
            panel4.Name = "panel4";
            panel4.Size = new Size(473, 65);
            panel4.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 11);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 0;
            label4.Text = "Cobertura";
            // 
            // panel6
            // 
            panel6.Controls.Add(txtTelefono);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(1, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(473, 65);
            panel6.TabIndex = 2;
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
            txtTelefono.Location = new Point(13, 29);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Padding = new Padding(8, 7, 8, 7);
            txtTelefono.PlaceholderColor = Color.Gray;
            txtTelefono.PlaceholderText = "";
            txtTelefono.Size = new Size(450, 30);
            txtTelefono.TabIndex = 1;
            txtTelefono.Type = Sara_UI_Design.SaraControls.SaraUI_TextBox.InputType.Text;
            txtTelefono.UnderlinedStyle = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 11);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 0;
            label6.Text = "Telefono";
            // 
            // panel7
            // 
            panel7.Controls.Add(txtDireccion);
            panel7.Controls.Add(label7);
            panel7.Location = new Point(1, 65);
            panel7.Name = "panel7";
            panel7.Size = new Size(473, 65);
            panel7.TabIndex = 3;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.FromArgb(12, 50, 132);
            txtDireccion.BorderColor = Color.FromArgb(90, 114, 138);
            txtDireccion.BorderFocusColor = Color.FromArgb(90, 114, 138);
            txtDireccion.BorderRadius = 8;
            txtDireccion.BorderSize = 2;
            txtDireccion.ForeColor = Color.White;
            txtDireccion.IconColor = Color.Gray;
            txtDireccion.IconLocation = Sara_UI_Design.SaraControls.SaraUI_TextBox.SaraIconLocation.Left;
            txtDireccion.IconName = "None";
            txtDireccion.IconSize = 20;
            txtDireccion.Location = new Point(13, 29);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Padding = new Padding(8, 7, 8, 7);
            txtDireccion.PlaceholderColor = Color.Gray;
            txtDireccion.PlaceholderText = "";
            txtDireccion.Size = new Size(450, 30);
            txtDireccion.TabIndex = 1;
            txtDireccion.Type = Sara_UI_Design.SaraControls.SaraUI_TextBox.InputType.Text;
            txtDireccion.UnderlinedStyle = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 11);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 0;
            label7.Text = "Direccion";
            // 
            // panel8
            // 
            panel8.Controls.Add(txtCorreo);
            panel8.Controls.Add(label8);
            panel8.Location = new Point(1, 130);
            panel8.Name = "panel8";
            panel8.Size = new Size(473, 65);
            panel8.TabIndex = 4;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(12, 50, 132);
            txtCorreo.BorderColor = Color.FromArgb(90, 114, 138);
            txtCorreo.BorderFocusColor = Color.FromArgb(90, 114, 138);
            txtCorreo.BorderRadius = 8;
            txtCorreo.BorderSize = 2;
            txtCorreo.ForeColor = Color.White;
            txtCorreo.IconColor = Color.Gray;
            txtCorreo.IconLocation = Sara_UI_Design.SaraControls.SaraUI_TextBox.SaraIconLocation.Left;
            txtCorreo.IconName = "None";
            txtCorreo.IconSize = 20;
            txtCorreo.Location = new Point(13, 29);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Padding = new Padding(8, 7, 8, 7);
            txtCorreo.PlaceholderColor = Color.Gray;
            txtCorreo.PlaceholderText = "";
            txtCorreo.Size = new Size(450, 30);
            txtCorreo.TabIndex = 1;
            txtCorreo.Type = Sara_UI_Design.SaraControls.SaraUI_TextBox.InputType.Text;
            txtCorreo.UnderlinedStyle = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 11);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 0;
            label8.Text = "Correo";
            // 
            // panel9
            // 
            panel9.Controls.Add(chkEstado);
            panel9.Controls.Add(label9);
            panel9.Location = new Point(1, 195);
            panel9.Name = "panel9";
            panel9.Size = new Size(473, 65);
            panel9.TabIndex = 5;
            // 
            // chkEstado
            // 
            chkEstado.Location = new Point(13, 29);
            chkEstado.MinimumSize = new Size(45, 22);
            chkEstado.Name = "chkEstado";
            chkEstado.OffBackColor = Color.FromArgb(90, 114, 138);
            chkEstado.OffToggleColor = Color.Gainsboro;
            chkEstado.OnBackColor = Color.FromArgb(12, 50, 132);
            chkEstado.OnToggleColor = Color.WhiteSmoke;
            chkEstado.Size = new Size(59, 24);
            chkEstado.TabIndex = 1;
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 11);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 0;
            label9.Text = "Estado";
            // 
            // panel5
            // 
            panel5.Controls.Add(numMaximo);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(1, 260);
            panel5.Name = "panel5";
            panel5.Size = new Size(473, 65);
            panel5.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 11);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 0;
            label5.Text = "Maximo";
            // 
            // numCobertura
            // 
            numCobertura.Location = new Point(13, 29);
            numCobertura.Name = "numCobertura";
            numCobertura.Size = new Size(450, 23);
            numCobertura.TabIndex = 1;
            // 
            // numMaximo
            // 
            numMaximo.Location = new Point(13, 29);
            numMaximo.Name = "numMaximo";
            numMaximo.Size = new Size(450, 23);
            numMaximo.TabIndex = 1;
            // 
            // SegurosMedicosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "SegurosMedicosView";
            Subtitulo = "Gestión de pólizas, coberturas y convenios hospitalarios";
            Titulo = "Control de Seguros Médicos";
            panelGestionIzq.ResumeLayout(false);
            panelGestionDer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCobertura).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMaximo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private Sara_UI_Design.SaraControls.SaraUI_TextBox sarauI_TextBox7;
        private Label label7;
        private Panel panel6;
        private Sara_UI_Design.SaraControls.SaraUI_TextBox sarauI_TextBox6;
        private Label label6;
        private Sara_UI_Design.SaraControls.SaraUI_TextBox txtDireccion;
        private Panel panel4;
        private Sara_UI_Design.SaraControls.SaraUI_TextBox txtTelefono;
        private Label label4;
        private Panel panel3;
        private Label label3;
        private Panel panel2;
        private Sara_UI_Design.SaraControls.SaraUI_TextBox txtNombre;
        private Label label2;
        private Panel panel1;
        private Sara_UI_Design.SaraControls.SaraUI_TextBox txtCodigo;
        private Label label1;
        private Panel panel9;
        private Label label9;
        private Panel panel8;
        private Sara_UI_Design.SaraControls.SaraUI_TextBox txtCorreo;
        private Label label8;
        private Sara_UI_Design.SaraControls.SaraUI_ComboBox cmbTipo;
        private Panel panel5;
        private Label label5;
        private Sara_UI_Design.SaraControls.SaraUI_ToggleButton chkEstado;
        private NumericUpDown numMaximo;
        private NumericUpDown numCobertura;
    }
}
