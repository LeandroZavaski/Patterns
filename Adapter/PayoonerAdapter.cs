namespace Adapter
{
    public class PayoonerAdapter : IPaypalPayment
    {
        private readonly Payooner _payooner;

        public PayoonerAdapter(Payooner payooner)
        {
            _payooner = payooner;
        }
        public Token AuthToken()
        {
            return _payooner.AuthToken();
        }

        public void PaypalPayment()
        {
            _payooner.SendPayment();
        }

        public void PaypalReceive()
        {
            _payooner.ReceivePayment();
        }
    }
}
