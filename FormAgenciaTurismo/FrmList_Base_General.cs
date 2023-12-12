using Biblioteca_de_Clases;
using DataAgencia;
using Google.Protobuf.Collections;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAgenciaTurismo
{
    public partial class FrmList_Base_General : Form
    {
        List<Pasajero> listaPasajerosActivos;
        List<Pasajero> listaPasajerosInactivos;

        //string pathInactivos = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\AGENCIA_TURISMO\Pas_Inactivos.xml";
        //string pathActivos = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\AGENCIA_TURISMO\Pas_Activos.xml";


        public FrmList_Base_General()
        {
            InitializeComponent();
        }

        public FrmList_Base_General(List<Pasajero> listaActivos, List<Pasajero> listaInactivos)
        {
            InitializeComponent();

            this.listaPasajerosActivos = listaActivos;
            this.listaPasajerosInactivos = listaInactivos;
        }

        private void FrmBase_General_Load(object sender, EventArgs e)
        {
            try
            {
                String[] filtros = { "Pasajeros -> Estado -> Activo", "Pasajeros -> Estado -> Inactivo" };

                String[] ordenados = { "Pasajeros -> Id_Pasajero -> De menor a mayor",
                    "Pasajeros -> Id_Pasajero -> De mayor a menor", "Pasajeros -> Apellido -> A - Z",
                    "Pasajeros -> Apellido -> Z - A", "Pasajeros -> Edad -> Menor de 18 años",
                    "Pasajeros -> Edad -> Entre 18 y 30 años", "Pasajeros -> Edad -> Entre 30 y 50 años",
                    "Pasajeros -> Edad -> Mayor de 50 años"};

                foreach (String item in filtros)
                {
                    cmbFiltro.Items.Add(item);
                }

                foreach (String item in ordenados)
                {
                    cmbOrden.Items.Add(item);
                }

                CargarListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR AL LISTAR BASE GENERAL: {ex.Message}");
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFiltro.SelectedIndex == 0)
                {
                    lstGeneral.Items.Clear();

                    foreach (Pasajero pasajero in listaPasajerosActivos)
                    {
                        lstGeneral.Items.Add(pasajero);
                    }

                    if (cmbOrden.SelectedIndex == 0)
                    {
                        lstGeneral.Items.Clear();

                    }
                }
                else if (cmbFiltro.SelectedIndex == 1)
                {
                    lstGeneral.Items.Clear();

                    foreach (Pasajero pasajero in listaPasajerosInactivos)
                    {
                        lstGeneral.Items.Add(pasajero);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en buscador: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {








            //List<Pasajero> listaFiltro = new List<Pasajero>();
            //foreach (Pasajero item in lstGeneral.Items)
            //{
            //    listaFiltro.Add(item);
            //}

            //GuardarArchivo(listaFiltro);

            //lstGeneral.DataSource = null;
            //lstGeneral.DataSource = listaFiltro;              


        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //PrintDialog prtImprimir = new PrintDialog();
            //PrinterSettings ps = new PrinterSettings();
            //prtImprimir.PrinterSettings = ps;
            //prtImprimir.PrintPage += Imprimir;
            //prtImprimir.Print();
            PrintDocument printDoc = new();
            PrinterSettings ps = new();
            printDoc.PrinterSettings = ps;
            printDoc.PrintPage += Imprimir;
            printDoc.Print();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarListBox()
        {
            try
            {
                lstGeneral.Items.Clear();
                foreach (Pasajero activo in listaPasajerosActivos)
                {
                    lstGeneral.Items.Add(activo);
                }
                foreach (Pasajero inactivo in listaPasajerosInactivos)
                {
                    lstGeneral.Items.Add(inactivo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar listado de activos: {ex.Message}");
            }
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
            //e.Graphics.DrawString()
        }

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

        
    }
}
