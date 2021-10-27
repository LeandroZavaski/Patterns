namespace Adapter
{
    public interface IMercadoPago
    {
        Token AuthToken();
        void EnviarPagamento();
        void ReceberPayment();
    }
}
