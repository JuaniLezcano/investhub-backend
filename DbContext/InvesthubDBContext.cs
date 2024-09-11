using Microsoft.EntityFrameworkCore;
using Data.Models;

namespace Data.Data
{
    public partial class InvesthubDBContext : DbContext
    {
        public InvesthubDBContext() { }

        public InvesthubDBContext(DbContextOptions<InvesthubDBContext> options) : base(options) { }

        //Aca irian las clases con sus get y set
        public virtual DbSet<Cliente> Cliente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=db;Database=investhub;Username:admin;Password:investhub1234");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
