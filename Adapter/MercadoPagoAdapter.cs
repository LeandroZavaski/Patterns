namespace Adapter
{
    public class MercadoPagoAdapter : IPaypalPayment
    {
        private readonly MercadoPago _mercadoPago;

        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            _mercadoPago = mercadoPago;
        }

        public Token AuthToken()
        {
            return _mercadoPago.AuthToken();
        }

        public void PaypalPayment()
        {
            _mercadoPago.EnviarPagamento();
        }

        public void PaypalReceive()
        {
            _mercadoPago.ReceberPayment();
        }
    }
}
