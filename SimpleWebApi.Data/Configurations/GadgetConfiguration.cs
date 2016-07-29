using System.Data.Entity.ModelConfiguration;
using SimpleWebApi.Domain.Entities;

namespace SimpleWebApi.Data.Configurations
{
    public class GadgetConfiguration : EntityTypeConfiguration<Gadget>
    {
        public GadgetConfiguration()
        {
            ToTable("Gadgets");
            Property(g => g.Name).IsRequired().HasMaxLength(50);
            Property(g => g.Price).IsRequired().HasPrecision(8, 2);
            Property(g => g.CategoryId).IsRequired();
        }
    }
}
