using Biblioteca_de_Clases;
using DataAgencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAgenciaTurismo
{
    public partial class FrmList_Psj_Activos : Form
    {

        List<Pasajero> listaActivos;

        string pathInactivos = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\AGENCIA_TURISMO\Pas_Inactivos.xml";
        string pathActivos = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\AGENCIA_TURISMO\Pas_Activos.xml";

        public FrmList_Psj_Activos(List<Pasajero> lista)
        {
            InitializeComponent();
            this.listaActivos = lista;
        }

        private void FrmPas_Activos_Load(object sender, EventArgs e)
        {
            String[] filtros = { "Id_Pasajero", "DNI" };
            try
            {
                foreach (String item in filtros)
                {
                    cmbFiltro.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Load: " + ex.Message);
            }

            CargarListBoxActivos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFiltro.SelectedIndex == 0)
                {
                    int id_Pasajero = int.Parse(this.txtDato.Text);

                    foreach (Pasajero pasajero in listaActivos)
                    {
                        if (pasajero.Id_Pasajero == id_Pasajero)
                        {
                            lstFiltro.Items.Clear();
                            lstFiltro.Items.Add(pasajero);
                        }
                    }
                }
                else if (cmbFiltro.SelectedIndex == 1)
                {
                    int dni = int.Parse(this.txtDato.Text);

                    foreach (Pasajero pasajero in listaActivos)
                    {
                        if (pasajero.DNI == dni)
                        {
                            lstFiltro.Items.Clear();
                            lstFiltro.Items.Add(pasajero);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en buscador: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = lstActivos.SelectedIndex;
                ValidarIndice(indice);
                Pasajero pasajeroModif = listaActivos[indice];
                FrmCarga_Pasajero formModificar = new(pasajeroModif);
                MessageBox.Show($"Se modificará el pasajero: {pasajeroModif}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (formModificar.ShowDialog() == DialogResult.OK)
                {
                    listaActivos[indice] = formModificar.PasajeroForm;
                    if (Agencia_Ado.ModificarPasajero(pasajeroModif))
                    {
                        MessageBox.Show("BDD actualizada correctamente", "Informe de MySQL");
                    }
                    else
                    {
                        MessageBox.Show("Fallo en conección con la BDD", "Informe de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    CargarListBoxActivos();
                    CargarBackup();
                    MessageBox.Show("Lista actualizada", "Informe de xml");
                }
                else
                {
                    MessageBox.Show("Acción cancelada por el usuario", "Informe del Formulario", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR AL MODIFICAR: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = lstActivos.SelectedIndex;
                ValidarIndice(indice);                
                Pasajero pasajeroElim = listaActivos[indice];
                FrmCarga_Pasajero formEliminar = new FrmCarga_Pasajero(pasajeroElim);
                MessageBox.Show($"Se eliminará el pasajero: {pasajeroElim}", "Baja de empleado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (formEliminar.ShowDialog() == DialogResult.OK)
                {
                    if (Agencia_Ado.AltaPasajeroInactivo(pasajeroElim))
                    {
                        if (Agencia_Ado.EliminarPasajero(pasajeroElim))
                        {
                            MessageBox.Show("BDD actualizada correctamente");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error en conección con BDD, verifique Backup");
                        ProcesarCambioBajaBackup(pasajeroElim);
                    }
                    CargarListBoxActivos();
                    CargarBackup();
                }
                else
                {
                    MessageBox.Show("Accion cancelada por el usuario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR AL ELIMINAR PASAJEROS ACTIVOS: {ex.Message}");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region METODOS

        private void CargarListBoxActivos()
        {
            try
            {
                lstActivos.Items.Clear();
                foreach (Pasajero pasajero in listaActivos)
                {
                    lstActivos.Items.Add(pasajero);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar listado de activos: {ex.Message}");
            }
        }

        private void ProcesarCambioBajaBackup(Pasajero pasajero)
        {
            try
            {
                List<Pasajero> listaInactivos = new List<Pasajero>();                         
                listaInactivos.Add(pasajero);

                Serializa<Pasajero>.EscribirXml(listaInactivos, pathInactivos);
                listaActivos.Remove(pasajero);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR AL PROCESAR CAMBIOS EN BACKUP: {ex.Message}");
            }
        }

        private void CargarBackup()
        {
            try
            {
                Serializa<Pasajero>.EscribirXml(listaActivos, pathActivos);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR AL CARGAR BACKUP: {ex.Message}");
            }
        }

        private void ValidarIndice(int indice)
        {
            try
            {
                if (indice == -1)
                {
                    MessageBox.Show("Debe seleccionar pasajero", "Modificaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Error al validar indice: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }
        }

        private void txtDato_Validating(object sender, CancelEventArgs e)
        {
            string lectura = txtDato.Text;
            if (string.IsNullOrEmpty(lectura) || !int.TryParse(lectura, out int datoValido))
            {
                e.Cancel = true;
                MessageBox.Show("El campo es obligatorio y debe ser numerico", "Informe del formulario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (lectura.Length > 8)
            {
                e.Cancel = true;
                MessageBox.Show("Ingreso de digitos superior al permitido", "Informe del formulario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion


    }
}
