using System;

namespace AbstractFactory.Land
{
    public class Motorcycle : ILand
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando entrega da encomenda!");
        }
    }
}
