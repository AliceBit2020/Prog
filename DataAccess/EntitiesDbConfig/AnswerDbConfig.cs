using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.EntitiesDbConfig
{
    public class AnswerDbConfig:IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> tb)
        {
            tb.HasKey(x => x.Id);
          
            tb.HasOne(x => x.Question)
              .WithOne(x => x.Answer)
              .HasForeignKey<Question>(x=>x.AnswerId)
              .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
