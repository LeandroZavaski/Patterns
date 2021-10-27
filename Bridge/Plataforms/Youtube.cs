using System;

namespace Bridge.Plataforms
{
    public class Youtube : IPlataform
    {
        public Youtube()
        {
            ConfigureRMTP();
            Console.WriteLine("Trasmissão iniciada!");
        }

        public void AuthToken()
        {
            Console.WriteLine("Youtube: Autorizando Aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Configurando servidor RMTP!");
        }
    }
}
