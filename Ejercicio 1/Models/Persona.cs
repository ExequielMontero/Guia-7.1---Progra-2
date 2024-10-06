using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class Persona
    {
        public Persona(string dni, string nombre)
        {
            Dni = dni;
            Nombre = nombre;
        }

        public string Dni
        {
            get
            {
                return Dni;
            }

            private set
            {
                if (Convert.ToDouble(value) < 1000000)
                {
                    throw new Exceptions.RangoDniIncorrectoException();
                }
            }
        }
        public string Nombre { get; private set; }

    }
}
