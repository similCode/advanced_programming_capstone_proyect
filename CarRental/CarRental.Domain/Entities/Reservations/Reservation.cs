using CarRental.Domain.Entities.Persons;
using CarRental.Domain.Entities.Common;

using CarRental.Domain.Entities.Types;
using CarRental.Domain.Entities.Vehicles;

using CarRental.Domain.Entities.Suplements;

using CarRental.Domain.Abstract;

namespace CarRental.Domain.Entities.Reservations
{
    /// <summary>
    /// Modela la reservacion de un vehiculo.
    /// </summary>
    public class Reservation : ICountry
    {
        #region Properties

        public string CountryName { get; set; }

        #region Properties

        /// <summary>
        /// Cliente que realizó la renta.
        /// </summary>
        public Client Client { get; }

        /// <summary>
        /// Vehículo a rentar.
        /// </summary>
        public Vehicle Vehicle { get; }

        /// <summary>
        /// Fecha de inicio de la renta.
        /// </summary>
        public DateTime StartDate { get; }

        /// <summary>
        /// Fecha de finalizada la renta.
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Precio total a pagar por la orden.
        /// </summary>
        public Price TotalPrice { get; set; }

        /// <summary>
        /// Estado de la reservacion
        /// </summary>
        public Status Status { get; set; }

        protected Reservation()
        { }

        public Reservation(string countryName, Client client, Vehicle vehicle, DateTime startDate, Price totalPrice, Status status)
        {
            CountryName = countryName;
            Client = client;
            Vehicle = vehicle;
            StartDate = startDate;
            TotalPrice = totalPrice;
            Status = status;
        }

        public Suplement Suplements { get; set; }

        #endregion Properties
    }
}