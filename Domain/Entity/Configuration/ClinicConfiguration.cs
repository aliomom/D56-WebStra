using Domain.Entity.ProjectEntity.Clinic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Domain.Entity.Configuration
{
    public class ClinicConfiguration : EntityTypeConfiguration<Clinic>
    {
        public ClinicConfiguration()
        {
            ToTable("Clinic");
            HasKey(x => x.ID)
                .Property(x => x.ID)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
           .HasColumnName("Name")
           .HasColumnType("nvarchar")
           .IsRequired();

            Property(x => x.Spicalist)
              .HasColumnName("Spicalist")
              .HasColumnType("nvarchar")
              .IsRequired();

            Property(x => x.Address)
             .HasColumnName("Address")
             .HasColumnType("nvarchar");


            Property(x => x.Email)
          .HasColumnName("Email")
          .HasColumnType("nvarchar");

            Property(x => x.phoneNumber)
          .HasColumnName("phoneNumber")
          .HasColumnType("nvarchar");


            Property(x => x.Mobile)
          .HasColumnName("Mobile")
          .HasColumnType("nvarchar")
          .IsRequired();



            Property(x => x.fax)
          .HasColumnName("fax")
          .HasColumnType("nvarchar");

            Property(x => x.DailyOpenTime)
          .HasColumnName("DailyOpenTime")
          .HasColumnType("nvarchar")
          .IsRequired();

            Property(x => x.DailyCloseTime)
         .HasColumnName("DailyCloseTime")
         .HasColumnType("nvarchar")
         .IsRequired();

            Property(x => x.AfterNBrakestart)
      .HasColumnName("AfterNBrakestart")
      .HasColumnType("nvarchar")
      .IsRequired();

            Property(x => x.AfternBreakend)
     .HasColumnName("AfternBreakend")
     .HasColumnType("nvarchar")
     .IsRequired();

            HasMany(x => x.weekend).WithRequired(x => x.Clinic);
            HasMany(x => x.Patients).WithRequired(x => x.Clinic);
            HasMany(x => x.Doctors).WithRequired(x => x.Clinic);
            HasMany(x => x.Nurses).WithRequired(x => x.Clinic);
            HasMany(x => x.HolyDay).WithRequired(x => x.Clinic);
            HasMany(x => x.Room).WithRequired(x => x.Clinic);
            HasMany(x => x.Stores).WithRequired(x => x.Clinic);
            HasMany(x => x.Workers).WithRequired(x => x.Clinic);
            HasMany(x => x.Suppliers).WithRequired(x => x.Clinic);




        }


    }
}
