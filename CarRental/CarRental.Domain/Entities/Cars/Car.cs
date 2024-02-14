using CarRental.Domain.Abstract;
using CarRental.Domain.Entities.Common;
using CarRental.Domain.Entities.Types;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities.Vehicles
{
    /// <summary>
    /// Clase base para los vehículos del concesionario.
    /// </summary>
    public abstract class Car : IBrand, IPassengerCapacity
    {
        #region Properties

        public int PassengerCapacity { get; }

        /// <summary>
        /// Fuente de energía que consume el automóvil.
        /// </summary>
        public CarType CarType { get; }

        public string Brand { get; }

        /// <summary>
        /// Precio del vehículo.
        /// </summary>
        public Price Price { get; set; }

        /// <summary>
        /// Existencias del vehículo en la tienda.
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// Color del vehículo.
        /// </summary>
        public Color Color { get; set; }

        #endregion Properties

        /// <summary>
        /// Inicializa un objeto <see cref="Car"/>.
        /// </summary>
        /// <param name="brand">Marca del vehículo.</param>
        /// <param name="carType">Fuente de energía del vehículo.</param>
        protected Car(string brand, CarType carType, int passengerCapacity)
        {
            Stock = 0;
            Price = new Price(MoneyType.MN, 0);
            Color = Color.Black;
            Brand = brand;
            CarType = carType;
            PassengerCapacity = passengerCapacity;
        }
    }
}