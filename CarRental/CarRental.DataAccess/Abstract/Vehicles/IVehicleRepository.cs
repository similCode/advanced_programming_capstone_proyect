using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Domain.Entities.Common;
using CarRental.Domain.Entities.Insurances;
using CarRental.Domain.Entities.Somatons;
using CarRental.Domain.Entities.Vehicles;

namespace CarRental.DataAccess.Abstract.Vehicles
{
    /// <summary>
    /// Define las operaciones en BD para un vehiculo
    /// </summary>
    public interface IVehicleRepository : IRepository
    {
        /// <summary>
        /// Crea un carro en BD
        /// </summary>
        /// <param name="brandName">Nombre de la marca</param>
        /// <param name="fabricationDate">Fecha de fabricacion</param>
        /// <param name="plate">Chapa</param>
        /// <param name="motorNumber">Numero del motor</param>
        /// <param name="color">color</param>
        /// <param name="insurance">Seguro</param>
        /// <param name="somaton">Somaton</param>
        /// <param name="model">modelo</param>
        /// <param name="passengerCapacity">Capacidad de pasajeros</param>
        /// <param name="price">precio</param>
        /// <param name="wheelAmount">numero de ruedas</param>
        /// <param name="weight">peso</param>
        /// <param name="doorsAmount">Cantidad de puertas</param>
        /// <param name="numberOfVelocities">\Numero de velocidades</param>
        /// <param name="maxVelocity">Maxima velocidad</param>
        /// <param name="hasAirConditioning">Aire acondicianado</param>
        /// <returns></returns>
        Car CreateCar(string brandName, DateTime fabricationDate, Insurance insurance, Somaton somaton, Price price, int numberOfVelocities, int maxVelocity, bool hasAirConditioning);

        /// <summary>
        /// Crea una motocicleta en BD
        /// </summary>
        /// <param name="brandName">Nombre de la marca</param>
        /// <param name="fabricationDate">Fecha de fabricacion</param>
        /// <param name="plate">Chapa</param>
        /// <param name="motorNumber">Numero del motor</param>
        /// <param name="color">color</param>
        /// <param name="insurance">Seguro</param>
        /// <param name="somaton">Somaton</param>
        /// <param name="model">modelo</param>
        /// <param name="passengerCapacity">Capacidad de pasajeros</param>
        /// <param name="price">precio</param>
        /// <param name="wheelAmount">numero de ruedas</param>
        /// <param name="weight">peso</param>
        /// <param name="hasSideCar">Tiene carrito</param>
        /// <returns></returns>
        Motorcycle CreateMotorcycle(string brandName, DateTime fabricationDate, Insurance insurance, Somaton somaton, Price price, bool hasSideCar);

        /// <summary>
        /// Obtiene un vehiculo de BD
        /// </summary>
        /// <typeparam name="V">Tipo de vehiculo</typeparam>
        /// <param name="id">Identificador del vehiculo</param>
        /// <returns>Retorna un vehiculo si existe en BD, de lo contrario<see langword="null"></returns>
        Vehicle? GetVehicle(Guid id);

        /// <summary>
        /// Obtiene todos los vehiculos en BD
        /// </summary>
        /// <returns>vehiculos en BD</returns>
        IEnumerable<Vehicle> GetAllVehicles();

        /// <summary>
        /// Obtiene todos los carros en BD
        /// </summary>
        /// <returns></returns>
        IEnumerable<Car> GetAllCars();

        /// <summary>
        /// Obtiene todas las motocicletas en BD
        /// </summary>
        /// <returns></returns>
        IEnumerable<Motorcycle> GetAllMotorcycles();

        /// <summary>
        /// Actualiza un vehiculo en BD
        /// </summary>
        /// <param name="vehicle">Vehiculo a actualizar</param>
        void UpdateVehicle(Vehicle vehicle);

        /// <summary>
        /// Borra un vehiculo en BD
        /// </summary>
        /// <param name="vehicle">Vehiculo a borrar</param>
        void DeleteVehicle(Vehicle vehicle);
    }
}