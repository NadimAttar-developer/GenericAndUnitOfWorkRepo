
using Microsoft.EntityFrameworkCore;
using StartupCompany.Domain.Entities;

namespace StartupCompany.DataAccess.Context;
public class StartupCompanyDbContext : DbContext
{
    public StartupCompanyDbContext(DbContextOptions<StartupCompanyDbContext> options) : base(options) { }

    public DbSet<Service> ServiceSet { get; set; }
    public DbSet<Product> ProductSet { get; set; }
    public DbSet<Team> TeamSet { get; set; }
    public DbSet<Technology> TechnologySet { get; set; }
    public DbSet<TeamTechnology> TeamTechnologySet { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Service>().HasData(
            new Service { Id = 1, Name = "Service1", Description = "D1", Price = 2500 },
            new Service { Id = 2, Name = "Service2", Description = "D2", Price = 4000 },
            new Service { Id = 3, Name = "Service3", Description = "D3", Price = 5000 }
            );

        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Product1", Description = "D1", Cost = 12000, UsersCounts = 40 },
            new Product { Id = 2, Name = "Product2", Description = "D2", Cost = 6000, UsersCounts = 50 },
            new Product { Id = 3, Name = "Product3", Description = "D3", Cost = 5000, UsersCounts = 400 },
            new Product { Id = 4, Name = "Product4", Description = "D4", Cost = 15000, UsersCounts = 100 },
            new Product { Id = 5, Name = "Product5", Description = "D5", Cost = 10000, UsersCounts = 110 }
            );

        modelBuilder.Entity<Technology>().HasData(
            new Technology { Id = 1, Name = "Technology1" },
            new Technology { Id = 2, Name = "Technology2" }
            );

        modelBuilder.Entity<Team>().HasData(
                new Team
                {
                    Id = 1,
                    FullName = "Nadim Attar",
                    Email = "nadimattar.software.engineer@gmail.com",
                    Phone = "213521341234"
                },
                new Team
                {
                    Id = 2,
                    FullName = "Mohammed Attar",
                    Email = "moh@gmail.com",
                    Phone = "36424316241"
                }
            );

        modelBuilder.Entity<TeamTechnology>().HasData(
            new TeamTechnology { Id = 1, TeamId = 1, TechnologyId = 1 },
            new TeamTechnology { Id = 2, TeamId = 1, TechnologyId = 2 },
            new TeamTechnology { Id = 3, TeamId = 2, TechnologyId = 1 },
            new TeamTechnology { Id = 4, TeamId = 2, TechnologyId = 2 }
            );
    }



}
