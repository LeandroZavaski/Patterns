namespace Adapter
{
    public interface IPayoonerPayment
    {
        Token AuthToken();
        void SendPayment();
        void ReceivePayment();
    }
}
