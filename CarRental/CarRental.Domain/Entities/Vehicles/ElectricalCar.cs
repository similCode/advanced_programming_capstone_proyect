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
        /// Capacidad de la bateria
        /// </summary>
        private string BatteryCapacity { get; set; }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        protected ElectricalCar()
        { }

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        public ElectricalCar(int doorsAmount, TransmissionType transmissionType, int numberOfVelocities, int maxVelocity, string batteryCapacity) : base(doorsAmount, numberOfVelocities, maxVelocity)
        {
            BatteryCapacity = batteryCapacity;
        }
    }
}