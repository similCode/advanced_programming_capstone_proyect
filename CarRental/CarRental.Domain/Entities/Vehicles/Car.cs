﻿using CarRental.Domain.Entities.Types;

namespace CarRental.Domain.Entities.Vehicles
{
    /// <summary>
    /// Esta clase modela un carro
    /// </summary>
    public abstract class Car : Vehicle
    {
        /// <summary>
        /// Cantidad de puertas
        /// </summary>
        public int DoorsAmount { get; }

        /// <summary>
        /// Si tiene aire acondicionado
        /// </summary>
        public bool HasAirConditioning { get; set; }

        /// <summary>
        /// Numero de velocidades
        /// </summary>
        public int NumberOfVelocities { get; }

        /// <summary>
        /// Maxima velocidad de acuerdo al fabricante
        /// </summary>
        public int MaxVelocity { get; }

        /// <summary>
        /// Constructor por default
        /// </summary>

        protected Car()
        { }

        /// <summary>
        /// Constructor por parametros
        /// </summary>
        /// <param name="doorsAmount"></param>
        /// <param name="numberOfVelocities"></param>
        /// <param name="maxVelocity"></param>
        public Car(int doorsAmount, int numberOfVelocities, int maxVelocity)
        {
            DoorsAmount = doorsAmount;
            NumberOfVelocities = numberOfVelocities;
            MaxVelocity = maxVelocity;
        }
    }
}