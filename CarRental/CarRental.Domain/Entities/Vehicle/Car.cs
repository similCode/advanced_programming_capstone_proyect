using System;
using CarRental.Domain.Entities.Types;

namespace CarRental.Domain.Entities.Vehicle
{
    public class Car : Vehicle
    {
        public int DoorsAmount { get; }

        public bool HasAirConditioning { get; set; }

        public TransmissionType TransmissionType { get; }

        public int NumberVelocities { get; }

        public int TankCapacity { get; set; }

        public int MaxVelocity { get; }

        public EnergyType EnergyType { get; }
    }
}