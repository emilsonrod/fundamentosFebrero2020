using Herencia.Clases;
using Herencia.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIVehiculosConsole
{
    class Program
    {
        static VehiculosManager manager = new VehiculosManager();

        static void Main(string[] args)
        {
             while (true)
            {
                Console.WriteLine("Que desea trabajar?");
                Console.WriteLine("1.- Agregar Vehiculo");
                Console.WriteLine("3.- Cambiar Cilindrada");
                Console.WriteLine("4.- Imprimir Lista por tipo");
                Console.WriteLine("5.- Imprimir Vehiculos");
                int funcionalidad = Convert.ToInt32(Console.ReadLine());
                EjecutarFuncionalidad(funcionalidad);
            }
        }

        private static void EjecutarFuncionalidad(int funcionalidad)
        {
            switch (funcionalidad)
            {
                case 1:
                    AgregarVehiculo();
                    break;
                case 3:
                    CambiarCilindrada();
                    break;
                case 4:
                    ImprimirTipoVehiculo();
                    break;
                case 5:
                    ImprimirVehiculos();
                    break;
            }
        }

        private static void AgregarVehiculo()
        {
            Console.WriteLine("Ingrese la marca:");
            string marca = Console.ReadLine();
            Console.WriteLine("Ingrese el recorrido:");
            int recorrido = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el motor: 1 -> si tiene, otro numero no tiene");
            int tieneMotor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de serie:");
            string numSerie = Console.ReadLine();
            Console.WriteLine("Bicileta -> 1, Automovil -> 2");
            int tipoVehiculo = Convert.ToInt32(Console.ReadLine());
            switch (tipoVehiculo)
            {
                case 1:
                    manager.AgregarVehiculo(VehiculosManager.CrearBicicleta(marca, recorrido, tieneMotor == 1, numSerie));
                    break;
                case 2:
                    Console.WriteLine("Ingrese la cilindrada");
                    int cilindrada = Convert.ToInt32(Console.ReadLine());
                    manager.AgregarVehiculo(VehiculosManager.CrearAutomovil(marca, recorrido, tieneMotor == 1, numSerie, cilindrada));
                    break;
            }

        }

        private static void CambiarCilindrada()
        {
            Console.WriteLine("Ingrese la nueva cilindrada");
            int cilindrada = Convert.ToInt32(Console.ReadLine());
            manager.CambiarTodasCilindrada(cilindrada);
        }

        private static void ImprimirVehiculos()
        {
            foreach (Vehiculo vehiculo in manager.retornarVehiculos())
            {
                Console.WriteLine(vehiculo.ToString());
            }
        }

        private static void ImprimirTipoVehiculo()
        {
            Console.WriteLine("Ingrese tipo de Vehiculo 1.- Bicicleta, 2.- Automovil");
            int tipo = Convert.ToInt32(Console.ReadLine());
            foreach (Vehiculo vehiculo in manager.retornarTipoVehiculo(tipo))
            {
                Console.WriteLine(vehiculo.ToString());
            }
        }
    }
}
