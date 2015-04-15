namespace HomeLib.Entity.Interfaces.Storage
{
    public interface IDbProvider<T, TKey> where T : IBaseEntity<TKey>
    {
        T GetById(TKey Id);
        T Create();
        void Insert(T entity);
        void Update(T entity);
        void Delete(TKey id);
    }
}