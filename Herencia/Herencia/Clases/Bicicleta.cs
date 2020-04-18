using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Clases
{
    public class Bicicleta : Vehiculo
    {
        public Bicicleta(string marca, int recorrido, bool motor, string numeroSerie) : base(marca, recorrido, motor, numeroSerie)
        { }
    }
}
