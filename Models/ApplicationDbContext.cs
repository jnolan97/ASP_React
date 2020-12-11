using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace ASP_React.Models
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Task> Task { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "TODOs" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "In Progress" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Complete" });

            //seed pies

            modelBuilder.Entity<Task>().HasData(new Task
            {
                Id = 1,
                Category = "TODOs",
                Title = "Implement DbContext",
                Content = "Add data..."


            });

            modelBuilder.Entity<Task>().HasData(new Task
            {
                Id = 2,
                Category = "In Progress",
                Title = "Implement React DnD",
                Content = "Add data..."


            });

            modelBuilder.Entity<Task>().HasData(new Task
            {
                Id = 3,
                Category = "Complete",
                Title = "Implement Login",
                Content = "Add data..."


            });


        }
    }
}
