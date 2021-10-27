using System;

namespace ChainOfResponsability.Middlewares
{
    public class CheckWeakPasswordMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (password.Equals("123456"))
            {
                Console.WriteLine("Senha fraca!");
            }

            return CheckNext(email, password);
        }
    }
}
