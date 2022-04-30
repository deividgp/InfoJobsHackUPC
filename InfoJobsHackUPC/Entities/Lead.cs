using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfoJobsHackUPC.Entities
{
    public partial class Lead
    {
        [Required]
        public int IdLead { get; set; }

        public DateTime PublicationDate { get; set; }

        public string Province { get; set; }

        public string OfferType { get; set; }

        public string Industry { get; set; }

        public string JobTitle { get; set; }

        public string NormalizedName { get; set; }

        public string Description { get; set; }

        public string Requirements { get; set; }

        public int MinimumSalary { get; set; }

        public int MaximumSalary { get; set; }

        public bool IsSalaryShowed { get; set; }

        public int NumViews { get; set; }

        public int NumLeads { get; set; }
    }

	public partial class Leads_Config : IEntityTypeConfiguration<Lead>
	{
		public Leads_Config() { }

		public void Configure(EntityTypeBuilder<Lead> entity)
		{
            entity.HasKey(e => e.IdLead).HasName("PK_Leads");
        }
	}
}
