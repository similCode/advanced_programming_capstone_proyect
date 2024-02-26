using System;
using CarRental.Domain.Entities.Common;

namespace CarRental.Domain.Entities.Suplements
{
    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public class Suplement
    {
        public Price Price { get; set; }

        public string Description { get; set; }

        protected Suplement()
        { }

        public Suplement(Price price)
        {
            Price = price;
        }
    }
}