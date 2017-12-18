using System.Collections.Generic;
using RestauranteMaster.Domain.Commands.RetauranteCommand;
using RestauranteMaster.Domain.Entities;

namespace RestauranteMaster.Domain.Services
{
    public interface IRestauranteApplicationService
    {
        List<Restaurante> GetAll();
        Restaurante GetOne(string nome);
        Restaurante GetId(int restauranteId);
        Restaurante Create(RegisterRestauranteCommand command);
        Restaurante Update(UpdateRestauranteCommand command);
        Restaurante Delete(DeleteRestauranteCommand command);
    }
}
