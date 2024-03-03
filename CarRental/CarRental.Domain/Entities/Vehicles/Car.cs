using CarRental.Domain.Entities.Common;
using CarRental.Domain.Entities.Insurances;
using CarRental.Domain.Entities.Somatons;
using CarRental.Domain.Entities.Types;
using System.Drawing;

namespace CarRental.Domain.Entities.Vehicles
{
    /// <summary>
    /// Esta clase modela un carro
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Cantidad de puertas
        /// </summary>
        public int DoorsAmount { get; }

        /// <summary>
        /// Si tiene aire acondicionado
        /// </summary>
        public bool HasAirConditioning { get; set; }

        /// <summary>
        /// Numero de velocidades
        /// </summary>
        public int NumberOfVelocities { get; }

        /// <summary>
        /// Maxima velocidad garantizada por el fabricante
        /// </summary>
        public int MaxVelocity { get; }

        /// <summary>
        /// Constructor requerido por Entity Framework
        /// </summary>
        protected Car()
        { }

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="doorsAmount"></param>
        /// <param name="numberOfVelocities"></param>
        /// <param name="maxVelocity"></param>
        /// <param name="hasAirConditioning"></param>
        public Car(string brandName, DateTime fabricationDate, string plate, string motorNumber, Color color, Insurance insurance, Somaton somaton, string model, int passengerCapacity, Price price, int wheelAmount, int weight, int doorsAmount, int numberOfVelocities, int maxVelocity, bool hasAirConditioning) : base(brandName, fabricationDate, plate, motorNumber, color, insurance, somaton, model, passengerCapacity, price, wheelAmount, weight)
        {
            DoorsAmount = doorsAmount;
            NumberOfVelocities = numberOfVelocities;
            MaxVelocity = maxVelocity;
            HasAirConditioning = hasAirConditioning;
        }
    }
}