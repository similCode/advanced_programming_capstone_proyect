using System;

namespace CarRental.Domain.Abstract;

/// <summary>
/// Interfase con nombre del pais.
/// </summary>
public interface ICountry
{
    /// <summary>
    /// Nombre del pais de procedencia
    /// </summary>
    public string CountryName { get; }
}