using Domain.Entity.ProjectEntity.Clinic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Configuration
{
    public class HolydayConfiguration :EntityTypeConfiguration<HolyDay>
    {
        public HolydayConfiguration()
        {

            ToTable("Holyday");
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
           .HasColumnName("Name")
           .HasColumnType("nvarchar")
           .IsRequired();

            Property(x => x.StartDateTime)
              .HasColumnName("StartDateTime")
              .HasColumnType("nvarchar")
              .IsRequired();

            Property(x => x.EndDateTime)
             .HasColumnName("EndDateTime")
             .HasColumnType("nvarchar").IsRequired();



            Property(x => x.IsPaid)
          .HasColumnName("IsPaid")
          .HasColumnType("nvarchar").IsRequired();



            // كل عطلة في إلها عيادة وحيدة و كل عيادة إلها أكثر من عطلة

            HasRequired(x => x.Clinic).WithMany(x => x.HolyDay);












        }
   

    }
}
