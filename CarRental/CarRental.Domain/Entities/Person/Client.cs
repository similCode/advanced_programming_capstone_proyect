using CarRental.Domain.Entities.Reservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Modela un cliente de concesionario de autos.
/// </summary>
namespace CarRental.Domain.Entities.Person
{
    public class Client : Person
    {
        public Reservation.Reservation[] reservations { get; set; }
    }
}