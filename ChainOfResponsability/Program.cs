using ChainOfResponsability.Middlewares;
using ChainOfResponsability.Servers;
using System;

namespace ChainOfResponsability
{
    class Program
    {
        private static Server _server;

        static void Main(string[] args)
        {
            Init();

            Boolean done;

            do
            {
                Console.WriteLine("Digite seu email:");

                string email = Console.ReadLine();

                Console.WriteLine("Digite sua senha:");

                string password = Console.ReadLine();

                done = _server.Login(email, password);

            } while (!done);

            Console.ReadLine();
        }

        private static void Init()
        {
            _server = new Server();

            _server.RegisterUser("master@hcode.com.br", "123456");
            _server.RegisterUser("user@hcode.com.br", "123456");

            Middleware middleware = new CheckUserMiddleware(_server);

            middleware.LinkWith(new CheckPermissionMiddleware());
            middleware.LinkWith(new CheckWeakPasswordMiddleware());

            _server.SetMiddleware(middleware);
        }
    }
}
