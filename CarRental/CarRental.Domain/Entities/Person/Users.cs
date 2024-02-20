using System;

using CarRental.Domain.Entities.Types;

namespace CarRental.Domain.Entities.Person
{
    /// <summary>
    /// Modela la clase usuario que puede ser
    /// un cliente, un admin, un empleado, un proveedor.
    /// </summary>
    public class Users : Person
    {
        /// <summary>
        /// Tipo de usuario
        /// </summary>
        public UserRoleType Role { get; set; }

        /// <summary>
        /// Constructor por default
        /// </summary>
        protected Users()
        { }

        public Users(string name, string lastName, string iD, string countryName, UserRoleType role) : base(name, lastName, iD, countryName)
        {
            Role = role;
        }
    }
}