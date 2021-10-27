using AbstractFactory.Aircraft;
using AbstractFactory.Land;

namespace AbstractFactory.Factories
{
    public interface ITransportFactory
    {
        IAircraft CreateTransportAircraft();
        ILand CreateTransportVehicle();
    }
}
