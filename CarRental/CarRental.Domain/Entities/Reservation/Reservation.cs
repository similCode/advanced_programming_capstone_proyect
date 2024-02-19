using CarRental.Domain.Entities.Person;
using CarRental.Domain.Entities.Common;
using CarRental.Domain.Entities.Vehicle;
using CarRental.Domain.Entities.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities.Reservation
{
    /// <summary>
    /// Modela la reservacion de un vehiculo.
    /// </summary>
    public class Reservation
    {
        #region Properties

        /// <summary>
        /// Cliente que realizó la renta.
        /// </summary>
        public Client Client { get; }

        /// <summary>
        /// Vehículo a rentar.
        /// </summary>
        public Vehicle.Vehicle Vehicle { get; }

        /// <summary>
        /// Fecha de inicio de la renta.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Fecha de finalizada la renta.
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Precio total a pagar por la orden.
        /// </summary>
        public Price TotalPrice => new Price(Vehicle.Price.Currency, Vehicle.Price.Value);

        /// <summary>
        /// Estado de la reservacion
        /// </summary>
        public Status Status { get; set; }

        #endregion Properties
    }
}