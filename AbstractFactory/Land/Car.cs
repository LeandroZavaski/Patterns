using System;

namespace AbstractFactory.Land
{
    public class Car : ILand
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos um passageiro!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciamos o trajéto!");
        }
    }
}
