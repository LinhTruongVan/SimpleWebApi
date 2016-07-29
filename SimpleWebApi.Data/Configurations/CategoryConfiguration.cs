using SimpleWebApi.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SimpleWebApi.Data.Configurations
{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            ToTable("Categories");
            Property(c => c.Name).IsRequired().HasMaxLength(50);
            HasMany(c => c.Gadgets)
                .WithRequired()
                .HasForeignKey(c => c.CategoryId);
        }
    }
}
