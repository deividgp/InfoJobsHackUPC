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
        public string Name { get; set; }
        [Required]
        public long Id { get; set; }
        

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
            entity.HasKey(e => e.Name);
        }
    }
}
