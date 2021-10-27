using ChainOfResponsability.Middlewares;
using System;
using System.Collections.Generic;

namespace ChainOfResponsability.Servers
{
    public class Server
    {

        private Dictionary<string, string> users = new Dictionary<string, string>();

        private Middleware _middleware;

        public void SetMiddleware(Middleware middleware)
        {
            _middleware = middleware;
        }

        public Boolean Login(string email, string password)
        {
            if (_middleware.Check(email, password))
            {
                Console.WriteLine("Usuário autorizado com sucesso");

                return true;
            }
            return false;
        }

        public void RegisterUser(string email, string password)
        { 
            users[email] = password;
        }

        public Boolean HasEmail(string email)
        {
            return users.ContainsKey(email);
        }

        public Boolean IsValidPassword(string email, string password)
        {
            var value = string.Empty;
            users.TryGetValue(email, out value);

            return password == value;
        }
    }
}
