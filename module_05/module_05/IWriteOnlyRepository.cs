using System;

namespace module_05
{
    public interface IWriteOnlyRepository<in T> : IDisposable
    {
        void Add(T newEntity);
        void Delete(T newEntity);
        int Commit();
    }
}