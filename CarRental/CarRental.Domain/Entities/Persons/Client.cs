using CarRental.Domain.Entities.Common;
using CarRental.Domain.Entities.Reservations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        [NotMapped]
        public List<Reservation> Reservations { get; set; }

        /// <summary>
        /// Identificador unico de reservacion
        /// </summary>
        public Guid Reservation { get; set; }

        /// <summary>
        /// Constructor requerido por EntityFrameworkCore para migraciones
        /// </summary>
        protected Client()
        { }

        /// <summary>
        /// Inicializa un cliente
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