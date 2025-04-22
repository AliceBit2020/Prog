using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;
using DataAccess.EntitiesDbConfig;

namespace DataAccess
{
    public class TestSystemConext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<TestResult> Results { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        public TestSystemConext(DbContextOptions<TestSystemConext> options) : base(options)
        {

        }
        public TestSystemConext()
        {
          
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=DESKTOP-O6DMGPJ\\SQLEXPRESS;Database=TestingDb;TrustServerCertificate=true;Trusted_Connection=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AnswerDbConfig());
            modelBuilder.ApplyConfiguration(new CourseDbConfig());
            modelBuilder.ApplyConfiguration(new QuestionDbConfig());
            modelBuilder.ApplyConfiguration(new TestResultDbConfig());
            modelBuilder.ApplyConfiguration(new ThemeDbConfig());
            modelBuilder.ApplyConfiguration(new UserDbConfig());
        }

    }
}
