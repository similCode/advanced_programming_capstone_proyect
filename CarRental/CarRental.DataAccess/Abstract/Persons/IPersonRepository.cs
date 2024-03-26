using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Domain.Entities.Persons;
using CarRental.Domain.Entities.Types;

namespace CarRental.DataAccess.Abstract.Persons;

/// <summary>
/// Define las operaciones en BD para personas
/// </summary>
public interface IPersonRepository : IRepository
{
    /// <summary>
    /// Crea un usuario en BD
    /// </summary>
    /// <param name="name">Nombre</param>
    /// <param name="lastName">Apellido</param>
    /// <param name="iD">Identificador</param>
    /// <param name="countryName">Nombre del pais</param>
    /// <param name="role">Rol</param>
    /// <returns></returns>
    Users CreateUser(string name, string lastName, string iD, string countryName, UserRoleType role);

    /// <summary>
    /// Crea un cliente en BD
    /// </summary>
    /// <param name="name">Nombre</param>
    /// <param name="lastName">Apellido</param>
    /// <param name="iD">Identificador</param>
    /// <param name="countryName">Nombre del pais</param>
    /// <param name="role">Rol</param>
    /// <returns></returns>
    Client CreateClient(string name, string lastName, string iD, string countryName);

    /// <summary>
    /// Obtiene una persona de BD
    /// </summary>
    /// <typeparam name="P">Tipo de persona a obtener</typeparam>
    /// <param name="id">Identificador de la persona</param>
    /// <returns>Persona solicitada de existir en BD, de lo contrario<see langword="null"></returns>
    Person GetPerson(Guid id);

    /// <summary>
    /// Obtiene todas las personas de base de datos
    /// </summary>
    /// <returns>Personas en base de datos</returns>
    IEnumerable<Person> GetAllPersons();

    /// <summary>
    /// Actualiza una persona en BD
    /// </summary>
    /// <param name="person">Persona a actualizar</param>
    void UpdatePerson(Person person);

    /// <summary>
    /// Borra una persona en BD
    /// </summary>
    /// <param name="person">Persona a borrar</param>
    void DeletePerson(Person person);
}