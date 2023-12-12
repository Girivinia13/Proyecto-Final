namespace FormAgenciaTurismo
{
    partial class FrmContratacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContratacion));
            lblIDPaquete = new Label();
            txtPaquete = new TextBox();
            txtPasajero = new TextBox();
            lblIDPasajero = new Label();
            lblPrecioFinal = new Label();
            grpMedioPago = new GroupBox();
            lblCuotas = new Label();
            nupCuotas = new NumericUpDown();
            chkCredito = new CheckBox();
            chkDebito = new CheckBox();
            chkTransferencia = new CheckBox();
            chkEfectivo = new CheckBox();
            txtPrecioFinal = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtPrecioBase = new TextBox();
            label1 = new Label();
            btnSalir = new Button();
            btnGuardar = new Button();
            grpMedioPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupCuotas).BeginInit();
            SuspendLayout();
            // 
            // lblIDPaquete
            // 
            lblIDPaquete.AutoSize = true;
            lblIDPaquete.BackColor = Color.Transparent;
            lblIDPaquete.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblIDPaquete.ForeColor = Color.Black;
            lblIDPaquete.Location = new Point(54, 163);
            lblIDPaquete.Name = "lblIDPaquete";
            lblIDPaquete.Size = new Size(78, 17);
            lblIDPaquete.TabIndex = 2;
            lblIDPaquete.Text = "ID Paquete";
            // 
            // txtPaquete
            // 
            txtPaquete.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaquete.ForeColor = Color.Black;
            txtPaquete.Location = new Point(168, 159);
            txtPaquete.Name = "txtPaquete";
            txtPaquete.Size = new Size(115, 24);
            txtPaquete.TabIndex = 3;
            // 
            // txtPasajero
            // 
            txtPasajero.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            txtPasajero.ForeColor = Color.Black;
            txtPasajero.Location = new Point(168, 119);
            txtPasajero.Name = "txtPasajero";
            txtPasajero.Size = new Size(115, 24);
            txtPasajero.TabIndex = 1;
            // 
            // lblIDPasajero
            // 
            lblIDPasajero.AutoSize = true;
            lblIDPasajero.BackColor = Color.Transparent;
            lblIDPasajero.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblIDPasajero.ForeColor = Color.Black;
            lblIDPasajero.Location = new Point(54, 122);
            lblIDPasajero.Name = "lblIDPasajero";
            lblIDPasajero.Size = new Size(82, 17);
            lblIDPasajero.TabIndex = 0;
            lblIDPasajero.Text = "ID Pasajero";
            // 
            // lblPrecioFinal
            // 
            lblPrecioFinal.AutoSize = true;
            lblPrecioFinal.BackColor = Color.Transparent;
            lblPrecioFinal.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioFinal.ForeColor = Color.Black;
            lblPrecioFinal.Location = new Point(54, 240);
            lblPrecioFinal.Name = "lblPrecioFinal";
            lblPrecioFinal.Size = new Size(103, 17);
            lblPrecioFinal.TabIndex = 13;
            lblPrecioFinal.Text = "Precio Final  $";
            // 
            // grpMedioPago
            // 
            grpMedioPago.Controls.Add(lblCuotas);
            grpMedioPago.Controls.Add(nupCuotas);
            grpMedioPago.Controls.Add(chkCredito);
            grpMedioPago.Controls.Add(chkDebito);
            grpMedioPago.Controls.Add(chkTransferencia);
            grpMedioPago.Controls.Add(chkEfectivo);
            grpMedioPago.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            grpMedioPago.ForeColor = Color.Black;
            grpMedioPago.Location = new Point(347, 119);
            grpMedioPago.Name = "grpMedioPago";
            grpMedioPago.Size = new Size(357, 142);
            grpMedioPago.TabIndex = 6;
            grpMedioPago.TabStop = false;
            grpMedioPago.Text = "Medios de Pago";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(208, 66);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(48, 17);
            lblCuotas.TabIndex = 11;
            lblCuotas.Text = "Cuotas";
            // 
            // nupCuotas
            // 
            nupCuotas.Increment = new decimal(new int[] { 3, 0, 0, 0 });
            nupCuotas.Location = new Point(260, 63);
            nupCuotas.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nupCuotas.Name = "nupCuotas";
            nupCuotas.Size = new Size(50, 24);
            nupCuotas.TabIndex = 12;
            nupCuotas.TextAlign = HorizontalAlignment.Center;
            nupCuotas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chkCredito
            // 
            chkCredito.AutoSize = true;
            chkCredito.Location = new Point(191, 36);
            chkCredito.Name = "chkCredito";
            chkCredito.Size = new Size(120, 21);
            chkCredito.TabIndex = 10;
            chkCredito.Text = "Tarjeta Credito";
            chkCredito.UseVisualStyleBackColor = true;
            // 
            // chkDebito
            // 
            chkDebito.AutoSize = true;
            chkDebito.Location = new Point(37, 96);
            chkDebito.Name = "chkDebito";
            chkDebito.Size = new Size(117, 21);
            chkDebito.TabIndex = 9;
            chkDebito.Text = "Tarjeta Debito";
            chkDebito.UseVisualStyleBackColor = true;
            // 
            // chkTransferencia
            // 
            chkTransferencia.AutoSize = true;
            chkTransferencia.Location = new Point(37, 66);
            chkTransferencia.Name = "chkTransferencia";
            chkTransferencia.Size = new Size(111, 21);
            chkTransferencia.TabIndex = 8;
            chkTransferencia.Text = "Transferencia";
            chkTransferencia.UseVisualStyleBackColor = true;
            // 
            // chkEfectivo
            // 
            chkEfectivo.AutoSize = true;
            chkEfectivo.Location = new Point(37, 36);
            chkEfectivo.Name = "chkEfectivo";
            chkEfectivo.Size = new Size(77, 21);
            chkEfectivo.TabIndex = 7;
            chkEfectivo.Text = "Efectivo";
            chkEfectivo.UseVisualStyleBackColor = true;
            // 
            // txtPrecioFinal
            // 
            txtPrecioFinal.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioFinal.ForeColor = Color.Black;
            txtPrecioFinal.Location = new Point(168, 237);
            txtPrecioFinal.Name = "txtPrecioFinal";
            txtPrecioFinal.Size = new Size(115, 24);
            txtPrecioFinal.TabIndex = 14;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.LightGreen;
            btnAceptar.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Black;
            btnAceptar.Location = new Point(55, 306);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(110, 38);
            btnAceptar.TabIndex = 15;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(199, 306);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(110, 38);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtPrecioBase
            // 
            txtPrecioBase.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioBase.ForeColor = Color.Black;
            txtPrecioBase.Location = new Point(168, 197);
            txtPrecioBase.Name = "txtPrecioBase";
            txtPrecioBase.Size = new Size(115, 24);
            txtPrecioBase.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(54, 200);
            label1.Name = "label1";
            label1.Size = new Size(98, 17);
            label1.TabIndex = 4;
            label1.Text = "Precio Base  $";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.SkyBlue;
            btnSalir.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Location = new Point(595, 306);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(110, 38);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(255, 192, 255);
            btnGuardar.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(451, 306);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 38);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmContratacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Fondo_sub_form;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(757, 437);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(txtPrecioBase);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtPrecioFinal);
            Controls.Add(grpMedioPago);
            Controls.Add(lblPrecioFinal);
            Controls.Add(txtPasajero);
            Controls.Add(lblIDPasajero);
            Controls.Add(txtPaquete);
            Controls.Add(lblIDPaquete);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmContratacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contratacion";
            grpMedioPago.ResumeLayout(false);
            grpMedioPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupCuotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIDPaquete;
        private TextBox txtPaquete;
        private TextBox txtPasajero;
        private Label lblIDPasajero;
        private Label lblPrecioFinal;
        private GroupBox grpMedioPago;
        private CheckBox chkDebito;
        private CheckBox chkEfectivo;
        private CheckBox chkCredito;
        private TextBox txtPrecioFinal;
        private Label lblCuotas;
        private NumericUpDown nupCuotas;
        private Button btnAceptar;
        private Button btnCancelar;
        private CheckBox chkTransferencia;
        private TextBox txtPrecioBase;
        private Label label1;
        private Button btnSalir;
        private Button btnGuardar;
    }
}