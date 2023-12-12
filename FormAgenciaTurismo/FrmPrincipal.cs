using Biblioteca_de_Clases;
using DataAgencia;

namespace FormAgenciaTurismo
{
    public partial class FrmPrincipal : Form
    {
        List<Pasajero> listaPasajerosActivos;
        List<Pasajero> listaPasajerosInactivos;
        

        //string pathInactivos = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\AGENCIA_TURISMO\Pas_Inactivos.xml";
        //string pathActivos = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\AGENCIA_TURISMO\Pas_Activos.xml";

        public FrmPrincipal()
        {
            InitializeComponent();
            listaPasajerosActivos = new List<Pasajero>();
            listaPasajerosInactivos = new List<Pasajero>();              
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            WindowState = FormWindowState.Maximized;
            try
            {
                listaPasajerosActivos = Agencia_Ado.MostrarPasajeros();
                listaPasajerosInactivos = Agencia_Ado.MostrarPasajerosInactivos();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region ARCHIVOS

        // --------------- BASE GENERAL ---------------
        private void smi_Pasajeros_Click(object sender, EventArgs e)
        {   //base general de pasajeros de ado
            try
            {
                FrmList_Base_General imprimirTodos = new(listaPasajerosActivos, listaPasajerosInactivos);
                if (listaPasajerosActivos.Count > 0 || listaPasajerosInactivos.Count > 0)
                {                  
                    imprimirTodos.MdiParent = this;
                    imprimirTodos.Show();
                }
                else
                {
                    MessageBox.Show("No existen datos", "Informe de archivo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR AL LISTAR BASE GENERAL DE PASAJEROS (Consulte lista en Backup): {ex.Message}");
            }
        }

        private void smi_Contrataciones_Click(object sender, EventArgs e)
        {

        }

        private void smi_Paquetes_Click(object sender, EventArgs e)
        {

        }

        private void smi_Excursiones_Click(object sender, EventArgs e)
        {

        }


        // ------------------ BACKUP ------------------
        private void smi_BG_Pasajero_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirArchivo();
              
                //listaPasajerosInactivos = Serializa<Pasajero>.LeerXml(pathInactivos);
                //listaPasajerosActivos = Serializa<Pasajero>.LeerXml(pathActivos);
                FrmList_Base_General imprimirTodos = new(listaPasajerosActivos, listaPasajerosInactivos);

                if (listaPasajerosActivos.Count > 0 || listaPasajerosInactivos.Count > 0)
                {                    
                    imprimirTodos.MdiParent = this;
                    imprimirTodos.Show();
                }
                else
                {
                    MessageBox.Show("No existen datos en backup", "Informe de archivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR AL LISTAR BACKUP GENERAL: {ex.Message}");
            }
        }

        private void smi_BA_Pasajero_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirArchivo();
                //listaPasajerosActivos = Serializa<Pasajero>.LeerXml(pathActivos);
                FrmList_Psj_Activos imprimirActivos = new(listaPasajerosActivos);

                if (listaPasajerosActivos.Count > 0)
                {
                    imprimirActivos.MdiParent = this;
                    imprimirActivos.Show();
                }
                else
                {
                    MessageBox.Show("No existen datos en backup", "Informe de archivo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR AL LISTAR BACKUP DE ACTIVOS: {ex.Message}");
            }
        }

        #endregion

        #region PASAJERO
        private void smi_Psj_Alta_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCarga_Pasajero formAlta = new();
                if (formAlta.ShowDialog() == DialogResult.OK)
                {
                    listaPasajerosActivos.Add(formAlta.PasajeroForm);
                    GuardarArchivo(listaPasajerosActivos);                   
                    //Serializa<Pasajero>.EscribirXml(listaPasajerosActivos, pathActivos);

                    if (Agencia_Ado.AltaPasajero(formAlta.PasajeroForm))
                    {
                        MessageBox.Show("BDD cargada correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Fallo en coneccion con la BDD");
                    }

                    MessageBox.Show("Carga exitosa", "Informe de Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Proceso cancelado por el usuario", "Informe de Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR EN ALTA: {ex.Message}");
            }
        }

        private void smi_Psj_Activos_Click(object sender, EventArgs e)
        {
            try
            {
                FrmList_Psj_Activos imprimirActivos = new(listaPasajerosActivos);
                if (listaPasajerosActivos.Count > 0)
                {
                    
                    imprimirActivos.MdiParent = this;
                    imprimirActivos.Show();
                }
                else
                {
                    MessageBox.Show("No existen datos", "Informe de archivo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR AL LISTAR ACTIVOS (Consulte lista en Backup): {ex.Message}");
            }
        }
        #endregion

        #region CONTRATACION
        private void smi_Cnt_Alta_Click(object sender, EventArgs e)
        {
            FrmContratacion formAlta = new FrmContratacion();
            formAlta.Show();
        }

        private void smi_Cnt_Activas_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region PAQUETE
        private void smi_Paq_Alta_Click(object sender, EventArgs e)
        {
            FrmCarga_Paquete formAlta = new FrmCarga_Paquete();
            formAlta.Show();
        }

        private void smi_Paq_Activos_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region EXCURSION

        #endregion

        #region SALIR
        private void smi_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region METODOS

        private void GuardarArchivo(List<Pasajero> lista)
        {
            string path;

            sfdGuardar.Title = "Guardar archivo";
            sfdGuardar.Filter = "Archivos de texto (*.txt) | *.txt | (*.xml) | *.xml";
            sfdGuardar.FileName = ".txt | .xml";

            sfdGuardar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (sfdGuardar.ShowDialog() == DialogResult.OK)
            {
                path = sfdGuardar.FileName;

                if (sfdGuardar.FileName == ".txt")
                {
                    Serializa<Pasajero>.EscribirTxt(lista, path);
                }
                else if (sfdGuardar.FileName == ".xml")
                {
                    Serializa<Pasajero>.EscribirXml(lista, path);
                }
            }
            else
            {
                MessageBox.Show("Accion cancelada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AbrirArchivo()
        {
            string path;

            ofdAbrir.Title = "Abrir archivo";
            ofdAbrir.Filter = "Archivos de texto (*.txt) | *.txt | (*.xml) | *.xml";
            ofdAbrir.FileName = "Seleccione un archivo";

            ofdAbrir.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (ofdAbrir.ShowDialog() == DialogResult.OK)
            {
                path = ofdAbrir.FileName;
                if (ofdAbrir.Filter == "Archivos de texto (*.txt) | *.txt")
                {
                    Serializa<Pasajero>.LeerTxt(path);
                }
                else if (ofdAbrir.Filter == "Archivos de texto (*.xml) | *.xml")
                {
                    Serializa<Pasajero>.LeerXml(path);
                }
            }
        }

        // --------------- PROYECCIONES ---------------

        //queris de ado
        /*
        StreamWriter sw = new StreamWriter(path. true);
        sw.WriteLine(txtEstadisticas.Text);
        sw.Close();
        */

        /*private void btnGuardar_Click(object sender, EventArgs e)
        {
        StreamWriter sw = new StreamWriter(path, true);
        sw.WriteLine(txtAnotador.Text);
        sw.Close();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
        string lectura;

        StreamReader sr = new StreamReader(path);
        lectura = sr.ReadToEnd();
        sr.Close();
        txtAnotador.Text = lectura;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
        txtAnotador.Clear();
        }*/

        #endregion
    }
}
