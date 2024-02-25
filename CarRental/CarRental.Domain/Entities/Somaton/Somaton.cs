using System;

namespace CarRental.Domain.Entities.Somaton
/// <summary>
/// Summary description for Class1
/// </summary>
public class Somaton
{
    public Date ExpirationDate { get; set; }

    public Date ExpeditionDate { get; set; }

    public Status Status { get; }

    public string Number { get; }
}
