namespace HomeLib.Entity.Interfaces.Storage
{
    public interface IDbProvider<T, in TKey> where T : IBaseEntity<TKey>
    {
        T GetById(TKey id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(TKey id);
    }
}