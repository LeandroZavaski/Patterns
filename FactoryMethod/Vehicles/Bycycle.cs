using System;

namespace FactoryMethod.Vehicles
{
    public class Bycycle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a comida!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando entrega da comida!");
        }
    }
}
