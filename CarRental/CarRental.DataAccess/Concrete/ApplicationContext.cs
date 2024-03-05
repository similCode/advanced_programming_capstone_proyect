using CarRental.Domain.Entities.Circulations;
using CarRental.Domain.Entities.Common;
using CarRental.Domain.Entities.Insurances;
using CarRental.Domain.Entities.Persons;
using CarRental.Domain.Entities.Reservations;
using CarRental.Domain.Entities.Somatons;
using CarRental.Domain.Entities.Supplements;
using CarRental.Domain.Entities.Vehicles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Drawing;
using CarRental.DataAccess.FluentConfigurations;

namespace CarRental.DataAccess.Concrete

{
    public class ApplicationContext : DbContext
    {
        #region Tables

        /// <summary>
        /// Tabla de personas
        /// </summary>
        public DbSet<Person> Persons { get; set; }

        /// <summary>
        /// Tabla de clientes
        /// </summary>
        public DbSet<Client> Clients { get; set; }

        /// <summary>
        /// Tabla de usuarios
        /// </summary>
        public DbSet<Users> Users { get; set; }

        /// <summary>
        /// Tabla de circulaciones
        /// </summary>
        public DbSet<Circulation> Circulations { get; set; }

        /// <summary>
        /// tabla de seguros
        /// </summary>
        public DbSet<Insurance> Insurances { get; set; }

        /// <summary>
        ///Tabla de precios
        /// </summary>
        public DbSet<Price> Prices { get; set; }

        /// <summary>
        /// Tabla de reservaciones
        /// </summary>
        public DbSet<Reservation> Reservations { get; set; }

        /// <summary>
        /// Tabla de somatones
        /// </summary>
        public DbSet<Somaton> Somatons { get; set; }

        /// <summary>
        /// Tabla de suplementos
        /// </summary>
        public DbSet<Supplement> Supplements { get; set; }

        /// <summary>
        /// Tabla de vehiculos
        /// </summary>
        public DbSet<Vehicle> Vehicles { get; set; }

        /// <summary>
        /// Tabla de carros
        /// </summary>
        public DbSet<Car> Cars { get; set; }

        /// <summary>
        /// Tabla de motocicletas
        /// </summary>
        public DbSet<Motorcycle> Motorcycles { get; set; }

        #endregion Tables

        /// <summary>
        /// Constructor requerido por EntityFramework
        /// </summary>
        ///
        public ApplicationContext()
        { }

        public ApplicationContext(string connectionString)
        : base(GetOptions(connectionString)) { }

        public ApplicationContext(DbContextOptions<ApplicationContext> options
) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Base classes mapping

            modelBuilder.Entity<Person>().ToTable("Persons");
            modelBuilder.Entity<Client>().ToTable("Clients");
            modelBuilder.Entity<Users>().ToTable("Users");

            modelBuilder.Entity<Circulation>().ToTable("Circulations");
            modelBuilder.Entity<Circulation>().Property(circ => circ.Color).HasConversion
                (c => c.ToArgb(),
                c => Color.FromArgb(c));
            modelBuilder.Entity<Circulation>().Property(circ => circ.Color2).HasConversion
                (c => c.ToArgb(),
                c => Color.FromArgb(c));
            modelBuilder.Entity<Insurance>().ToTable("Insurances");

            modelBuilder.Entity<Price>().ToTable("Prices");
            modelBuilder.Entity<Reservation>().ToTable("Reservations");
            modelBuilder.Entity<Somaton>().ToTable("Somatons");
            modelBuilder.Entity<Supplement>().ToTable("Supplements");
            modelBuilder.Entity<Vehicle>().ToTable("Vehicles");
            modelBuilder.Entity<Vehicle>().Property(v => v.Color)
                .HasConversion(
                c => c.ToArgb(),
                c => Color.FromArgb(c));
            modelBuilder.Entity<Vehicle>().Property(v => v.Color2)
                .HasConversion(
                c => c.ToArgb(),
                c => Color.FromArgb(c));
            modelBuilder.Entity<Motorcycle>().ToTable("Motorcycles");

            modelBuilder.Entity<Car>().ToTable("Cars");

            #endregion Base classes mapping

            modelBuilder.ApplyConfiguration(new ClientFluentConfiguration());
            modelBuilder.ApplyConfiguration(new UserFluentConfiguration());
            modelBuilder.ApplyConfiguration(new MotorcycleFluentConfiguration());
            modelBuilder.ApplyConfiguration(new CarFluentConfiguration());
        }

        #region Helpers

        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqliteDbContextOptionsBuilderExtensions.UseSqlite(new DbContextOptionsBuilder(), connectionString).Options;
        }

        #endregion Helpers
    }

    /// <summary>
    /// Habilita las migraciones.
    /// </summary>
    public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();

            try
            {
                var connectionString = "Data Source = CarRentalDB.sqlite";
                optionsBuilder.UseSqlite(connectionString);
            }
            catch (Exception)
            {
                //handle errror here.. means DLL has no sattelite configuration file.
                throw;
            }

            return new ApplicationContext(optionsBuilder.Options);
        }
    }
}