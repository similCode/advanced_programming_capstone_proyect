using CarRental.DataAccess.Abstract.Circulations;
using CarRental.DataAccess.Abstract.Persons;
using CarRental.DataAccess.Repositories;
using CarRental.DataAccess.Tests.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DataAccess.Tests.Persons
{
    [TestClass]
    public class PersonTests
    {
        private IPersonRepository _personRepository;

        public PersonTests()
        {
            _personRepository = new ApplicationRepository(ConnectionStringProvider.GetConnectionString()); ;
        }

        public void Can_Create_Person()
        {
            //Arrange
            _personRepository.BeginTransaction();

            //Execute
            _personRepository.CommitTransaction();

            //Assert
        }

        [DataRow(1)]
        [TestMethod]
        public void Can_Get_Person(Guid id)
        {
            //Arrange
            _personRepository.BeginTransaction();

            //Execute
            var loadedPerson = _personRepository.GetPerson(id);
            _personRepository.CommitTransaction();

            //Assert
            Assert.IsNotNull(loadedPerson);
        }

        [TestMethod]
        public void Can_Update_Person(Guid id)
        {
            //Arrange
            _personRepository.BeginTransaction();
            var loadedPerson = _personRepository.GetPerson(id);
            Assert.IsNotNull(loadedPerson);

            //Execute
            //TODO:btibti43u


            //Assert
            _personRepository.CommitTransaction();

        }

        [DataRow(1)]
        [TestMethod]
        public void Can_Delete_Person(Guid id)
        {
            //Arrange
            _personRepository.BeginTransaction();

            //Execute
            var loadedPerson = _personRepository.GetPerson(id);
            Assert.IsNotNull(loadedPerson);
            _personRepository.DeletePerson(loadedPerson);
            _personRepository.PartialCommit();
            loadedPerson = _personRepository.GetPerson(id);
            _personRepository.CommitTransaction();

            //Assert
            Assert.IsNull(loadedPerson);

        }
    }
}
