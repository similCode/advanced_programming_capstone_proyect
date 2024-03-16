using System;

using CarRental.Domain.Entities.Types;

namespace CarRental.Domain.Entities.Persons
{
    /// <summary>
    /// Modela la clase usuario que puede ser
    /// un un admin, un empleado, un proveedor.
    /// </summary>
    public class Users : Person
    {
        /// <summary>
        /// Tipo de usuario
        /// </summary>
        public UserRoleType Role { get; set; }

        /// <summary>
        /// Constructor requerido por Entity Framework
        /// </summary>
        protected Users()
        { }

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="name">Nombre</param>
        /// <param name="lastName">Apellido</param>
        /// <param name="iD">Identificador</param>
        /// <param name="countryName">Nombre del pais</param>
        /// <param name="role">Rol</param>
        public Users(string name, string lastName, string iD, string countryName, UserRoleType role) : base(name, lastName, iD, countryName)
        {
            Role = role;
        }
    }
}