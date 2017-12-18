using Microsoft.Practices.Unity;
using RestauranteMaster.ApplicationService;
using RestauranteMaster.Domain.Repositories;
using RestauranteMaster.Domain.Services;
using RestauranteMaster.Infra.Presistence;
using RestauranteMaster.Infra.Presistence.DataContexts;
using RestauranteMaster.Infra.Repositories;
using RestauranteMaster.SharedKernel;
using RestauranteMaster.SharedKernel.Events;
using Unity;
using Unity.Lifetime;

namespace RestauranteMaster.CrossCutting
{
    public static class DependencyRegister
    {
        /// <param name="conatiner"></param>
        public static void Register(UnityContainer container)
        {
            container.RegisterType<DataContext, DataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<IRestauranteRepository, RestauranteRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IPratoRepository, PratoRepository>(new HierarchicalLifetimeManager());
            
            container.RegisterType<IRestauranteApplicationService, RestauranteApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IPratoApplicationService, PratoApplicationService>(new HierarchicalLifetimeManager());

            container.RegisterType<IHandler<DomainNotification>, DomainNotificationHandler>(new HierarchicalLifetimeManager());

        }
    }
}