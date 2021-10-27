using AbstractFactory.Aircraft;
using AbstractFactory.Land;

namespace AbstractFactory.Factories
{
    public class UberTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Airplane();
        }

        public ILand CreateTransportVehicle()
        {
            return new Car();
        }
    }
}
