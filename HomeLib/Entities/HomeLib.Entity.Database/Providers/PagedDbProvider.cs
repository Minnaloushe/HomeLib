using System.Collections.Generic;
using System.Data;
using Dapper;
using HomeLib.Entity.Interfaces.Storage;

namespace HomeLib.Entity.Database.Providers
{
    public class PagedDbProvider<T, TK, TKey> : IPagedDbProvider<T, TK, TKey> where T : IBaseEntity<TKey> where TK : class, IBaseEntity<TKey>, T
    {
        private readonly IDbConnection _connection;
        private readonly string _tableName;


        public PagedDbProvider(IDbConnection connection, string tableName)
        {
            _connection = connection;
            _tableName = tableName;
        }

        public IEnumerable<T> GetPage(int pageSize, int skip = 0)
        {
            return _connection.Query<TK>(_tableName + "_GetPage", new {pageSize, skip},
                commandType: CommandType.StoredProcedure);
        }
    }
}