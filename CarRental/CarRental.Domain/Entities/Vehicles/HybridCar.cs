using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities.Vehicles
{
    internal class HybridCar : Car
    {
        private GasolineStations[] NearbyGasolineStations { get; set; }
        private ChargingStation[] NearbyChargingStations { get; set; }

        /// <summary>
        /// Constructor por default
        /// </summary>
        protected HybridCar()
        { }

        /// <summary>
        /// Constructor por parametrso
        /// </summary>
        /// <param name="doorsAmount">Numero de puertas</param>
        /// <param name="numberOfVelocities">Numero de Velocidades</param>
        /// <param name="maxVelocity">Maxima Velocidad</param>
        public HybridCar(int doorsAmount, int numberOfVelocities, int maxVelocity) : base(doorsAmount, numberOfVelocities, maxVelocity)
        {
        }
    }
}