using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities.Vehicles
{
    /// <summary>
    /// Esta clase modela una gasolinera
    /// </summary>
    internal class GasolineStations
    {
        /// <summary>
        /// Municipalidad
        /// </summary>
        private string Municipality { get; }

        /// <summary>
        /// Litros de gasolina disponibles
        /// </summary>
        private float LitersOfGasolineAvailable { get; set; }

        public GasolineStations(string municipality)
        {
            Municipality = municipality;
        }
    }
}