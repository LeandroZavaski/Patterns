using FactoryMethod.Vehicles;
using System;

namespace FactoryMethod.Factories
{
    public class BycycleTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Bycycle();
        }
    }
}
