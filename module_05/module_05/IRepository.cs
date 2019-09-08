namespace module_05
{
    public interface IRepository<T> : IReadOnlyRepository<T>
    {
        void Add(T newEntity);
        void Delete(T newEntity);
        int Commit();
    }
}
