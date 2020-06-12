using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QLTT.Data.Entities;
using QLTT.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTT.Data.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");
            builder.HasKey(x => x.ID);
            builder.HasKey(x => x.ID_class);
            builder.Property(x => x.Accumulated_Points).IsRequired().HasDefaultValue(120);
            builder.Property(x => x.Status_1).IsRequired().HasDefaultValue(Status.qualified);
            builder.Property(x => x.Status_2).IsRequired().HasDefaultValue(Status.approved);


        }
    }
}
