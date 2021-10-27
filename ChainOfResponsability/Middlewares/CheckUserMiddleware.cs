using ChainOfResponsability.Servers;
using System;

namespace ChainOfResponsability.Middlewares
{
    public class CheckUserMiddleware : Middleware
    {
        private readonly Server _server;

        public CheckUserMiddleware(Server server)
        {
            _server = server;
        }

        public override bool Check(string email, string password)
        {
            if (!_server.HasEmail(email))
            {
                Console.WriteLine("E-mail inválido");
                return false;
            }

            if (!_server.IsValidPassword(email, password))
            {
                Console.WriteLine("Email e/ou Password inválido");
                return false;
            }

            return CheckNext(email, password);
        }
    }
}
