using CarRental.DataAccess.Abstract.Supplements;
using CarRental.DataAccess.Repositories;
using CarRental.DataAccess.Tests.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DataAccess.Tests.Supplements
{
    [TestClass]
    public class SupplementTests
    {
        private ISupplementRepository _supplementRepository;

        public SupplementTests()
        {
            _supplementRepository = new ApplicationRepository(ConnectionStringProvider.GetConnectionString());
        }

        public void Can_Create_Supplement()
        {
            //Arrange
            _supplementRepository.BeginTransaction();

            //Execute
            _supplementRepository.CommitTransaction();

            //Assert

        }

        [DataRow(1)]
        [TestMethod]
        public void Can_Get_Supplement(Guid id)
        {
            //Arrange
            _supplementRepository.BeginTransaction();

            //Execute
            var loadedSupplement = _supplementRepository.GetSupplement(id);
            _supplementRepository.CommitTransaction();

            //Assert
            Assert.IsNotNull(loadedSupplement);
        }

        [TestMethod]
        public void Can_Update_Supplement(Guid id)
        {
            //Arrange
            _supplementRepository.BeginTransaction();

            //Execute

            //Assert
            _supplementRepository.CommitTransaction();

        }

        [DataRow(1)]
        [TestMethod]
        public void Can_Delete_Supplement(Guid id)
        {
            //Arrange
            _supplementRepository.BeginTransaction();

            //Execute
            var loadedSupplement = _supplementRepository.GetSupplement(id);
            Assert.IsNotNull(loadedSupplement);
            _supplementRepository.DeleteSupplement(loadedSupplement);
            _supplementRepository.PartialCommit();
            loadedSupplement = _supplementRepository.GetSupplement(id);
            _supplementRepository.CommitTransaction();

            //Assert
            Assert.IsNull(loadedSupplement);

        }

    }
}
