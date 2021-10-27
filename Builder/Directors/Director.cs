using Builder.Builders;
using Builder.Components;

namespace Builder.Directors
{
    public class Director
    {
        private readonly IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructSedanCar()
        {
            _builder.SetVehicleType(VehicleType.SEDAN);
            _builder.SetEngine(new Engine { Power = 2000 });
            _builder.SetSeats(5);
            _builder.SetTransmission(Transmission.AUTOMATIC);
        }

        public void ConstructTruck()
        {
            _builder.SetVehicleType(VehicleType.TRUCK);
            _builder.SetEngine(new Engine { Power = 4000 });
            _builder.SetSeats(2);
            _builder.SetTransmission(Transmission.MANUAL);
        }

        public void ConstructSuv()
        {
            _builder.SetVehicleType(VehicleType.SUV);
            _builder.SetEngine(new Engine { Power = 2600 });
            _builder.SetSeats(5);
            _builder.SetTransmission(Transmission.AUTOMATIC_SEQUENTIAL);
            _builder.SetAirbags(true);
        }
    }
}
