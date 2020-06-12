using Microsoft.EntityFrameworkCore;
using QLTT.Data.Entities;
using QLTT.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLTT.Data.EF
{
    public class QLTTDBContext : DbContext
    {
        public QLTTDBContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new StudentInClassConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new JobConfiguration());
            modelBuilder.ApplyConfiguration(new DescriptionJobConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public DataSet<Company> Companies { set; get; }
        public DataSet<Student> Students { set; get; }
        public DataSet<Department> Departments { set; get; }
        public DataSet<ClassRoom> ClassRooms { set; get; }
        public DataSet<Job> Jobs { set; get; }

    }
}
