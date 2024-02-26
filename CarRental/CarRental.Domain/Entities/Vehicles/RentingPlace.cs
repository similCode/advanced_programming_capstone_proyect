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
        /// Municipalidad
        /// </summary>
        private string Municipality { get; }

        /// <summary>
        /// Lista de autos en el local
        /// </summary>
        public List<Car> Cars { get; set; }

        /// <summary>
        /// Lista de bicicletas en el local
        /// </summary>
        public List<Bicycle> Bicycles { get; set; }

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

        public RentingPlace(string municipality, List<Car> cars, List<Bicycle> cycles)
        {
            Municipality = municipality;
            Cars = cars;
            Bicycles = cycles;
        }
    }
}