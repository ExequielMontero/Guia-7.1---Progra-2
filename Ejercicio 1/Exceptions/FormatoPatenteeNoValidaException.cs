using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Exceptions
{
    internal class FormatoPatenteeNoValidaException : ApplicationException
    {
        public FormatoPatenteeNoValidaException():base("Patente no valida")
        {
        }

        public FormatoPatenteeNoValidaException(string message) : base(message)
        {
        }

        public FormatoPatenteeNoValidaException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
