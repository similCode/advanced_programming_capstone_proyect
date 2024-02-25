using System;


namespace CarRental.Domain.Enities.Vehicle
{
    public class Car : Vehicle
    {

        public bool HasAirConditioning { get; set; }

        public TransmissionType TransmissionType { get; set;  }

        public int VelocitiesAmount { get; }

        public int TankCapacity { get; set; }

        
    }
}

