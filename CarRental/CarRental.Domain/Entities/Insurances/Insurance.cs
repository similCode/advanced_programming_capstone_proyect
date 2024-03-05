using CarRental.Domain.Entities.Common;
using System;

namespace CarRental.Domain.Entities.Insurances
{
    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public class Insurance : Entity
    {
        /// <summary>
        /// Posibles estados
        /// </summary>
        public enum Status
        {
            Enable,

            Disable,
        }

        public string PolicyNumber { get; }

        /// <summary>
        /// Fecha de expiracion
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Fecha de creacion de Insurance
        /// </summary>
        public DateTime ExpeditionDate { get; set; }
    }
}