using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCGuviDemo.Models;

namespace MVCGuviDemo.Data
{
    public class MVCGuviDemoContext : DbContext
    {
        public MVCGuviDemoContext (DbContextOptions<MVCGuviDemoContext> options)
            : base(options)
        {
        }

        public DbSet<MVCGuviDemo.Models.Category> Category { get; set; } = default!;

        public DbSet<Prdouct> Prdoucts { get; set; } = default!;
    }
}
