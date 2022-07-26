using KarateSocial.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KarateSocial.Data.Mappings
{
    public class PersonMapping : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.BirthDate).IsRequired();
            builder.Property(x => x.CPF).HasMaxLength(50).IsRequired();
            builder.Property(x => x.FullName).HasMaxLength(100).IsRequired();

            builder.HasMany(x => x.Users)
                .WithOne(x => x.Person)
                .HasForeignKey(x => x.PersonId);
        }
    }
}