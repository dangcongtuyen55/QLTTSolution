using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QLTT.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLTT.Data.Configurations
{
    public class JobConfiguration : IEntityTypeConfiguration<Job>
    {

        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.ToTable("Jobs");
            builder.HasKey(x => x.Id);
            builder.HasKey(x => x.Id_Comapany);

        }
    
    }
}
