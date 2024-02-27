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
        /// Municipalidad del local de renta
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
        /// Constructor requerido por Entity Framework
        /// </summary>
        protected RentingPlace()
        { }

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="municipality"></param>
        /// <param name="cars"></param>
        /// <param name="cycles"></param>
        public RentingPlace(string municipality, List<Car> cars, List<Bicycle> cycles)
        {
            Municipality = municipality;
            Cars = cars;
            Bicycles = cycles;
        }
    }
}