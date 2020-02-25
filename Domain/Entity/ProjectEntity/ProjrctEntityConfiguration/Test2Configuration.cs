using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.ProjrctEntityConfiguration
{
   public class Test2Configuration:EntityTypeConfiguration<Test2>
    {
        public Test2Configuration()
        {
            ToTable("test2");


            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .HasColumnName("name")
                .HasColumnType("nvarchar")

                .IsOptional();
        }
    }
}
