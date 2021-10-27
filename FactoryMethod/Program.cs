using FactoryMethod.Factories;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }

            Console.ReadLine();
        }

        private static bool MainMenu()
        {
            //Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Uber");
            Console.WriteLine("2) Uber Transport");
            Console.WriteLine("3) Uber Eats");
            Console.WriteLine("4) Exit");
            Console.Write("\r\nSelect an option: ");

            Transport transport = null;

            switch (Console.ReadLine())
            {
                case "1":
                    transport = new CarTransport();
                    transport.StartTransport();
                    return true;
                case "2":
                    transport = new MotorcycleTransport();
                    transport.StartTransport();
                    return true;
                case "3":
                    transport = new BycycleTransport();
                    transport.StartTransport();
                    return true;
                case "4":
                    return false;
                default:
                    Console.WriteLine("Selecione o tipo de serviço");
                    return true;
            }
        }
    }
}
