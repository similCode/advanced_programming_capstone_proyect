using System;
using CarRental.Domain.Entities.Common;
using CarRental.Domain.Entities.Types;

namespace CarRental.Domain.Entities.Somatons
{
    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public class Somaton : Entity
    {
        public DateTime ExpirationDate { get; set; }

        public DateTime ExpeditionDate { get; set; }

        public Status Status { get; }

        public string Number { get; }
    }
}