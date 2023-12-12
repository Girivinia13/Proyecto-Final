using Biblioteca_de_Clases;
using DataAgencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FormAgenciaTurismo
{
    public partial class FrmCarga_Pasajero : Form
    {
        #region ATRIBUTO
        Pasajero unPasajero;
        #endregion

        #region CONSTRUCTORES
        public FrmCarga_Pasajero()
        {
            InitializeComponent();
            unPasajero = null;
        }

        public FrmCarga_Pasajero(Pasajero pasaj)
        {
            InitializeComponent();
            //dev valores exist en form
            unPasajero = pasaj;
            txtId_Pasajero.Text = unPasajero.Id_Pasajero.ToString();
            txtId_Pasajero.Enabled = false;
            txtDNI.Text = unPasajero.DNI.ToString();
            txtApellido.Text = unPasajero.Apellido;
            txtNombre.Text = unPasajero.Nombre;
            txtEdad.Text = unPasajero.Edad.ToString();
            cmbGenero.Text = unPasajero.Genero;
            txtEmail.Text = unPasajero.Email;
            cmbEstado.Text = unPasajero.Estado;
        }
        #endregion

        #region PROPIEDAD 
        public Pasajero PasajeroForm
        {//prop del atributo local para crear el pasaj
            get
            {
                return unPasajero;
            }
        }

        #endregion

        #region MANEJADORES DE EVENTOS
        private void FrmPasajero_Load(object sender, EventArgs e)
        {
            try
            {
                String[] estados = { "Activo", "Inactivo" };
                String[] generos = { "Femenino", "Masculino", "No binario", "Transgenero", "Otro" };

                foreach (String item in estados)
                {
                    cmbEstado.Items.Add(item);
                }

                foreach (String item in generos)
                {
                    cmbGenero.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Load: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (unPasajero == null)
                {
                    int id_Pasajero = Agencia_Ado.MostrarProxIdPasajero();
                    int dni = int.Parse(txtDNI.Text);
                    string apellido = txtApellido.Text;
                    string nombre = txtNombre.Text;
                    int edad = int.Parse(txtEdad.Text);
                    string genero = cmbGenero.Text;
                    string email = txtEmail.Text;
                    string estado = cmbEstado.Text;

                    unPasajero = new Pasajero(id_Pasajero, dni, apellido, nombre, edad, genero, email, estado);
                }
                else
                {
                    unPasajero.DNI = int.Parse(txtDNI.Text);
                    unPasajero.Apellido = txtApellido.Text;
                    unPasajero.Nombre = txtNombre.Text;
                    unPasajero.Edad = int.Parse(txtEdad.Text);
                    unPasajero.Genero = cmbGenero.Text;
                    unPasajero.Email = txtEmail.Text;
                    unPasajero.Estado = cmbEstado.Text;
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El campo es obligatorio y con el formato ejemplificado");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("El numero ingresado supera el limite de digitos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar datos: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion

        #region VALIDACIONES
        public static bool EsSoloLetra(string palabra)
        {
            bool ok = true;
            try
            {
                foreach (char letra in palabra)
                {
                    if (!char.IsLetter(letra) && !char.IsSeparator(letra))
                    {
                        ok = false;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ok;
        }

        public static bool EsMailValido(string email)
        {
            bool ok = true;

            try
            {
                Regex regex = new Regex(@"[^@\s]+@[^@\s]+\.[^@\s]+$");
                if (!regex.IsMatch(email))
                {
                    ok = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ok;
        }

        private void cmbEstado_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int indice = cmbEstado.SelectedIndex;

                if (indice == -1)
                {
                    e.Cancel = true;
                    MessageBox.Show("El campo es obligatorio", "Informe del formulario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDni_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string lectura = txtDNI.Text;
                if (string.IsNullOrEmpty(lectura) || !int.TryParse(lectura, out int dniValido))
                {
                    e.Cancel = true;
                    MessageBox.Show("El campo es obligatorio y debe ser numerico", "Informe del formulario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (lectura.Length != 8)
                {
                    e.Cancel = true;
                    MessageBox.Show("Ingreso menos de 8 digitos, si es correcto, anteponga ceros para completar", "Informe del formulario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtApellido_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string lectura = txtApellido.Text;

                if (string.IsNullOrEmpty(lectura) || !EsSoloLetra(lectura))
                {
                    e.Cancel = true;
                    MessageBox.Show("El campo es obligatorio y permite solo letras", "Informe del formulario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string lectura = txtNombre.Text;

                if (string.IsNullOrEmpty(lectura) || !EsSoloLetra(lectura))
                {
                    e.Cancel = true;
                    MessageBox.Show("El campo es obligatorio y permite solo letras", "Informe del formulario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtEdad_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string lectura = txtEdad.Text;
                if (string.IsNullOrEmpty(lectura) || !int.TryParse(lectura, out int edadValida))// valores entre 0 y 99
                {
                    e.Cancel = true;
                    MessageBox.Show("El campo es obligatorio y debe ser numerico", "Informe del formulario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (lectura.Length < 0 || lectura.Length > 99)
                {
                    e.Cancel = true;
                    MessageBox.Show("Limite de digitos para edad, verificar numero", "Informe del formulario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbGenero_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int indice = cmbGenero.SelectedIndex;

                if (indice == -1)
                {
                    e.Cancel = true;
                    MessageBox.Show("El campo es obligatorio", "Informe del formulario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en validar letras: " + ex.Message);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string lectura = txtEmail.Text;
                if (string.IsNullOrEmpty(lectura) || !EsMailValido(lectura))
                {
                    e.Cancel = true;
                    MessageBox.Show("El campo es obligatorio y con el formato ejemplificado", "Informe del formulario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en validar letras: " + ex.Message);
            }
        }
        #endregion
    }
}
