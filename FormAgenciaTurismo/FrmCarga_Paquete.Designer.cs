namespace FormAgenciaTurismo
{
    partial class FrmCarga_Paquete
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
            lblPaquete = new Label();
            txtPaquete = new TextBox();
            txtPrecioBase = new TextBox();
            lblPrecio = new Label();
            lblDescripcion = new Label();
            cmbDescripcion = new ComboBox();
            lblExcursiones = new Label();
            lblFecha = new Label();
            btnSalir = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnAceptar = new Button();
            dtpFecha = new DateTimePicker();
            nudExcursiones = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudExcursiones).BeginInit();
            SuspendLayout();
            // 
            // lblPaquete
            // 
            lblPaquete.AutoSize = true;
            lblPaquete.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaquete.Location = new Point(53, 128);
            lblPaquete.Name = "lblPaquete";
            lblPaquete.Size = new Size(78, 17);
            lblPaquete.TabIndex = 0;
            lblPaquete.Text = "ID Paquete";
            // 
            // txtPaquete
            // 
            txtPaquete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaquete.Location = new Point(158, 124);
            txtPaquete.Name = "txtPaquete";
            txtPaquete.Size = new Size(120, 25);
            txtPaquete.TabIndex = 1;
            // 
            // txtPrecioBase
            // 
            txtPrecioBase.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioBase.Location = new Point(583, 224);
            txtPrecioBase.Name = "txtPrecioBase";
            txtPrecioBase.Size = new Size(120, 25);
            txtPrecioBase.TabIndex = 9;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(464, 228);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(94, 17);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio Base $";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(51, 177);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(80, 17);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripcion";
            // 
            // cmbDescripcion
            // 
            cmbDescripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDescripcion.FormattingEnabled = true;
            cmbDescripcion.Location = new Point(158, 173);
            cmbDescripcion.Name = "cmbDescripcion";
            cmbDescripcion.Size = new Size(545, 25);
            cmbDescripcion.TabIndex = 5;
            // 
            // lblExcursiones
            // 
            lblExcursiones.AutoSize = true;
            lblExcursiones.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblExcursiones.Location = new Point(51, 224);
            lblExcursiones.Name = "lblExcursiones";
            lblExcursiones.Size = new Size(81, 17);
            lblExcursiones.TabIndex = 6;
            lblExcursiones.Text = "Excursiones";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(381, 128);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(44, 17);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.SkyBlue;
            btnSalir.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Location = new Point(599, 303);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(110, 38);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(255, 192, 255);
            btnGuardar.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(459, 303);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 38);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(189, 303);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 38);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.LightGreen;
            btnAceptar.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Black;
            btnAceptar.Location = new Point(47, 303);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(110, 38);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFecha.Location = new Point(448, 125);
            dtpFecha.MaxDate = new DateTime(2200, 12, 31, 0, 0, 0, 0);
            dtpFecha.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(256, 25);
            dtpFecha.TabIndex = 3;
            // 
            // nudExcursiones
            // 
            nudExcursiones.Location = new Point(158, 222);
            nudExcursiones.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudExcursiones.Name = "nudExcursiones";
            nudExcursiones.Size = new Size(120, 23);
            nudExcursiones.TabIndex = 7;
            nudExcursiones.TextAlign = HorizontalAlignment.Center;
            // 
            // FrmPaquete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_sub_form;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(757, 437);
            Controls.Add(nudExcursiones);
            Controls.Add(dtpFecha);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblFecha);
            Controls.Add(lblExcursiones);
            Controls.Add(cmbDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(txtPrecioBase);
            Controls.Add(lblPrecio);
            Controls.Add(txtPaquete);
            Controls.Add(lblPaquete);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            Name = "FrmPaquete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paquete";
            ((System.ComponentModel.ISupportInitialize)nudExcursiones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPaquete;
        private TextBox txtPaquete;
        private TextBox txtPrecioBase;
        private Label lblPrecio;
        private Label lblDescripcion;
        private ComboBox cmbDescripcion;
        private Label lblExcursiones;
        private Label lblFecha;
        private Button btnSalir;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnAceptar;
        private DateTimePicker dtpFecha;
        private NumericUpDown nudExcursiones;
    }
}