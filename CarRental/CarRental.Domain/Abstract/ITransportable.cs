using System;
using CarRental.Domain.Abstract;
using CarRental.Domain.Entities.Types;
using CarRental.Domain.Entities.Insurances;
using CarRental.Domain.Entities.Somatons;
using System.Drawing;
using CarRental.Domain.Entities.Circulations;

namespace CarRental.Domain.Abstract
{
    /// <summary>
    /// Interface de transporte
    /// </summary>
    public interface ITransportable

    {
        /// <summary>
        /// Nombre de la marca
        /// </summary>
        public string BrandName { get; }

        /// <summary>
        /// Modelo del vehiculo
        /// </summary>

        public string Model { get; }

        /// <summary>
        /// Fecha de fabricacion
        /// </summary>
        public DateTime FabricationDate { get; }

        /// <summary>
        /// Numero de placa
        /// </summary>
        public string Plate { get; }

        /// <summary>
        /// Numero del motor
        /// </summary>

        public string MotorNumber { get; }

        /// <summary>
        /// Color del vehiculo
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// 2do Color del carro
        /// </summary>
        public Color? Color2 { get; set; }

        /// <summary>
        /// Seguro del carro
        /// </summary>
        public Insurance Insurance { get; }

        /// <summary>
        /// Somaton del vehiculo
        /// </summary>
        public Somaton Somaton { get; }
    }
}