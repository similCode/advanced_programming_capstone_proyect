using CarRental.Domain.Abstract
using System;
namespace CarRental.Domain.Entities.Person;
/// <summary>
/// Summary description for Class1
/// </summary>
public abstract class Person : Icountry
{
    /// <summary>
    /// Nombre de la persona.
    /// </summary>
    public string name { get; }

    public string lastName { get; }

    /// <summary>
    /// Edad de la persona.
    /// </summary>
    public int age { get; }

    /// <summary>
    /// Identificador de la persona.
    /// </summary>
    public string ID { get; }

    public string countryName { get; }

    public string email { get; }

    public string phone { get; set; }
}
