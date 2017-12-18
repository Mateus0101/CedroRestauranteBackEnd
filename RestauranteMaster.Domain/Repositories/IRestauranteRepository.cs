using System.Collections.Generic;
using RestauranteMaster.Domain.Entities;

namespace RestauranteMaster.Domain.Repositories
{
    public interface IRestauranteRepository
    {
        List<Restaurante> GetAll();
        Restaurante GetOne(string nome);
        Restaurante GetId(int id);
        void Create(Restaurante restaurante);
        void Update(Restaurante restaurante);
        void Delete(Restaurante restaurante);
    }
}
