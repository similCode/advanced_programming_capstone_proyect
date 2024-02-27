using System;
using CarRental.Domain.Entities.Common;

namespace CarRental.Domain.Entities.Suplements
{
    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public class Suplement
    {
        /// <summary>
        /// Precio del suplemento
        /// </summary>
        public Price Price { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Constructor requerido por  Entity Framework
        /// </summary>
        protected Suplement()
        { }

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="price"></param>
        public Suplement(Price price)
        {
            Price = price;
        }
    }
}