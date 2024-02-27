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

        /// <summary>
        /// Constructor requerido por Entity Framework
        /// </summary>
        protected Bicycle()
        { }

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="type"></param>
        protected Bicycle(CycleType type)
        { Type = type; }
    }
}