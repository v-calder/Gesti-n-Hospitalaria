namespace Presentacion
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            sarauI_GridPanel1 = new Sara_UI_Design.SaraControls.SaraUI_GridPanel();
            panel2 = new Panel();
            btnCerrar = new Label();
            label6 = new Label();
            btnIniciarSesion = new Sara_UI_Design.SaraControls.SaraUI_Button();
            label5 = new Label();
            chkRecordarme = new Sara_UI_Design.SaraControls.SaraUI_ToggleButton();
            txtContrasena = new Sara_UI_Design.SaraControls.SaraUI_TextBox();
            label4 = new Label();
            txtUsuario = new Sara_UI_Design.SaraControls.SaraUI_TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            sarauI_PictureBox1 = new Sara_UI_Design.SaraControls.SaraUI_PictureBox();
            panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sarauI_GridPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sarauI_PictureBox1).BeginInit();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(480, 624);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // sarauI_GridPanel1
            // 
            sarauI_GridPanel1.BorderRadius = 0;
            sarauI_GridPanel1.ColumnGap = 0;
            sarauI_GridPanel1.ColumnsConfig = "1fr, 1fr";
            sarauI_GridPanel1.Controls.Add(panel2);
            sarauI_GridPanel1.Controls.Add(panel);
            sarauI_GridPanel1.Dock = DockStyle.Fill;
            sarauI_GridPanel1.Location = new Point(0, 0);
            sarauI_GridPanel1.Margin = new Padding(3, 4, 3, 4);
            sarauI_GridPanel1.Name = "sarauI_GridPanel1";
            sarauI_GridPanel1.Padding = new Padding(0);
            sarauI_GridPanel1.RowGap = 0;
            sarauI_GridPanel1.RowsConfig = "1fr";
            sarauI_GridPanel1.Size = new Size(967, 624);
            sarauI_GridPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnIniciarSesion);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(chkRecordarme);
            panel2.Controls.Add(txtContrasena);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtUsuario);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(sarauI_PictureBox1);
            panel2.Location = new Point(483, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(483, 624);
            panel2.TabIndex = 1;
            // 
            // btnCerrar
            // 
            btnCerrar.AutoSize = true;
            btnCerrar.Font = new Font("Segoe UI", 12F);
            btnCerrar.ForeColor = Color.Silver;
            btnCerrar.Location = new Point(448, 9);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 28);
            btnCerrar.TabIndex = 11;
            btnCerrar.Text = "X";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 140, 128);
            label6.Location = new Point(138, 475);
            label6.Name = "label6";
            label6.Size = new Size(206, 23);
            label6.TabIndex = 10;
            label6.Text = "¿Olvidaste tu contraseña?";
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.FromArgb(0, 140, 128);
            btnIniciarSesion.BorderColor = Color.PaleVioletRed;
            btnIniciarSesion.BorderRadius = 6;
            btnIniciarSesion.BorderSize = 0;
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.IconLocation = Sara_UI_Design.SaraControls.SaraUI_Button.SaraIconLocation.Left;
            btnIniciarSesion.IconName = "None";
            btnIniciarSesion.IconPadding = 8;
            btnIniciarSesion.IconSize = 16;
            btnIniciarSesion.IconStyle = Sara_UI_Design.SaraControls.SaraUI_IconLibrary.SaraIconStyle.Outline;
            btnIniciarSesion.Location = new Point(56, 539);
            btnIniciarSesion.Margin = new Padding(3, 4, 3, 4);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(343, 60);
            btnIniciarSesion.TabIndex = 9;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(22, 36, 57);
            label5.Location = new Point(114, 433);
            label5.Name = "label5";
            label5.Size = new Size(101, 23);
            label5.TabIndex = 8;
            label5.Text = "Recuerdame";
            // 
            // chkRecordarme
            // 
            chkRecordarme.AutoSize = true;
            chkRecordarme.Location = new Point(56, 432);
            chkRecordarme.Margin = new Padding(3, 4, 3, 4);
            chkRecordarme.MinimumSize = new Size(51, 29);
            chkRecordarme.Name = "chkRecordarme";
            chkRecordarme.OffBackColor = Color.Gray;
            chkRecordarme.OffToggleColor = Color.Gainsboro;
            chkRecordarme.OnBackColor = Color.FromArgb(0, 140, 128);
            chkRecordarme.OnToggleColor = Color.WhiteSmoke;
            chkRecordarme.Size = new Size(51, 29);
            chkRecordarme.TabIndex = 7;
            chkRecordarme.UseVisualStyleBackColor = true;
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = Color.FromArgb(247, 249, 251);
            txtContrasena.BorderColor = Color.FromArgb(247, 249, 251);
            txtContrasena.BorderFocusColor = Color.FromArgb(12, 50, 132);
            txtContrasena.BorderRadius = 5;
            txtContrasena.BorderSize = 0;
            txtContrasena.ForeColor = Color.Black;
            txtContrasena.IconColor = Color.Gray;
            txtContrasena.IconLocation = Sara_UI_Design.SaraControls.SaraUI_TextBox.SaraIconLocation.Right;
            txtContrasena.IconName = "Logout";
            txtContrasena.IconSize = 12;
            txtContrasena.Location = new Point(56, 389);
            txtContrasena.Margin = new Padding(3, 4, 3, 4);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Padding = new Padding(7, 7, 30, 7);
            txtContrasena.PlaceholderColor = Color.Gray;
            txtContrasena.PlaceholderText = "Password";
            txtContrasena.Size = new Size(343, 35);
            txtContrasena.TabIndex = 6;
            txtContrasena.Type = Sara_UI_Design.SaraControls.SaraUI_TextBox.InputType.Password;
            txtContrasena.UnderlinedStyle = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(22, 36, 57);
            label4.Location = new Point(56, 363);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 5;
            label4.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(247, 249, 251);
            txtUsuario.BorderColor = Color.FromArgb(247, 249, 251);
            txtUsuario.BorderFocusColor = Color.FromArgb(12, 50, 132);
            txtUsuario.BorderRadius = 5;
            txtUsuario.BorderSize = 0;
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.IconColor = Color.Gray;
            txtUsuario.IconLocation = Sara_UI_Design.SaraControls.SaraUI_TextBox.SaraIconLocation.Right;
            txtUsuario.IconName = "User";
            txtUsuario.IconSize = 12;
            txtUsuario.Location = new Point(56, 315);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Padding = new Padding(7, 7, 30, 7);
            txtUsuario.PlaceholderColor = Color.Gray;
            txtUsuario.PlaceholderText = "Victor Calderon";
            txtUsuario.Size = new Size(343, 35);
            txtUsuario.TabIndex = 4;
            txtUsuario.Type = Sara_UI_Design.SaraControls.SaraUI_TextBox.InputType.Text;
            txtUsuario.UnderlinedStyle = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(22, 36, 57);
            label3.Location = new Point(56, 288);
            label3.Name = "label3";
            label3.Size = new Size(158, 23);
            label3.TabIndex = 3;
            label3.Text = "Nombre de Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 17F);
            label2.ForeColor = Color.FromArgb(90, 114, 138);
            label2.Location = new Point(17, 215);
            label2.Name = "label2";
            label2.Size = new Size(469, 40);
            label2.TabIndex = 2;
            label2.Text = "Por favor, introduce tus credenciales";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(12, 50, 132);
            label1.Location = new Point(31, 153);
            label1.Name = "label1";
            label1.Size = new Size(427, 57);
            label1.TabIndex = 1;
            label1.Text = "Gestión Hospitalaria";
            // 
            // sarauI_PictureBox1
            // 
            sarauI_PictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            sarauI_PictureBox1.BorderColor = Color.RoyalBlue;
            sarauI_PictureBox1.BorderColor2 = Color.HotPink;
            sarauI_PictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            sarauI_PictureBox1.BorderRadius = 12;
            sarauI_PictureBox1.BorderSize = 0;
            sarauI_PictureBox1.GradientAngle = 50F;
            sarauI_PictureBox1.Image = Properties.Resources.Escudo_de_la_universidad_Mariano_Gálvez_Guatemala_svg;
            sarauI_PictureBox1.IsCircular = false;
            sarauI_PictureBox1.Location = new Point(170, 16);
            sarauI_PictureBox1.Margin = new Padding(3, 4, 3, 4);
            sarauI_PictureBox1.Name = "sarauI_PictureBox1";
            sarauI_PictureBox1.Size = new Size(114, 114);
            sarauI_PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            sarauI_PictureBox1.TabIndex = 0;
            sarauI_PictureBox1.TabStop = false;
            // 
            // panel
            // 
            panel.Controls.Add(pictureBox1);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Margin = new Padding(3, 4, 3, 4);
            panel.Name = "panel";
            panel.Size = new Size(483, 624);
            panel.TabIndex = 0;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 624);
            Controls.Add(sarauI_GridPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sarauI_GridPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sarauI_PictureBox1).EndInit();
            panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Sara_UI_Design.SaraControls.SaraUI_GridPanel sarauI_GridPanel1;
        private Panel panel2;
        private Label btnCerrar;
        private Label label6;
        private Sara_UI_Design.SaraControls.SaraUI_Button btnIniciarSesion;
        private Label label5;
        private Sara_UI_Design.SaraControls.SaraUI_ToggleButton chkRecordarme;
        private Sara_UI_Design.SaraControls.SaraUI_TextBox txtContrasena;
        private Label label4;
        private Sara_UI_Design.SaraControls.SaraUI_TextBox txtUsuario;
        private Label label3;
        private Label label2;
        private Label label1;
        private Sara_UI_Design.SaraControls.SaraUI_PictureBox sarauI_PictureBox1;
        private Panel panel;
    }
}