using Microsoft.EntityFrameworkCore;
using Models;
using System;

namespace Binding
{
    public class DB : DbContext
    {
        public DbSet<Employee> employees { get; set; }
        public DbSet<Position> positions { get; set; }
       

        public DB(DbContextOptions<DB> options)
           : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Position>().HasData(
                new Position
                {
                    Id = 1,
                    PositionName = "Developer"
                },
                new Position
                {
                    Id = 2,
                    PositionName = "DevOps"
                }

            );
            modelBuilder.Entity<Employee>().HasData(
               new Employee
               {
                   Id = 1,
                   Name = "Holger",
                   Surname = "Göpfert",
                   Salary = 1500,
                   Hired = new DateTime(),
                   Fired = new DateTime(),
                   PositionId = 1
                   //PositionName = "Developer"
                   
               },
               new Employee
               {
                   Id = 2,
                   Name = "Steffen",
                   Surname = "Frommberger",
                   Salary = 1500,
                   Hired = new DateTime(),
                   Fired = new DateTime(),
                   PositionId = 2
                   //PositionName = "DevOps"
               },
               new Employee
               {
                   Id = 3,
                   Name = "Иван",
                   Surname = "Петров",
                   Salary = 2500,
                   Hired = new DateTime(),
                   Fired = new DateTime(),
                   PositionId = 2
                   //PositionName = "DevOps"
               }


          );

        }


    }
}
