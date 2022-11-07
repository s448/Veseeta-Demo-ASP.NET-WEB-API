using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Drawing;
using System.Reflection.Metadata;

namespace graduation.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //add our tables

        public virtual DbSet<User>? Users { get; set; }
        public virtual DbSet<Banner>? Banners { get; set; }
        public virtual DbSet<Clinic>? Clinics { set; get; }
        public virtual DbSet<ClinicReservation>? ClinicReservations { set; get; }
        public virtual DbSet<Consultation>? Consultations { set; get; }
        public virtual DbSet<MRI_Result>? MRI_Results { set; get; }
        public virtual DbSet<Doctor>? Doctors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
//            modelBuilder
//    .Entity<Consultation>()
//    .HasOne(e => e.User)
//    .WithMany(e => e.Consultations)
//    .OnDelete(DeleteBehavior.ClientCascade);

//            modelBuilder
//.Entity<Consultation>()
//.HasOne(e => e.Doctor)
//.WithMany(e => e.Consultations)
//.OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
