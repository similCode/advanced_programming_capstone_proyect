using CarRental.Domain.Entities.Common;
using System;

namespace CarRental.Domain.Entities.Insurances
{
    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public class Insurance : Entity
    {
        protected Insurance() { }
        public Insurance(Statusenum status, string policyNumber, DateTime expirationDate, DateTime expeditionDate)
        {
            Status = status;
            PolicyNumber = policyNumber;
            ExpirationDate = expirationDate;
            ExpeditionDate = expeditionDate;
        }

        /// <summary>
        /// Posibles estados
        /// </summary>
        public enum Statusenum
        {
            Enable,

            Disable,
        }
        public Statusenum Status { get; set; }

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