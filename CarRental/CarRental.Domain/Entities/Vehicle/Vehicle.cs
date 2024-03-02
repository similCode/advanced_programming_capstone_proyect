using CarRental.Domain.Abstract;
using CarRental.Domain.Entities.Common;
using CarRental.Domain.Entities.Types;
using CarRental.Domain.Entiies.Circulation
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
    public abstract class Vehicle : ITransportable
    {
        #region Properties

        public int PassengerCapacity { get; }

        /// <summary>
        /// Precio del vehículo.
        /// </summary>
        public Price Price { get; set; }

        /// <summary>
        /// Color del vehículo.
        /// </summary>
        public Color Color { get; set; }

        public int whellAmount { get; }

        public int weigth { get; }

        public int MaxVelocity { get; }

        public string audioSystem { get; set; }

        public Circulation Circulation { get; }

        #endregion Properties
    }
}