using CarRental.Domain.Entities.Circulations;
using CarRental.Domain.Entities.Common;
using CarRental.Domain.Entities.Insurances;
using CarRental.Domain.Entities.Persons;
using CarRental.Domain.Entities.Reservations;
using CarRental.Domain.Entities.Somatons;
using CarRental.Domain.Entities.Supplements;
using CarRental.Domain.Entities.Vehicles;
using CarRental.Domain.Entities.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Drawing;
using CarRental.DataAccess.FluentConfigurations;
using CarRental.DataAccess.Concrete;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        //Creando un contexto para interactuar con la base de datos
        ApplicationContext appContext = new("Data Source=CarRentalDB.sqlite");
        //Verificando si la BD no existe
        if (!appContext.Database.CanConnect())
        {
            //Genera BD con las tablas configuradas en su migración
            appContext.Database.Migrate();
        }

        //CRUD con usuarios

        // Crear un usuario

        Users user = new("Carlos", "Rodríguez", "99062207946", "Cuba", UserRoleType.Guest);
        appContext.Set<Users>().Add(user);
        appContext.SaveChanges();

        //Lectura del nombre de todos los usuarios
        var users = appContext.Set<Users>().ToList();
        foreach (var loadedUser in users)
        {
            string UserName = appContext.Set<string>().Find(loadedUser.Name);
            loadedUser.Name = UserName;
        }

        // Actualización del nombre del país del usuario creado
        users = appContext.Set<Users>().ToList();
        foreach (var loadedUser in users)
        {
            string UserName = appContext.Set<string>().Find(loadedUser.Name);
            loadedUser.Name = UserName;
        }

        // Actualización del nombre del país del usuario creado
        users = appContext.Set<Users>().ToList();
        foreach (var loadedUser in users)
        {
            if (loadedUser.CI = "99062207946")
            {
                loadedUser.CountryName = "USA";
                appContext.Set<Users>().Update(loadedUser);
            }
        }
        appContext.SaveChanges();

        //Eliminar a todos los usuarios
        users = appContext.Set<Users>().ToList();
        foreach (var loadedUser in users)
        {
            appContext.Set<Users>().Remove(loadedUser);
        }
        appContext.SaveChanges();

        //Creando Insurance
        Insurance carInsurance = new Insurance("enable", "4394925832", new DateTime(2029, 3, 12), new DateTime(2023, 5, 12));
        appContext.Set<Insurance>().Add(carInsurance);
        appContext.SaveChanges();

        //leyendo insurance
        var insurances = appContext.Set<Insurances>().ToList();

        //actualizando insurance
        foreach (var insurance in insurances)
        {
            insurance.Status = "disable";
            appContext.Set<Insurance>().Update(insurance);
        }
        appContext.SaveChanges();

        //Borrando insurance
        foreach (var insurance in insurances)
        {
            appContext.Set<Insurance>().Remove(insurance);
        }
        appContext.SaveChanges();

        //Creando Somaton
        Somaton carSomaton = new Somaton(new DateTime(2028, 12, 12), new DateTime(2023, 8, 9), "Approved", 09310940748658516506);

        //Leyendo Somaton
        var somatons = appContext.Set<Somaton>().ToList();

        //Actualizando Somaton
        foreach (var somaton in somatons)
        {
            somaton.Status = "Cancelled";
            appContext.Set<Somaton>().Update(somaton);
        }
        appContext.SaveChanges();

        //Borrando Somaton
        foreach (somaton in somatons)
        {
            appContext.Set<Somaton>().Remove(somaton);
        }
        appContext.SaveChanges();
    }
}