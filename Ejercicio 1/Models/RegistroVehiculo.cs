using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class RegistroVehiculo
    {
        public RegistroVehiculo(string patente, string serie, Persona propietario)
        {
            Match validacion = Regex.Match(patente, @"^[a-zA-Z]{3}[0-9]{3}$");
            if (validacion.Success)
            {
                Patente = patente;

            }
            else
            {
                throw new Exceptions.FormatoPatenteeNoValidaException("Patente no valida");
            }
            Serie = serie;
            Propietario = propietario;
        }

        public string Patente { get; private set; }
        public string Serie { get; private set; }
        public Persona Propietario { get; private set; }

    }
}
