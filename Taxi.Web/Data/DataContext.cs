using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taxi.Web.Data.Entities;

namespace Taxi.Web.Data
{
    //hereda del identitydbcotext es generica y va a heredar de todas las tablas de usuarios
    public class DataContext : IdentityDbContext<UserEntity>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<TaxiEntity> Taxis {get; set;}
        public DbSet<TripEntity> Trips {get; set;}
        public DbSet<TripDetailEntity> TripDetails {get; set;}

        public DbSet<UserGroupEntity> UserGroups { get; set; }

        //cuando se crea la base de datos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TaxiEntity>()
                 .HasIndex(t => t.Plaque)
                    .IsUnique();

        }
    }
}
