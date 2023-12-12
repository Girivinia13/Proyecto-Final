namespace FormAgenciaTurismo
{
    partial class FrmList_Base_General
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmList_Base_General));
            lstGeneral = new ListBox();
            btnSalir = new Button();
            lblFiltro = new Label();
            lblOrden = new Label();
            cmbFiltro = new ComboBox();
            btnListar = new Button();
            btnImprimir = new Button();
            cmbOrden = new ComboBox();
            sfdGuardar = new SaveFileDialog();
            ofdAbrir = new OpenFileDialog();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lstGeneral
            // 
            lstGeneral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstGeneral.BackColor = Color.PapayaWhip;
            lstGeneral.Cursor = Cursors.Hand;
            lstGeneral.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstGeneral.FormattingEnabled = true;
            lstGeneral.ItemHeight = 17;
            lstGeneral.Location = new Point(21, 127);
            lstGeneral.Margin = new Padding(5);
            lstGeneral.MinimumSize = new Size(741, 242);
            lstGeneral.Name = "lstGeneral";
            lstGeneral.Size = new Size(791, 327);
            lstGeneral.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.CornflowerBlue;
            btnSalir.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Location = new Point(644, 503);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(165, 38);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblFiltro.Location = new Point(31, 23);
            lblFiltro.MinimumSize = new Size(89, 23);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(89, 23);
            lblFiltro.TabIndex = 19;
            lblFiltro.Text = "Filtrar por: ";
            // 
            // lblOrden
            // 
            lblOrden.AutoSize = true;
            lblOrden.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrden.Location = new Point(375, 22);
            lblOrden.MinimumSize = new Size(0, 23);
            lblOrden.Name = "lblOrden";
            lblOrden.Size = new Size(89, 23);
            lblOrden.TabIndex = 20;
            lblOrden.Text = "Ordenar por: ";
            // 
            // cmbFiltro
            // 
            cmbFiltro.BackColor = SystemColors.Control;
            cmbFiltro.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Location = new Point(31, 47);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new Size(314, 25);
            cmbFiltro.TabIndex = 21;
            // 
            // btnListar
            // 
            btnListar.BackColor = Color.FromArgb(255, 255, 192);
            btnListar.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            btnListar.Location = new Point(713, 30);
            btnListar.MinimumSize = new Size(0, 38);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(96, 38);
            btnListar.TabIndex = 22;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = false;
            btnListar.Click += btnListar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            btnImprimir.Location = new Point(398, 503);
            btnImprimir.MinimumSize = new Size(0, 38);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(165, 38);
            btnImprimir.TabIndex = 23;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // cmbOrden
            // 
            cmbOrden.BackColor = SystemColors.Control;
            cmbOrden.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOrden.FormattingEnabled = true;
            cmbOrden.Location = new Point(375, 47);
            cmbOrden.Name = "cmbOrden";
            cmbOrden.Size = new Size(314, 25);
            cmbOrden.TabIndex = 24;
            // 
            // ofdAbrir
            // 
            ofdAbrir.FileName = "openFileDialog1";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkSeaGreen;
            btnGuardar.Font = new Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(31, 502);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(165, 38);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmList_Base_General
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_sub_form;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(834, 561);
            Controls.Add(btnGuardar);
            Controls.Add(cmbOrden);
            Controls.Add(btnImprimir);
            Controls.Add(btnListar);
            Controls.Add(cmbFiltro);
            Controls.Add(lblOrden);
            Controls.Add(lblFiltro);
            Controls.Add(btnSalir);
            Controls.Add(lstGeneral);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(850, 600);
            MinimumSize = new Size(850, 600);
            Name = "FrmList_Base_General";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Base General";
            Load += FrmBase_General_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstGeneral;
        private Button btnSalir;
        private PrintDialog printDialog1;
        private Label label1;
        private Label label2;
        private ComboBox cmbFiltro;
        private Button button1;
        private Button btnImprimir;
        private Label lblFiltro;
        private Label lblOrden;
        private ComboBox cmbOrden;
        private Button btnListar;
        private SaveFileDialog sfdGuardar;
        private OpenFileDialog ofdAbrir;
        private Button btnGuardar;
        private PrintDialog printDialog2;
    }
}