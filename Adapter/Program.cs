using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Paypal payment = new Paypal();
            //Payooner payment = new Payooner();

            //IPaypalPayment payment = new PayoonerAdapter(new Payooner());
            IPaypalPayment payment = new MercadoPagoAdapter(new MercadoPago());

            payment.PaypalPayment();
            payment.PaypalReceive();

            Console.ReadLine();
        }
    }
}
