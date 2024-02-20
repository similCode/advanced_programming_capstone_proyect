using System;
using CarRental.Domain.Entities.Types;

namespace CarRental.Domain.Entities.Vehicles
{
    /// <summary>
    /// Esta clase modela una bicicleta
    /// </summary>
    public class Cycle : Vehicle
    {
        /// <summary>
        /// Tipo de bicicleta
        /// </summary>
        public CycleType Type { get; }

        public Cycle()
        { }

        protected Cycle(CycleType type)
        { Type = type; }
    }
}