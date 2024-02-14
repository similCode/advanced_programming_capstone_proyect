using CarRental.Domain.Entities.Clients;
using CarRental.Domain.Entities.Common;
using CarRental.Domain.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities.Orders
{
    public class RentOrder
    {
        #region Properties

        /// <summary>
        /// Cliente que realizó la renta.
        /// </summary>
        public Client Client { get; }

        /// <summary>
        /// Vehículo a rentar.
        /// </summary>
        public Car Vehicle { get; }

        /// <summary>
        /// Cantidad de unidades del vehículo rentadas.
        /// </summary>
        public int Units { get; set; }

        /// <summary>
        /// Fecha de creación de la orden.
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Fecha en la que se ejecuta el pago.
        /// </summary>
        public DateTime? PaymentDay { get; set; }

        /// <summary>
        /// Indica si la orden de renta ya fue pagada;
        /// </summary>
        public bool IsPayed => PaymentDay is not null;

        /// <summary>
        /// Precio total a pagar por la orden.
        /// </summary>
        public Price TotalPrice => new Price(Vehicle.Price.Currency, Vehicle.Price.Value * Units);

        #endregion Properties

        /// <summary>
        /// Inicializa un objeto <see cref="RentOrder"/>.
        /// </summary>
        /// <param name="client">Cliente que realiza la renta.</param>
        /// <param name="car">Vehículo que realiza la renta.</param>
        /// <param name="units">Unidades del vehículo renta.</param>
        public RentOrder(Client client, Car car, int units = 1)
        {
            Client = client;
            Vehicle = car;
            Units = units;
        }
    }
}