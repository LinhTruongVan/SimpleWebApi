using SimpleWebApi.Data.Configurations;
using SimpleWebApi.Domain.Entities;
using System.Data.Entity;

namespace SimpleWebApi.Data
{
    public class SimpleWebApiContext : DbContext
    {
        public SimpleWebApiContext()
           : base("SimpleWebApi")
        {
            Database.SetInitializer<SimpleWebApiContext>(null);
        }

        public IDbSet<Category> Categories { get; set; }
        public IDbSet<Gadget> Gadgets { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new GadgetConfiguration());
        }
    }
}
