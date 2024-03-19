using CarRental.DataAccess.Abstract.Reservations;
using CarRental.DataAccess.Repositories;
using CarRental.DataAccess.Tests.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DataAccess.Tests.Reservations
{
    [TestClass]
    public class ReservationTests
    {
        private IReservationRepository _reservationRepository;

        public ReservationTests()
        {
            _reservationRepository = new ApplicationRepository(ConnectionStringProvider.GetConnectionString());
        }

        public void Can_Create_Reservation()
        {
            //Arrange
            _reservationRepository.BeginTransaction();

            //Execute
            _reservationRepository.CommitTransaction();

            //Assert
        }
        [DataRow(1)]
        [TestMethod]
        public void Can_Get_Reservation(Guid id)
        {
            //Arrange
            _reservationRepository.BeginTransaction();

            //Execute
            var loadedReservation = _reservationRepository.GetReservation(id);
            _reservationRepository.CommitTransaction();

            //Assert
            Assert.IsNotNull(loadedReservation);

        }
        [TestMethod]
        public void Can_Update_Reservation(Guid id)
        {
            //Arrange
            _reservationRepository.BeginTransaction();

            //Execute

            //Assert
            _reservationRepository.CommitTransaction();

        }

        [DataRow(1)]
        [TestMethod]
        public void Can_Delete_Reservation(Guid id)
        {
            //Arrange
            _reservationRepository.BeginTransaction();

            //Execute
            var loadedReservation = _reservationRepository.GetReservation(id);
            Assert.IsNotNull(loadedReservation);
            _reservationRepository.DeleteReservation(loadedReservation);
            _reservationRepository.PartialCommit();
            loadedReservation = _reservationRepository.GetReservation(id);
            _reservationRepository.CommitTransaction();

            //Assert
            Assert.IsNull(loadedReservation);

        }
    }

}
