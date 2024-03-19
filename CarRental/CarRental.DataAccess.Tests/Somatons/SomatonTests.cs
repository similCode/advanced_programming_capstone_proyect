using CarRental.DataAccess.Abstract.Somatons;
using CarRental.DataAccess.Repositories;
using CarRental.DataAccess.Tests.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DataAccess.Tests.Somatons
{
    [TestClass]
    public class SomatonTests
    {
        private ISomatonRepository _somatonRepository;

        public SomatonTests()
        {
            _somatonRepository = new ApplicationRepository(ConnectionStringProvider.GetConnectionString());
        }

        public void Can_Create_Somaton()
        {
            //Arrange
            _somatonRepository.BeginTransaction();

            //Execute
            _somatonRepository.CommitTransaction();

            //Assert

        }
        [DataRow(1)]
        [TestMethod]
        public void Can_Get_Somaton(Guid id)
        {
            //Arrange
            _somatonRepository.BeginTransaction();

            //Execute
            var loadedSomaton = _somatonRepository.GetSomaton(id);
            _somatonRepository.CommitTransaction();

            //Assert
            Assert.IsNotNull(loadedSomaton);

        }
        [TestMethod]
        public void Can_Update_Somaton(Guid id)
        {
            //Arrange
            _somatonRepository.BeginTransaction();

            //Execute

            //Assert
            _somatonRepository.CommitTransaction();

        }

        [DataRow(1)]
        [TestMethod]
        public void Can_Delete_Somaton(Guid id)
        {
            //Arrange
            _somatonRepository.BeginTransaction();

            //Execute
            var loadedSomaton = _somatonRepository.GetSomaton(id);
            Assert.IsNotNull(loadedSomaton);
            _somatonRepository.DeleteSomaton(loadedSomaton);
            _somatonRepository.PartialCommit();
            loadedSomaton = _somatonRepository.GetSomaton(id);
            _somatonRepository.CommitTransaction();

            //Assert
            Assert.IsNull(loadedSomaton);
        }

    }
}
