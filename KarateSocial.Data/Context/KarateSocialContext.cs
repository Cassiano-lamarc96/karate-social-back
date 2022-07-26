using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using KarateSocial.Data.Extentions;
using KarateSocial.Data.Mappings;
using KarateSocial.Domain.Entities;

namespace KarateSocial.Data.Context
{
    public class KarateSocialContext : DbContext
    {
        public KarateSocialContext(DbContextOptions<KarateSocialContext> option)
            : base(option) { }

        #region "DbSets"

        public DbSet<User> Users { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<ProfileGroup> ProfileGroups { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new PersonMapping());
            modelBuilder.ApplyConfiguration(new ProfileMapping());
            modelBuilder.ApplyConfiguration(new ProfileGroupMapping());
            modelBuilder.ApplyConfiguration(new UserProfileMapping());

            modelBuilder.ApplyGlobalConfigurations();
            modelBuilder.SeedData();
            base.OnModelCreating(modelBuilder);
        }
    }
}
