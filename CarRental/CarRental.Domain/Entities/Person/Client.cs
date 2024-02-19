using CarRental.Domain.Entities.Reservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities.Person
{
    /// <summary>
    /// Modela un cliente de concesionario de autos.
    /// </summary>
    public class Client : Person
    {
        /// <summary>
        /// Arreglo de las reservaciones del cliente.
        /// </summary>
        public Reservation.Reservation[] reservations { get; set; }
    }
}