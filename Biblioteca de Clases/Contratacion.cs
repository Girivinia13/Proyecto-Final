using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Contratacion
    {
        int idPaquete;
        int idPersona;
        string medioPago;
        float precioFinal;

        public Contratacion()
        {
            
        }

        public Contratacion(int idPaquete, int idPersona, string medioPago, float precioFinal)
        {
            this.IdPaquete = idPaquete;
            this.IdPersona = idPersona;
            this.MedioPago = medioPago;
            this.PrecioFinal = precioFinal;
        }

        public int IdPaquete { get => idPaquete; set => idPaquete = value; }
        public int IdPersona { get => idPersona; set => idPersona = value; }
        public string MedioPago { get => medioPago; set => medioPago = value; }
        public float PrecioFinal { get => precioFinal; set => precioFinal = value; }

        public override string ToString()
        {
            return $"IdPaquete: {idPaquete}\tIdPersona: {idPersona}\tMedioPago: {medioPago}\tPrecioFinal: {precioFinal}";
        }

        
    }

}
