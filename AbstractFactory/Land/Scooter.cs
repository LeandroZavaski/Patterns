using System;

namespace AbstractFactory.Land
{
    public class Scooter : ILand
    {
        public void GetCargo()
        {
            Console.WriteLine("Patinete alugado!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando tempo de aluguel!");
        }
    }
}
