using CarRental.Domain.Entities.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities.Persons
{
    /// <summary>
    /// Modela un cliente de la renta de autos.
    /// </summary>
    public class Client : Person
    {
        /// <summary>
        /// Lista de las reservaciones del cliente.
        /// </summary>
        public List<Reservation> Reservations { get; set; }

        /// <summary>
        /// Constructor requerido por Entity Framework
        /// </summary>
        protected Client()
        { }

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="iD"></param>
        /// <param name="countryName"></param>
        public Client(string name, string lastName, string iD, string countryName) : base(name, lastName, iD, countryName)
        {
        }
    }
}