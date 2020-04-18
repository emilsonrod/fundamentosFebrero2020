using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Clases
{
    public class Automovil : Vehiculo
    {
        string mensajeAutomovil = " la cilindrada es de {0}";

        public Automovil(string marca, int recorrido, bool motor, string numeroSerie, int cilindrada) : 
            base(marca, recorrido, motor, numeroSerie)
        {
            Cilindarada = cilindrada;
        }

        public int Cilindarada { get; set; }

        public void CambiarCilindrada(int cilindrada)
        {
            Cilindarada = cilindrada;
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + mensajeAutomovil, Cilindarada) ;
        }
    }
}
