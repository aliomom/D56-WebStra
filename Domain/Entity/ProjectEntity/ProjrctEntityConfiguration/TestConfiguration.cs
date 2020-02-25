using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.ProjectEntity.ProjrctEntityConfiguration
{
  public  class TestConfiguration : EntityTypeConfiguration<Test>
    {
       public  TestConfiguration()
        {
            ToTable("test");


            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .HasColumnName("name")
                .HasColumnType("nvarchar")

                .IsOptional();

        }
    }
}
