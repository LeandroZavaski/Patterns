using AbstractFactory.Aircraft;
using AbstractFactory.Factories;
using AbstractFactory.Land;

namespace AbstractFactory.App
{
    public class Application
    {
        private IAircraft aircraft;
        private ILand land;

        public Application(ITransportFactory factory)
        {
            aircraft = factory.CreateTransportAircraft();
            land = factory.CreateTransportVehicle();
        }

        public void StartRoute()
        {
            aircraft.StartRoute();
            land.StartRoute();
        }
    }
}
