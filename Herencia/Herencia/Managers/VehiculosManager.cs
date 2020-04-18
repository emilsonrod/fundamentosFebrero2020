using Herencia.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Managers
{
    public class VehiculosManager
    {
        List<Vehiculo> listaVehiculos;

        public VehiculosManager()
        {
            listaVehiculos = new List<Vehiculo>();
        }

        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            listaVehiculos.Add(vehiculo);
        }

        public void CambiarTodasCilindrada(int cilindrada)
        {
            foreach (Vehiculo vehiculo in listaVehiculos)
            {
                Automovil autoAux = vehiculo as Automovil;
                if (autoAux != null)
                    autoAux.Cilindarada = cilindrada;
            }
        }

        /// <summary>
        /// Funcion inicialmente imprimia los vehiculos en consola ImprimirVehiculos()
        /// ahora retorna la lista de vehiculos retornarVehiculos()
        /// </summary>
        /// <returns></returns>
        public List<Vehiculo> retornarVehiculos()
        {
            return listaVehiculos;
        }

        /// <summary>
        /// funcion inicialmente imprimia la lista por tipo de vehiculo ImprimirTipoVehiculo()
        /// ahora retorna la lista filtrada por tipo de vehiculo retornarTipoVehiculo()
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public List<Vehiculo> retornarTipoVehiculo(int tipo)
        {
            List<Vehiculo> result = null;
            switch (tipo)
            {
                case 1:
                    result = listaVehiculos.Where(vh => vh is Bicicleta).ToList();
                    break;
                case 2:
                    result = listaVehiculos.Where(vh => vh is Automovil).ToList();
                    break;
            }
            return result;
        }

        public static Vehiculo CrearBicicleta(string marca, int recorrido, bool motor, string numeroSerie)
        {
            return new Bicicleta(marca, recorrido, motor, numeroSerie);
        }

        public static Vehiculo CrearAutomovil(string marca, int recorrido, bool motor, string numeroSerie,int cilindrada)
        {
            return new Automovil(marca, recorrido, motor, numeroSerie, cilindrada);
        }
    }
}
