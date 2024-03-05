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
        //Create

         Price carPrice = new(MoneyType.Euro, 5000);
    
        appContext.Set<Price>().Add(carPrice);
        appContext.SaveChanges();
        
        



    }

     



}