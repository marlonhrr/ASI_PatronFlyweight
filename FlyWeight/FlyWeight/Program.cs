using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Vehiculo("Renault", "Dubster", "Negro", "FKA175", DateTime.Now, "Camilo");
            Vehiculo v2 = new Vehiculo("Chevrolet", "Sprak GT", "Plata", "ABO401", DateTime.Now, "Marlon");
            Vehiculo v3 = new Vehiculo("Ford", "Fiesta Titanium", "Rojo", "HJA895", DateTime.Now, "David");
            Vehiculo v4 = new Vehiculo("Renault", "Dubster", "Negro", "FKA176", DateTime.Now, "Marlon");

            v1.MostrarInformacionVehiculo();
            v2.MostrarInformacionVehiculo();
            v3.MostrarInformacionVehiculo();
            v4.MostrarInformacionVehiculo();

            Console.ReadLine();
        }
    }
}
