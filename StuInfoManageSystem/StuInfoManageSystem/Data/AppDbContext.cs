using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StuInfoManageSystem.Models;

namespace StuInfoManageSystem.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public DbSet<Major> Majors { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>()
                .HasIndex(s => s.Number)
                .IsUnique();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("FileName=Data/App.db");
        }
    }
}
