using QLTT.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QLTT.Data.Configurations
{
   public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
    
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Companys");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Adress).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Url).IsRequired();


        }

    }
}
