using CarRental.Domain.Entities.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities.Vehicles
{
    /// <summary>
    /// Motocicleta.
    /// </summary>
    public class Minivan : Car
    {
        /// <summary>
        /// Inicializa un objeto <see cref="Minivan"/>.
        /// </summary>
        /// <param name="brand">Marca de la motocicleta.</param>
        /// <param name="carType">Fuente de energía de la motocicleta.</param>
        public Minivan(string brand, CarType carType, int passengerCapacity) : base(brand, carType, passengerCapacity)
        {
        }
    }
}