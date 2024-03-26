using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.DataAccess.Abstract.Circulations;
using CarRental.DataAccess.Repositories;
using CarRental.DataAccess.Tests.Utilities;
using CarRental.Domain.Entities.Insurances;
using CarRental.Domain.Entities.Somatons;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarRental.DataAccess.Tests.Circulation
{
    [TestClass]
    public class CirculationTests
    {
        public ICirculationRepository _circulationRepository;

        public CirculationTests()
        {
            _circulationRepository = new ApplicationRepository(ConnectionStringProvider.GetConnectionString());
        }

        [TestMethod]
        public void Can_Create_Circulation()
        {
            //Arrange
            _circulationRepository.BeginTransaction();

            //Execute
            _circulationRepository.CommitTransaction();

            //Assert
        }

        [DataRow(1)]
        [TestMethod]
        public void Can_Get_Circulation(Guid id)
        {
            //Arrange
            _circulationRepository.BeginTransaction();

            //Execute
            var loadedCirculation = _circulationRepository.GetCirculation(id);
            _circulationRepository.CommitTransaction();

            //Assert
            Assert.IsNotNull(loadedCirculation);
        }

        [DataRow(1, "Red", 1, 1, "2024-03-16T12:00:00")]
        [TestMethod]
        public void Can_Update_Circulation(Guid id, Color color, Guid insuranceID, Guid somatonId, DateTime expirationDate)
        {
            //Arrange
            _circulationRepository.BeginTransaction();
            var loadedCirculation = _circulationRepository.GetCirculation(id);
            Assert.IsNotNull(loadedCirculation);

            //Execute
            loadedCirculation.Color = color;
            loadedCirculation.InsuranceID = insuranceID;
            loadedCirculation.SomatonId = somatonId;
            loadedCirculation.ExpeditionDate = expirationDate;
            _circulationRepository.UpdateCirculation(loadedCirculation);

            //Assert
            var modifyedCirculation = _circulationRepository.GetCirculation(id);
            _circulationRepository.CommitTransaction();
            Assert.AreEqual(modifyedCirculation.Color, color);
            Assert.AreEqual(modifyedCirculation.InsuranceID, insuranceID);
            Assert.AreEqual(modifyedCirculation.SomatonId, somatonId);
            Assert.AreEqual(modifyedCirculation.ExpeditionDate, expirationDate);
        }

        [DataRow(1)]
        [TestMethod]
        public void Can_Delete_Circulation(Guid id)
        {
            //Arrange
            _circulationRepository.BeginTransaction();

            //Execute
            var loadedCirculation = _circulationRepository.GetCirculation(id);
            Assert.IsNotNull(loadedCirculation);
            _circulationRepository.DeleteCirculation(loadedCirculation);
            _circulationRepository.PartialCommit();
            loadedCirculation = _circulationRepository.GetCirculation(id);
            _circulationRepository.CommitTransaction();

            //Assert
            Assert.IsNull(loadedCirculation);
        }
    }
}