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

        /// <summary>
        /// Fecha de creado
        /// </summary>
        public DateTime ExpeditionDate { get; set; }

        public string VIN { get; }

        /// <summary>
        /// Constructor requerido por Entity Framework
        /// </summary>
        protected Circulation()
        { }

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="brandName"></param>
        /// <param name="model"></param>
        /// <param name="fabricationDate"></param>
        /// <param name="plate"></param>
        /// <param name="motorNumber"></param>
        /// <param name="color"></param>
        /// <param name="color2"></param>
        /// <param name="insurance"></param>
        /// <param name="insuranceID"></param>
        /// <param name="somaton"></param>
        /// <param name="somatonId"></param>
        /// <param name="expirationDate"></param>
        /// <param name="expeditionDate"></param>
        /// <param name="vin"></param>
        public Circulation(string brandName, string model, DateTime fabricationDate, string plate, string motorNumber, Color color, Insurance insurance, Guid insuranceID, Somaton somaton, Guid somatonId, DateTime expirationDate, DateTime expeditionDate, string vin)
        {
            BrandName = brandName;
            Model = model;
            FabricationDate = fabricationDate;
            Plate = plate;
            MotorNumber = motorNumber;
            Color = color;
            Insurance = insurance;
            InsuranceID = insuranceID;
            Somaton = somaton;
            SomatonId = somatonId;
            ExpirationDate = expirationDate;
            ExpeditionDate = expeditionDate;
            VIN = vin;
        }
    }
}