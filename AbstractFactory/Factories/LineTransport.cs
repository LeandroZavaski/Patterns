using AbstractFactory.Aircraft;
using AbstractFactory.Land;

namespace AbstractFactory.Factories
{
    public class LineTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Drone();
        }

        public ILand CreateTransportVehicle()
        {
            return new Scooter();
        }
    }
}
