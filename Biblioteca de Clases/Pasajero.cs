using System.Text;

namespace Biblioteca_de_Clases
{
    public class Pasajero
    {
        #region Atributos
        int id_Pasajero;
        int dni;
        string apellido;
        string nombre;
        int edad;
        string genero;
        string email;
        string estado;
        #endregion

        #region Constructores
        public Pasajero()
        {

        }
        public Pasajero(int dni, string apellido, string nombre, int edad, string genero, string email, string estado)
        {            
            DNI = dni;
            Apellido = apellido;
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
            Email = email;
            Estado = estado;
        }
        public Pasajero(int id_Pasajero, int dni, string apellido, string nombre, int edad, string genero, string email, string estado)
        {
            Id_Pasajero = id_Pasajero;
            DNI = dni;
            Apellido = apellido;
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
            Email = email;
            Estado = estado;
        }
        #endregion

        #region Propiedades
        public int Id_Pasajero { get => id_Pasajero; set => id_Pasajero = value; }
        public int DNI { get => dni; set => dni = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Email { get => email; set => email = value; }
        public string Estado { get => estado; set => estado = value; }

        #endregion

        
        public override string ToString()
        {            
            return $"ID: {Id_Pasajero}  ({Estado})  -  DNI: {DNI}  -  {Apellido}, {Nombre}  -  EDAD: {Edad}  -  GENERO: {Genero}  -  EMAIL: {Email}";
        }
    }
}