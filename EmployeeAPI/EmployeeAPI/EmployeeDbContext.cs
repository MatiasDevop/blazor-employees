using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {

        }
        public DbSet<EmployeeInfo> EmployeeInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<EmployeeInfo>().HasData(
            //     new EmployeeInfo { EmployeeId = "1", Name = "Piter", Designation = "ddd", Deparment = "small size" },
            //     new EmployeeInfo { EmployeeId = "2", Name = "Elver" , Designation = "dedasda", Deparment = "king size" },
            //     new EmployeeInfo { EmployeeId = "2", Name = "Jhon", Designation = "ererere", Deparment = "big" }
            //     );
        }
    }
}
