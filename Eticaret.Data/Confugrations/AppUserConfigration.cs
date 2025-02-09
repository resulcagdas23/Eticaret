﻿using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eticaret.Data.Confugrations
{
    public class AppUserConfigration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.SurName).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.Phone).HasColumnType("varchar(15)").HasMaxLength(15);
            builder.Property(x => x.Password).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.UserName).HasColumnType("varchar(50)").HasMaxLength(50);
            //builder.HasData(
            //    new AppUser
            //    {
            //        Id = 1,
            //        CreateDate = DateTime.Now,
            //        UserName = "Admin",
            //        Email    = "admin@eticaret.com.tr",
            //        IsActive = true,
            //        IsAdmin = true,
            //        Name = "Test",
            //        Password = "123456",
            //        SurName = "User",
            //    }
            //    );

        }
    }
}
