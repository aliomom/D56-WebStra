using Domain.Entity.ProjectEntity.Clinic.Equipment.DiagnosticEquipment.Part;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Configuration
{
    public class DirectOperatingPartNameConfiguration : EntityTypeConfiguration<DirectOperatingPartName>
    {
        public DirectOperatingPartNameConfiguration()
        {
            ToTable("DirectOperatingPartName");
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
          .HasColumnName("Name")
          .HasColumnType("nvarchar")
          .IsRequired();

            Property(x => x.Description)
           .HasColumnName("Description")
           .HasColumnType("nvarchar")
           .IsRequired();

            Property(x => x.ManufactureCompany)
          .HasColumnName("ManufactureCompany")
          .HasColumnType("nvarchar")
          .IsRequired();

            Property(x => x.ManufactureCompanyEmail)
        .HasColumnName("ManufactureCompanyEmail")
        .HasColumnType("nvarchar")
        .IsRequired();

            Property(x => x.ManufactureCompanyPhone)
     .HasColumnName("ManufactureCompanyPhone")
     .HasColumnType("nvarchar")
     .IsRequired();

            Property(x => x.ManufactureCompanyAddress)
         .HasColumnName("ManufactureCompanyAddress")
         .HasColumnType("nvarchar")
         .IsRequired();


            Property(x => x.MaintenanceContactPerson)
         .HasColumnName("ManufactureCompanyPerson")
         .HasColumnType("nvarchar")
         .IsRequired();


            Property(x => x.MaintenancePhone)
         .HasColumnName("MaintenancePhone")
         .HasColumnType("nvarchar")
         .IsRequired();


            Property(x => x.UserGuide)
                .HasColumnName("UserGuide")
                .HasColumnType("varbinary");

            Property(x => x.Note)
                .HasColumnName("Note")
                .HasColumnType("text");


            Property(x => x.DepreciationPeriodPerMounth)
                .HasColumnName("DepreciationPeriodPerMounth")
                .HasColumnType("int")
                .IsRequired();

            Property(x => x.DepreciationOnOperatingTimes)
                .HasColumnName("DepreciationOnOperatingTimes")
                .HasColumnType("int")
                .IsRequired();


            HasMany(x => x.DirectOperatingPart).WithRequired(x => x.DirectOperatingPartName);
            // كملي

            Property(x => x.Cost)
                .HasColumnName("cost")
                .HasColumnType("money")
                .IsRequired();









        }
    }
}
