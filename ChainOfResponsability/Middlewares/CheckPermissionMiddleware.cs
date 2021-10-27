using System;

namespace ChainOfResponsability.Middlewares
{
    public class CheckPermissionMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (email.Equals("master@hcode.com.br"))
            {
                Console.WriteLine("Seja bem vindo Administrador!");
            }
            else
            {
                Console.WriteLine("Seja bem vindo!");
            }

            return CheckNext(email, password);
        }
    }
}
