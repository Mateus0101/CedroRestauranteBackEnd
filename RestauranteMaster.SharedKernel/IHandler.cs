using System;
using System.Collections.Generic;
using RestauranteMaster.SharedKernel.Events.Contracts;

namespace RestauranteMaster.SharedKernel
{
    public interface IHandler<T> : IDisposable where T : IDomainEvent
    {
        void Handler(T args);
        IEnumerable<T> Notify();
        bool HasNotifications();
    }
}
