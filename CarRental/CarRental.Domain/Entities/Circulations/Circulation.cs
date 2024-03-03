using System;
using System.Drawing;
using CarRental.Domain.Abstract;
using CarRental.Domain.Entities.Somatons;
using CarRental.Domain.Entities.Insurances;
using CarRental.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Domain.Entities.Circulations
{
    public class Circulation : Entity, ITransportable
    {
        public string BrandName { get; }

        public string Model { get; }

        public DateTime FabricationDate { get; }

        public string Plate { get; }

        public string MotorNumber { get; }

        public Color Color { get; set; }

        public Color Color2 { get; set; }

        [NotMapped]
        public Insurance Insurance { get; }

        /// <summary>
        /// Identificador unico de Insurance
        /// </summary>
        public Guid InsuranceID { get; set; }

        [NotMapped]
        public Somaton Somaton { get; }

        /// <summary>
        /// Identificador unico de Somaton
        /// </summary>
        public Guid SomatonId { get; set; }

        /// <summary>
        /// Fecha de Expiracion de la reservacion
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        public DateTime ExpeditionDate { get; set; }

        public string VIN { get; }
    }
}