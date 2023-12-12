using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Excepcion : Exception
    {
        Object objetoError;
        public Excepcion(string message, Object error) : base(message)
        {
            this.objetoError = error;
        }
        public Object ObjetoError
        {
            get
            {
                return this.objetoError;
            }
        }
    }
}
