using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using RestauranteMaster.Domain.Entities;
using RestauranteMaster.Domain.Repositories;
using RestauranteMaster.Domain.Specs;
using RestauranteMaster.Infra.Presistence.DataContexts;

namespace RestauranteMaster.Infra.Repositories
{
    public class RestauranteRepository : IRestauranteRepository
    {
        private DataContext _context;

        public RestauranteRepository(DataContext context)
        {
            this._context = context;
        }

        public void Create(Restaurante restaurante)
        {
            _context.Restaurante.Add(restaurante);
        }

        public void Delete(Restaurante restaurante)
        {
            _context.Restaurante.Remove(restaurante);
        }

        public List<Restaurante> GetAll()
        {
            return _context.Restaurante.ToList();
        }

        public Restaurante GetOne(string nome)
        {
            return _context.Restaurante.Where(RestauranteSpecs.GetOne(nome)).FirstOrDefault();
        }

        public Restaurante GetId(int id)
        {
            return _context.Restaurante.Where(RestauranteSpecs.GetId(id)).FirstOrDefault();
        }

        public void Update(Restaurante restaurante)
        {
            _context.Entry<Restaurante>(restaurante).State = EntityState.Modified;
        }
    }
}
