using System.ComponentModel.DataAnnotations;

namespace InfoJobsHackUPC.Entities
{
    public class Profile
    {
        [Required]
        public string Name { get; set; }
        public string Field { get; set; }
    }
}
