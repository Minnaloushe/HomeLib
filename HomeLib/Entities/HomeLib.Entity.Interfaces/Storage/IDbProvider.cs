using System;

namespace HomeLib.Entity.Interfaces.Storage
{
    public interface IDbProvider<T, in TK, in TKey> : IDisposable where T : IBaseEntity<TKey> where TK : class, IBaseEntity<TKey>, T
    {
        T GetById(TKey id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(TKey id);
    }
}