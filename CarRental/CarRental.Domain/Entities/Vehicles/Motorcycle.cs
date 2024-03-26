using CarRental.Domain.Abstract;
using CarRental.Domain.Entities.Common;
using CarRental.Domain.Entities.Insurances;
using CarRental.Domain.Entities.Somatons;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities.Vehicles
{
    /// <summary>
    /// Esta clase modela una motocycleta
    /// </summary>
    public class Motorcycle : Vehicle
    {
        /// <summary>
        /// Tiene sidecar
        /// </summary>
        private bool HasSideCar { get; set; }

        /// <summary>
        /// Constructor requerido por EntityFrameworkCore para migraciones
        /// </summary>
        protected Motorcycle()
        { }

        /// <summary>
        /// Inicializa una motocicleta
        /// </summary>
        /// <param name="brandName"></param>
        /// <param name="fabricationDate"></param>
        /// <param name="plate"></param>
        /// <param name="motorNumber"></param>
        /// <param name="color"></param>
        /// <param name="color2"></param>
        /// <param name="insurance"></param>
        /// <param name="somaton"></param>
        /// <param name="model"></param>
        /// <param name="passengerCapacity"></param>
        /// <param name="price"></param>
        /// <param name="wheelAmount"></param>
        /// <param name="weight"></param>
        public Motorcycle(string brandName, DateTime fabricationDate, Insurance insurance, Somaton somaton, Price price, bool hasSideCar) : base(brandName, fabricationDate, insurance, somaton, price)
        {
            HasSideCar = hasSideCar;
        }
    }
}