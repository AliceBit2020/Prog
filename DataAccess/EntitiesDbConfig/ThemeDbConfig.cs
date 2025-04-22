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

    public class ThemeDbConfig : IEntityTypeConfiguration<Theme>
    {
        public void Configure(EntityTypeBuilder<Theme> tb)
        {
            tb.HasKey(x => x.Id);
            tb.Property(x => x.Name).IsRequired().HasMaxLength(20);
            tb.Property(x=>x.Description).IsRequired().HasMaxLength(50);
           
           
            tb.HasOne(x => x.Course)
              .WithMany(x => x.Themes)
              .HasForeignKey(x => x.CourseId)
              .IsRequired()
              .OnDelete(DeleteBehavior.NoAction);

            tb.HasMany(x => x.Questions)
              .WithOne(x => x.Theme)
              .HasForeignKey(x => x.ThemeId);

        }
    }
}
