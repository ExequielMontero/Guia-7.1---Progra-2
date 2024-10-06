using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Exceptions
{
    internal class RangoDniIncorrectoException : ApplicationException
    {
        public RangoDniIncorrectoException():base ("Dni debe ser mayor a 1000000")
        {
        }

        public RangoDniIncorrectoException(string message) : base(message)
        {
        }

        public RangoDniIncorrectoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
