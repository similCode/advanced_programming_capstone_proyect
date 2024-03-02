using CarRental.Domain.Abstract;
using CarRental.Domain.Entities.Common;
using CarRental.Domain.Entities.Types;
using CarRental.Domain.Abstract.ITransportable
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
    public abstract class Vehicle : ITransportable
    {
        #region Properties

        /// <summary>
        /// Nombre de la marca del vehículo.
        /// </summary>
        public string BrandName { get; }

        /// <summary>
        /// Fecha de fabricación del vehículo.
        /// </summary>
        public DateTime FabricationDate { get; }

        /// <summary>
        /// Número de placa del vehículo.
        /// </summary>
        public string Plate { get; }

        /// <summary>
        /// Número de motor del vehículo.
        /// </summary>
        public string MotorNumber { get; }

        /// <summary>
        /// Color principal del vehículo.
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Color secundario del vehículo.
        /// </summary>
        public Color Color2 { get; set; }

        /// <summary>
        /// Información del seguro asociado al vehículo.
        /// </summary>
        public Insurance Insurance { get; }

        /// <summary>
        /// Información del somaton del vehículo.
        /// </summary>
        public Somaton Somaton { get; }

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
        /// Cantidad de ruedas
        /// </summary>
        public int WheelAmount { get; }

        /// <summary>
        /// Peso del vehiculo
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
        /// <param name="weight"></param>
        public Vehicle(string brandName, DateTime fabricationDate, string plate, string motorNumber, Color color, Color color2, Insurance insurance, Somaton somaton, string model, int passengerCapacity, Price price, int wheelAmount, int weight)
        {
            BrandName = brandName;
            FabricationDate = fabricationDate;
            Plate = plate;
            MotorNumber = motorNumber;
            Color = color;
            Color2 = color2;
            Insurance = insurance;
            Somaton = somaton;
            Model = model;
            PassengerCapacity = passengerCapacity;
            Price = price;
            WheelAmount = wheelAmount;
            Weight = weight;
        }

        #endregion Properties
    }
}