using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.DomainLayer
{
    public interface IRepository
    {
    }

    public interface IRepository<T>:IRepository
    {
        IUnitOfWork UnitOfWork { get; }
    }

}
