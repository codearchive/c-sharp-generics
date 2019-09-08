using System;
using System.Linq;

namespace module_05
{
    public interface IReadOnlyRepository<out T> : IDisposable
    {
        T FindById(int id);
        IQueryable<T> FindAll();
    }
}
