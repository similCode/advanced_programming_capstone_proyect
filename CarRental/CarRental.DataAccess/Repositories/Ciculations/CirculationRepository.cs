using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Domain.Entities.Circulations;
using CarRental.Domain.Entities.Insurances;
using CarRental.Domain.Entities.Somatons;
using CarRental.DataAccess.Abstract.Circulations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CarRental.DataAccess.Repositories
{
    /// <summary>
    /// Clase parcial referida a la circulacion
    /// </summary>
    public partial class ApplicationRepository : ICirculationRepository
    {
        public Circulation CreateCirculation(string brandName, string model, DateTime fabricationDate, string plate, string motorNumber, Color color, Insurance insurance, Guid insuranceID, Somaton somaton, Guid somatonId, DateTime expirationDate, DateTime expeditionDate, string vin)
        {
            Circulation circulation = new Circulation(brandName, model, fabricationDate, plate, motorNumber, color, insurance, insuranceID, somaton, somatonId, expirationDate, expeditionDate, vin);
            _context.Add(circulation);
            return circulation;
        }

        public Circulation? GetCirculation(Guid id)
        {
            return _context.Set<Circulation>().Find(id);
        }

        public void UpdateCirculation(Circulation circulation)
        {
            _context.Set<Circulation>().Update(circulation);
        }

        public void DeleteCirculation(Circulation circulation)
        {
            _context.Remove(circulation);
        }
    }
}