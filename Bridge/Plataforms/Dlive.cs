using System;

namespace Bridge.Plataforms
{
    public class Dlive : IPlataform
    {
        public Dlive()
        {
            ConfigureRMTP();
            Console.WriteLine("Trasmissão iniciada!");
        }

        public void AuthToken()
        {
            Console.WriteLine("Dlive: Autorizando Aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Configurando servidor RMTP!");
        }
    }
}
