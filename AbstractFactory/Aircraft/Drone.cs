using System;

namespace AbstractFactory.Aircraft
{
    public class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando o vento!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Encomenda acoplada, ligando as helices!");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem!");
        }
    }
}
