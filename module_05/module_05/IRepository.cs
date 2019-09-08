using System;
using System.Linq;

namespace module_05
{
    public interface IRepository<T> : IDisposable
    {
        void Add(T newEntity);
        void Delete(T newEntity);
        T FindById(int id);
        IQueryable<T> FindAll();
        int Commit();
    }
}
