using CarRental.Domain.Abstract;
using System;

namespace CarRental.Domain.Entities.Person;

/// <summary>
/// Clase base persona.
/// </summary>
public abstract class Person : ICountry
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

    /// <summary>
    /// Correo electronico de la persona.
    /// </summary>
    public string Email { get; }

    /// <summary>
    /// Numero de telefono de la persona.
    /// </summary>
    public string Phone { get; set; }
}