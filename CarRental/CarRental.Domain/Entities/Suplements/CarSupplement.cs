using System;
using CarRental.Domain.Entities.Common;

namespace CarRental.Domain.Entities.CarSupplements
{
    /// <summary>
    /// Modela el suplemento de un auto
    /// </summary>
    public class CarSupplement
    {
        /// <summary>
        /// Precio del suplemento
        /// </summary>
        public Price Price { get; set; }

        /// <summary>
        ///Descripcion del suplemento
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Constructor requerido por  Entity Framework
        /// </summary>
        protected CarSupplement()
        { }

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="price"></param>
        public CarSupplement(Price price)
        {
            Price = price;
        }
    }
}