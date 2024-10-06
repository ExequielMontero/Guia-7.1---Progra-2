using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class DepartamentoVehicular
    {
        public int CantidadRegistros { get; private set; }
        string serie="5345234234";
        ArrayList registro = new ArrayList();
        public RegistroVehiculo RegistrarVehiculo(Persona propietario, string patente)
        {
            RegistroVehiculo actual = new RegistroVehiculo(patente, serie, propietario);
            double aux = Convert.ToDouble(serie);
            aux++;
            Convert.ToString(serie);
            registro.Add(actual);
            CantidadRegistros++;
            return actual;
        }

        public RegistroVehiculo VerRegistro(int idx)
        {
            return registro[idx] as RegistroVehiculo;
        }
    }
}
