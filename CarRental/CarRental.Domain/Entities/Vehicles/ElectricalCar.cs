using CarRental.Domain.Entities.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities.Vehicles
{
    /// <summary>
    /// Esta clase modela un carro electrico
    /// </summary>
    internal class ElectricalCar : Car
    {
        /// <summary>
        /// Capacidad de la bateria en kWh
        /// </summary>
        private int BatteryCapacity { get; set; }

        /// <summary>
        /// Constructor requerido por Entity Framework
        /// </summary>
        protected ElectricalCar()
        { }

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        public ElectricalCar(int doorsAmount, TransmissionType transmissionType, int numberOfVelocities, int maxVelocity, int batteryCapacity) : base(doorsAmount, numberOfVelocities, maxVelocity)
        {
            BatteryCapacity = batteryCapacity;
        }
    }
}