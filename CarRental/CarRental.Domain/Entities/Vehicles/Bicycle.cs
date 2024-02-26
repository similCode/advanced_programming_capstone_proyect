using System;
using CarRental.Domain.Entities.Types;

namespace CarRental.Domain.Entities.Vehicles
{
    /// <summary>
    /// Esta clase modela una bicicleta
    /// </summary>
    public class Bicycle : Vehicle
    {
        /// <summary>
        /// Tipo de bicicleta
        /// </summary>
        public CycleType Type { get; }

        public Bicycle()
        { }

        protected Bicycle(CycleType type)
        { Type = type; }
    }
}