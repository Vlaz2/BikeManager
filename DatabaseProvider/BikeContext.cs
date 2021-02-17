using DatabaseProvider.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseProvider
{
    public class BikeContext: DbContext
    {
        public DbSet<Bike> Bikes { get; set; }

        public DbSet<TypeBike> TypeBikes { get; set; }

        public BikeContext(DbContextOptions<BikeContext> options)
           : base(options)
        {

        }
    }
}
