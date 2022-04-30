using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;

namespace InfoJobsHackUPC.Entities
{
    public partial class SkillProfile
    {
        public int IdSkill { get; set; }

        public int IdProfile { get; set; }

        [ForeignKey("IDSkill")]
        [InverseProperty("SkillProfile_FKSkill")]
        public Skill FKSkill { get; set; }

        [ForeignKey("IdProfile")]
        [InverseProperty("SkillProfile_FKProfile")]
        public Profile FKProfile { get; set; }
    }

    public partial class SkillProfile_Config : IEntityTypeConfiguration<SkillProfile>
    {
        public SkillProfile_Config()
        {

        }

        public void Configure(EntityTypeBuilder<SkillProfile> entity)
        {
            entity.HasKey(e => e.IdSkill);
            entity.HasKey(e => e.IdProfile);

            entity.HasIndex(e => e.IdSkill);
            entity.HasIndex(e => e.IdProfile);
        }
    }
}