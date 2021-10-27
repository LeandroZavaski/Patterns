using System;

namespace Adapter
{
    public class Payooner : IPayoonerPayment
    {
        private Token _token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePayment()
        {
            _token = AuthToken();
            Console.WriteLine("Enviando Pagamento com Payooner!");
        }

        public void SendPayment()
        {
            _token = AuthToken();
            Console.WriteLine("Recebendo Pagamento com Payooner!");
        }
    }
}
