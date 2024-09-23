using Microsoft.EntityFrameworkCore;
using investhub_backend.Data.Models;

namespace investhub_backend.DbContextInvesthub
{
    public partial class InvesthubDBContext : DbContext
    {
        public InvesthubDBContext() { }

        public InvesthubDBContext(DbContextOptions<InvesthubDBContext> options) : base(options) { }

        //Aca van los modelos con sus get y set
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Email> Email { get; set; }
        public virtual DbSet<Ahorro> Ahorro { get; set; }
        public virtual DbSet<Accion> Accione { get; set; }
        public virtual DbSet<Portafolio> Portafolio { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Database=investhub;Username=admin;Password=investhub1234");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
