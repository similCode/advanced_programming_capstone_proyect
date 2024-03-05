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
    static void Main(string[] args)
    {
        //Creando un contexto para interactuar con la base de datos
        ApplicationContext appContext = new("Data Source=CarRentalDB.sqlite");
        //Verificando si la BD no existe
        if (!appContext.Database.CanConnect())
        {
            //Genera BD con las tablas configuradas en su migración
            appContext.Database.Migrate();
        }
        //Crear el precio de un carro

         Price carPrice = new(MoneyType.Euro, 5000);
    
        appContext.Set<Price>().Add(carPrice);
        appContext.SaveChanges();
        
       //Lectura del nombre de todos los usuarios
       var users= appContext.Set<Users>().ToList();
      foreach (var loadedUser in users)
      {
         string UserName=appContext.Set<string>().Find(loadedUser.userName);
         loadedUser.userName= UserName;
      }
      
     // actualización del nombre del país de un usuario que emigró
        var users= appContext.Set<Users>().ToList();
        foreach(var loadedUser in users)
        {
          if(loadedUser.CI="99062207946")
          {
            loadedUser.countryName="USA"
            appContext.Set<Users>().Update(loadedUser);
          }
        }
        appContext.SaveChanges();

    }

     



}