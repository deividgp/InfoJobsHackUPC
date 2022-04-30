using InfoJobsHackUPC.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace InfoJobsHackUPC
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration configuration;

        public DbSet<Lead> Leads { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        
        public AppDbContext(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

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
            options.UseNpgsql(configuration.GetConnectionString("PostgreSQL"));
        }
    }
}
