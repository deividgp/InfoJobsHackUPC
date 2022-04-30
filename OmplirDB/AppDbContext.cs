using InfoJobsHackUPC.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmplirDB
{
    public class AppDbContext : DbContext
    {
        public DbSet<Lead> Leads { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<SkillProfile> SkillProfiles { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }

        // Aquest mètode permet aplicar la configuració addicional de la base de dades i de les taules
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Crida primer el mètode base
            base.OnModelCreating(modelBuilder);
            // Aplica la configuració addicional de cada taula
            modelBuilder.ApplyConfiguration(new Leads_Config());
            modelBuilder.ApplyConfiguration(new Skill_Config());
            modelBuilder.ApplyConfiguration(new User_Config());
            modelBuilder.ApplyConfiguration(new UserSkill_Config());
            modelBuilder.ApplyConfiguration(new Profile_Config());
            modelBuilder.ApplyConfiguration(new SkillProfile_Config());
            modelBuilder.ApplyConfiguration(new UserProfile_Config());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql("Server=127.0.0.1;Port=5432;Database=InfoJobs;User Id=postgres;Password=password;");
        }
    }
}
