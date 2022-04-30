using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;

namespace InfoJobsHackUPC.Entities
{
    public partial class UserProfile
    {
        public int IdUser { get; set; }

        public int IdProfile { get; set; }

        [ForeignKey("IdUser")]
        [InverseProperty("UserProfile_FKUser")]
        public User FKUser { get; set; }

        [ForeignKey("IdProfile")]
        [InverseProperty("UserProfile_FKProfile")]
        public Profile FKProfile { get; set; }
    }

    public partial class UserProfile_Config : IEntityTypeConfiguration<UserProfile>
    {
        public UserProfile_Config()
        {

        }

        public void Configure(EntityTypeBuilder<UserProfile> entity)
        {
            entity.HasKey(e => e.IdUser);
            entity.HasKey(e => e.IdProfile);

            entity.HasIndex(e => e.IdUser);
            entity.HasIndex(e => e.IdProfile);
        }
    }
}