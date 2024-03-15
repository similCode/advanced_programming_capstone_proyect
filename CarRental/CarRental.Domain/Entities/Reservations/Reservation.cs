using CarRental.Domain.Entities.Persons;
using CarRental.Domain.Entities.Common;

using CarRental.Domain.Entities.Types;
using CarRental.Domain.Entities.Vehicles;

using CarRental.Domain.Entities.Supplements;

using CarRental.Domain.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Domain.Entities.Reservations
{
    /// <summary>
    /// Modela la reservacion de un vehiculo.
    /// </summary>
    public class Reservation : Entity, ICountry
    {
        #region Properties

        public string CountryName { get; set; }

        /// <summary>
        /// Cliente que realizó la renta.
        /// </summary>
        [NotMapped]
        public Client Client { get; }

        /// <summary>
        /// Identificador unico del cliente
        /// </summary>
        private Guid ClientId { get; set; }

        /// <summary>
        /// Vehículo a rentar.
        /// </summary>
        [NotMapped]
        public Vehicle Vehicle { get; }

        /// <summary>
        /// Identificador unico del vehiculo
        /// </summary>
        private Guid VehicleId { get; set; }

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
        [NotMapped]
        public Price TotalPrice { get; set; }

        /// <summary>
        /// Identificador unico del precio
        /// </summary>
        private Guid PriceId { get; set; }

        /// <summary>
        /// Estado de la reservacion
        /// </summary>
        public Status Status { get; set; }

        [NotMapped]
        public Supplement ReservationSupplement { get; set; }

        /// <summary>
        /// Identificador unico de suplemento
        /// </summary>
        private Guid SupplementId { get; set; }

        /// <summary>
        /// Constructor requerido por EntityFrameworkCore para migraciones
        /// </summary>
        protected Reservation()
        { }

        /// <summary>
        /// Inicializa una reservacion
        /// </summary>
        /// <param name="countryName"></param>
        /// <param name="client"></param>
        /// <param name="vehicle"></param>
        /// <param name="startDate"></param>
        /// <param name="totalPrice"></param>
        /// <param name="status"></param>
        /// <param name="reservationSupplement"></param>
        public Reservation(string countryName, Client client, Vehicle vehicle, DateTime startDate, Price totalPrice, Status status, Supplement reservationSupplement)
        {
            CountryName = countryName;
            Client = client;
            Vehicle = vehicle;
            StartDate = startDate;
            TotalPrice = totalPrice;
            Status = status;
            ReservationSupplement = reservationSupplement;
        }

        /// <summary>
        /// Suplementos que se le añadiran al auto rentado
        /// </summary>
        public Supplement Supplements { get; set; }

        #endregion Properties
    }
}