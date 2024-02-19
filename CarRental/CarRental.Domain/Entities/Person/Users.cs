using System;

using CarRental.Domain.Entities.Types;

namespace CarRental.Domain.Entities.Person
{
    /// <summary>
    /// Modela la clase usuario.
    /// </summary>
    public class Users : Person
    {
        /// <summary>
        /// Tipo de usuario
        /// </summary>
        public UserRoleType Role { get; }
    }
}