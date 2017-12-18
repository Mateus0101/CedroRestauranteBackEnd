using System;

namespace RestauranteMaster.Infra.Presistence
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
