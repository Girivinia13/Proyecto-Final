namespace FormAgenciaTurismo
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            menuPrincipal = new MenuStrip();
            smi_Archivos = new ToolStripMenuItem();
            smi_BaseGeneral = new ToolStripMenuItem();
            smi_BG_Pasajeros = new ToolStripMenuItem();
            smi_Contrataciones = new ToolStripMenuItem();
            smi_Paquetes = new ToolStripMenuItem();
            smi_Excursiones = new ToolStripMenuItem();
            smi_Backup = new ToolStripMenuItem();
            smi_BckGeneral = new ToolStripMenuItem();
            smi_BG_Pasajero = new ToolStripMenuItem();
            smi_BG_Contratacion = new ToolStripMenuItem();
            smi_BG_Paquete = new ToolStripMenuItem();
            smi_BG_Excursion = new ToolStripMenuItem();
            smi_Bck_Activos = new ToolStripMenuItem();
            smi_BA_Pasajero = new ToolStripMenuItem();
            smi_BA_Contratacion = new ToolStripMenuItem();
            smi_BA_Paquete = new ToolStripMenuItem();
            smi_BA_Excursion = new ToolStripMenuItem();
            smi_Pasajero = new ToolStripMenuItem();
            smi_Psj_Alta = new ToolStripMenuItem();
            smi_Psj_Activos = new ToolStripMenuItem();
            smi_Contratacion = new ToolStripMenuItem();
            smi_Cnt_Alta = new ToolStripMenuItem();
            smi_Cnt_Activas = new ToolStripMenuItem();
            smi_Paquete = new ToolStripMenuItem();
            smi_Paq_Alta = new ToolStripMenuItem();
            smi_Paq_Baja = new ToolStripMenuItem();
            smi_Salir = new ToolStripMenuItem();
            smi_Excursion = new ToolStripMenuItem();
            smi_Exc_Alta = new ToolStripMenuItem();
            smi_Exc_Baja = new ToolStripMenuItem();
            smi_Exc_Anexo = new ToolStripMenuItem();
            sfdGuardar = new SaveFileDialog();
            ofdAbrir = new OpenFileDialog();
            menuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuPrincipal
            // 
            menuPrincipal.BackColor = Color.Transparent;
            menuPrincipal.BackgroundImage = (Image)resources.GetObject("menuPrincipal.BackgroundImage");
            menuPrincipal.BackgroundImageLayout = ImageLayout.Stretch;
            menuPrincipal.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuPrincipal.GripMargin = new Padding(2);
            menuPrincipal.Items.AddRange(new ToolStripItem[] { smi_Archivos, smi_Pasajero, smi_Contratacion, smi_Paquete, smi_Salir, smi_Excursion });
            menuPrincipal.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Padding = new Padding(10, 10, 10, 6);
            menuPrincipal.Size = new Size(757, 38);
            menuPrincipal.TabIndex = 0;
            menuPrincipal.Text = "menuPrincipal";
            // 
            // smi_Archivos
            // 
            smi_Archivos.DropDownItems.AddRange(new ToolStripItem[] { smi_BaseGeneral, smi_Backup });
            smi_Archivos.Name = "smi_Archivos";
            smi_Archivos.Size = new Size(91, 22);
            smi_Archivos.Text = "Archivos";
            // 
            // smi_BaseGeneral
            // 
            smi_BaseGeneral.DropDownItems.AddRange(new ToolStripItem[] { smi_BG_Pasajeros, smi_Contrataciones, smi_Paquetes, smi_Excursiones });
            smi_BaseGeneral.Name = "smi_BaseGeneral";
            smi_BaseGeneral.Size = new Size(184, 22);
            smi_BaseGeneral.Text = "Base_General";
            // 
            // smi_BG_Pasajeros
            // 
            smi_BG_Pasajeros.Name = "smi_BG_Pasajeros";
            smi_BG_Pasajeros.Size = new Size(197, 22);
            smi_BG_Pasajeros.Text = "Pasajeros";
            smi_BG_Pasajeros.Click += smi_Pasajeros_Click;
            // 
            // smi_Contrataciones
            // 
            smi_Contrataciones.Name = "smi_Contrataciones";
            smi_Contrataciones.Size = new Size(197, 22);
            smi_Contrataciones.Text = "Contrataciones";
            smi_Contrataciones.Click += smi_Contrataciones_Click;
            // 
            // smi_Paquetes
            // 
            smi_Paquetes.Name = "smi_Paquetes";
            smi_Paquetes.Size = new Size(197, 22);
            smi_Paquetes.Text = "Paquetes";
            smi_Paquetes.Click += smi_Paquetes_Click;
            // 
            // smi_Excursiones
            // 
            smi_Excursiones.Name = "smi_Excursiones";
            smi_Excursiones.Size = new Size(197, 22);
            smi_Excursiones.Text = "Excursiones";
            smi_Excursiones.Click += smi_Excursiones_Click;
            // 
            // smi_Backup
            // 
            smi_Backup.DropDownItems.AddRange(new ToolStripItem[] { smi_BckGeneral, smi_Bck_Activos });
            smi_Backup.Name = "smi_Backup";
            smi_Backup.Size = new Size(184, 22);
            smi_Backup.Text = "Backup";
            // 
            // smi_BckGeneral
            // 
            smi_BckGeneral.DropDownItems.AddRange(new ToolStripItem[] { smi_BG_Pasajero, smi_BG_Contratacion, smi_BG_Paquete, smi_BG_Excursion });
            smi_BckGeneral.Name = "smi_BckGeneral";
            smi_BckGeneral.Size = new Size(175, 22);
            smi_BckGeneral.Text = "Bck_General";
            // 
            // smi_BG_Pasajero
            // 
            smi_BG_Pasajero.Name = "smi_BG_Pasajero";
            smi_BG_Pasajero.Size = new Size(209, 22);
            smi_BG_Pasajero.Text = "BG_Pasajero";
            smi_BG_Pasajero.Click += smi_BG_Pasajero_Click;
            // 
            // smi_BG_Contratacion
            // 
            smi_BG_Contratacion.Name = "smi_BG_Contratacion";
            smi_BG_Contratacion.Size = new Size(209, 22);
            smi_BG_Contratacion.Text = "BG_Contratacion";
            // 
            // smi_BG_Paquete
            // 
            smi_BG_Paquete.Name = "smi_BG_Paquete";
            smi_BG_Paquete.Size = new Size(209, 22);
            smi_BG_Paquete.Text = "BG_Paquete";
            // 
            // smi_BG_Excursion
            // 
            smi_BG_Excursion.Name = "smi_BG_Excursion";
            smi_BG_Excursion.Size = new Size(209, 22);
            smi_BG_Excursion.Text = "BG_Excursion";
            // 
            // smi_Bck_Activos
            // 
            smi_Bck_Activos.DropDownItems.AddRange(new ToolStripItem[] { smi_BA_Pasajero, smi_BA_Contratacion, smi_BA_Paquete, smi_BA_Excursion });
            smi_Bck_Activos.Name = "smi_Bck_Activos";
            smi_Bck_Activos.Size = new Size(175, 22);
            smi_Bck_Activos.Text = "Bck_Activos";
            // 
            // smi_BA_Pasajero
            // 
            smi_BA_Pasajero.Name = "smi_BA_Pasajero";
            smi_BA_Pasajero.Size = new Size(208, 22);
            smi_BA_Pasajero.Text = "BA_Pasajero";
            smi_BA_Pasajero.Click += smi_BA_Pasajero_Click;
            // 
            // smi_BA_Contratacion
            // 
            smi_BA_Contratacion.Name = "smi_BA_Contratacion";
            smi_BA_Contratacion.Size = new Size(208, 22);
            smi_BA_Contratacion.Text = "BA_Contratacion";
            // 
            // smi_BA_Paquete
            // 
            smi_BA_Paquete.Name = "smi_BA_Paquete";
            smi_BA_Paquete.Size = new Size(208, 22);
            smi_BA_Paquete.Text = "BA_Paquete";
            // 
            // smi_BA_Excursion
            // 
            smi_BA_Excursion.Name = "smi_BA_Excursion";
            smi_BA_Excursion.Size = new Size(208, 22);
            smi_BA_Excursion.Text = "BA_Excursion";
            // 
            // smi_Pasajero
            // 
            smi_Pasajero.DropDownItems.AddRange(new ToolStripItem[] { smi_Psj_Alta, smi_Psj_Activos });
            smi_Pasajero.Name = "smi_Pasajero";
            smi_Pasajero.Size = new Size(91, 22);
            smi_Pasajero.Text = "Pasajero";
            // 
            // smi_Psj_Alta
            // 
            smi_Psj_Alta.Name = "smi_Psj_Alta";
            smi_Psj_Alta.Size = new Size(170, 22);
            smi_Psj_Alta.Text = "Psj_Alta";
            smi_Psj_Alta.Click += smi_Psj_Alta_Click;
            // 
            // smi_Psj_Activos
            // 
            smi_Psj_Activos.Name = "smi_Psj_Activos";
            smi_Psj_Activos.Size = new Size(170, 22);
            smi_Psj_Activos.Text = "Psj_Activos";
            smi_Psj_Activos.Click += smi_Psj_Activos_Click;
            // 
            // smi_Contratacion
            // 
            smi_Contratacion.DropDownItems.AddRange(new ToolStripItem[] { smi_Cnt_Alta, smi_Cnt_Activas });
            smi_Contratacion.Name = "smi_Contratacion";
            smi_Contratacion.Size = new Size(122, 22);
            smi_Contratacion.Text = "Contratacion";
            // 
            // smi_Cnt_Alta
            // 
            smi_Cnt_Alta.Name = "smi_Cnt_Alta";
            smi_Cnt_Alta.Size = new Size(170, 22);
            smi_Cnt_Alta.Text = "Cnt_Alta";
            smi_Cnt_Alta.Click += smi_Cnt_Alta_Click;
            // 
            // smi_Cnt_Activas
            // 
            smi_Cnt_Activas.Name = "smi_Cnt_Activas";
            smi_Cnt_Activas.Size = new Size(170, 22);
            smi_Cnt_Activas.Text = "Cnt_Activas";
            smi_Cnt_Activas.Click += smi_Cnt_Activas_Click;
            // 
            // smi_Paquete
            // 
            smi_Paquete.DropDownItems.AddRange(new ToolStripItem[] { smi_Paq_Alta, smi_Paq_Baja });
            smi_Paquete.Name = "smi_Paquete";
            smi_Paquete.Size = new Size(86, 22);
            smi_Paquete.Text = "Paquete";
            // 
            // smi_Paq_Alta
            // 
            smi_Paq_Alta.Name = "smi_Paq_Alta";
            smi_Paq_Alta.Size = new Size(174, 22);
            smi_Paq_Alta.Text = "Paq_Alta";
            smi_Paq_Alta.Click += smi_Paq_Alta_Click;
            // 
            // smi_Paq_Baja
            // 
            smi_Paq_Baja.Name = "smi_Paq_Baja";
            smi_Paq_Baja.Size = new Size(174, 22);
            smi_Paq_Baja.Text = "Paq_Activos";
            // 
            // smi_Salir
            // 
            smi_Salir.Alignment = ToolStripItemAlignment.Right;
            smi_Salir.Name = "smi_Salir";
            smi_Salir.Size = new Size(73, 22);
            smi_Salir.Text = "Salir ->";
            smi_Salir.Click += smi_Salir_Click;
            // 
            // smi_Excursion
            // 
            smi_Excursion.DropDownItems.AddRange(new ToolStripItem[] { smi_Exc_Alta, smi_Exc_Baja, smi_Exc_Anexo });
            smi_Excursion.Name = "smi_Excursion";
            smi_Excursion.Size = new Size(100, 22);
            smi_Excursion.Text = "Excursion";
            // 
            // smi_Exc_Alta
            // 
            smi_Exc_Alta.Name = "smi_Exc_Alta";
            smi_Exc_Alta.Size = new Size(172, 22);
            smi_Exc_Alta.Text = "Exc_Alta";
            // 
            // smi_Exc_Baja
            // 
            smi_Exc_Baja.Name = "smi_Exc_Baja";
            smi_Exc_Baja.Size = new Size(172, 22);
            smi_Exc_Baja.Text = "Exc_Activas";
            // 
            // smi_Exc_Anexo
            // 
            smi_Exc_Anexo.Name = "smi_Exc_Anexo";
            smi_Exc_Anexo.Size = new Size(172, 22);
            smi_Exc_Anexo.Text = "Exc_Anexo";
            // 
            // ofdAbrir
            // 
            ofdAbrir.FileName = "openFileDialog1";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_form_agenci_tur;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(757, 437);
            Controls.Add(menuPrincipal);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuPrincipal;
            MinimumSize = new Size(773, 476);
            Name = "FrmPrincipal";
            Text = "AGENCIA DE TURISMO";
            Load += FrmPrincipal_Load;
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuPrincipal;
        private ToolStripMenuItem smi_Archivos;
        private ToolStripMenuItem smi_Paquete;
        private ToolStripMenuItem smi_Pasajero;
        private ToolStripMenuItem smi_Contratacion;
        private ToolStripMenuItem smi_Salir;
        private ToolStripMenuItem smi_Paq_Alta;
        private ToolStripMenuItem smi_Paq_Baja;
        private ToolStripMenuItem smi_Psj_Alta;
        private ToolStripMenuItem smi_Cnt_Alta;
        private ToolStripMenuItem smi_Cnt_Activas;
        private ToolStripMenuItem smi_BaseGeneral;
        private ToolStripMenuItem smi_Psj_Activos;
        private ToolStripMenuItem smi_Backup;
        private ToolStripMenuItem smi_BckGeneral;
        private ToolStripMenuItem smi_BG_Pasajeros;
        private ToolStripMenuItem smi_Contrataciones;
        private ToolStripMenuItem smi_Paquetes;
        private ToolStripMenuItem smi_Bck_Activos;
        private ToolStripMenuItem smi_BG_Pasajero;
        private ToolStripMenuItem smi_BG_Contratacion;
        private ToolStripMenuItem smi_BG_Paquete;
        private ToolStripMenuItem smi_BA_Pasajero;
        private ToolStripMenuItem smi_BA_Contratacion;
        private ToolStripMenuItem smi_BA_Paquete;
        private ToolStripMenuItem smi_Excursiones;
        private ToolStripMenuItem smi_BG_Excursion;
        private ToolStripMenuItem smi_BA_Excursion;
        private ToolStripMenuItem smi_Excursion;
        private ToolStripMenuItem smi_Exc_Alta;
        private ToolStripMenuItem smi_Exc_Baja;
        private ToolStripMenuItem smi_Exc_Anexo;
        private SaveFileDialog sfdGuardar;
        private OpenFileDialog ofdAbrir;
    }
}