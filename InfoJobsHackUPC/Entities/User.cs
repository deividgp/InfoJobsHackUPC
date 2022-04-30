using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

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
