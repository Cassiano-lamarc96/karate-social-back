using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using KarateSocial.Domain.Entities;

namespace KarateSocial.Data.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Id).IsRequired();

            builder.HasOne(x => x.Person)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.PersonId);
        }
    }
}
