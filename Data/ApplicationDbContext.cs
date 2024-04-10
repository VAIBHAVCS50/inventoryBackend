using inventBackend.Models;
using Microsoft.EntityFrameworkCore;
using Serilog;
namespace inventBackend.Data

{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        
        public DbSet<User> User { get; set; }
        public DbSet<User> Equipment { get; set; }
        public DbSet<User> Request { get; set; }
        public DbSet<User> Gatepass { get; set; }
        public DbSet<User> Log { get; set; }
    }
}
