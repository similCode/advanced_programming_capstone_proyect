using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.DataAccess.Abstract.Insurances;
using CarRental.DataAccess.Repositories;
using CarRental.DataAccess.Tests.Utilities;
using CarRental.Domain.Entities.Insurances;
using CarRental.Domain.Entities.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NuGet.Frameworks;
using static CarRental.Domain.Entities.Insurances.Insurance;

namespace CarRental.DataAccess.Tests.Insurances
{
    [TestClass]
     public class InsuranceTests
    {
        private IInsuranceRepository _insuranceRepository;

        public InsuranceTests()
        {
            _insuranceRepository = new ApplicationRepository(ConnectionStringProvider.GetConnectionString());
        }

        [DataRow(Statusenum.Enable, "POL1234", "2024-03-16T12:00:00", "2043-03-16T12:00:00")]
        [TestMethod]
        public void Can_Create_Insurance(Statusenum status, string policyNumber, string expirationDateString, string expeditionDateString )
        {
            DateTime expirationDate = DateTime.Parse(expirationDateString);
            DateTime expeditionDate = DateTime.Parse(expeditionDateString);
            //Arrange
            _insuranceRepository.BeginTransaction();

            //Ejecutar
            Insurance newInsurance = _insuranceRepository.CreateInsurance(status, policyNumber, expirationDate, expeditionDate);
            _insuranceRepository.PartialCommit();
            Insurance? loadedInsurance = _insuranceRepository.GetInsurance(newInsurance.Id);
            _insuranceRepository.CommitTransaction();

            //Assert
            Assert.IsNotNull(loadedInsurance);
            Assert.AreEqual(loadedInsurance.Status, status);
            Assert.AreEqual(loadedInsurance.PolicyNumber, policyNumber);
            Assert.AreEqual(loadedInsurance.ExpirationDate, expirationDate);
            Assert.AreEqual(loadedInsurance.ExpeditionDate, expeditionDate);
        }

        [DataRow(1)]
        [TestMethod]
        public void Can_Get_Insurance(Guid id)
        {
            //Arrange
            _insuranceRepository.BeginTransaction();

            //Execute
            var loadedInsurance = _insuranceRepository.GetInsurance(id);
            _insuranceRepository.CommitTransaction();

            //Assert
            Assert.IsNotNull(loadedInsurance);

        }


        [DataRow(1,Statusenum.Enable, "2024-03-16T12:00:00")]
        [TestMethod]
        public void Can_Update_Insurance(Guid id, Statusenum status, DateTime expirationDate)
        {
            //Arrange
            _insuranceRepository.BeginTransaction();
            var loadedInsurance = _insuranceRepository.GetInsurance(id);
            Assert.IsNotNull(loadedInsurance);

            //Execute
            loadedInsurance.Status = status;
            loadedInsurance.ExpirationDate = expirationDate;
            _insuranceRepository.UpdateInsurance(loadedInsurance);

            //Assert
            var modifyedInsurance = _insuranceRepository.GetInsurance(id);
            _insuranceRepository.CommitTransaction();
            Assert.AreEqual(modifyedInsurance.Status, status);
            Assert.AreEqual(modifyedInsurance.ExpirationDate, expirationDate);

        }

        [DataRow(1)]
        [TestMethod]
        public void Can_Delete_Insurance(Guid id)
        {
            //Arrange
            _insuranceRepository.BeginTransaction();

            //Execute
            var loadedInsurance = _insuranceRepository.GetInsurance(id);
            Assert.IsNotNull(loadedInsurance);
            _insuranceRepository.DeleteInsurance(loadedInsurance);
            _insuranceRepository.PartialCommit();
            loadedInsurance = _insuranceRepository.GetInsurance(id);
            _insuranceRepository.CommitTransaction();

            //Assert
            Assert.IsNull(loadedInsurance);

        }

    }
}
