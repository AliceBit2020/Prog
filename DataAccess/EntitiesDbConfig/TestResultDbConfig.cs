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
    public class TestResultDbConfig : IEntityTypeConfiguration<TestResult>
    {
        public void Configure(EntityTypeBuilder<TestResult> tb)
        {
            tb.HasKey(x => x.Id);
           

            tb.HasOne(x => x.User)
                .WithMany(x => x.TestResults)
                .HasForeignKey(x => x.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            tb.HasOne(x=>x.Course)
                .WithMany(x=>x.Results)
                .HasForeignKey(x=>x.CourseId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
            tb.HasOne(x => x.Theme)
                .WithMany(x=>x.Results)
                .HasForeignKey(x=>x.ThemeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
          
            tb.Property(x=>x.Result)
                .IsRequired()
                .HasMaxLength(20);


        }
    }
}
