using CarRental.Domain.Abstract;
using CarRental.Domain.Entities.Common;
using System;

namespace CarRental.Domain.Entities.Persons
{
    /// <summary>
    /// Clase base persona.
    /// </summary>
    public abstract class Person : Entity, ICountry
    {
        /// <summary>
        /// Nombre de la persona.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Apellido de la persona
        /// </summary>
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

        /// <summary>
        /// Correo electronico de la persona.
        /// </summary>
        private string Email { get; set; }

        /// <summary>
        /// Numero de telefono de la persona.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Constructor requerido por EntityFramework
        /// </summary>
        protected Person()
        { }

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="iD"></param>
        public Person(string name, string lastName, string iD, string countryName)
        {
            Name = name;
            LastName = lastName;
            ID = iD;
            CountryName = countryName;
        }
    }
}