using CarRental.DataAccess.Abstract.Common;
using CarRental.DataAccess.Repositories;
using CarRental.DataAccess.Tests.Utilities;
using CarRental.Domain.Entities.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DataAccess.Tests.Common
{
    [TestClass]
    public class PriceTests
    {
        private IPriceRepository _priceRepository;

        public PriceTests()
        {
            _priceRepository = new ApplicationRepository(ConnectionStringProvider.GetConnectionString());
        }


        [TestMethod]
        public void Can_Create_Price()
        {
            //Arrange
            _priceRepository.BeginTransaction();
            //Execute
            _priceRepository.CommitTransaction();
            //Assert

        }

        [DataRow(1)]
        [TestMethod]
        public void Can_Get_Price(Guid id)
        {
            //Arrange
            _priceRepository.BeginTransaction();

            //Execute
            var loadedPrice = _priceRepository.GetPrice(id);
            _priceRepository.CommitTransaction();

            //Assert
            Assert.IsNotNull(loadedPrice);
        }

        [DataRow(1, MoneyType.USD, 6200)]
        [TestMethod]
        public void Can_Update_Price(Guid id, double value, MoneyType moneyType)
        {
            //Arrange
            _priceRepository.BeginTransaction();
            var loadedPrice = _priceRepository.GetPrice(id);
            Assert.IsNotNull(loadedPrice);

            //Execute
            loadedPrice.Value = value;
            loadedPrice.Currency = moneyType;
            _priceRepository.UpdatePrice(loadedPrice);

            //Assert
            var modifyedPrice = _priceRepository.GetPrice(id);
            _priceRepository.CommitTransaction();
            Assert.AreEqual(modifyedPrice.Value, value);
            Assert.AreEqual(modifyedPrice.Currency, moneyType);
        }

        [DataRow(1)]
        [TestMethod]
        public void Can_Delete_Price(Guid id)
        {
            //Arrange
            _priceRepository.BeginTransaction();

            //Execute
            var loadedPrice = _priceRepository.GetPrice(id);
            Assert.IsNotNull(loadedPrice);
            _priceRepository.DeletePrice(loadedPrice);
            _priceRepository.PartialCommit();
            loadedPrice = _priceRepository.GetPrice(id);
            _priceRepository.CommitTransaction();

            //Assert
            Assert.IsNull(loadedPrice);
        }
    }
}
