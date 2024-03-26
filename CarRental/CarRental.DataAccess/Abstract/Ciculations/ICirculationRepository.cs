using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Domain.Entities.Circulations;
using CarRental.Domain.Entities.Insurances;
using CarRental.Domain.Entities.Somatons;

namespace CarRental.DataAccess.Abstract.Circulations
{
    /// <summary>
    /// Define las operaciones a realizar en BD con circulaciones
    /// </summary>
    public interface ICirculationRepository : IRepository
    {
        /// <summary>
        /// Crea una circulacion en base de datos
        /// </summary>
        /// <param name="brandName">Nombre de la marca</param>
        /// <param name="model">modelo</param>
        /// <param name="fabricationDate">Fecha de fabricacion</param>
        /// <param name="plate">Chapa</param>
        /// <param name="motorNumber">Numero del motor</param>
        /// <param name="color">Color</param>
        /// <param name="insurance">Seguro</param>
        /// <param name="insuranceID">Identificador del seguro</param>
        /// <param name="somaton">Somaton</param>
        /// <param name="somatonId">Identificador del somatom</param>
        /// <param name="expirationDate">Fecha de expiracion</param>
        /// <param name="expeditionDate">Fecha de emision</param>
        /// <param name="vin"></param>
        /// <returns></returns>
        Circulation CreateCirculation(string brandName, string model, DateTime fabricationDate, string plate, string motorNumber, Color color, Insurance insurance, Somaton somaton, DateTime expirationDate, DateTime expeditionDate, string vin);

        /// <summary>
        /// Obtiene una circulacion de BD
        /// </summary>
        /// <param name="id">Identificador de la circulacion</param>
        /// <returns>Circulacion solicitada de existir en BD, de lo contrario <see langword="null"/>.</returns>
        Circulation? GetCirculation(Guid id);

        /// <summary>
        /// Actualiza una Ciculacion en BD
        /// </summary>
        /// <param name="circulation">Circulacion a actualizar</param>
        void UpdateCirculation(Circulation circulation);

        /// <summary>
        /// Borra una Circulacion a BD
        /// </summary>
        /// <param name="circulation">Circulacion a borrar</param>
        void DeleteCirculation(Circulation circulation);
    }
}