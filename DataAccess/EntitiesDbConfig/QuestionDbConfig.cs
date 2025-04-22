using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.EntitiesDbConfig
{
    public class QuestionDbConfig : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> tb)
        {
            tb.HasKey(x => x.Id);
          
            tb.HasOne(x => x.Answer)
              .WithOne(x => x.Question)
              .HasForeignKey<Question>(x=>x.AnswerId);

            tb.HasOne(x => x.Theme)
              .WithMany(x => x.Questions)
              .HasForeignKey(x => x.ThemeId)
              .IsRequired()
              .OnDelete(DeleteBehavior.NoAction);


            tb.Property(x=>x.Quest)
                .IsRequired()
                .HasMaxLength(50);

            tb.HasOne(x=>x.Course)
              .WithMany(x=>x.Questions)
              .HasForeignKey(x=>x.CourseId)
              .IsRequired()
              .OnDelete(DeleteBehavior.NoAction);
           

        }
    }
}
