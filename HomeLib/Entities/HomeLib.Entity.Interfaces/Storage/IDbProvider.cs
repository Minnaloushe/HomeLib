namespace HomeLib.Entity.Interfaces.Storage
{
    public interface IDbProvider<T, in TKey> where T : IBaseEntity<TKey>, new()
    {
        T GetById(TKey id);
        T Create();
        void Insert(T entity);
        void Update(T entity);
        void Delete(TKey id);
    }
}