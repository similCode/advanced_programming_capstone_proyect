using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Domain.Entities.Common;
using CarRental.Domain.Entities.Insurances;
using CarRental.Domain.Entities.Somatons;
using CarRental.Domain.Entities.Vehicles;
using CarRental.DataAccess.Abstract.Vehicles;

namespace CarRental.DataAccess.Repositories
{
    /// <summary>
    /// Clase parcial referida a los vehiculos
    /// </summary>
    public partial class ApplicationRepository : VehicleRepository
    {
        public Car CreateCar(string brandName, DateTime fabricationDate, string plate, string motorNumber, Color color, Insurance insurance, Somaton somaton, string model, int passengerCapacity, Price price, int wheelAmount, int weight, int doorsAmount, int numberOfVelocities, int maxVelocity, bool hasAirConditioning)
        {
            Car car = new Car(brandName, fabricationDate, plate, motorNumber, color, insurance, somaton, model, passengerCapacity, price, wheelAmount, weight, doorsAmount, numberOfVelocities, maxVelocity, hasAirConditioning);
            _context.Add(car); return car;
        }

        public Motorcycle CreateMotorcycle(string brandName, DateTime fabricationDate, string plate, string motorNumber, Color color, Insurance insurance, Somaton somaton, string model, int passengerCapacity, Price price, int wheelAmount, int weight, bool hasSideCar)
        {
            Motorcycle motorcycle = new Motorcycle(brandName, fabricationDate, plate, motorNumber, color, insurance, somaton, model, passengerCapacity, price, wheelAmount, weight, hasSideCar);
            _context.Add(motorcycle); return motorcycle;
        }

        public V? GetVehicle<V>(Guid id) where V : Vehicle
        {
            return _context.Set<V>().Find(id);
        }

        public IEnumerable<Vehicle> GetAllVehicles()
        {
            return _context.Set<Vehicle>().ToList();
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _context.Set<Car>().ToList();
        }

        public IEnumerable<Motorcycle> GetAllMotorcycles()
        {
            return _context.Set<Motorcycle>().ToList();
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            _context.Update(vehicle);
        }

        public void DeleteVehicle(Vehicle vehicle)
        {
            _context.Remove(vehicle);
        }
    }
}