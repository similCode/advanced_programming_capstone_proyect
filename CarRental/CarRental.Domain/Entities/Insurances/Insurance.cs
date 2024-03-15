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
        /// Constructor requerido por EntityFrameworkCore para migraciones
        /// </summary>
        protected Insurance()
        { }

        /// <summary>
        /// Inicializa un seguro
        /// </summary>
        /// <param name="status"></param>
        /// <param name="policyNumber"></param>
        /// <param name="expirationDate"></param>
        /// <param name="expeditionDate"></param>
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

        /// <summary>
        /// Estado del seguro
        /// </summary>
        public Statusenum Status { get; set; }

        /// <summary>
        /// Numero de poliza
        /// </summary>
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