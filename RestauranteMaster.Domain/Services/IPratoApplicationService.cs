using System.Collections.Generic;
using RestauranteMaster.Domain.Commands.PratoCommand;
using RestauranteMaster.Domain.Entities;

namespace RestauranteMaster.Domain.Services
{
    public interface IPratoApplicationService
    {
        List<Prato> GetAll(string restaurante);
        Prato GetPrato(string restaurante, string nome);
        Prato GetOne(string nome);
        Prato GetId(int id);
        Prato Create(RegisterPratoCommand command);
        Prato Update(UpdatePratoCommand command);
        Prato Delete(DeletePratoCommand command);
    }
}
