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
    public class UndirectOperationConfiguration : EntityTypeConfiguration<UndirectOperation>
    {
        public UndirectOperationConfiguration()
        {
            ToTable("UndirectOperation");
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
          
            Property(x => x.date)
               .HasColumnName("date")
               .HasColumnType("nvarchar")
               .IsRequired();

            Property(x => x.CodeInStock)
           .HasColumnName("CodeInStock")
           .HasColumnType("nvarchar")
           .IsRequired();


            Property(x => x.IsInUse)
                .HasColumnName("IsInUse")
                .HasColumnType("boolian");

           HasRequired(x => x.UndirectOperationName).WithMany(x => x.UndirectOperation);

            // its done

        }
    }

}
