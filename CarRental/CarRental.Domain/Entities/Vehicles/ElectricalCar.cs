using CarRental.Domain.Entities.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities.Vehicles
{
    internal class ElectricalCar : Car
    {
        /// <summary>
        /// Arreglo de estaciones de carga cercanas
        /// </summary>
        private ChargingStation[] NearbyChargingStations { get; set; }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        protected ElectricalCar()
        { }

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="nearbyChargingStations"></param>
        public ElectricalCar(int doorsAmount, TransmissionType transmissionType, int numberOfVelocities, int maxVelocity, ChargingStation[] nearbyChargingStations) : base(doorsAmount, numberOfVelocities, maxVelocity)
        {
        }
    }
}