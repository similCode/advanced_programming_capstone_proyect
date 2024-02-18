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
    public class Reservation
    {
        #region Properties

        /// <summary>
        /// Cliente que realizó la renta.
        /// </summary>
        public Client client { get; }

        /// <summary>
        /// Vehículo a rentar.
        /// </summary>
        public Vehicle vehicle { get; }

        /// <summary>
        /// Fecha de inicio de la renta.
        /// </summary>
        public DateTime startDate { get; set; }

        /// <summary>
        /// Fecha de finalizada la renta.
        /// </summary>
        public DateTime endDate { get; set; }

        /// <summary>
        /// Precio total a pagar por la orden.
        /// </summary>
        public Price totalPrice => new Price(Vehicle.Price.Currency, Vehicle.Price.Value);

        public Status status {  get; set; }

        #endregion Properties

    }
}