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

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        protected Client()
        { }

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="age"></param>
        /// <param name="iD"></param>
        /// <param name="countryName"></param>
        /// <param name="email"></param>
        public Client(string name, string lastName, string iD, string countryName) : base(name, lastName, iD, countryName)
        {
        }
    }
}