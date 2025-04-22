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
    public class UserDbConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> tb)
        {
            tb.HasKey(x => x.Id);
            tb.HasIndex(x => x.Login)
                .IsUnique();
                
            tb.Property(x=>x.Password)
                .IsRequired()
                .HasMaxLength(20);
            tb.Property(x=> x.Email)
                .IsRequired()
                .HasMaxLength(20);

            tb.HasMany(x => x.Courses)
                .WithMany(x => x.Users);
                
            tb.HasMany(x => x.TestResults)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

          
            tb.HasCheckConstraint("CK_Login_Len", "LEN([Login])>=3 and LEN([Login])<=15");
            tb.HasCheckConstraint("CK_Password_Min", "LEN([Password])>=6");




            



        }
    }
}
