using GroupA.Models;
using Microsoft.EntityFrameworkCore;

namespace GroupA.Data;

public class AppDbContext : DbContext
{
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<WashingMachine> WashingMachines => Set<WashingMachine>();
    public DbSet<qPogram> Programs => Set<qPogram>();
    public DbSet<AvailableProgram> AvailablePrograms => Set<AvailableProgram>();
    public DbSet<PurchaseHistory> PurchaseHistories => Set<PurchaseHistory>();
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<qPogram>().HasData(new List<qPogram>
        {
            new qPogram()
            {
                ProgramId = 1,
                Name = "Quick Wash",
                DurationMinutes = 69
            },
            new qPogram()
            {
                ProgramId = 2,
                Name = "Cotton Cycle",
                DurationMinutes = 143
            },
            new qPogram()
            {
                ProgramId = 3,
                Name = "Synthetic",
                DurationMinutes = 190
            }
        });

        modelBuilder.Entity<WashingMachine>().HasData(new List<WashingMachine>
        {
            new WashingMachine()
            {
                WashingMachineId = 1,
                MaxWeight = 32.23M,
                SerialNumber = "WM2012/S431/12"
            },
            new WashingMachine()
            {
                WashingMachineId = 2,
                MaxWeight = 52.23M,
                SerialNumber = "WM2014/S491/28"
            }
        });

        modelBuilder.Entity<Customer>().HasData(new List<Customer>
        {
            new Customer()
            {
                CustomerId = 1,
                FirstName = "John",
                LastName = "Doe",
                PhoneNumber = null
            },
            new Customer()
            {
                CustomerId = 2,
                FirstName = "Arda",
                LastName = "Seydol",
                PhoneNumber = "+485172096501"
            }
        });
        modelBuilder.Entity<AvailableProgram>().HasData(new List<AvailableProgram>
        {
            new AvailableProgram()
            {
                AvailableProgramId = 1,
                ProgramId = 1,
                WashingMachineId = 1,
                Price = 100.00m
            },
            new AvailableProgram()
            {
                AvailableProgramId = 2,
                ProgramId = 2,
                WashingMachineId = 1,
                Price = 150.00m
            }
        });
        modelBuilder.Entity<PurchaseHistory>().HasData(new List<PurchaseHistory>
        {
            new PurchaseHistory()
            {
                AvailableProgramId = 1,
                CustomerId = 1,
                PurchaseDate = DateTime.Parse("2025-06-09"),
                Rating = 12
            },
            new PurchaseHistory()
            {
                AvailableProgramId = 2,
                CustomerId = 2,
                PurchaseDate = DateTime.Parse("2025-02-03"),
                Rating = null
            }
        });


    }
}    

 
