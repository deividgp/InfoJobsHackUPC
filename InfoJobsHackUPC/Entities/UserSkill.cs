using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;


namespace InfoJobsHackUPC.Entities
{
    public partial class UserSkill
    {
        public int IdUser { get; set; }

        public string IdSkill { get; set; }

        [ForeignKey("IdUser")]
        [InverseProperty("UserSkills_FKUser")]
        public User FKUser { get; set; }

        [ForeignKey("IdSkill")]
        [InverseProperty("UserSkills_FKSkill")]
        public Skill FKSkill { get; set; }
    }

    public partial class UserSkill_Config : IEntityTypeConfiguration<UserSkill>
    {
        public UserSkill_Config()
        {

        }

        public void Configure(EntityTypeBuilder<UserSkill> entity)
        {
            entity.HasKey(e => e.IdUser);
            entity.HasKey(e => e.IdSkill);

            entity.HasIndex(e => e.IdUser);
            entity.HasIndex(e => e.IdSkill);
        }
    }
}
