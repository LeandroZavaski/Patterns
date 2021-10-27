using System;

namespace AbstractFactory.Aircraft
{
    class Airplane : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando o vento!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros a bordo, Voo autorizado!");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem!");
        }
    }
}
