using CarRental.Domain.Entities.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities.Vehicles
{
    /// <summary>
    /// Automóvil.
    /// </summary>
    public class Sedan : Car
    {
        #region Properties

        /// <summary>
        /// Indica si el automóvil es descapotable.
        /// </summary>
        public bool IsConvertible { get; set; }

        #endregion Properties

        /// <summary>
        /// Inicializa un objeto <see cref="Sedan"/>.
        /// </summary>
        /// <param name="brand">Marca del automóvil.</param>
        /// <param name="carType">Fuente de energía del automóvil.</param>
        public Sedan(string brand, CarType carType, int passengerCapacity) : base(brand, carType, passengerCapacity)
        {
            IsConvertible = true;
        }
    }
}