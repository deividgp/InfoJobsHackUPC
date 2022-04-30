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
    public partial class User
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }

        [InverseProperty("FKUser")]
        public virtual ObservableCollection<UserSkill> UserSkills_FKUser { get; } = new ObservableCollection<UserSkill>();

        [InverseProperty("FKUser")]
        public virtual ObservableCollection<UserProfile> UserProfile_FKUser { get; } = new ObservableCollection<UserProfile>();
    }

    public partial class User_Config : IEntityTypeConfiguration<User>
    {
        public User_Config()
        {

        }

        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.HasKey(e => e.Id);
        }
    }
}
