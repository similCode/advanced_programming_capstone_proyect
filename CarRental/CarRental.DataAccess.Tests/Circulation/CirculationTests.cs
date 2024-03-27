using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.DataAccess.Abstract.Circulations;
using CarRental.DataAccess.Abstract.Insurances;
using CarRental.DataAccess.Abstract.Somatons;
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
        [DataRow()]
        [TestMethod]
        public void Can_Create_Circulation(string model, string plate, string motorNumber, Guid insuranceId, Guid somatonId)
        {
            //Arrange
            _circulationRepository.BeginTransaction();
            Insurance? insurance = ((IInsuranceRepository)_circulationRepository).GetInsurance(insuranceId);
            Assert.IsNotNull(insurance);
            Somaton? somaton = ((ISomatonRepository)_circulationRepository).GetSomaton(somatonId);
            Assert.IsNotNull(somaton);


            //Execute
            var circulationDB = _circulationRepository.CreateCirculation(model, plate, motorNumber, insurance, somaton);
            _circulationRepository.PartialCommit();
            var loadedCirculation = _circulationRepository.GetCirculation(circulationDB.Id);
            _circulationRepository.CommitTransaction();

            //Assert
            Assert.IsNotNull(loadedCirculation);
            Assert.AreEqual(circulationDB.Model, loadedCirculation.Model);
            Assert.AreEqual(circulationDB.Plate, loadedCirculation.Plate);
            Assert.AreEqual(circulationDB.MotorNumber, loadedCirculation.MotorNumber);
            Assert.AreEqual(circulationDB.InsuranceID, loadedCirculation.InsuranceID);
            Assert.AreEqual(circulationDB.SomatonId, loadedCirculation.SomatonId);
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