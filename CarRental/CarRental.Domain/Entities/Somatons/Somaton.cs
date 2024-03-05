﻿using System;
using CarRental.Domain.Entities.Common;
using CarRental.Domain.Entities.Types;

namespace CarRental.Domain.Entities.Somatons
{
    /// <summary>
    /// Clase que modela a un somaton
    /// </summary>
    public class Somaton : Entity
    {
        /// <summary>
        /// Fecha de expiracion
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Fecha de creacion
        /// </summary>
        public DateTime ExpeditionDate { get; set; }

        /// <summary>
        /// Estado del somaton
        /// </summary>
        public Status Status { get; }

        /// <summary>
        /// Numero del somaton
        /// </summary>
        public string Number { get; }

        /// <summary>
        /// Constructor requerido por EntityFramework
        /// </summary>
        protected Somaton()
        { }

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="expirationDate"></param>
        /// <param name="expeditionDate"></param>
        /// <param name="status"></param>
        /// <param name="number"></param>
        public Somaton(DateTime expirationDate, DateTime expeditionDate, Status status, string number)
        {
            ExpirationDate = expirationDate;
            ExpeditionDate = expeditionDate;
            Status = status;
            Number = number;
        }
    }
}