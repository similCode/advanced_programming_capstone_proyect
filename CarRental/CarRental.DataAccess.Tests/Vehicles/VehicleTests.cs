using CarRental.DataAccess.Abstract.Vehicles;
using CarRental.DataAccess.Repositories;
using CarRental.DataAccess.Tests.Utilities;
using CarRental.Domain.Entities.Vehicles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DataAccess.Tests.Vehicles
{
    [TestClass]
    public class VehicleTests
    {
        private IVehicleRepository _vehicleRepository;

        public VehicleTests()
        {
            _vehicleRepository = new ApplicationRepository(ConnectionStringProvider.GetConnectionString());
        }

        public void Can_Create_Vehicle()
        {
            //Arrange
            _vehicleRepository.BeginTransaction();

            //Execute
            _vehicleRepository.CommitTransaction();

            //Assert

        }

        [DataRow(1)]
        [TestMethod]
        public void Can_Get_Vehicle(Guid id)
        {
            //Arrange
            _vehicleRepository.BeginTransaction();

            //Execute
            var loadedVehicle = _vehicleRepository.GetVehicle<Vehicle>(id);
            _vehicleRepository.CommitTransaction();

            //Assert
            Assert.IsNotNull(loadedVehicle);

        }

        [TestMethod]
        public void Can_Update_Vehicle(Guid id)
        {
            //Arrange
            _vehicleRepository.BeginTransaction();

            //Execute

            //Assert
            _vehicleRepository.CommitTransaction();

        }

        [DataRow(1)]
        [TestMethod]
        public void Can_Delete_Vehicle(Guid id)
        {
            //Arrange
            _vehicleRepository.BeginTransaction();

            //Execute
            var loadedVehicle = _vehicleRepository.GetVehicle<Vehicle>(id);
            Assert.IsNotNull(loadedVehicle);
            _vehicleRepository.DeleteVehicle(loadedVehicle);
            _vehicleRepository.PartialCommit();
            loadedVehicle = _vehicleRepository.GetVehicle<Vehicle>(id);
            _vehicleRepository.CommitTransaction();

            //Assert
            Assert.IsNull(loadedVehicle);

        }

    }
}
