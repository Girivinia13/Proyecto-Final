namespace FormAgenciaTurismo
{
    partial class FrmList_Psj_Activos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmList_Psj_Activos));
            lstActivos = new ListBox();
            btnSalir = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            lblFiltro = new Label();
            cmbFiltro = new ComboBox();
            lblDato = new Label();
            txtDato = new TextBox();
            btnBuscar = new Button();
            lstFiltro = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstActivos
            // 
            lstActivos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstActivos.BackColor = Color.Honeydew;
            lstActivos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstActivos.FormattingEnabled = true;
            lstActivos.HorizontalScrollbar = true;
            lstActivos.ItemHeight = 20;
            lstActivos.Location = new Point(16, 131);
            lstActivos.MinimumSize = new Size(744, 304);
            lstActivos.Name = "lstActivos";
            lstActivos.ScrollAlwaysVisible = true;
            lstActivos.Size = new Size(794, 324);
            lstActivos.TabIndex = 6;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.CornflowerBlue;
            btnSalir.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Location = new Point(626, 501);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(165, 38);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.DarkSeaGreen;
            btnModificar.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(39, 501);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(165, 38);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.LightCoral;
            btnEliminar.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(331, 501);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(165, 38);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Modern No. 20", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFiltro.Location = new Point(19, 16);
            lblFiltro.MinimumSize = new Size(0, 22);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(90, 22);
            lblFiltro.TabIndex = 0;
            lblFiltro.Text = "Consultar por : ";
            lblFiltro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbFiltro
            // 
            cmbFiltro.BackColor = SystemColors.Control;
            cmbFiltro.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Location = new Point(117, 14);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new Size(121, 25);
            cmbFiltro.TabIndex = 1;
            // 
            // lblDato
            // 
            lblDato.AutoSize = true;
            lblDato.Font = new Font("Modern No. 20", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDato.Location = new Point(348, 16);
            lblDato.MinimumSize = new Size(0, 22);
            lblDato.Name = "lblDato";
            lblDato.Size = new Size(75, 22);
            lblDato.TabIndex = 2;
            lblDato.Text = "Cargar dato :";
            lblDato.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDato
            // 
            txtDato.BackColor = SystemColors.Control;
            txtDato.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDato.Location = new Point(430, 15);
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(140, 25);
            txtDato.TabIndex = 3;
            txtDato.TextAlign = HorizontalAlignment.Center;
            txtDato.Validating += txtDato_Validating;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(255, 255, 192);
            btnBuscar.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(673, 11);
            btnBuscar.MinimumSize = new Size(0, 29);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(137, 29);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lstFiltro
            // 
            lstFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstFiltro.BackColor = Color.PapayaWhip;
            lstFiltro.BorderStyle = BorderStyle.None;
            lstFiltro.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lstFiltro.FormattingEnabled = true;
            lstFiltro.HorizontalScrollbar = true;
            lstFiltro.ItemHeight = 20;
            lstFiltro.Location = new Point(16, 49);
            lstFiltro.MinimumSize = new Size(794, 30);
            lstFiltro.Name = "lstFiltro";
            lstFiltro.Size = new Size(794, 40);
            lstFiltro.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Modern No. 20", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 106);
            label1.MinimumSize = new Size(0, 22);
            label1.Name = "label1";
            label1.Size = new Size(252, 22);
            label1.TabIndex = 10;
            label1.Text = "Seleccione item para Modificar o Eliminar : ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmList_Psj_Activos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_sub_form;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(830, 557);
            Controls.Add(label1);
            Controls.Add(lstFiltro);
            Controls.Add(btnBuscar);
            Controls.Add(txtDato);
            Controls.Add(lblDato);
            Controls.Add(cmbFiltro);
            Controls.Add(lblFiltro);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnSalir);
            Controls.Add(lstActivos);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(850, 600);
            MinimumSize = new Size(850, 600);
            Name = "FrmList_Psj_Activos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pasajeros Activos";
            Load += FrmPas_Activos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstActivos;
        private Button btnSalir;
        private Button btnModificar;
        private Button btnEliminar;
        private Label lblFiltro;
        private ComboBox cmbFiltro;
        private Label lblDato;
        private TextBox txtDato;
        private Button btnBuscar;
        private ListBox lstFiltro;
        private Label label1;
    }
}