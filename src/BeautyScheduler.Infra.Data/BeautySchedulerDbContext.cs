using BeautyScheduler.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BeautyScheduler.Infra.Data
{
    public class BeautySchedulerDbContext : DbContext
    {
        public BeautySchedulerDbContext(DbContextOptions<BeautySchedulerDbContext> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }
        public DbSet<Cliente> Cliente { get; set; }       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(u =>
            {
                u.HasKey(i => i.Id);
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
