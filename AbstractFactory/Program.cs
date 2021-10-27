using AbstractFactory.App;
using AbstractFactory.Factories;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Application app = ConfigureApplication();

            app.StartRoute();

            Console.ReadLine();
        }

        public static Application ConfigureApplication()
        {
            Application app;

            ITransportFactory transportFactory;
            string company = "Line";

            if (company.Equals("Uber"))
            {
                transportFactory = new UberTransport();
            }
            else if (company.Equals("99"))
            {
                transportFactory = new NineNineTransport();
            }
            else
            {
                transportFactory = new LineTransport();
            }

            app = new Application(transportFactory);

            return app;
        }
    }
}
