using Entities.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users",@"dbo");
            builder.HasKey(x => x.Id);

            builder.Property(x=>x.Username)
                .HasColumnName("Username")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Firstname)
                .HasColumnName("Firstname")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Lastname)
               .HasColumnName("Lastname")
               .HasMaxLength(50)
               .IsRequired();

            builder.Property(x => x.Password)
               .HasColumnName("Password")
               .HasMaxLength(20)
               .IsRequired();

            builder.Property(x => x.Gender)
               .HasColumnName("Gender")
               .IsRequired();

            builder.Property(x => x.DateOfBirth)
           .HasColumnName("DateOfBirth")
           .IsRequired();
            builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);

            builder.HasData(new User
            {
                Id = 1,
                Firstname = "Elshen",
                Lastname = "Guliyev",
                Password = "12345",
                Gender = true,
                DateOfBirth = Convert.ToDateTime("05-09-2002"),
                CreatedDate = DateTime.Now,
                Address = "Baku",
                CreatedUserId = 1,
                Email = "elwenquliyev513@gmail.com",
                Username = "Elshen513"
            });






        }
    }
}
