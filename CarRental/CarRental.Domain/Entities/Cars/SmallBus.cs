using CarRental.Domain.Entities.Types;

namespace CarRental.Domain.Entities.Vehicles
{
    public class SmallBus : Car
    {
        public SmallBus(string brand, CarType carType, int passengerCapacity) : base(brand, carType, passengerCapacity)
        {
        }
    }
}