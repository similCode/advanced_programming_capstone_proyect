using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Domain.Entities.Common;
using CarRental.Domain.Entities.Persons;
using CarRental.Domain.Entities.Reservations;
using CarRental.Domain.Entities.Supplements;
using CarRental.Domain.Entities.Types;
using CarRental.Domain.Entities.Vehicles;

namespace CarRental.DataAccess.Abstract.Reservations
{
    /// <summary>
    /// Define las operaciones con las reservaciones en BD
    /// </summary>
    public interface IReservationRepository : IRepository
    {
        /// <summary>
        /// Crea una reservacion en BD
        /// </summary>
        /// <param name="countryName">Nombre del pais</param>
        /// <param name="client">Cliente</param>
        /// <param name="vehicle">Vehiculo</param>
        /// <param name="startDate">Fecha de inicio</param>
        /// <param name="totalPrice">Precio total</param>
        /// <param name="status">Estado</param>
        /// <param name="reservationSupplement">Suplementos de la reservacion</param>
        /// <returns></returns>
        Reservation CreateReservation(string countryName, Client client, Vehicle vehicle, DateTime startDate, Price totalPrice, Status status, Supplement reservationSupplement);

        /// <summary>
        /// Obtiene una reservacion en BD
        /// </summary>
        /// <param name="id">Identificador de la reservacion</param>
        /// <returns>Obtiene la reservacion en caso de existir en BD, de lo contrario<see langword="null"></returns>
        Reservation? GetReservation(Guid id);

        /// <summary>
        /// Actualiza una reservacion
        /// </summary>
        /// <param name="reservation">Reservacion a actualizar</param>
        void UpdateReservation(Reservation reservation);

        /// <summary>
        /// Borra una reservacion
        /// </summary>
        /// <param name="reservation">Reservacion a borrar</param>
        void DeleteReservation(Reservation reservation);
    }
}