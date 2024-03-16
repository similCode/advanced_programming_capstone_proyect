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
using CarRental.DataAccess.Abstract.Reservations;

namespace CarRental.DataAccess.Repositories
{
    /// <summary>
    /// Clase parcial referidad a las reservaciones
    /// </summary>
    public partial class ApplicationRepository : IReservationRepository
    {
        public Reservation CreateReservation(string countryName, Client client, Vehicle vehicle, DateTime startDate, Price totalPrice, Status status, Supplement reservationSupplement)
        {
            Reservation reservation = new Reservation(countryName, client, vehicle, startDate, totalPrice, status, reservationSupplement);
            _context.Add(reservation); return reservation;
        }

        public Reservation? GetReservation(Guid id)
        {
            return _context.Set<Reservation>().Find(id);
        }

        public void UpdateReservation(Reservation reservation)
        {
            _context.Set<Reservation>().Update(reservation);
        }

        public void DeleteReservation(Reservation reservation)
        {
            _context.Remove(reservation);
        }
    }
}