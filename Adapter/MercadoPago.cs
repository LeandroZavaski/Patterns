using System;

namespace Adapter
{
    public class MercadoPago : IMercadoPago
    {
        private Token _token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void EnviarPagamento()
        {
            _token = AuthToken();
            Console.WriteLine("Enviando Pagamento com Mercado Pago!");
        }

        public void ReceberPayment()
        {
            _token = AuthToken();
            Console.WriteLine("Recebendo Pagamento com Mercado Pago!");
        }
    }
}
