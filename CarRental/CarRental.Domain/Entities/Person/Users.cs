using System;

using CarRental.Domain.Entities.Types;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace CarRental.Domain.Entities.Person
{
    public class Users : Person
    {
        public UserRoleType Role { get; }
    }
}