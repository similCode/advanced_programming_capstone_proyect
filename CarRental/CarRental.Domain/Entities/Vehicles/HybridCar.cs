using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities.Vehicles
{
    internal class HybridCar : Car
    {
        /// <summary>
        /// Capacidad del tanque
        /// </summary>
        private int TankCapacity { get; set; }

        /// <summary>
        /// Capacidad de la bateria en kWh
        /// </summary>
        private int BatteryCapacity { get; set; }

        /// <summary>
        /// Constructor requerido por Entity Framework
        /// </summary>
        protected HybridCar()
        { }

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="doorsAmount">Numero de puertas</param>
        /// <param name="numberOfVelocities">Numero de Velocidades</param>
        /// <param name="maxVelocity">Maxima Velocidad</param>
        public HybridCar(int doorsAmount, int numberOfVelocities, int maxVelocity, int tankCapacity, int batteryCapacity) : base(doorsAmount, numberOfVelocities, maxVelocity)
        {
            BatteryCapacity = batteryCapacity;
            TankCapacity = tankCapacity;
        }
    }
}