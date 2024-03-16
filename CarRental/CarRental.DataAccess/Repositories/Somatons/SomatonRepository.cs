using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Domain.Entities.Somatons;
using CarRental.Domain.Entities.Types;
using CarRental.DataAccess.Abstract.Somatons;

namespace CarRental.DataAccess.Repositories
{
    /// <summary>
    /// Clase parcial referida a los somatones
    /// </summary>
    public partial class ApplicationRepository : ISomatonRepository
    {
        public Somaton CreateSomaton(DateTime expirationDate, DateTime expeditionDate, Status status, string number)
        {
            Somaton somaton = new Somaton(expirationDate, expeditionDate, status, number);
            _context.Add(somaton); return somaton;
        }

        public Somaton? GetSomaton(Guid id)
        {
            return _context.Set<Somaton>().Find(id);
        }

        public void UpdateSomaton(Somaton somaton)
        {
            _context.Set<Somaton>().Update(somaton);
        }

        public void DeleteSomaton(Somaton somaton)
        {
            _context.Remove(somaton);
        }
    }
}