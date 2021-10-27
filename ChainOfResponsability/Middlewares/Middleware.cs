using System;

namespace ChainOfResponsability.Middlewares
{
    public abstract class Middleware
    {
        private Middleware _next;

        public Middleware LinkWith(Middleware next)
        {
            _next = next;

            return _next;
        }

        public abstract Boolean Check(string email, string password);

        protected Boolean CheckNext(string email, string password)
        {
            if (_next == null)
            {
                return true;
            }

            return _next.Check(email, password);
        }
    }
}
