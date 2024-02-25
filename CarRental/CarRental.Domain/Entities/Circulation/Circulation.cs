using System;
using CarRental.Domain.Abstract;



namespace CarRental.Domain.Entiies.Circulation
{
    public class Circulation : ITransportable
    {
        public Date ExpirationDate { get; set; }

        public Date ExpeditionDate { get; set; }

        public string VIN { get; }
    }
}

