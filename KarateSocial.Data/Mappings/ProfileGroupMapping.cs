using KarateSocial.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KarateSocial.Data.Mappings
{
    public class ProfileGroupMapping : IEntityTypeConfiguration<ProfileGroup>
    {
        public void Configure(EntityTypeBuilder<ProfileGroup> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(100);
        }
    }
}
