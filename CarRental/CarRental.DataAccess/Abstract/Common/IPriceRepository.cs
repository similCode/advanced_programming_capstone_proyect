using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Domain.Entities.Common;
using CarRental.Domain.Entities.Types;

namespace CarRental.DataAccess.Abstract.Common
{
    /// <summary>
    /// Define las operaciones con los precios en BD
    /// </summary>
    public interface IPriceRepository : IRepository
    {
        /// <summary>
        /// Crea un precio en BD
        /// </summary>
        /// <param name="currency">Moneda</param>
        /// <param name="value">Valor</param>
        /// <returns></returns>
        Price CreatePrice(MoneyType currency, double value);

        /// <summary>
        /// Obtiene un precio de BD.
        /// </summary>
        /// <param name="id">Identificador del precio.</param>
        /// <returns>Precio solicitado de existir en BD, de lo contrario <see langword="null"/>.</returns>
        Price? GetPrice(Guid id);

        /// <summary>
        /// Actualiza el valor de un precio en BD.
        /// </summary>
        /// <param name="price">Precio a actualizar.</param>
        void UpdatePrice(Price price);

        /// <summary>
        /// Elimina un precio de BD.
        /// </summary>
        /// <param name="price">Precio a eliminar.</param>
        void DeletePrice(Price price);
    }
}