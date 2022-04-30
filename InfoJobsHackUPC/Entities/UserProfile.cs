using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoJobsHackUPC.Entities
{
    public partial class UserProfile
    {
        [ForeignKey("Id_user")]
        public int Id_user { get; set; }
        [ForeignKey("Id_skill")]
        public int Id_skill { get; set; }
    }

    public partial class UserProfile_config : IEntityTypeConfiguration<UserProfile>
    {
        public UserProfile_config()
        {

        }

        public void Configure(EntityTypeBuilder<UserProfile> entity)
        {
            entity.HasKey(e => e.Id_user);
            entity.HasKey(e => e.Id_skill);

            entity.HasIndex(e => e.Id_user);
            entity.HasIndex(e => e.Id_skill);
        }
    }
}