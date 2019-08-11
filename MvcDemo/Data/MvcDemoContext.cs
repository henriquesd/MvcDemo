using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcDemo.Models
{
    public class MvcDemoContext : DbContext
    {
        public MvcDemoContext (DbContextOptions<MvcDemoContext> options)
            : base(options)
        {
        }

        public DbSet<MvcDemo.Models.Movie> Movie { get; set; }
    }
}
