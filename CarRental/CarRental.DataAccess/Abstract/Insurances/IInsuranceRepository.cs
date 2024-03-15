using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Domain.Entities.Insurances;
using static CarRental.Domain.Entities.Insurances.Insurance;

namespace CarRental.DataAccess.Abstract.Insurances
{
    /// <summary>
    /// Define las operaciones en BD de los seguros
    /// </summary>
    public interface IInsuranceRepository : IRepository
    {
        /// <summary>
        /// Crea un seguro en BD
        /// </summary>
        /// <param name="status">Estado</param>
        /// <param name="policyNumber">Numero de poliza</param>
        /// <param name="expirationDate">Fecha de expiracion</param>
        /// <param name="expeditionDate">Fecha de emision</param>
        /// <returns></returns>
        Insurance CreateInsurance(Statusenum status, string policyNumber, DateTime expirationDate, DateTime expeditionDate);

        /// <summary>
        /// Obtiene un seguro de BD
        /// </summary>
        /// <param name="id">Identificador del seguro</param>
        /// <returns>Seguro de existir en BD, de lo contrario<see langword="null"></returns>
        Insurance? GetInsurance(Guid id);

        /// <summary>
        /// Actualiza un seguro en BD
        /// </summary>
        /// <param name="insurance">Seguro a actualizar</param>
        void UpdateInsurance(Insurance insurance);

        /// <summary>
        /// Borra un seguro de BD
        /// </summary>
        /// <param name="id">Seguro a borrar</param>
        void DeleteInsurance(Insurance insurance);
    }
}