using System;
using CarRental.Domain.Entities.Common;

namespace CarRental.Domain.Entities.Supplements
{
    /// <summary>
    /// Modela el suplemento de un auto
    /// </summary>
    public class Supplement : Entity
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
        /// Constructor requerido por  EntityFrameworkCore para migraciones
        /// </summary>
        protected Supplement()
        { }

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="price"></param>
        public Supplement(Price price, string description)
        {
            Price = price;
            Description = description;
        }
    }
}