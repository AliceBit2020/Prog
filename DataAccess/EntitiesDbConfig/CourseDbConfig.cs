using DataAccess.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntitiesDbConfig
{
    public class CourseDbConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> tb)
        {
            tb.HasKey(x => x.Id);
            tb.Property(x=>x.Name).IsRequired().HasMaxLength(20);
            tb.Property(x => x.Description).HasMaxLength(50);

            tb.HasMany(x => x.Users)
              .WithMany(x => x.Courses);

            tb.HasMany(x => x.Questions)
              .WithOne(x => x.Course)
              .HasForeignKey(x => x.CourseId);

            tb.HasMany(x=>x.Themes)
                .WithOne(x=>x.Course)
                .HasForeignKey(x=>x.CourseId);

        }
    }
}
