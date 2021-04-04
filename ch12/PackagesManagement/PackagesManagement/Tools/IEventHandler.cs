using DDD.DomainLayer;
using System.Threading.Tasks;


namespace DDD.ApplicationLayer
{
    public interface IEventHandler
    {
    }

    public interface IEventHandler<T>:IEventHandler
        where T : IEventNotification
    {
        Task HandleAsync(T ev);
    }
}
