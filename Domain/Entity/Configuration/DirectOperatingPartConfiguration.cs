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
    public class DirectOperatingPartConfiguration : EntityTypeConfiguration<DirectOperatingPart>
    {
        public DirectOperatingPartConfiguration()
        {
            ToTable("DirectOperatingPart");
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
                 Property(x => x.CodeInStuck)
                .HasColumnName("CodeInStuck")
                .HasColumnType("nvarchar")
                .IsRequired();

            Property(x => x.Date)
                .HasColumnName("Date")
                .HasColumnType("nvarchar")
                .IsRequired();

            Property(x => x.Note)
                .HasColumnName("Note")
                .HasColumnType("nvarchar");

            HasRequired(x => x.DirectOperatingPartName).WithMany(x => x.DirectOperatingPart);

            // its done

        }
    }
}
