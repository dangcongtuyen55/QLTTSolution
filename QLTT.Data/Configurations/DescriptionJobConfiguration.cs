using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QLTT.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTT.Data.Configurations
{
    public class DescriptionJobConfiguration : IEntityTypeConfiguration<DescriptionJob>
    {
        public void Configure(EntityTypeBuilder<DescriptionJob> builder)
        {
            builder.ToTable("DescriptionJobs");
            builder.HasKey(x => new { x.Company_id, x.Job_Id });
            builder.HasOne(x => x.Job).WithMany(x => x.DescriptionJobs).HasForeignKey(x => x.Job_Id);
            builder.HasOne(x => x.Company).WithMany(x => x.DescriptionJobs).HasForeignKey(x => x.Company_id);
        }
    }
}
