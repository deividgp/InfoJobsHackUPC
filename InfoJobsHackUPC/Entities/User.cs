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
}
