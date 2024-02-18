using System;


namespace CarRental.Domain.Enities.Vehicle
{
    public class Car : Vehicle
    {
        public int doorsAmount { get; }

        public bool hasAirConditioning { get; set; }

        public TransmissionType transmissionType { get; }

        public int numberVelocities { get; }

        public int tankCapacity { get; set; }

        public int maxVelocity { get; }

        public EnergyType EnergyType { get; }
    }
}

