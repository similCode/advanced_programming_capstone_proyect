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
    /// Clase base para los vehículos del negocio
    /// </summary>
    public abstract class Vehicle
    {
        #region Properties

        /// <summary>
        /// Modelo del vehiculo
        /// </summary>
        public string Model { get; }

        /// <summary>
        /// Capacidad de pasajeros
        /// </summary>
        public int PassengerCapacity { get; }

        /// <summary>
        /// Precio del vehículo.
        /// </summary>
        public Price Price { get; set; }

        /// <summary>
        /// Color del vehículo.
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Cantidad de ruedas
        /// </summary>
        public int WheelAmount { get; }

        /// <summary>
        /// Peso
        /// </summary>
        public int Weight { get; }

        /// <summary>
        /// Constructor requerido por Entity Framework
        /// </summary>
        protected Vehicle()
        { }

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="model"></param>
        /// <param name="passengerCapacity"></param>
        /// <param name="price"></param>
        /// <param name="color"></param>
        /// <param name="wheelAmount"></param>
        /// <param name="wheight"></param>
        public Vehicle(string model, int passengerCapacity, Price price, Color color, int wheelAmount, int wheight)
        {
            Model = model;
            PassengerCapacity = passengerCapacity;
            Price = price;
            Color = color;
            WheelAmount = wheelAmount;
            Weight = wheight;
        }

        #endregion Properties
    }
}