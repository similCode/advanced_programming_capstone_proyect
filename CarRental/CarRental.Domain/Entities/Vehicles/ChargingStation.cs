using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities.Vehicles
{
    /// <summary>
    /// Esta clase modela una estacion de carga para autos electricos
    /// </summary>
    internal class ChargingStation
    {
        /// <summary>
        /// Municipalidad
        /// </summary>
        private string Municipality { get; }

        /// <summary>
        /// Velocidad de carga
        /// </summary>
        private string ChargingSpeed { get; }

        /// <summary>
        /// Cantidad de autos que se pueden cargar a la vez
        /// </summary>
        private int CarStations { get; }

        /// <summary>
        /// Constructor por defect
        /// </summary>
        public ChargingStation()
        { }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="municipality">Municipalidad</param>
        /// <param name="chargingCapacity">Capacidad de Carga</param>
        /// <param name="carStations">Estaciones de carga</param>
        public ChargingStation(string municipality, string chargingCapacity, int carStations)
        {
            Municipality = municipality;
            ChargingSpeed = chargingCapacity;
            CarStations = carStations;
        }
    }
}