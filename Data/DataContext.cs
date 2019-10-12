using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FestivalVar.Domain;
using Microsoft.AspNetCore.Identity;

namespace FestivalVar.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Festival> Festivals { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Draw> Draws { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Title = "Yemek"
                }
            );
            
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 2,
                    Title = "Spor"
                }
            );
            
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 3,
                    Title = "Diger"
                }
            );

            modelBuilder.Entity<Festival>().HasData(
                new Festival
                {
                    Id = 1,
                    Title = "Festival1Title",
                    City = "Adana",
                    CategoryId = 1
                }
            );
            
            modelBuilder.Entity<Festival>().HasData(
                new Festival
                {
                    Id = 2,
                    Title = "Festival2Title",
                    City = "Ankara",
                    CategoryId = 1
                }
            );
            
            modelBuilder.Entity<Festival>().HasData(
                new Festival
                {
                    Id = 3,
                    Title = "Festival3Title",
                    City = "Istanbul",
                    CategoryId = 1
                }
            );
        }

    }
}
