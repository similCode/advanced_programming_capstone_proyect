using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Domain.Entities.Somatons;
using CarRental.Domain.Entities.Types;

namespace CarRental.DataAccess.Abstract.Somatons
{
    /// <summary>
    /// Define las operaciones en bases de datos con los somatones
    /// </summary>
    public interface ISomatonRepository : IRepository
    {
        /// <summary>
        /// Crea un somaton
        /// </summary>
        /// <param name="expirationDate">Fecha de expiracion</param>
        /// <param name="expeditionDate">Fecha de emision</param>
        /// <param name="status">Estado</param>
        /// <param name="number">Numero de somaton</param>
        /// <returns></returns>
        Somaton CreateSomaton(DateTime expirationDate, DateTime expeditionDate, Status status, string number);

        /// <summary>
        /// Obtiene un somaton de BD
        /// </summary>
        /// <param name="id">Identificador del somaton</param>
        /// <returns>Retorna un somaton si existe en BD, de lo contrario<see langword="null"></returns>
        Somaton? GetSomaton(Guid id);

        /// <summary>
        /// Actualiza un somaton en BD
        /// </summary>
        /// <param name="somaton">Somaton a actualizar</param>
        void UpdateSomaton(Somaton somaton);

        /// <summary>
        /// Borra un somaton en BD
        /// </summary>
        /// <param name="somaton">Somaton a borrar</param>
        void DeleteSomaton(Somaton somaton);
    }
}