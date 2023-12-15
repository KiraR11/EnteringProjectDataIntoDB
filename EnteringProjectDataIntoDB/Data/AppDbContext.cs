using EnteringProjectDataIntoDB.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EnteringProjectDataIntoDB.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().HasData(
                new Employee(0, "Иван", "Иванов", "Иванович", "ivan@example.com", new List<int>() { 0}), 
                new Employee(1, "Петр", "Петров", "Петрович", "petr@example.com", new List<int>() { 0, 1 }),
                new Employee(2, "Кирилл", "Рязанов", "Вадимович", "Kirill_R@example.com", new List<int>() { 1 })
                );
            modelBuilder.Entity<Project>().HasData(
                new Project(0,"","","",0,new List<int>() {0,1 },new DateOnly(2023,12,15), 8),
                new Project(1,"","","",1,new List<int>() { 0,1 },new DateOnly(2022,12,15), new DateOnly(2023, 10, 15), 2)
                );
        }
    }
}
