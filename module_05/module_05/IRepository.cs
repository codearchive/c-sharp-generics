namespace module_05
{
    public interface IRepository<T> : IReadOnlyRepository<T>, IWriteOnlyRepository<T>
    {
    }
}
