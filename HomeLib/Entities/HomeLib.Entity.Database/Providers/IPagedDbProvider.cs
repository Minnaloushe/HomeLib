using System.Collections.Generic;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.Providers
{
    public interface IPagedDbProvider<out T, TK, TKey>
        where T : IBaseEntity<TKey>
        where TK : class, IBaseEntity<TKey>, T
    {
        IEnumerable<T> GetPage(int pageSize, int skip = 0);
    }
}