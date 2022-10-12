using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarBookingApp.Data
{
    public class CarBookingAppContext : DbContext
    {
        public CarBookingAppContext (DbContextOptions<CarBookingAppContext> options)
            : base(options)
        {
        }

        public DbSet<CarBookingApp.Data.Car> Car { get; set; } = default!;
    }
}
