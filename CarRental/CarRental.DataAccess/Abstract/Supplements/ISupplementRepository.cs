using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Domain.Entities.Common;
using CarRental.Domain.Entities.Supplements;

namespace CarRental.DataAccess.Abstract.Supplements
{
    /// <summary>
    /// Define las operaciones de los suplementos en BD
    /// </summary>
    public interface ISupplementRepository : IRepository
    {
        /// <summary>
        /// Crea un suplemento en BD
        /// </summary>
        /// <param name="price">Precio</param>
        /// <param name="description">Descripcion</param>
        /// <returns></returns>
        Supplement CreateSupplement(Price price, string description);

        /// <summary>
        /// Obtiene un suplemento de BD
        /// </summary>
        /// <param name="id">Identificador del suplemento</param>
        /// <returns>Retorna un suplemento si existe en BD, en caso contrario <see langword="null"></returns>
        Supplement? GetSupplement(Guid id);

        /// <summary>
        /// Borra un suplemento de base de datos
        /// </summary>
        /// <param name="supplement">Suplemento a borrar</param>
        void DeleteSupplement(Supplement supplement);
    }
}