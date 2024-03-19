using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.DataAccess.Abstract.Insurances;
using CarRental.DataAccess.Repositories;
using CarRental.DataAccess.Tests.Utilities;
using CarRental.Domain.Entities.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NuGet.Frameworks;
using static CarRental.Domain.Entities.Insurances.Insurance;

namespace CarRental.DataAccess.Tests.NewFolder1
{
    [TestClass]
     public class InsuranceTests
    {
        private IInsuranceRepository _insuranceRepository;

        public InsuranceTests()
        {
            _insuranceRepository = new ApplicationRepository(ConnectionStringProvider.GetConnectionString());
        }

        [TestMethod]
        public void Can_Create_Insurance()
        {
            //Arrange
            _insuranceRepository.BeginTransaction();

            //Execute
            _insuranceRepository.CommitTransaction();

            //Assert

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
