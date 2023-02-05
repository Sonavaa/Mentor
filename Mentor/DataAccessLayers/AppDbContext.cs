using Mentor.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Mentor.DataAccessLayers
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Service> Services { get; set; }
    }
}
