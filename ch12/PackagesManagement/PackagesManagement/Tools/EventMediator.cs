using DDD.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDD.ApplicationLayer
{
    public class EventMediator : IEventMediator
    {
        IServiceProvider services;


        Task IEventMediator.TriggerEvents(IEnumerable<IEventNotification> events)
        {
            throw new NotImplementedException();
        }
    }
}
