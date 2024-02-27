using CarRental.Domain.Entities.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities.Vehicles
{
    /// <summary>
    /// Esta clase modela un carro de combustion
    /// </summary>
    internal class CombustionCar : Car
    {
        /// <summary>
        /// Capacidad del tanque
        /// </summary>
        private int TankCapacity { get; set; }

        /// <summary>
        /// Tipo de transmision
        /// </summary>
        public TransmissionType TransmissionType { get; }

        /// <summary>
        /// Constructor requerido por Entity Framework
        /// </summary>
        protected CombustionCar()
        { }

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="doorsAmount">Numero de puertas</param>
        /// <param name="transmissionType">Tipo de transmision</param>
        /// <param name="numberOfVelocities">Numero de velocidades</param>
        /// <param name="tankCapacity">Capacidad del tanque</param>
        /// <param name="maxVelocity">Maxima Velocidad</param>
        /// <param name=""></param>
        public CombustionCar(int doorsAmount, TransmissionType transmissionType, int numberOfVelocities, int tankCapacity, int maxVelocity) : base(doorsAmount, numberOfVelocities, maxVelocity)
        {
            TransmissionType = transmissionType;
        }
    }
}