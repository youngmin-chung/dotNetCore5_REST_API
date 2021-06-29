using Microsoft.EntityFrameworkCore;
using RESTAPI.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPI.Server.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Department Table
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 4, DepartmentName = "Admin" });

            // Seed Employee Table
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "Harry",
                LastName = "Potter",
                Email = "harry@hogwarts.com",
                DateOfBrith = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/hp.png"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                FirstName = "Hermione",
                LastName = "Granger",
                Email = "hermione@hogwarts.com",
                DateOfBrith = new DateTime(1981, 12, 22),
                Gender = Gender.Female,
                DepartmentId = 2,
                PhotoPath = "images/hg.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "Ron",
                LastName = "Weasley",
                Email = "ron@hogwarts.com",
                DateOfBrith = new DateTime(1979, 11, 11),
                Gender = Gender.Male,
                DepartmentId = 3,
                PhotoPath = "images/rw.png"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                FirstName = "Luna",
                LastName = "Lovegood",
                Email = "luna@hogwarts.com",
                DateOfBrith = new DateTime(1982, 9, 23),
                Gender = Gender.Female,
                DepartmentId = 3,
                PhotoPath = "images/luluv.png"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 5,
                FirstName = "Rubeus",
                LastName = "Hagrid",
                Email = "rub@hogwarts.com",
                DateOfBrith = new DateTime(1982, 9, 23),
                Gender = Gender.Male,
                DepartmentId = 4,
                PhotoPath = "images/rh.png"
            });
        }
    }
}
