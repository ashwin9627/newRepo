using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HRMS_Web_Project.Models
{
    public class TableDBContext : DbContext
    {
        public TableDBContext() : base(@"Data Source=KALIDASA\SQLDEV2016;Database=HRMSDB;integrated Security=True")
        {
            // Database.SetInitializer(new MigrateDatabaseToLatestVersion<TableDBContext, HRMS_Web_Project.Migrations.Configuration>());
        }


        public DbSet<EmployeeDetails> Employee1 { get; set; }
        public DbSet<UserCredintials> Users1 { get; set; }
        public DbSet<DesignationTable> DesigTable1 { get; set; }
        public DbSet<LeaveTable> Leave1 { get; set; }
        public DbSet<Blog> Blog1 { get; set; }
    }
}