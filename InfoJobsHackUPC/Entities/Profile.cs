using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace InfoJobsHackUPC.Entities
{
    public class Profile
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Field { get; set; }
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
