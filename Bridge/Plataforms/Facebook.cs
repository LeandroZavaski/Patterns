using System;

namespace Bridge.Plataforms
{
    public class Facebook : IPlataform
    {
        public Facebook()
        {
            ConfigureRMTP();
            Console.WriteLine("Trasmissão iniciada!");
        }

        public void AuthToken()
        {
            Console.WriteLine("Facebook: Autorizando Aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Configurando servidor RMTP!");
        }
    }
}
