using Microsoft.EntityFrameworkCore;
using LabWebApp.Models;
using System.Collections.Generic;

namespace LabWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
