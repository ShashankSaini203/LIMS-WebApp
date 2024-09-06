using LIMS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Infrastructure.Database.DBcontext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {     
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Laboratory>()
                .HasMany(l => l.Instruments)
                .WithOne(i => i.Laboratory)
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
