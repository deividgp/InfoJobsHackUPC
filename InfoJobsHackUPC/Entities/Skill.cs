using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoJobsHackUPC.Entities
{
    public partial class Skill
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }

        [InverseProperty("FKSkill")]
        public virtual ObservableCollection<UserSkill> UserSkills_FKSkill { get; } = new ObservableCollection<UserSkill>();
        [InverseProperty("FKSkill")]
        public virtual ObservableCollection<SkillProfile> SkillProfile_FKSkill { get; } = new ObservableCollection<SkillProfile>();
    }

    public partial class Skill_Config : IEntityTypeConfiguration<Skill>
    {
        public Skill_Config()
        {

        }

        public void Configure(EntityTypeBuilder<Skill> entity)
        {
            entity.HasKey(e => e.Id);
        }
    }
}
