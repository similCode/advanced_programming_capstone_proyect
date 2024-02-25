using CarRental.Domain.Abstract
using System;
namespace CarRental.Domain.Entities.Person
{
    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public abstract class Person : Icountry
    {
        /// <summary>
        /// Nombre de la persona.
        /// </summary>
        public string Name { get; }

        public string LastName { get; }

        /// <summary>
        /// Edad de la persona.
        /// </summary>
        public int Age { get; }

        /// <summary>
        /// Identificador de la persona.
        /// </summary>
        public string ID { get; }

        public string CountryName { get; }

        public string Email { get; }

        public string Phone { get; set; }
    }
}

