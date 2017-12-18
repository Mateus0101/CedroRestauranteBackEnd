using System.Collections.Generic;
using RestauranteMaster.Domain.Entities;

namespace RestauranteMaster.Domain.Repositories
{
    public interface IPratoRepository
    {
        List<Prato> GetAll(string restaurante);
        Prato GetPrato(string restaurante, string nome);
        Prato GetOne(string nome);
        Prato GetId(int id);
        void Create(Prato prato);
        void Update(Prato prato);
        void Delete(Prato prato);
    }
}
