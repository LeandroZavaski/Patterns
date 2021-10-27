using System;

namespace Adapter
{
    public class Paypal : IPaypalPayment
    {
        private Token _token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void PaypalPayment()
        {
            _token = AuthToken();
            Console.WriteLine("Enviando Pagamento com Paypal!");
        }

        public void PaypalReceive()
        {
            _token = AuthToken();
            Console.WriteLine("Recebendo Pagamento com Paypal!");
        }
    }
}
