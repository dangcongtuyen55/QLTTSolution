using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QLTT.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTT.Data.Configurations
{
    public class StudentInClassConfiguration : IEntityTypeConfiguration<StudentInClass>
    {
        public void Configure(EntityTypeBuilder<StudentInClass> builder)
        {
            builder.HasKey(t => new { t.StudentId, t.ClassId});
            builder.ToTable("StudentInClass");
            builder.HasOne(t => t.Student).WithMany(pc => pc.StudentInClass)
                .HasForeignKey(pc => pc.StudentId);

            builder.HasOne(t => t.ClassRoom).WithMany(pc => pc.StudentInClass)
                .HasForeignKey(pc => pc.ClassId);
        }
    }
}
