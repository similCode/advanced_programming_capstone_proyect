using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities.Vehicles
{
    /// <summary>
    /// Esta clase modela el lugar de renta de autos
    /// </summary>
    internal class RentingPlace
    {
        /// <summary>
        /// Arreglo de estaciones de carga cercanas
        /// </summary>
        private ChargingStation[] NearbyChargingStations { get; }

        /// <summary>
        /// Municipalidad
        /// </summary>
        private string Municipality { get; }

        /// <summary>
        /// Arreglo de autos en el local
        /// </summary>
        private Car[] Cars { get; }

        /// <summary>
        /// Arreglo de bicicletas en el local
        /// </summary>
        private Cycle[] Cycles { get; }

        /// <summary>
        /// Atributo que dice si el local tiene estacion de carga o no
        /// </summary>
        private bool HasChargingStation { get; }

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="municipality"></param>
        /// <param name="cars"></param>
        /// <param name="cycles"></param>
        /// <param name="hasChargingStation"></param>
        /// <param name="nearbyChargingStations"></param>
        protected RentingPlace()
        { }

        public RentingPlace(string municipality, Car[] cars, Cycle[] cycles, bool hasChargingStation, ChargingStation[] nearbyChargingStations)
        {
            Municipality = municipality;
            Cars = cars;
            Cycles = cycles;
            HasChargingStation = hasChargingStation;
            NearbyChargingStations = nearbyChargingStations;
        }
    }
}