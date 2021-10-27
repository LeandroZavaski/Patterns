using Bridge.Plataforms;
using Bridge.Transmissions;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            StartLive(new Youtube());
            StartLive(new Facebook());
            StartLiveAdvanced(new TwichTv());
            StartLiveAdvanced(new Dlive());

            Console.ReadLine();
        }

        private static void StartLive(IPlataform plataform)
        {
            Console.WriteLine("Aguarde...");

            Live live = new Live(plataform);

            live.Broadcasting();
            live.Result();
        }

        private static void StartLiveAdvanced(IPlataform plataform)
        {
            Console.WriteLine("Aguarde...");

            AdvancedLive live = new AdvancedLive(plataform);

            live.Broadcasting();
            live.Subtitle();
            live.Comments();
            live.Record();
            live.Result();
        }
    }
}
