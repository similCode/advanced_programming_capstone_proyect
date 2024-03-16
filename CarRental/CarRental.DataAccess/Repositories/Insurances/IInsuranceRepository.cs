using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Domain.Entities.Insurances;
using static CarRental.Domain.Entities.Insurances.Insurance;
using CarRental.DataAccess.Abstract.Insurances;
using CarRental.Domain.Entities.Circulations;

namespace CarRental.DataAccess.Repositories
{
    /// <summary>
    /// Clase parcial referida a los seguros
    /// </summary>
    public partial class ApplicationRepository : IInsuranceRepository
    {
        public Insurance CreateInsurance(Statusenum status, string policyNumber, DateTime expirationDate, DateTime expeditionDate)

        {
            Insurance insurance = new Insurance(status, policyNumber, expirationDate, expeditionDate);
            _context.Add(insurance); return insurance;
        }

        public Insurance? GetInsurance(Guid id)
        {
            return _context.Set<Insurance>().Find(id);
        }

        public void UpdateInsurance(Insurance insurance)
        {
            _context.Set<Insurance>().Update(insurance);
        }

        public void DeleteInsurance(Insurance insurance)
        {
            _context.Remove(insurance);
        }
    }
}