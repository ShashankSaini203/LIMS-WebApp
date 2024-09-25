using LIMS.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LIMS.Infrastructure.Database.DBcontext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instrument>()
                    .HasOne<Laboratory>()
                    .WithMany()
                    .HasForeignKey(i => i.LaboratoryId)
                    .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CalibrationRecord>()
                    .HasOne<Instrument>()
                    .WithMany()
                    .HasForeignKey(i => i.InstrumentId)
                    .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CalibrationRecord>()
                    .HasOne<Technician>()
                    .WithMany()
                    .HasForeignKey(i => i.TechnicianId)
                    .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderDetails>()
                    .HasOne<Laboratory>()
                    .WithMany()
                    .HasForeignKey(i => i.LaboratoryId)
                    .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Instrument>()
                    .HasOne<Laboratory>()
                    .WithMany()
                    .HasForeignKey(i => i.LaboratoryId)
                    .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<CalibrationRecord> CalibrationRecords { get; set; }
        public DbSet<Laboratory> Laboratories { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Technician> Technicians { get; set; }
    }
}
