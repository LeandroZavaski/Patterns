using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Plataforms
{
    public class TwichTv : IPlataform
    {
        public TwichTv()
        {
            ConfigureRMTP();
            Console.WriteLine("Trasmissão iniciada!");
        }

        public void AuthToken()
        {
            Console.WriteLine("TwichTv: Autorizando Aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Configurando servidor RMTP!");
        }
    }
}
