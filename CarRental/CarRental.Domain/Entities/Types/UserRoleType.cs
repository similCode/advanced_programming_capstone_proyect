using System;

namespace CarRental.Domain.Entities.Types
{
    /// <summary>
    /// Posibles roles de usuario
    /// </summary>
    public enum UserRoleType
    {
        Guest,
        Admin,
        Employee,
        Supervisor
    }
}