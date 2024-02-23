namespace SelfCheckinWebApp.DBModels
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GuestCheckInDBContext : DbContext
    {
        public GuestCheckInDBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<FeatureSwitch> FeatureSwitches { get; set; }
        public virtual DbSet<SiteFeatureSwitch> SiteFeatureSwitches { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Site>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Site>()
                .HasMany(e => e.SiteFeatureSwitches)
                .WithRequired(e => e.Site)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FeatureSwitch>()
                .HasMany(e => e.SiteFeatureSwitches)
                .WithRequired(e => e.FeatureSwitch)
                .WillCascadeOnDelete(false);
        }
    }
}
