using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Clases
{
    public class Vehiculo
    {
        private string mensaje = "Vehiculo marca {0}, con recorrido {1} km, tiene motor: {2}, con numero de serie {3}";

        public Vehiculo()
        {
            Marca = string.Empty;
            Recorrido = 0;
            Motor = false;
            NumeroSerie = string.Empty;
        }

        public Vehiculo(string marca, int recorrido, bool motor, string numeroSerie)
        {
            Marca = marca;
            Recorrido = recorrido;
            Motor = motor;
            NumeroSerie = numeroSerie;
        }

        public string Marca { get; set; }
        public int Recorrido { get; set; }
        public bool Motor { get; set; }
        public string NumeroSerie { get; set; }
       
        public override string ToString()
        {
            return string.Format(mensaje, Marca, Recorrido, Motor? "si" : "no", NumeroSerie);
        }
    }
}
