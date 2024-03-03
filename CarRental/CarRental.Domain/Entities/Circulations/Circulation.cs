using System;
using System.Drawing;
using CarRental.Domain.Abstract;
using CarRental.Domain.Entities.Somatons;
using CarRental.Domain.Entities.Insurances;

namespace CarRental.Domain.Entities.Circulations
{
    public class Circulation : ITransportable
    {
        public string BrandName { get; }

        public string Model { get; }

        public DateTime FabricationDate { get; }

        public string Plate { get; }

        public string MotorNumber { get; }

        public Color Color { get; set; }

        public Color? Color2 { get; set; }

        public Insurance Insurance { get; }

        public Somaton Somaton { get; }

        /// <summary>
        /// Fecha de Expiracion de la reservacion
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        public DateTime ExpeditionDate { get; set; }

        public string VIN { get; }
    }
}