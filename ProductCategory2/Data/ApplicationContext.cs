using System;
using Microsoft.EntityFrameworkCore;
using ProductsCategory.Entities;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

	}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    modelBuilder.Entity<Product>().HasData(
                new[]
                {
                    new Product { Id = 1, Name="Apple" },
                    new Product { Id = 2, Name = "Lemon" },
                    new Product { Id = 3, Name = "Cucumber"},
                    new Product { Id = 4, Name = "TV"},
                    new Product { Id = 5, Name = "Computer"},
                    new Product { Id = 6, Name = "Telephone"},
                    new Product { Id = 7, Name = "Pacmoon" },
                    new Product { Id = 8, Name = "Ape" },
                    new Product { Id = 9, Name = "Gold" },
                    new Product { Id = 10, Name = "Cat" },
                });
        modelBuilder.Entity<Category>().HasData(
               new[]
               {
                    new Category { Id = 1, Name="Fructs" },
                    new Category { Id = 2, Name = "Electronic" },
                    new Category { Id = 3, Name = "House" },
                    new Category { Id = 4, Name = "NFT"},
               });
        modelBuilder.Entity<Product>()
            .HasMany(e => e.Categories)
            .WithMany(e => e.Products);
    }
}
