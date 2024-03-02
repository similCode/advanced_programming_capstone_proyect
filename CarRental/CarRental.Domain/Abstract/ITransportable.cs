using System;
using CarRental.Domain.Abstract;
using CarRental.Domain.Entities.Types;
using CarRental.Domain.Entities.Insurance;
using CarRental.Domain.Entities.Somaton;

namespace CarRental.Domain.Abstract
{
    /// <summary>
    /// Summary description for Class1
    /// </summary>
    /// 
    public interface ITransportable : IBrand
    {
        public string BrandName { get; }

        public string Model { get; }

        public Date FabricationDate { get; }

        public EnergyType EngineType { get; }

        public string Plate { get; }

        public string MotorNumber {  get; }

        public Color Color { get; set; }

        public Color Color2 { get; set; }

        public Insurance Insurance { get; }

        public Somaton Somaton { get; }
    }

}
