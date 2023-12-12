namespace FormAgenciaTurismo
{
    partial class FrmCarga_Pasajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarga_Pasajero));
            lblID = new Label();
            txtId_Pasajero = new TextBox();
            txtDNI = new TextBox();
            lblDNI = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtEdad = new TextBox();
            lblEdad = new Label();
            txtEmail = new TextBox();
            lblGenero = new Label();
            lblEmail = new Label();
            cmbGenero = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            lblIndicador = new Label();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.Transparent;
            lblID.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.Location = new Point(55, 127);
            lblID.Name = "lblID";
            lblID.Size = new Size(86, 18);
            lblID.TabIndex = 0;
            lblID.Text = "ID Pasajero";
            // 
            // txtId_Pasajero
            // 
            txtId_Pasajero.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtId_Pasajero.Location = new Point(152, 125);
            txtId_Pasajero.MaxLength = 5;
            txtId_Pasajero.Name = "txtId_Pasajero";
            txtId_Pasajero.Size = new Size(130, 24);
            txtId_Pasajero.TabIndex = 1;
            txtId_Pasajero.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDNI.Location = new Point(637, 125);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.PlaceholderText = "Ej: 10123456";
            txtDNI.Size = new Size(130, 24);
            txtDNI.TabIndex = 5;
            txtDNI.TextAlign = HorizontalAlignment.Center;
            txtDNI.Validating += txtDni_Validating;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.BackColor = Color.Transparent;
            lblDNI.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblDNI.Location = new Point(595, 129);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(38, 18);
            lblDNI.TabIndex = 4;
            lblDNI.Text = "DNI";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(130, 173);
            txtApellido.MaxLength = 200;
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ej: Juan";
            txtApellido.Size = new Size(250, 24);
            txtApellido.TabIndex = 7;
            txtApellido.Validating += txtApellido_Validating;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(55, 175);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(63, 18);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(517, 173);
            txtNombre.MaxLength = 200;
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ej: Perez";
            txtNombre.Size = new Size(250, 24);
            txtNombre.TabIndex = 9;
            txtNombre.Validating += txtNombre_Validating;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(447, 176);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(58, 18);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre";
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtEdad.Location = new Point(109, 223);
            txtEdad.MaxLength = 2;
            txtEdad.Name = "txtEdad";
            txtEdad.PlaceholderText = "Ej: 35";
            txtEdad.Size = new Size(61, 24);
            txtEdad.TabIndex = 11;
            txtEdad.TextAlign = HorizontalAlignment.Center;
            txtEdad.Validating += txtEdad_Validating;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.BackColor = Color.Transparent;
            lblEdad.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblEdad.Location = new Point(55, 226);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(42, 18);
            lblEdad.TabIndex = 10;
            lblEdad.Text = "Edad";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(480, 223);
            txtEmail.MaxLength = 200;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Ej: nombre@gmail.com";
            txtEmail.Size = new Size(287, 24);
            txtEmail.TabIndex = 15;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.BackColor = Color.Transparent;
            lblGenero.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenero.Location = new Point(196, 226);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(53, 18);
            lblGenero.TabIndex = 12;
            lblGenero.Text = "Genero";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(426, 226);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 18);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email";
            // 
            // cmbGenero
            // 
            cmbGenero.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(262, 223);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(110, 26);
            cmbGenero.TabIndex = 13;
            cmbGenero.Validating += cmbGenero_Validating;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkSeaGreen;
            btnGuardar.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(165, 289);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(165, 38);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(502, 289);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(165, 38);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.Transparent;
            lblEstado.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstado.Location = new Point(335, 127);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(76, 18);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Estado (*)";
            // 
            // cmbEstado
            // 
            cmbEstado.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(420, 124);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(130, 26);
            cmbEstado.TabIndex = 3;
            cmbEstado.Validating += cmbEstado_Validating;
            // 
            // lblIndicador
            // 
            lblIndicador.AutoSize = true;
            lblIndicador.BackColor = Color.Transparent;
            lblIndicador.Font = new Font("Nirmala UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lblIndicador.Location = new Point(55, 367);
            lblIndicador.Name = "lblIndicador";
            lblIndicador.Size = new Size(229, 12);
            lblIndicador.TabIndex = 18;
            lblIndicador.Text = "(*) Indique :  Activo para Altas / Inactivo para Bajas.";
            // 
            // FrmCarga_Pasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Fondo_sub_form;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(834, 457);
            Controls.Add(lblIndicador);
            Controls.Add(cmbEstado);
            Controls.Add(lblEstado);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbGenero);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblGenero);
            Controls.Add(txtEdad);
            Controls.Add(lblEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtDNI);
            Controls.Add(lblDNI);
            Controls.Add(txtId_Pasajero);
            Controls.Add(lblID);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(850, 496);
            MinimumSize = new Size(850, 496);
            Name = "FrmCarga_Pasajero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pasajero";
            Load += FrmPasajero_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private TextBox txtId_Pasajero;
        private TextBox txtDNI;
        private Label lblDNI;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtEdad;
        private Label lblEdad;
        private TextBox txtEmail;
        private Label lblGenero;
        private Label lblEmail;
        private ComboBox cmbGenero;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label lblEstado;
        private ComboBox cmbEstado;
        private Label lblIndicador;
    }
}