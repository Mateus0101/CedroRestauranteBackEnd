using System.Data.Entity.ModelConfiguration;
using RestauranteMaster.Domain.Entities;

namespace RestauranteMaster.Infra.Presistence.Map
{
    public class RestauranteMap : EntityTypeConfiguration<Restaurante>
    {
        public RestauranteMap()
        {
            ToTable("Restaurantes");

            HasKey(x => x.RestauranteId);

            Property(x => x.Nome).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            
            HasMany(X => X.Prato);
        }
    }
}
