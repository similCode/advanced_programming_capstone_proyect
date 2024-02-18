using CarRental.Domain.Abstract;
using CarRental.Domain.Entities.Common;
using CarRental.Domain.Entities.Types;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities.Vehicle
{
    /// <summary>
    /// Clase base para los vehículos del negocio
    /// </summary>
    public abstract class Vehicle
    {
        #region Properties

        public string Model { get; }

        public int PassengerCapacity { get; }

        /// <summary>
        /// Precio del vehículo.
        /// </summary>
        public Price Price { get; set; }

        /// <summary>
        /// Color del vehículo.
        /// </summary>
        public Color Color { get; set; }

        public int WheelAmount { get; }

        public int Weight { get; }

        #endregion Properties
    }
}