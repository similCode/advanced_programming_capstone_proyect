using System;

namespace CarRental.Domain.Entities.Types
{
    /// <summary>
    /// Posibles estados
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// requerido
        /// </summary>
        Requested,

        /// <summary>
        /// Aprobado
        /// </summary>
        Approved,

        /// <summary>
        /// Pagado
        /// </summary>
        Payed,

        /// <summary>
        /// Consumido
        /// </summary>
        Consumed,

        /// <summary>
        /// Cancelado
        /// </summary>
        Cancelled
    }
}