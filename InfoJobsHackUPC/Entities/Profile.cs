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
    public class Profile
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Field { get; set; }

        [InverseProperty("FKProfile")]
        public virtual ObservableCollection<UserProfile> UserProfile_FKProfile{ get; } = new ObservableCollection<UserProfile>();

         [InverseProperty("FKProfile")]
        public virtual ObservableCollection<SkillProfile> SkillProfile_FKProfile{ get; } = new ObservableCollection<SkillProfile>();
    }

    public partial class Profile_Config : IEntityTypeConfiguration<Profile>
    {
        public Profile_Config()
        {

        }

        public void Configure(EntityTypeBuilder<Profile> entity)
        {
            entity.HasKey(e => e.Id);
        }
    }
}
