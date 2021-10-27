using System;

namespace AbstractFactory.Aircraft
{
    public class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando o vento!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros a bordo, Ligando as hélices!");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem!");
        }
    }
}
