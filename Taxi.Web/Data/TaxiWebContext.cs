using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taxi.Web.Data.Entities;

namespace Taxi.Web.Data
{
    public class TaxiWebContext : DbContext
    {
        public TaxiWebContext (DbContextOptions<TaxiWebContext> options)
            : base(options)
        {
        }

        public DbSet<Taxi.Web.Data.Entities.TaxiEntity> TaxiEntity { get; set; }
    }
}
