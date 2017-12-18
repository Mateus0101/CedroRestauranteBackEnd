using System.Data.Entity;
using RestauranteMaster.Domain.Entities;
using RestauranteMaster.Infra.Presistence.Map;

namespace RestauranteMaster.Infra.Presistence.DataContexts
{
    public class DataContext : DbContext
    {
        public DataContext() : base("RestauranteMaster")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }
        public virtual DbSet<Restaurante> Restaurante { get; set; }
        public virtual DbSet<Prato> Prato { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new RestauranteMap());
            modelBuilder.Configurations.Add(new PratoMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}