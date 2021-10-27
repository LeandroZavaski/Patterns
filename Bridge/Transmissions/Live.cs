using Bridge.Plataforms;
using System;

namespace Bridge.Transmissions
{
    public class Live : ITransmission
    {
        private readonly IPlataform _plataform;

        public Live(IPlataform plataform)
        {
            _plataform = plataform;
        }

        public void Broadcasting()
        {
            Console.WriteLine($"Iniciando a transmissão na plataforma: {_plataform}");
        }

        public void Record()
        {
            Console.WriteLine($"Iniciando a gravação na plataforma: {_plataform}");
        }

        public void Result()
        {
            Console.WriteLine("No ar!");
        }
    }
}
