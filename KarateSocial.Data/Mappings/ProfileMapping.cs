using KarateSocial.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KarateSocial.Data.Mappings
{
    public class ProfileMapping : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(100);
            builder.HasOne(x => x.ProfileGroup)
                .WithMany(x => x.Profiles)
                .HasForeignKey(x => x.ProfileGroupId);
        }
    }
}