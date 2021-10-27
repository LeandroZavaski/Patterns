using AbstractFactory.Aircraft;
using AbstractFactory.Land;

namespace AbstractFactory.Factories
{
    public class NineNineTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Helicopter();
        }

        public ILand CreateTransportVehicle()
        {
            return new Motorcycle();
        }
    }
}
