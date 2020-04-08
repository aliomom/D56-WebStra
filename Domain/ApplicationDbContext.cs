namespace Domain
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Domain.Entity.ProjectEntity;

    public class ApplicationDbContext : DbContext
    {
        internal ApplicationDbContext(string nameOrConnectionString)
             : base(nameOrConnectionString = "DefaultConnection")
        {
        }

        public ApplicationDbContext()
            : base("DefaultConnection")
        {

        }

        public static ApplicationDbContext ctor (string nameOrConnectionString)
        {
            ApplicationDbContext app = new ApplicationDbContext(nameOrConnectionString);
            return app;


        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Test> test { get; set; }
        public virtual DbSet<Test2> test2 { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);
            modelBuilder.Configurations.Add(new TestConfiguration());

            modelBuilder.Configurations.Add(new Test2Configuration());
        }
    }
}
