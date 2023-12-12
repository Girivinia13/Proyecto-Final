using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Paquete
    {
        int idPaquete;
        DateOnly fecha;
        string descripcion;
        int cantExcursiones;
        float precioBase;

        public Paquete()
        {
            
        }

        public Paquete(int idPaquete, DateOnly fecha, string descripcion, int cantExcursiones, float precioBase)
        {
            this.IdPaquete = idPaquete;
            this.Fecha = fecha;
            this.Descripcion = descripcion;
            this.CantExcursiones = cantExcursiones;
            this.PrecioBase = precioBase;
        }

        public int IdPaquete { get => idPaquete; set => idPaquete = value; }
        public DateOnly Fecha { get => fecha; set => fecha = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int CantExcursiones { get => cantExcursiones; set => cantExcursiones = value; }
        public float PrecioBase { get => precioBase; set => precioBase = value; }
    }
}
