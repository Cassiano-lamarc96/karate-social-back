using KarateSocial.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KarateSocial.Data.Mappings
{
    public class UserProfileMapping : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.HasOne(x => x.User)
                .WithMany(p => p.UserProfiles)
                .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Profile)
                .WithMany(p => p.UserProfiles)
                .HasForeignKey(x => x.ProfileId);
        }
    }
}