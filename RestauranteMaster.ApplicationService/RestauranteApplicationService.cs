using System.Collections.Generic;
using RestauranteMaster.Domain.Commands.RetauranteCommand;
using RestauranteMaster.Domain.Entities;
using RestauranteMaster.Domain.Repositories;
using RestauranteMaster.Domain.Services;
using RestauranteMaster.Infra.Presistence;
using RestauranteMaster.SharedKernel;
using RestauranteMaster.SharedKernel.Events;

namespace RestauranteMaster.ApplicationService
{
    public class RestauranteApplicationService : ApplicationServiceBase, IRestauranteApplicationService
    {
        private IRestauranteRepository _repository;
        private IHandler<DomainNotification> _notification;

        public RestauranteApplicationService(IRestauranteRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
            this._notification = DomainEvent.Container.GetService<IHandler<DomainNotification>>();
        }

        public Restaurante Create(RegisterRestauranteCommand command)
        {
            var restaurante = new Restaurante(command.Nome);
            restaurante.RegisterRestaurante();
            _repository.Create(restaurante);

            if (Commit())
            {
                return restaurante;
            }

            return null;
        }

        public Restaurante Delete(DeleteRestauranteCommand command)
        {
            var restaurante = _repository.GetOne(command.Nome);
            _repository.Delete(restaurante);

            if (Commit())
            {
                return restaurante;
            }

            return null;
        }

        public List<Restaurante> GetAll()
        {
            return _repository.GetAll();
        }

        public Restaurante GetOne(string nome)
        {
            return _repository.GetOne(nome);
        }

        public Restaurante GetId(int id)
        {
            return _repository.GetId(id);
        }

        public Restaurante Update(UpdateRestauranteCommand command)
        {
            var restaurante = _repository.GetId(command.RestauranteId);
            restaurante.UpdateRestaurante(command.Nome);
            _repository.Update(restaurante);

            if (Commit())
            {
                return restaurante;
            }

            return null;
        }
    }
}
