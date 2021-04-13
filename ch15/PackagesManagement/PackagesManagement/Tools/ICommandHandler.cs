using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDD.ApplicationLayer
{
    public interface ICommandHandler
    {
    }

    public interface ICommandHandler<T>:ICommandHandler
        where T : ICommand
    {
        Task HandleAsync(T command);
    }
}
