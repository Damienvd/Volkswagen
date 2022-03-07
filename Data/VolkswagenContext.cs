#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Volkswagen.Models;

namespace Volkswagen.Data
{
    public class VolkswagenContext : DbContext
    {
        public VolkswagenContext (DbContextOptions<VolkswagenContext> options)
            : base(options)
        {
        }

        public DbSet<Volkswagen.Models.Model> Model { get; set; }
    }
}
