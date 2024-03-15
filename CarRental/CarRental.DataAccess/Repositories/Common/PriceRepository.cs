using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Domain.Entities.Common;
using CarRental.Domain.Entities.Types;
using CarRental.DataAccess.Abstract.Common;

namespace CarRental.DataAccess.Repositories
{
    /// <summary>
    /// Clase parcial referida a un precio
    /// </summary>
    public partial class ApplicationRepository : IPriceRepository
    {
        public Price CreatePrice(MoneyType currency, double value)
        {
            Price price = new Price(currency, value);
            _context.Add(price);
            return price;
        }

        public Price? GetPrice(Guid id)
        {
            return _context.Set<Price>().Find(id);
        }

        public void UpdatePrice(Price price)
        {
            _context.Set<Price>().Update(price);
        }

        public void DeletePrice(Price price)
        {
            _context.Remove(price);
        }
    }
}